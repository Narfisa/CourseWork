using Okulova_CourseWork.dbHelper;
using System;
using System.Windows.Forms;
using System.Linq;
using static Okulova_CourseWork.StringCheck;

namespace Okulova_CourseWork
{
    public partial class Staff_AddAuthor : Form
    {
        private DB db = new DB();

        public Staff_AddAuthor()
        {
            InitializeComponent();
            ToolTip lastname = new ToolTip();
            ToolTip patronymic = new ToolTip();
            lastname.SetToolTip(LastNametextbox, "Это не обязательное поле.");
            patronymic.SetToolTip(Patronymictextbox, "Это не обязательное поле.");
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
                Patronymictextbox.Text = null;
                Countrytextbox.Text = null;
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (FirstNametextbox.Text != "")
                db.AddAuthor(LastNametextbox.Text, FirstNametextbox.Text, Patronymictextbox.Text,
                    Countrytextbox.Text);
            else
                MessageBox.Show("Пожалуйста, заполните, как минимум, поле *Имя*.",
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
                if (a != 0) LastNametextbox.Focus();
            }
        }

        private void FirstNametextbox_Leave(object sender, EventArgs e)
        {
            if (FirstNametextbox.Text.Length > 15 || FirstNametextbox.Text.Length < 2)
            {
                MessageBox.Show("В поле может быть от 2 до 15 символов", "Неккоректный ввод",
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
                if (a != 0) FirstNametextbox.Focus();
            }
        }

        private void Patronymictextbox_Leave(object sender, EventArgs e)
        {
            if (Patronymictextbox.Text.Length > 15)
            {
                MessageBox.Show("В поле не может быть больше 15 символов", "Неккоректный ввод",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                Patronymictextbox.Focus();
            }
            else
            {
                int a = Check(Patronymictextbox.Text, false);
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
                if (a != 0) Patronymictextbox.Focus();
            }
        }

        private void Countrytextbox_Leave(object sender, EventArgs e)
        {
            if (Countrytextbox.Text.Length > 15 || Countrytextbox.Text.Length < 2)
            {
                MessageBox.Show("В поле может быть от 2 до 15 символов", "Неккоректный ввод",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                Countrytextbox.Focus();
            }
            else
            {
                int a = Check(Countrytextbox.Text, false);
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
                if (a != 0) Countrytextbox.Focus();
            }
        }        
    }
}
