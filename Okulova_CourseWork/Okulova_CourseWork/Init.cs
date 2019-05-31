using Okulova_CourseWork.dbHelper;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Okulova_CourseWork
{
    public partial class Init : Form
    {
        private DB db = new DB();
        public Init()
        {
            InitializeComponent();
            ToolTip Passport = new ToolTip();
            Passport.SetToolTip(PassporttextBox, "Введите серию и номер паспорта БЕЗ пробелов и других знаков.");
            ToolTip Password = new ToolTip();
            Password.SetToolTip(PasswordtextBox, "Пароль по умолчанию - серия и номер паспорта без пробелов.");
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            PasswordtextBox.Text = "";
            PassporttextBox.Text = "";
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {            
            string Passport = PassporttextBox.Text;
            string Password = PasswordtextBox.Text;
            int LoginResult = db.Login(Passport, Password);
            // 0 - This worker has default password - message about changing the pass
            // 1 - All is right
            // -1 - wrong passport or password
            if (LoginResult == -1)
                MessageBox.Show("Неверный паспорт или пароль", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
            {
                if (LoginResult == 0)
                    MessageBox.Show("У вас установлен пароль по умолчанию\nЖелательно изменить его во вкладе 'Изменение'",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int idStaff = db.GetIdStaff(Passport, Password);
                MainStaff mainStaff = new MainStaff(idStaff);
                Hide();
                mainStaff.ShowDialog();
                mainStaff.Dispose();
            }        
        }

        private void PassporttextBox_Leave(object sender, EventArgs e)
        {
            char[] str = PassporttextBox.Text.ToCharArray();
            int i;
            if (str.Length > 10 || str.Length < 10)
            {
                MessageBox.Show("В серии и номере паспорта должно быть 10 цифр", "Неккоректный ввод",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                PassporttextBox.Focus();
            }
            else
            {
                for (i = 0; i < str.Length; ++i)
                    if (!char.IsNumber(str[i]))
                    {
                        MessageBox.Show("В серии и номере паспорта должны быть только цифры.\nБез пробелов и других знаков.",
                            "Неккоректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                        PassporttextBox.Focus();
                        break;
                    }
            }            
        }

        private void PasswordtextBox_Leave(object sender, EventArgs e)
        {
            char[] str = PasswordtextBox.Text.ToCharArray();
            if (str.Length < 6 || str.Length > 20)
                MessageBox.Show("Пароль должен быть длиной от 6 до 20 символов", "Неккоректный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
