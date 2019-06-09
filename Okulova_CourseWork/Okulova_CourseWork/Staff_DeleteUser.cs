﻿using Okulova_CourseWork.dbHelper;
using System;
using System.Windows.Forms;
using static Okulova_CourseWork.StringCheck;
using System.Linq;

namespace Okulova_CourseWork
{
    public partial class Staff_DeleteUser : Form
    {
        private DB db = new DB();
        public Staff_DeleteUser()
        {
            InitializeComponent();
            dataGrid.DataSource = db.GetUsersTable();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (IDtextBox.Text.Length < 0)
            {
                MessageBox.Show("Поле не может быть отрицательным", "Неккоректный ввод",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int a = Check(IDtextBox.Text, true);
                switch (a)
                {
                    case -1:
                        MessageBox.Show("Поле не может быть пустым", "Неккоректный ввод",
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
                if (a == 0)
                {
                    var query = from b in db.GetUsersTable()
                                where b.Id == Convert.ToInt32(IDtextBox.Text)
                                select b.Id;
                    int res = query.FirstOrDefault();
                    if (res == 0)
                    {
                        MessageBox.Show("ID не найден", "", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить все сведения об Пользователе, включая взятые им книги?", "",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            db.DeleteUser(res);
                            MessageBox.Show("Удаление выполнено успешно", "Выполнено",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGrid.DataSource = db.GetUsersTable();
                        }
                    }
                }
            }
        }

        private void Searchtextbox_TextChanged(object sender, EventArgs e)
        {
            string s = Searchtextbox.Text;
            dataGrid.DataSource = db.Search(2, s);
        }
    }
}
