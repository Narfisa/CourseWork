using Okulova_CourseWork.dbHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okulova_CourseWork
{
    public partial class User : Form
    {
        private DB db = new DB();
        public User()
        {
            InitializeComponent();
            ToolTip In = new ToolTip();
            In.SetToolTip(IncomboBox, "Выберите таблицу в меню снизу");
        }

        private void TablecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TablecomboBox.SelectedIndex == 0)
            {
                DataGrid.DataSource = db.GetBooksWithAuthorsTable();
                IncomboBox.Items.Clear();
                string[] mas = { "Title", "Genre", "Release", "Count", "FirstName", "LastName", "Всей таблице" };
                IncomboBox.Items.AddRange(mas);
            }
            else
            {
                DataGrid.DataSource = db.GetAuthorsTable();
                IncomboBox.Items.Clear();
                string[] mas = { "LastName", "FirstName", "Patronymic", "Country", "Всей таблице"};
                IncomboBox.Items.AddRange(mas);
            }
        }       

        private void User_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HelpUser help = new HelpUser();
            Hide();
            help.ShowDialog();
            help.Dispose();
            Show();
        }

        public IQueryable Search(int index, int table, string s)
        {
            if (table == 0)
            {
                switch (index)
                {
                    case 0:
                        return
                            //from c in db.GetBooksWithAuthorsTable()
                            //where c.Title.StartsWith(s)
                            //select new { c.Id, c.Count };
                            from c in db.GetBooksTable()
                            join Author_Book in db.GetAuthor_BooksTable()
                            on c.Id equals Author_Book.IdBooks
                            join Author in db.GetAuthorsTable()
                            on Author_Book.IdAuthors equals Author.Id
                            where c.Title.StartsWith(s)
                            select new { c.Id, c.Title, c.Genre, c.Release, c.Count, Author.FirstName, Author.LastName };
                    case 1:
                        return
                            from c in db.GetBooksTable()
                            join Author_Book in db.GetAuthor_BooksTable()
                            on c.Id equals Author_Book.IdBooks
                            join Author in db.GetAuthorsTable()
                            on Author_Book.IdAuthors equals Author.Id
                            where c.Genre.StartsWith(s)
                            select new { c.Id, c.Title, c.Genre, c.Release, c.Count, Author.FirstName, Author.LastName };
                    case 2:
                        return
                            from c in db.GetBooksTable()
                            join Author_Book in db.GetAuthor_BooksTable()
                            on c.Id equals Author_Book.IdBooks
                            join Author in db.GetAuthorsTable()
                            on Author_Book.IdAuthors equals Author.Id
                            where Convert.ToString(c.Release).StartsWith(s)
                            select new { c.Id, c.Title, c.Genre, c.Release, c.Count, Author.FirstName, Author.LastName };
                    case 3:
                        return
                            from c in db.GetBooksTable()
                            join Author_Book in db.GetAuthor_BooksTable()
                            on c.Id equals Author_Book.IdBooks
                            join Author in db.GetAuthorsTable()
                            on Author_Book.IdAuthors equals Author.Id
                            where Convert.ToString(c.Count).StartsWith(s)
                            select new { c.Id, c.Title, c.Genre, c.Release, c.Count, Author.FirstName, Author.LastName };

                    case 4:
                        return
                            from c in db.GetBooksTable()
                            join Author_Book in db.GetAuthor_BooksTable()
                            on c.Id equals Author_Book.IdBooks
                            join Author in db.GetAuthorsTable()
                            on Author_Book.IdAuthors equals Author.Id
                            where Author.FirstName.StartsWith(s)
                            select new { c.Id, c.Title, c.Genre, c.Release, c.Count, Author.FirstName, Author.LastName };
                    case 5:
                        return
                            from c in db.GetBooksTable()
                            join Author_Book in db.GetAuthor_BooksTable()
                            on c.Id equals Author_Book.IdBooks
                            join Author in db.GetAuthorsTable()
                            on Author_Book.IdAuthors equals Author.Id
                            where Author.LastName.StartsWith(s)
                            select new { c.Id, c.Title, c.Genre, c.Release, c.Count, Author.FirstName, Author.LastName };
                    default:
                        return
                            from c in db.GetBooksTable()
                            join Author_Book in db.GetAuthor_BooksTable()
                            on c.Id equals Author_Book.IdBooks
                            join Author in db.GetAuthorsTable()
                            on Author_Book.IdAuthors equals Author.Id
                            where c.Title.StartsWith(s) || c.Genre.StartsWith(s) || Convert.ToString(c.Release).StartsWith(s)
                            || Convert.ToString(c.Count).StartsWith(s) || Author.FirstName.StartsWith(s) || Author.LastName.StartsWith(s)
                            select new { c.Id, c.Title, c.Genre, c.Release, c.Count, Author.FirstName, Author.LastName };

                }
            }
            else
            {
                switch (index)
                {
                    case 0:
                        return
                            from c in db.GetAuthorsTable()                        
                            where c.LastName.StartsWith(s)
                            select new { c.Id, c.LastName, c.FirstName, c.Patronymic, c.Country };
                    case 1:
                        return
                            from c in db.GetAuthorsTable()
                            where c.FirstName.StartsWith(s)
                            select new { c.Id, c.LastName, c.FirstName, c.Patronymic, c.Country };
                    case 2:
                        return
                            from c in db.GetAuthorsTable()
                            where c.Patronymic.StartsWith(s)
                            select new { c.Id, c.LastName, c.FirstName, c.Patronymic, c.Country };
                    case 3:
                        return
                            from c in db.GetAuthorsTable()
                            where c.Country.StartsWith(s)
                            select new { c.Id, c.LastName, c.FirstName, c.Patronymic, c.Country };
                    default:
                        return
                            from c in db.GetAuthorsTable()
                            where c.LastName.StartsWith(s) || c.FirstName.StartsWith(s) 
                            || c.Patronymic.StartsWith(s) || c.Country.StartsWith(s)
                            select new { c.Id, c.LastName, c.FirstName, c.Patronymic, c.Country };
                }
            }                
        }

        private void Searchtextbox_TextChanged(object sender, EventArgs e)
        {
            string a = Searchtextbox.Text;
            int i = IncomboBox.SelectedIndex;
            int t = TablecomboBox.SelectedIndex;
            if (a == null)
                if (t == 0)
                    DataGrid.DataSource = db.GetBooksWithAuthorsTable();
                else
                    DataGrid.DataSource = db.GetAuthorsTable();
            else
                DataGrid.DataSource = Search(i, t, a);
        }
    }
}
