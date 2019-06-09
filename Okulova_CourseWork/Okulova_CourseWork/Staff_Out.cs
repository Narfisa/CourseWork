using Okulova_CourseWork.dbHelper;
using System;
using System.Windows.Forms;
using System.Linq;
using static Okulova_CourseWork.StringCheck;


namespace Okulova_CourseWork
{
    public partial class Staff_Out : Form
    {
        private DB db = new DB();
        public Staff_Out(int IdStaff)
        {
            InitializeComponent();
            this.IdStaff = IdStaff;
            Tableindex = 0;
            dataGrid.DataSource = db.GetBooksWithAuthorsTable();
            panel2.Hide();
            panel3.Hide();
            OKbutton.Enabled = false;
        }

        int IdStaff;
        int Tableindex;

        private void Searchtextbox_TextChanged(object sender, EventArgs e)
        {
            string s = Searchtextbox.Text;
            dataGrid.DataSource = db.Search(Tableindex, s);
        }

        private void FoundBookbutton_Click(object sender, EventArgs e)
        {
            if (IDBooktextbox.Text != "")
            {
                int x = -1;
                try
                {
                    x = Convert.ToInt32(IDBooktextbox.Text);
                }
                catch
                {
                    MessageBox.Show("ID должен состоять только из цифр", "Неккоректный ввод", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    IDBooktextbox.Focus();
                }
                if (x <= 0)
                {
                    MessageBox.Show("ID не может быть отрицательным или равным нулю.", "Неккоректный ввод", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    IDBooktextbox.Focus();
                }
                else
                {
                    var query = from c in db.GetBooksTable()
                                join Author_Book in db.GetAuthor_BooksTable()
                                on c.Id equals Author_Book.IdBooks
                                join Author in db.GetAuthorsTable()
                                on Author_Book.IdAuthors equals Author.Id
                                select c.Id;
                    var a = query.FirstOrDefault();
                    if (a == 0)
                        MessageBox.Show("Введен не существующий ID.", "ID не найден", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                    {
                        Tableindex = 1;
                        panel2.Show();
                        IDBooktextbox.Enabled = false;
                        dataGrid.DataSource = db.GetUsersTable();
                    }
                }
            }
            else
                MessageBox.Show("Заполните поле \"ID\"", "Неккоректный ввод", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            
        }

        private void FoundUserbutton_Click(object sender, EventArgs e)
        {
            if (IDUsertextbox.Text != "")
            {
                int x = -1;
                try
                {
                    x = Convert.ToInt32(IDUsertextbox.Text);
                }
                catch
                {
                    MessageBox.Show("ID должен состоять только из цифр", "Неккоректный ввод", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    IDUsertextbox.Focus();
                }
                if (x <= 0)
                {
                    MessageBox.Show("ID не может быть отрицательным или равным нулю.", "Неккоректный ввод", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    IDUsertextbox.Focus();
                }
                else
                {
                    var query = from c in db.GetUsersTable()
                                where c.Id == Convert.ToInt32(IDUsertextbox.Text)
                                select c.Id;
                    var a = query.FirstOrDefault();
                    if (a == 0)
                        MessageBox.Show("Введен не существующий ID.", "ID не найден", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                    {
                        Tableindex = 1;
                        panel3.Show();
                        IDUsertextbox.Enabled = false;
                        dataGrid.DataSource = from c in db.GetBooksTable()
                                              join author_Book in db.GetAuthor_BooksTable()
                                              on c.Id equals author_Book.IdBooks
                                              join Author in db.GetAuthorsTable()
                                              on author_Book.IdAuthors equals Author.Id
                                              where c.Id == Convert.ToInt32(IDBooktextbox.Text)
                                              select new
                                              {
                                                  c.Id,
                                                  c.Title,
                                                  c.Genre,
                                                  c.Release,
                                                  c.Count,
                                                  Author.FirstName,
                                                  Author.LastName,
                                                  Current_Count = c.Count - ((from rent in db.GetRentTable()
                                                                              where c.Id == rent.IdBooks
                                                                              select rent.Count).Sum() ?? 0)
                                              };
                    }
                }
            }
            else
                MessageBox.Show("Заполните поле \"ID\"", "Неккоректный ввод", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        }

        private void Counttextbox_Leave(object sender, EventArgs e)
        {
            if (Counttextbox.Text.Length < 0)
            {
                MessageBox.Show("Поле не может быть отрицательным", "Неккоректный ввод",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                Counttextbox.Focus();
            }
            else
            {
                int a = Check(Counttextbox.Text, true);
                switch (a)
                {
                    case -1:
                        MessageBox.Show("Поле не должно быть пустым", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1:
                        MessageBox.Show("Поле не должно содержать буквы и другие знаки", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        MessageBox.Show("Поле не должно содержать 2 и больше пробелов подряд", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        MessageBox.Show("Первый символ не должен быть пробелом", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                if (a != 0)
                {
                    Counttextbox.Focus();
                    OKbutton.Enabled = true;
                }
                else
                    if (Convert.ToInt32(Counttextbox.Text) > 20)
                {
                    MessageBox.Show("Вы ввели в \"Количество\" значение больше 20\nТакое обычно редко бывает," +
                    " так что воть, Вы лучше проверьте :3", "Возможный неккорректный ввод", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    if (Convert.ToInt32(Counttextbox.Text) == 0)
                        MessageBox.Show("Вы добавляете книгу с количеством 0? Чет падазрительна =_=",
                        "Возможный неккорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Counttextbox.Focus();
                }
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите сбросить данные?", "Вы уверены?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Tableindex = 0;
                dataGrid.DataSource = db.GetBooksWithAuthorsTable();
                IDBooktextbox.Enabled = true;
                IDUsertextbox.Enabled = true;
                Counttextbox.Text = "";
                IDUsertextbox.Text = "";
                IDBooktextbox.Text = "";
                panel3.Hide();
                panel2.Hide();
                OKbutton.Enabled = false;
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            int TotalCount = (from c in db.GetBooksTable()
                         where c.Id == Convert.ToInt32(IDBooktextbox.Text)
                         select c.Count).FirstOrDefault();
            var RentCount = (from g in db.GetRentTable()
                                where g.IdBooks == Convert.ToInt32(IDBooktextbox.Text)
                                select g);
            int count = TotalCount - RentCount.Count();
            if (count < Convert.ToInt32(Counttextbox.Text))
            {
                MessageBox.Show("Введенное значение количества больше текущего значения книг.\n" +
                    "Невозможно выдать книг больше, чем сейчас имеется. Измените количество книг в \"Изменение\", либо\n"
                    + "введите другое количество.",
                    "Невозможно выдать такое количество книг.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    db.AddRent(IdStaff, Convert.ToInt32(IDUsertextbox.Text), Convert.ToInt32(IDBooktextbox.Text),
                    DateTime.Today, DateTime.Today.AddMonths(3), Convert.ToInt32(Counttextbox.Text));
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка при добавлении записи о выдаче книги.\n Возможно, эта запись уже существуют.",
                        "Невозможно добавить запись", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Новая запись добавлена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Counttextbox_TextChanged(object sender, EventArgs e)
        {
            if (Counttextbox.Text == "")
                OKbutton.Enabled = false;
            else
                OKbutton.Enabled = true;
        }
    }
}
