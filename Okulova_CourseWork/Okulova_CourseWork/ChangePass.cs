using Okulova_CourseWork.dbHelper;
using System;
using System.Linq;
using System.Windows.Forms;
using static Okulova_CourseWork.StringCheck;

namespace Okulova_CourseWork
{
    public partial class ChangePass : Form
    {
        private DB db = new DB();
        public ChangePass(int b)
        {
            this.b = b;
            InitializeComponent();
            Clear();
        }
        int b;

        void Clear()
        {
            PassporttextBox.Text = "";
            PasstextBox.Text = "";
            NewPasstextBox.Text = "";
            NewPassAgaintextBox.Text = "";
            Changebutton.Enabled = false;
            NewPassAgainlabel.Visible = false;
            NewPassAgaintextBox.Visible = false;
            NewPasslabel.Visible = false;
            NewPasstextBox.Visible = false;
            OKbutton.Visible = true;
        }

        private void Changebutton_Click(object sender, EventArgs e)
        {
            if (NewPasstextBox.Text.Length < 6 || NewPasstextBox.Text.Length > 20)
                MessageBox.Show("Пароль должен быть длиной от 6 до 20 символов", "Неккоректный ввод",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                if (!string.Equals(NewPasstextBox.Text, NewPassAgaintextBox.Text))
                MessageBox.Show("Введённые вами пароли не совпадают", "Неккоректный ввод",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                db.ChangePassword(b, NewPasstextBox.Text);
                MessageBox.Show("Ваш пароль успешно изменён.", "Выполнено", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                Clear();
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void PassporttextBox_Leave(object sender, EventArgs e)
        {
            if (PassporttextBox.Text.Length != 10)
            {
                MessageBox.Show("В поле должно быть ровно 10 символов", "Неккоректный ввод",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                PassporttextBox.Focus();
            }
            else
            {
                int i = Check(PassporttextBox.Text, true);
                switch (i)
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
                if (i != 0) PassporttextBox.Focus();
            }
        }

        private void Foundbutton_Click(object sender, EventArgs e)
        {
            string passport = (from s in db.GetStaffTable()
                              where s.Id == b
                              select s.Passport).FirstOrDefault();
            
            string password = (from s in db.GetStaffTable()
                              where s.Id == b
                              select s.Password).FirstOrDefault();
            
            if (!string.Equals(PassporttextBox.Text, passport))
                MessageBox.Show("Введенный вами паспорт не найден.", "Неверное значение паспорта",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (!string.Equals(PasstextBox.Text,password))
                    MessageBox.Show("Вы ввели неверный пароль", "Неверный пароль",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    OKbutton.Visible = false;
                    NewPasslabel.Visible = true;
                    NewPasstextBox.Visible = true;
                    NewPassAgainlabel.Visible = true;
                    NewPassAgaintextBox.Visible = true;
                }
            }
        }
    }
}
