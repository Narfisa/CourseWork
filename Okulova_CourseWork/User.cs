using Okulova_CourseWork.dbHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Okulova_CourseWork
{
    public partial class User : Form
    {
        private DB db = new DB();
        public User()
        {
            InitializeComponent();
        }

        private void User_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HelpUser help = new HelpUser();
            Hide();
            help.ShowDialog();
            help.Dispose();
            Show();
        }

        public IQueryable Search(int table, string s)
        {
            if (table == 0)
            {
                return
                    from c in db.GetBooksTable()
                    join Author_Book in db.GetAuthor_BooksTable()
                    on c.Id equals Author_Book.IdBooks
                    join Author in db.GetAuthorsTable()
                    on Author_Book.IdAuthors equals Author.Id
                    join rent in db.GetRentTable()
                    on c.Id equals rent.IdBooks
                    where c.Title.StartsWith(s) || c.Genre.StartsWith(s) || Convert.ToString(c.Release).StartsWith(s)
                    || Convert.ToString(c.Count).StartsWith(s) || Author.FirstName.StartsWith(s) || Author.LastName.StartsWith(s)
                    select new { c.Id, c.Title, c.Genre, c.Release, c.Count, Author.FirstName, Author.LastName,
                        Current_Count = c.Count - (from goo in db.GetBooksTable()
                                                   join g_o in db.GetAuthor_BooksTable()
                                                   on goo.Id equals g_o.IdBooks
                                                   where rent.IdBooks == goo.Id && goo.Id == g_o.IdBooks
                                                   select g_o).Count()
                    };
            }
            else
            {
                return
                    from c in db.GetAuthorsTable()
                     where c.LastName.StartsWith(s) || c.FirstName.StartsWith(s) 
                     || c.Patronymic.StartsWith(s) || c.Country.StartsWith(s)
                     select new { c.Id, c.LastName, c.FirstName, c.Patronymic, c.Country };
            }                
        }

        private void Searchtextbox_TextChanged(object sender, EventArgs e)
        {
            string a = Searchtextbox.Text;
            int t = TablecomboBox.SelectedIndex;
            if (t == -1)
                MessageBox.Show("Выберите таблицу, в которой искать", "Выберите таблицу", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
            {
                if (a == null)
                    if (t == 0)
                        DataGrid.DataSource = db.GetBooksWithAuthorsTable();
                    else
                        DataGrid.DataSource = db.GetAuthorsTable();
                else
                    DataGrid.DataSource = Search(t, a);
            }
            
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IDtextBox.Text))
                MessageBox.Show("Ничего не введено.", "Пустая строка", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
            {
                char[] a = IDtextBox.Text.ToCharArray();
                int i;
                bool t = true;
                for (i = 0; i < a.Length; i++)
                    if (!char.IsNumber(a[i]))
                    {                       
                        t = false;
                        break;                        
                    }
                if (!t)
                {
                    MessageBox.Show("ID должен состоять только из цифр", "Неккоректный ввод", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    var query = from c in db.GetRentTable()
                                join b in db.GetBooksTable()
                                on c.IdBooks equals b.Id
                                where c.IdUsers == Convert.ToInt32(IDtextBox.Text)
                                select new { b.Title, c.Count, c.Issue, c.Return};
                    if (query.Any())
                        DataGrid.DataSource = query;
                    else
                        MessageBox.Show("ID не найден, либо у вас нет взятых книг", "Нет данных", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void TablecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TablecomboBox.SelectedIndex == 0)
                DataGrid.DataSource = db.GetBooksWithAuthorsTable();
            else
                DataGrid.DataSource = db.GetAuthorsTable();
        }
    }
}
