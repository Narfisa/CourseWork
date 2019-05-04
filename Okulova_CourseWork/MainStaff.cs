using Okulova_CourseWork.dbHelper;
using System;
using System.Windows.Forms;

namespace Okulova_CourseWork
{
    public partial class MainStaff : Form
    {
        private DB db = new DB();
        public MainStaff()
        {
            InitializeComponent();
        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            int a = ShowBox.SelectedIndex;
            switch (a)
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
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            int a = AddBox.SelectedIndex;
            switch (a)
            {
                case -1:
                    MessageBox.Show("Выберите, пожалуйста, в какую таблицу добавлять данные",
                        "Выберите таблицу", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 0:
                    Staff_Add form2 = new Staff_Add();
                    form2.ShowDialog();
                    form2.Dispose();
                    break;
                default:
                    MessageBox.Show("Пока добавление \"возможно\" только для таблицы 'Книги'",
                        "Функция на стадии разработки.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                    //    case 1:
                    //        Application.Run(new Form3());
                    //        break;
                    //    case 2:
                    //        Application.Run(new Form4());
                    //        break;
                    //    case 3:
                    //        Application.Run(new Form5());
                    //        break;
                    //
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта функция на стадии разработки.", "Ooops!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Outbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта функция на стадии разработки.", "Ooops!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Inbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта функция на стадии разработки.", "Ooops!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            if (ShowBox.SelectedIndex == -1)
                MessageBox.Show("Отобразите, пожалуйста, для начала таблицу.",
                    "Выберите таблицу", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Эта функция на стадии разработки.", "Ooops!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

        }

        private void Changebutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта функция на стадии разработки.", "Ooops!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
