using Okulova_CourseWork.dbHelper;
using System;
using System.Windows.Forms;
using System.Linq;
using static Okulova_CourseWork.StringCheck;

namespace Okulova_CourseWork
{ 
    public partial class Staff_ChangeBook : Form
    {
        private DB db = new DB();
        public Staff_ChangeBook()
        {
            InitializeComponent();
            panel2.Hide();
            dataGrid.DataSource = db.GetBooksWithAuthorsTable();
            Author1combobox.DataSource = from c in db.GetAuthorsTable()
                                         select c.LastName + " " + c.FirstName;
            Author1combobox.SelectedIndex = -1;
            Author2combobox.DataSource = from c in db.GetAuthorsTable()
                                         select c.LastName + " " + c.FirstName;
            Author2combobox.SelectedIndex = -1;
            Author3combobox.DataSource = from c in db.GetAuthorsTable()
                                         select c.LastName + " " + c.FirstName;
            Author3combobox.SelectedIndex = -1;
        }

        private void Foundbutton_Click(object sender, EventArgs e)
        {
            if (IDtextbox.Text != "")
            {
                int x = -1;
                try
                {
                    x = Convert.ToInt32(IDtextbox.Text);
                }
                catch
                {
                    MessageBox.Show("ID должен состоять только из цифр", "Неккоректный ввод", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    IDtextbox.Focus();
                }
                if (x <= 0)
                {
                    MessageBox.Show("ID не может быть отрицательным или равным нулю.", "Неккоректный ввод", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    IDtextbox.Focus();
                }
                else
                {
                    var query = from c in db.GetBooksTable()
                                join Author_Book in db.GetAuthor_BooksTable()
                                on c.Id equals Author_Book.IdBooks
                                join Author in db.GetAuthorsTable()
                                on Author_Book.IdAuthors equals Author.Id
                                where c.Id == x
                                select c.Id;
                    var a = query.FirstOrDefault();
                    if (a == 0)
                        MessageBox.Show("Введен не существующий ID.", "ID не найден", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                    {
                        panel2.Show();
                        Searchtextbox.Enabled = false;
                        IDtextbox.Enabled = false;
                        Foundbutton.Enabled = false;
                        dataGrid.DataSource = from c in db.GetBooksTable()
                                              join author_Book in db.GetAuthor_BooksTable()
                                              on c.Id equals author_Book.IdBooks
                                              join Author in db.GetAuthorsTable()
                                              on author_Book.IdAuthors equals Author.Id
                                              where c.Id == Convert.ToInt32(IDtextbox.Text)                                              
                                              select new
                                              {
                                                  c.Id, c.Title, c.Genre, c.Release, c.Count,
                                                  Author.FirstName, Author.LastName,
                                                  Current_Count = c.Count - ((from rent in db.GetRentTable()
                                                                              where c.Id == rent.IdBooks
                                                                              select rent.Count).Sum() ?? 0)
                                              };
                        int CountOfAuthors = (from c in db.GetAuthor_BooksTable()
                                              where c.IdBooks == Convert.ToInt32(IDtextbox.Text)
                                              select c).Count();
                        switch (CountOfAuthors)
                        {
                            case 1: Author2combobox.Hide(); Author3combobox.Hide(); break;
                            case 2: Author3combobox.Hide(); break;                             
                        }                       
                    }
                }
            }
            else
                MessageBox.Show("Заполните поле \"ID\"", "Неккоректный ввод", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);            
        }

        private void Titletextbox_Leave(object sender, EventArgs e)
        {
            if (Titletextbox.Text.Length > 35)
            {
                MessageBox.Show("В поле не должно быть больше 35 символов", "Неккоректный ввод",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                Titletextbox.Focus();
            }
            else
            {
                int a = Check(Titletextbox.Text, false);
                switch (a)
                {                    
                    case 1:
                        MessageBox.Show("Поле не должно содержать цифры", "Неккоректный ввод",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        MessageBox.Show("Поле не должно содержать знаки, кроме как '-'", "Неккоректный ввод",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        MessageBox.Show("Поле не должно содержать 2 и больше пробелов подряд", "Неккоректный ввод",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 4:
                        MessageBox.Show("Первый символ не должен быть пробелом", "Неккоректный ввод",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                if (a != 0 && a != -1) Titletextbox.Focus();
            }
        }

        private void Genretextbox_Leave(object sender, EventArgs e)
        {
            if (Genretextbox.Text.Length > 15 || Genretextbox.Text.Length < 3)
            {
                MessageBox.Show("В поле должно быть от 3 до 15 символов", "Неккоректный ввод",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                Genretextbox.Focus();
            }
            else
            {
                int a = Check(Genretextbox.Text, false);
                switch (a)
                {
                    case 1:
                        MessageBox.Show("Поле не должно содержать цифры", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        MessageBox.Show("Поле не должно содержать знаки, кроме как '-'", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        MessageBox.Show("Поле не должно содержать 2 и больше пробелов подряд", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 4:
                        MessageBox.Show("Первый символ не должен быть пробелом", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                if (a != 0 && a != -1) Genretextbox.Focus();
            }
        }

        private void Issuetextbox_Leave(object sender, EventArgs e)
        {
            if (Issuetextbox.Text.Length > 4 || Issuetextbox.Text.Length < 2)
            {
                MessageBox.Show("В поле должно быть от 2 до 4 символов", "Неккоректный ввод",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                Issuetextbox.Focus();
            }
            else
            {
                int a = Check(Issuetextbox.Text, true);
                switch (a)
                {
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
                if (a != 0 && a != -1)
                    Issuetextbox.Focus();
                else
                    if (Convert.ToInt32(Issuetextbox.Text) > DateTime.Now.Year)
                    {
                            MessageBox.Show("Оу, эта книга что, из будущего?\nВы просто ввели год больше текущего...",
                            "Неккоректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Issuetextbox.Focus();
                    }
            }
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
                if (a != 0 && a != -1) Counttextbox.Focus();
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
            if (MessageBox.Show("Вы уверены, что хотите очистить все поля?", "Вы уверены?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Titletextbox.Text = "";
                Genretextbox.Text = "";
                Issuetextbox.Text = "";
                Counttextbox.Text = "";
                Author1combobox.SelectedIndex = -1;
                Author2combobox.SelectedIndex = -1;
                Author3combobox.SelectedIndex = -1;
                Searchtextbox.Enabled = true;
                Searchtextbox.Text = "";
                IDtextbox.Enabled = true;
                IDtextbox.Text = "";
                Foundbutton.Enabled = true;               
                dataGrid.DataSource = db.GetBooksWithAuthorsTable();
                panel2.Hide();
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            int IdBook = Convert.ToInt32(IDtextbox.Text);
            if (MessageBox.Show("Принять изменения?", "Вы уверены?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                db.Changebook(IdBook, Titletextbox.Text,
                      Genretextbox.Text, Convert.ToInt32(Issuetextbox.Text),
                      Convert.ToInt32(Counttextbox.Text));
                int Id1 = Author1combobox.SelectedIndex;
                int Id2 = Author2combobox.SelectedIndex;
                int Id3 = Author3combobox.SelectedIndex;
                if (Id1 != -1)
                    db.ChangeAuthorForBook(IdBook, Id1);
                if (Id2 != -1)
                    db.ChangeAuthorForBook(IdBook, Id2);
                if (Id3 != -1)
                    db.ChangeAuthorForBook(IdBook, Id3);
            }
            MessageBox.Show("Изменения успешно выполнены", "Успешно.",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void Searchtextbox_TextChanged(object sender, EventArgs e)
        {
            string s = Searchtextbox.Text;
            dataGrid.DataSource = db.Search(0, s);
        }
    }
}
