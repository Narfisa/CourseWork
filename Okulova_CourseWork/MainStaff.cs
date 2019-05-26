using Okulova_CourseWork.dbHelper;
using System;
using System.Windows.Forms;
using System.Linq;

namespace Okulova_CourseWork
{
    public partial class MainStaff : Form
    {
        private DB db = new DB();
        public MainStaff(int a)
        {
            InitializeComponent();
            this.a = a;
            var query_firstname = from c in db.GetStaffTable()
                                  where c.Id == a
                                  select c.FirstName;
            var query_lastname = from c in db.GetStaffTable()
                                 where c.Id == a
                                 select c.LastName;
            this.Text = "Здравствуйте, " + query_firstname.FirstOrDefault() + " " + query_lastname.FirstOrDefault() + "!";
        }
        int a;

        private void Showbutton_Click(object sender, EventArgs e)
        {
            int i = ShowBox.SelectedIndex;
            switch (i)
            {
                case -1:
                    MessageBox.Show("Выберите, пожалуйста, какую таблицу отобразить",
                        "Выберите таблицу", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 0:
                    DataGrid.DataSource = db.GetBooksWithAuthorsTable();
                    break;
                case 1:
                    DataGrid.DataSource = db.GetAuthorsTable();
                    break;
                case 2:
                    DataGrid.DataSource = db.GetUsersTable();
                    break;
                case 3:
                    DataGrid.DataSource = db.GetStaffTable();
                    break;
                case 4:
                    DataGrid.DataSource = db.GetRentTable();
                    break;
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            int i = AddBox.SelectedIndex;
            switch (i)
            {
                case -1:
                    MessageBox.Show("Выберите, пожалуйста, в какую таблицу добавлять данные",
                        "Выберите таблицу", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 0:
                    Staff_AddBook form2 = new Staff_AddBook();
                    form2.ShowDialog();
                    form2.Dispose();
                    break;
                case 1:
                    Staff_AddAuthor form3 = new Staff_AddAuthor();
                    form3.ShowDialog();
                    form3.Dispose();
                    break;
                case 2:
                    Staff_AddUser form4 = new Staff_AddUser();
                    form4.ShowDialog();
                    form4.Dispose();
                    break;
                case 3:
                    Staff_AddStaff form5 = new Staff_AddStaff();
                    form5.ShowDialog();
                    form5.Dispose();
                    break;
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            int i = DeleteBox.SelectedIndex;
            switch (i)
            {
                case -1:
                    MessageBox.Show("Выберите, пожалуйста, в какой таблице вы хотите удалить данные",
                        "Выберите таблицу", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 0:
                    Staff_DeleteBook form2 = new Staff_DeleteBook();
                    form2.ShowDialog();
                    form2.Dispose();
                    break;
                case 1:
                    Staff_DeleteAuthor form3 = new Staff_DeleteAuthor();
                    form3.ShowDialog();
                    form3.Dispose();
                    break;
                case 2:
                    Staff_DeleteUser form4 = new Staff_DeleteUser();
                    form4.ShowDialog();
                    form4.Dispose();
                    break;
                case 3:
                    Staff_DeleteStaff form5 = new Staff_DeleteStaff();
                    form5.ShowDialog();
                    form5.Dispose();
                    break;
            }
        }

        private void Outbutton_Click(object sender, EventArgs e)
        {
            Staff_Out form = new Staff_Out(a);
            form.ShowDialog();
            form.Dispose();
        }

        private void Inbutton_Click(object sender, EventArgs e)
        {
            Staff_In form = new Staff_In(a);
            form.ShowDialog();
            form.Dispose();
        }        

        private void Changebutton_Click(object sender, EventArgs e)
        {
            int i = Changecombobox.SelectedIndex;
            switch (i)
            {
                case -1:
                    MessageBox.Show("Выберите, пожалуйста, в какой таблице вы хотите изменить данные",
                        "Выберите таблицу", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 0:
                    Staff_ChangeBook form2 = new Staff_ChangeBook();
                    form2.ShowDialog();
                    form2.Dispose();
                    break;
                case 1:
                    Staff_ChangeAuthor form3 = new Staff_ChangeAuthor();
                    form3.ShowDialog();
                    form3.Dispose();
                    break;
                case 2:
                    Staff_ChangeUser form4 = new Staff_ChangeUser();
                    form4.ShowDialog();
                    form4.Dispose();
                    break;
                case 3:
                    Staff_ChangeStaff form5 = new Staff_ChangeStaff();
                    form5.ShowDialog();
                    form5.Dispose();
                    break;
                case 4:
                    ChangePass form6 = new ChangePass(a);
                    form6.ShowDialog();
                    form6.Dispose();
                    break;
            }
        }

        public IQueryable Search(int table, string s)
        {
            if (table == 0)
                return
                    from c in db.GetBooksTable()
                        join Author_Book in db.GetAuthor_BooksTable()
                        on c.Id equals Author_Book.IdBooks
                        join Author in db.GetAuthorsTable()
                        on Author_Book.IdAuthors equals Author.Id
                        where c.Title.StartsWith(s) || c.Genre.StartsWith(s) || Convert.ToString(c.Release).StartsWith(s)
                        || Convert.ToString(c.Count).StartsWith(s) || Author.FirstName.StartsWith(s) || Author.LastName.StartsWith(s)
                        select new { c.Id, c.Title, c.Genre, c.Release, c.Count, Author.FirstName, Author.LastName };
            else if (table == 1)
                return
                    from c in db.GetAuthorsTable()
                    where c.LastName.StartsWith(s) || c.FirstName.StartsWith(s)
                    || c.Patronymic.StartsWith(s) || c.Country.StartsWith(s)
                    select new { c.Id, c.LastName, c.FirstName, c.Patronymic, c.Country };
            else if (table == 2)
                return
                   from c in db.GetUsersTable()
                   where c.LastName.StartsWith(s) || c.FirstName.StartsWith(s)
                   || c.PhoneNumber.StartsWith(s) || c.Adress.StartsWith(s) || Convert.ToString(c.Birthday).StartsWith(s)
                   select new { c.Id, c.FirstName, c.LastName, c.PhoneNumber, c.Adress, c.Birthday };
            else
                return
                 from c in db.GetStaffTable()
                 where c.LastName.StartsWith(s) || c.FirstName.StartsWith(s)
                 || c.PhoneNumber.StartsWith(s) 
                 select new { c.Id, c.FirstName, c.LastName, c.PhoneNumber, c.Birthday };

        }

        private void Searchtextbox_TextChanged(object sender, EventArgs e)
        {
            string s = Searchtextbox.Text;
            int i = ShowBox.SelectedIndex;
            if (i == -1)
                MessageBox.Show("Выберите таблицу, в которой искать", "Выберите таблицу", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
            {
                if (s == null)
                    switch (i)
                    {
                        case 0:
                            DataGrid.DataSource = db.GetBooksWithAuthorsTable(); break;
                        case 1:
                            DataGrid.DataSource = db.GetAuthorsTable(); break;
                        case 2:
                            DataGrid.DataSource = db.GetUsersTable(); break;
                        case 3:
                            DataGrid.DataSource = db.GetStaffTable(); break;
                        case 4:
                            DataGrid.DataSource = db.GetRentTable(); break;
                    }
                else
                    DataGrid.DataSource = Search(i, s);
            }            
        }

    }
}
