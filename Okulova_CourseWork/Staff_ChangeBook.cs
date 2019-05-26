using Okulova_CourseWork.dbHelper;
using System;
using System.Windows.Forms;
using System.Linq;

namespace Okulova_CourseWork
{ 
    public partial class Staff_ChangeBook : Form
    {
        private DB db = new DB();
        public Staff_ChangeBook()
        {
            InitializeComponent();
            panel2.Hide();
            dataGrid.DataSource = db.GetBooksWithAuthorsTable();
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
                    var query = from c in db.GetBooksTable()
                                join Author_Book in db.GetAuthor_BooksTable()
                                on c.Id equals Author_Book.IdBooks
                                join Author in db.GetAuthorsTable()
                                on Author_Book.IdAuthors equals Author.Id
                                where c.Id == x
                                select c.Id;
                    var a = query.FirstOrDefault();
                    if (a == 0)
                        MessageBox.Show("Введен не существующий ID.", "ID не найден", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else panel2.Show();
                }
            }
            else
                MessageBox.Show("Заполните поле \"ID\"", "Неккоректный ввод", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);            
        }

        public int Stringcheck(string s, bool key)
        {
            if (s == "")
                return -1;
            char[] str = s.ToCharArray();
            int i;
            if (!key)
            {
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
                int a = Stringcheck(Titletextbox.Text, false);
                // false - a letter can be a '-' char. True - can't be. Use true for ints, false for strings
                // 1 - there is a number; 2 - there are not only letters
                // 3 - there are 2 or more spaces; 4 - first char is a space; 0 - Only letters 
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
                if (a != 0 && a != -1) Titletextbox.Focus();
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
                int a = Stringcheck(Genretextbox.Text, false);
                // false - a letter can be a '-' char. True - can't be. Use true for ints, false for strings
                // 1 - there is a number; 2 - there are not only letters
                // 3 - there are 2 or more spaces; 4 - first char is a space; 0 - Only letters 
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
                if (a != 0 && a != -1) Genretextbox.Focus();
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
                int a = Stringcheck(Issuetextbox.Text, true);
                // false - a letter can be a '-' char. True - can't be. Use true for ints, false for strings
                // 1 - there are not only numbers; there are 2 or more spaces
                // 3 - first char is a space; 0 - Only numbers 
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
                if (a != 0 && a != -1)
                    Issuetextbox.Focus();
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
                int a = Stringcheck(Counttextbox.Text, true);
                // false - a letter can be a '-' char. True - can't be. Use true for ints, false for strings
                // 1 - there are not only numbers; there are 2 or more spaces
                // 3 - first char is a space; 0 - Only numbers 
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
                if (a != 0 && a != -1) Counttextbox.Focus();
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
                            MessageBox.Show("Вы добавляете книгу с количеством 0? Чет падазрительна =_=",
                            "Возможный неккорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Counttextbox.Focus();
                    }
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

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Принять изменения?", "Вы уверены?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                db.Changebook(Convert.ToInt32(IDtextbox.Text), Titletextbox.Text,
                    Genretextbox.Text, Convert.ToInt32(Issuetextbox.Text),
                    Convert.ToInt32(Counttextbox.Text));
        }
    }
}
