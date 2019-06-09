﻿using Okulova_CourseWork.dbHelper;
using System;
using System.Windows.Forms;
using System.Linq;
using static Okulova_CourseWork.StringCheck;

namespace Okulova_CourseWork
{
    public partial class Staff_AddStaff : Form
    {
        private DB db = new DB();
        public Staff_AddStaff()
        {
            InitializeComponent();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?\nВсе несохранённые данные будут потеряны!", "Вы уверены?",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Close();
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите очистить все поля?", "Вы уверены?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                FirstNametextbox.Text = null;
                LastNametextbox.Text = null;
                Phonetextbox.Text = null;
                BirthdayPicker.Text = null;
                Passporttextbox.Text = null;
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (FirstNametextbox.Text != "" && LastNametextbox.Text != "" && Phonetextbox.Text != ""
                && Passporttextbox.Text != "")
            {
                try
                {
                    db.AddStaff(FirstNametextbox.Text, LastNametextbox.Text, Phonetextbox.Text,
                        BirthdayPicker.Value, Passporttextbox.Text);
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка при добавлении.\n Возможно, эта запись уже существуют, либо введены неккоректные данные.",
                        "Невозможно добавить запись", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Пожалуйста, заполните все поля.",
                    "Заполните все поля.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void LastNametextbox_Leave(object sender, EventArgs e)
        {
            if (LastNametextbox.Text.Length > 15)
            {
                MessageBox.Show("В поле не может быть больше 15 символов", "Неккоректный ввод",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                LastNametextbox.Focus();
            }
            else
            {
                int a = Check(LastNametextbox.Text, false);
                switch (a)
                {
                    case -1:
                        MessageBox.Show("Поле не может быть пустым", "Неккоректный ввод",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1:
                        MessageBox.Show("Название не должно содержать цифры", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        MessageBox.Show("Название не должно содержать знаки, кроме как '-'", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        MessageBox.Show("Название не должно содержать 2 и больше пробелов подряд", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 4:
                        MessageBox.Show("Первый символ не должен быть пробелом", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                if (a != 0) LastNametextbox.Focus();
            }
        }

        private void FirstNametextbox_Leave(object sender, EventArgs e)
        {
            if (FirstNametextbox.Text.Length > 15)
            {
                MessageBox.Show("В поле не может быть больше 15 символов", "Неккоректный ввод",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                FirstNametextbox.Focus();
            }
            else
            {
                int a = Check(FirstNametextbox.Text, false);
                switch (a)
                {
                    case -1:
                        MessageBox.Show("Поле не может быть пустым", "Неккоректный ввод",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1:
                        MessageBox.Show("Название не должно содержать цифры", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        MessageBox.Show("Название не должно содержать знаки, кроме как '-'", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        MessageBox.Show("Название не должно содержать 2 и больше пробелов подряд", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 4:
                        MessageBox.Show("Первый символ не должен быть пробелом", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                if (a != 0) FirstNametextbox.Focus();
            }
        }

        private void Phonetextbox_Leave(object sender, EventArgs e)
        {
            if (Phonetextbox.Text.Length != 11)
            {
                MessageBox.Show("В поле должно быть ровно 11 символов", "Неккоректный ввод",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                Phonetextbox.Focus();
            }
            else
            {
                int a = Check(Phonetextbox.Text, true);
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
                        MessageBox.Show("Поле не должно 2 и больше пробелов подряд", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        MessageBox.Show("Первый символ не должен быть пробелом", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                if (a != 0) Phonetextbox.Focus();
            }
        }     

        private void Passporttextbox_Leave(object sender, EventArgs e)
        {
            if (Passporttextbox.Text.Length != 10)
            {
                MessageBox.Show("В поле должно быть ровно 10 символов", "Неккоректный ввод",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                Passporttextbox.Focus();
            }
            else
            {
                int a = Check(Passporttextbox.Text, true);
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
                if (a != 0) Passporttextbox.Focus();
            }
        }
    }
}
