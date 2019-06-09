using Okulova_CourseWork.dbHelper;
using static Okulova_CourseWork.StringCheck;
using System;
using System.Windows.Forms;
using System.Linq;

namespace Okulova_CourseWork
{
    public partial class Staff_In : Form
    {
        private DB db = new DB();
        public Staff_In(int a)
        {
            InitializeComponent();
            this.a = a;
            index = 1;
            dataGrid.DataSource = db.GetFullRentTable();
            OKbutton.Enabled = false;
            panel2.Hide();
            panel3.Hide();
        }

        int a;
        int index;        

        private void Searchtextbox_TextChanged(object sender, EventArgs e)
        {
            string s = Searchtextbox.Text;
            if (index == 3)
                Searchtextbox.Enabled = false;
            else
            {
                if (s != null)
                    dataGrid.DataSource =
                        db.Search(3, s);
                else
                    dataGrid.DataSource = db.GetFullRentTable();

            }
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
                    var query = from rent in db.GetRentTable()
                                where rent.IdBooks == x
                                select rent.IdBooks;
                    var a = query.FirstOrDefault();
                    if (a == 0)
                        MessageBox.Show("Введен не существующий ID.", "ID не найден", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                    {
                        index = 3;
                        panel3.Show();
                        IDBooktextbox.Enabled = false;
                        FoundBookbutton.Enabled = false;
                        dataGrid.DataSource = from rent in db.GetRentTable()
                                              join book in db.GetBooksTable()
                                              on rent.IdBooks equals book.Id
                                              join staff in db.GetStaffTable()
                                              on rent.IdStaff equals staff.Id
                                              join user in db.GetUsersTable()
                                              on rent.IdUsers equals user.Id
                                              where rent.IdBooks == x
                                              select new
                                              {
                                                  IdBook = book.Id,
                                                  book.Title,
                                                  IdUser = user.Id,
                                                  UserName = user.LastName + " " + user.FirstName,
                                                  IDStaff = staff.Id,
                                                  StaffName = staff.LastName + " " + staff.FirstName,
                                                  RentCount = rent.Count,
                                                  IssueDate = rent.Issue,
                                              };
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
                    var query = from c in db.GetRentTable()
                                where c.IdUsers == x
                                select c.IdUsers;
                    var a = query.FirstOrDefault();
                    if (a == 0)
                        MessageBox.Show("Введен не существующий ID.", "ID не найден", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                    {
                        index = 0;
                        panel2.Show();
                        IDUsertextbox.Enabled = false;
                        FoundUserbutton.Enabled = false;
                        dataGrid.DataSource = from rent in db.GetRentTable()
                                              join book in db.GetBooksTable()
                                              on rent.IdBooks equals book.Id
                                              join staff in db.GetStaffTable()
                                              on rent.IdStaff equals staff.Id
                                              join user in db.GetUsersTable()
                                              on rent.IdUsers equals user.Id
                                              where rent.IdUsers == x
                                              select new
                                              {
                                                  IdBook = book.Id,
                                                  book.Title,
                                                  IdUser = user.Id,
                                                  UserName = user.LastName + " " + user.FirstName,
                                                  IDStaff = staff.Id,
                                                  StaffName = staff.LastName + " " + staff.FirstName,
                                                  RentCount = rent.Count,
                                                  IssueDate = rent.Issue,
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
                        MessageBox.Show("Вы возвращаете книгу с количеством 0? Чет падазрительна =_=",
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
                index = 0;
                dataGrid.DataSource = db.GetBooksWithAuthorsTable();
                IDBooktextbox.Enabled = true;
                IDUsertextbox.Enabled = true;
                Counttextbox.Text = "";
                IDUsertextbox.Text = "";
                IDBooktextbox.Text = "";
                FoundUserbutton.Enabled = true;
                FoundBookbutton.Enabled = true;
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
            var Current_Count = (from good in db.GetRentTable()
                                 where good.IdBooks == Convert.ToInt32(IDBooktextbox.Text)
                                 select new
                                 {
                                     Current_Count = TotalCount - (from c in db.GetRentTable()                                                                  
                                                                   where c.IdBooks == good.IdBooks
                                                                   select c.Count).Sum()
                                 }).FirstOrDefault().Current_Count;
            int? count = TotalCount - Current_Count;
            if (Convert.ToInt32(Counttextbox.Text) + count > TotalCount)
            {
                MessageBox.Show("Введенное вами значение количества (" + Counttextbox.Text + ") и текущее количество книг (" +
                    Convert.ToString(Current_Count) + ") больше общего количества книг (" + Convert.ToString(TotalCount) +
                    "\nИзмените количество книг в \"Изменение\", либо введите другое количество.",
                    "Невозможно принять такое количество книг.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                db.DeleteRent(Convert.ToInt32(IDUsertextbox.Text), Convert.ToInt32(IDBooktextbox.Text), Convert.ToInt32(Counttextbox.Text));
                MessageBox.Show("Запись удалена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Counttextbox_TextChanged(object sender, EventArgs e)
        {
            if (Counttextbox.Text != "")
                OKbutton.Enabled = true;
            else
                OKbutton.Enabled = false;
        }
    }
}
