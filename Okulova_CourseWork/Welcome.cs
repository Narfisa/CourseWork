using Okulova_CourseWork.dbHelper;
using System;
using System.Windows.Forms;
using System.Threading;

namespace Okulova_CourseWork
{
    public partial class Welcome : Form
    {
        private DB db = new DB();
        public Welcome()
        {
            InitializeComponent();            
        }

        private void Userbutton_Click(object sender, EventArgs e)
        {
            User form = new User();
            Hide();
            form.ShowDialog();
            form.Dispose();
            Show();
        }

        private void Staffbutton_Click(object sender, EventArgs e)
        {
            Init frm = new Init();
            Hide();
            frm.ShowDialog();
            frm.Dispose();
            Show();
        }

        private void Init_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            Todaylabel.Text = "Сегодня " + DateTime.Now;
        }
    }
}
