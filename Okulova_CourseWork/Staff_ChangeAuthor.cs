using Okulova_CourseWork.dbHelper;
using System;
using System.Windows.Forms;
using System.Linq;

namespace Okulova_CourseWork
{
    public partial class Staff_ChangeAuthor : Form
    {
        private DB db = new DB();
        public Staff_ChangeAuthor()
        {
            InitializeComponent();
            dataGrid.DataSource = db.GetAuthorsTable();
            panel2.Hide();
        }

        public int Stringcheck(string s)
        {
            if (s == "")
                return -1;
            char[] str = s.ToCharArray();
            int i;
            for (i = 0; i < str.Length; ++i)
            {
                if (char.IsNumber(str[i]))
                    return 1;
                if (!char.IsLetter(str[i]) && str[i] != '-' && !char.IsWhiteSpace(str[i]))
                    return 2;
                if (i > 0 && char.IsWhiteSpace(str[i - 1]) && char.IsWhiteSpace(str[i]))
                    return 3;
                if (char.IsWhiteSpace(str[0]))
                    return 4;
            }
            return 0;
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
                int a = Stringcheck(LastNametextbox.Text);
                switch (a)
                {
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
                if (a != 0 && a != -1) LastNametextbox.Focus();
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
                int a = Stringcheck(FirstNametextbox.Text);
                switch (a)
                {
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
                if (a != 0 && a != -1) FirstNametextbox.Focus();
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
                int a = Stringcheck(Patronymictextbox.Text);
                switch (a)
                {
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
                if (a != 0 && a != -1) Patronymictextbox.Focus();
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
                int a = Stringcheck(Countrytextbox.Text);
                switch (a)
                {
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
                if (a != 0 && a != -1) Countrytextbox.Focus();
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Принять изменения?", "Вы уверены?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                db.ChangeAuthor(Convert.ToInt32(IDtextbox.Text), LastNametextbox.Text,
                    FirstNametextbox.Text, Patronymictextbox.Text, Countrytextbox.Text);
        }

        private void Foundbutton_Click(object sender, EventArgs e)
        {
            if (IDtextbox.Text != "")
            {
                int x = -1;
                try
                {
                    x = Convert.ToInt32(IDtextbox.Text);
                }
                catch
                {
                    MessageBox.Show("ID должен состоять только из цифр", "Неккоректный ввод", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    IDtextbox.Focus();
                }
                if (x <= 0)
                {
                    MessageBox.Show("ID не может быть отрицательным или равным нулю.", "Неккоректный ввод", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    IDtextbox.Focus();
                }
                else
                {
                    var query = from c in db.GetAuthorsTable()
                                where c.Id == x
                                select c.Id;
                    var a = query.FirstOrDefault();
                    if (a == 0)
                        MessageBox.Show("Введен не существующий ID.", "ID не найден", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else   panel2.Show();
                }
            }
            else
                MessageBox.Show("Заполните поле \"ID\"", "Неккоректный ввод", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        }
    }
}
