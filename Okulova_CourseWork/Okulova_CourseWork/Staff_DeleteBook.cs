using Okulova_CourseWork.dbHelper;
using System;
using System.Windows.Forms;
using System.Linq;
using static Okulova_CourseWork.StringCheck;

namespace Okulova_CourseWork
{
    public partial class Staff_DeleteBook : Form
    {
        private DB db = new DB();
        public Staff_DeleteBook()
        {
            InitializeComponent();
            dataGrid.DataSource = db.GetBooksWithAuthorsTable();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(IDtextBox.Text) < 0)
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
                    var query = from c in db.GetBooksTable()                                
                                where c.Id == Convert.ToInt32(IDtextBox.Text)
                                select c.Id;
                    int res = query.FirstOrDefault();
                    if (res == 0)
                    {                        
                        MessageBox.Show("ID не найден", "", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }
                    else
                    {                        
                        if (MessageBox.Show("Вы уверены, что хотите удалить все сведения о книге?", "",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            db.DeleteBook(res);
                            MessageBox.Show("Удаление выполнено успешно", "Выполнено",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGrid.DataSource = db.GetBooksWithAuthorsTable();
                        }
                    }
                }
            }            
        }
    }
}
