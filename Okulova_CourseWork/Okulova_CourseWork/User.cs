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

        private void Searchtextbox_TextChanged(object sender, EventArgs e)
        {
            string s = Searchtextbox.Text;
            int TableIndex = TablecomboBox.SelectedIndex;
            if (TableIndex == -1)
                MessageBox.Show("Выберите таблицу, в которой искать", "Выберите таблицу", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
            {
                if (s == null)
                    if (TableIndex == 0)
                        DataGrid.DataSource = db.GetBooksWithAuthorsTable();
                    else
                        DataGrid.DataSource = db.GetAuthorsTable();
                else
                    DataGrid.DataSource = db.Search(TableIndex, s);
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
