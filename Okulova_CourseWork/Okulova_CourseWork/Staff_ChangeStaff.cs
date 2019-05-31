using Okulova_CourseWork.dbHelper;
using System;
using System.Windows.Forms;
using System.Linq;
using static Okulova_CourseWork.StringCheck;

namespace Okulova_CourseWork
{
    public partial class Staff_ChangeStaff : Form
    {
        private DB db = new DB();
        public Staff_ChangeStaff()
        {
            InitializeComponent();
            dataGrid.DataSource = db.GetStaffTable();
            panel2.Hide();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите очистить все поля?", "Вы уверены?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                FirstNametextbox.Text = "";
                LastNametextbox.Text = "";
                Phonetextbox.Text = "";
                Adresstextbox.Text = "";
                BirthdayPicker.Text = "";
                Passporttextbox.Text = "";
                Searchtextbox.Enabled = true;
                Searchtextbox.Text = "";
                IDtextbox.Text = "";
                IDtextbox.Enabled = true;
                dataGrid.DataSource = db.GetStaffTable();
                panel2.Hide();
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
                int a = Check(LastNametextbox.Text, false);
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
                if (a != 0 && a != -1) LastNametextbox.Focus();
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
                if (a != 0 && a != -1) FirstNametextbox.Focus();
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
                if (a != 0 && a != -1) Phonetextbox.Focus();
            }
        }

        private void Adresstextbox_Leave(object sender, EventArgs e)
        {
            if (Adresstextbox.Text.Length > 50 || Adresstextbox.Text.Length < 10)
            {
                MessageBox.Show("В поле может быть от 10 до 50 символов", "Неккоректный ввод",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                Adresstextbox.Focus();
            }
            else
            {
                int a = Check(Adresstextbox.Text, true);
                switch (a)
                {
                    case 2:
                        MessageBox.Show("Поле не должно содержать 2 и больше пробелов подряд", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 4:
                        MessageBox.Show("Первый символ не должен быть пробелом", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                if (a != 0 && a != -1) Adresstextbox.Focus();
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
                if (a != 0 && a != -1) Passporttextbox.Focus();
            }
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
                    var query = from c in db.GetStaffTable()
                                where c.Id == Convert.ToInt32(IDtextbox.Text)
                                select c.Id;
                    var a = query.FirstOrDefault();
                    if (a == 0)
                        MessageBox.Show("Введен не существующий ID.", "ID не найден", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                    {
                        panel2.Show();
                        BirthdayPicker.Value = (from c in db.GetStaffTable()
                                                where c.Id == Convert.ToInt32(IDtextbox.Text)
                                                select c.Birthday).FirstOrDefault();
                        Searchtextbox.Enabled = false;
                        IDtextbox.Enabled = false;
                        Foundbutton.Enabled = false;
                        dataGrid.DataSource = from c in db.GetStaffTable()
                                              where c.Id == Convert.ToInt32(IDtextbox.Text)
                                              select c;
                    }
                }
            }
            else
                MessageBox.Show("Заполните поле \"ID\"", "Неккоректный ввод", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Принять изменения?", "Вы уверены?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                db.ChangeStaff(Convert.ToInt32(IDtextbox.Text), FirstNametextbox.Text,
                      LastNametextbox.Text, Phonetextbox.Text, BirthdayPicker.Value, Passporttextbox.Text);
                MessageBox.Show("Изменения успешно выполнены", "Успешно.",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void Searchtextbox_TextChanged(object sender, EventArgs e)
        {
            string s = Searchtextbox.Text;
            dataGrid.DataSource = db.Search(3, s);
        }
    }
}
