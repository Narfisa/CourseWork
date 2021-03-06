﻿using Okulova_CourseWork.dbHelper;
using System;
using System.Windows.Forms;
using System.Linq;
using Okulova_CourseWork.entities;
using static Okulova_CourseWork.StringCheck;

namespace Okulova_CourseWork
{
    public partial class Staff_AddBook : Form
    {
        private DB db = new DB();
        public Staff_AddBook()
        {
            InitializeComponent();
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

        public void Clear()
        {
            Titletextbox.Text = null;
            Genretextbox.Text = null;
            Issuetextbox.Text = null;
            Counttextbox.Text = null;
            Author1combobox.SelectedIndex = -1;
            Author2combobox.SelectedIndex = -1;
            Author3combobox.SelectedIndex = -1;
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите очистить все поля?", "Вы уверены?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Clear();
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?\nВсе несохранённые данные будут потеряны!", "Вы уверены?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Close();
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (Titletextbox.Text == "" && Genretextbox.Text == ""
                && Issuetextbox.Text == "" && Counttextbox.Text == "")
                MessageBox.Show("Пожалуйста,заполните все поля",
                "Заполните все поля.", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            else
            {
                if (Author1combobox.SelectedIndex == -1 && Author2combobox.SelectedIndex == -1
                    && Author3combobox.SelectedIndex == -1)
                {
                    MessageBox.Show("Нужно выбрать хотя бы одного автора.",
                        "Заполните все поля.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        db.Addbook(Titletextbox.Text, Genretextbox.Text, Convert.ToInt32(Issuetextbox.Text), Convert.ToInt32(Counttextbox.Text));
                        if (Author1combobox.SelectedIndex != -1)
                        {
                            int idBook = (from c in db.GetBooksTable()
                                          where c.Title == Titletextbox.Text
                                          select c.Id).First();
                            db.AddAuthor_Book(idBook, Author1combobox.SelectedIndex + 1);
                        }
                        if (Author2combobox.SelectedIndex != -1)
                        {
                            int idBook = (from c in db.GetBooksTable()
                                          where c.Title == Titletextbox.Text
                                          select c.Id).First();
                            db.AddAuthor_Book(idBook, Author2combobox.SelectedIndex + 1);
                        }
                        if (Author3combobox.SelectedIndex != -1)
                        {
                            int idBook = (from c in db.GetBooksTable()
                                          where c.Title == Titletextbox.Text
                                          select c.Id).First();
                            db.AddAuthor_Book(idBook, Author3combobox.SelectedIndex + 1);
                        }
                        MessageBox.Show("Новая запись добавлена.", "Добавлено.", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Произошла ошибка при добавлении.\n Возможно, эта запись уже существуют, либо введены неккоректные данные.",
                        "Невозможно добавить запись", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }                    
            }

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
                    case -1:
                        MessageBox.Show("Поле не может быть пустым", "Неккоректный ввод",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
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
                if (a != 0) Titletextbox.Focus();
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
                    case -1:
                        MessageBox.Show("Поле не может быть пустым", "Неккоректный ввод",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
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
                if (a != 0) Genretextbox.Focus();
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
                if (a != 0) Issuetextbox.Focus();
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
                if (a != 0) Counttextbox.Focus();
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
                    {
                        MessageBox.Show("Вы добавляете книгу с количеством 0? Чет падазрительна =_=",
                              "Возможный неккорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Counttextbox.Focus();
                    }
                }
            }
        }        
    }
}
