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
    public partial class Staff_Add : Form
    {
        public Staff_Add()
        {
            InitializeComponent();
        }

        public int Stringcheck(string s, bool key)
        {
            char[] str = s.ToCharArray();
            int i;
            if (!key)
            {
                for (i = 0; i < str.Length; ++i)
                {
                    if (char.IsNumber(str[i]))
                        return 1;
                    if (!char.IsLetter(str[i]) && str[i] != '-')
                        return 2;
                    if (i > 0 && char.IsWhiteSpace(str[i - 1]) && char.IsWhiteSpace(str[i]))
                        return 3;
                    if (char.IsWhiteSpace(str[i]))
                        return 4;
                }
                return 0;
            }
            else
            {
                for (i = 0; i < str.Length; ++i)
                {
                    if (char.IsLetter(str[i]))
                        return 1;                    
                    if (i > 0 && char.IsWhiteSpace(str[i - 1]) && char.IsWhiteSpace(str[i]))
                        return 2;
                    if (char.IsWhiteSpace(str[i]))
                        return 3;
                }
                return 0;
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите очистить все поля?", "Вы уверены?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Titletextbox.Text = null;
                Genretextbox.Text = null;
                Issuetextbox.Text = null;
                Counttextbox.Text = null;
                Author1combobox.SelectedIndex = -1;
                Author2combobox.SelectedIndex = -1;
                Author3combobox.SelectedIndex = -1;
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
            if (Titletextbox.Text != "" && Genretextbox.Text != "" 
                && Issuetextbox.Text != "" && Counttextbox.Text != "")
                MessageBox.Show("Эта функция на стадии разработки.", "Ooops!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
                MessageBox.Show("Пожалуйста,заполните все поля.\nАвторов пока можно не заполнять", 
                    "Заполните все поля.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void Titletextbox_Leave(object sender, EventArgs e)
        {
            int a = Stringcheck(Titletextbox.Text, false);
            // false - a letter can be a '-' char. True - can't be. Use true for ints, false for strings
            // 1 - there is a number; 2 - there are not only letters
            // 3 - there are 2 or more spaces; 4 - first char is a space; 0 - Only letters 
            switch (a)
            {
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
            Titletextbox.Focus();
        }

        private void Genretextbox_Leave(object sender, EventArgs e)
        {
            int a = Stringcheck(Titletextbox.Text, false);
            // false - a letter can be a '-' char. True - can't be. Use true for ints, false for strings
            // 1 - there is a number; 2 - there are not only letters
            // 3 - there are 2 or more spaces; 4 - first char is a space; 0 - Only letters 
            switch (a)
            {
                case 1:
                    MessageBox.Show("Жанр не должен содержать цифры", "Неккоректный ввод",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("Жанр не должен содержать знаки, кроме как '-'", "Неккоректный ввод",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    MessageBox.Show("Жанр не должен содержать 2 и больше пробелов подряд", "Неккоректный ввод",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 4:
                    MessageBox.Show("Первый символ не должен быть пробелом", "Неккоректный ввод",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            Genretextbox.Focus();
        }

        private void Issuetextbox_Leave(object sender, EventArgs e)
        {
            int a = Stringcheck(Titletextbox.Text, true);
            // false - a letter can be a '-' char. True - can't be. Use true for ints, false for strings
            // 1 - there are not only numbers; there are 2 or more spaces
            // 3 - first char is a space; 0 - Only numbers 
            switch (a)
            {
                case 1:
                    MessageBox.Show("Год выпуска не должен содержать буквы и другие знаки", "Неккоректный ввод",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("Жанр не должен содержать 2 и больше пробелов подряд", "Неккоректный ввод",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    MessageBox.Show("Первый символ не должен быть пробелом", "Неккоректный ввод",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            Issuetextbox.Focus();
        }

        private void Counttextbox_Leave(object sender, EventArgs e)
        {
            int a = Stringcheck(Titletextbox.Text, true);
            // false - a letter can be a '-' char. True - can't be. Use true for ints, false for strings
            // 1 - there are not only numbers; there are 2 or more spaces
            // 3 - first char is a space; 0 - Only numbers 
            switch (a)
            {
                case 1:
                    MessageBox.Show("Год выпуска не должен содержать буквы и другие знаки", "Неккоректный ввод",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("Жанр не должен содержать 2 и больше пробелов подряд", "Неккоректный ввод",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    MessageBox.Show("Первый символ не должен быть пробелом", "Неккоректный ввод",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            Counttextbox.Focus();
        }
        
    }
}
