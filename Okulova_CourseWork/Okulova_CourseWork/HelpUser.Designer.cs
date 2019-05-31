namespace Okulova_CourseWork
{
    partial class HelpUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpUser));
            this.Tablelabel = new System.Windows.Forms.Label();
            this.Searchlabel = new System.Windows.Forms.Label();
            this.Infolabel = new System.Windows.Forms.Label();
            this.Viewlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tablelabel
            // 
            this.Tablelabel.AutoSize = true;
            this.Tablelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tablelabel.ForeColor = System.Drawing.Color.Black;
            this.Tablelabel.Location = new System.Drawing.Point(12, 141);
            this.Tablelabel.Name = "Tablelabel";
            this.Tablelabel.Size = new System.Drawing.Size(556, 20);
            this.Tablelabel.TabIndex = 0;
            this.Tablelabel.Text = "1. В списке \'таблицы\' выберите таблицу, которую вы хотите отобразить";
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Searchlabel.ForeColor = System.Drawing.Color.Black;
            this.Searchlabel.Location = new System.Drawing.Point(12, 209);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(571, 60);
            this.Searchlabel.TabIndex = 2;
            this.Searchlabel.Text = "2. Вы так же можете воспользоваться поисковой строкой для \r\nоблегчения поиска дан" +
    "ных. Просто сначала выберите таблицу\r\nв меню справа,а затем вводите нужные вам з" +
    "начения в поисковую строку";
            // 
            // Infolabel
            // 
            this.Infolabel.AutoSize = true;
            this.Infolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Infolabel.ForeColor = System.Drawing.Color.White;
            this.Infolabel.Location = new System.Drawing.Point(12, 9);
            this.Infolabel.Name = "Infolabel";
            this.Infolabel.Size = new System.Drawing.Size(561, 100);
            this.Infolabel.TabIndex = 3;
            this.Infolabel.Text = resources.GetString("Infolabel.Text");
            this.Infolabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Viewlabel
            // 
            this.Viewlabel.AutoSize = true;
            this.Viewlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Viewlabel.ForeColor = System.Drawing.Color.Black;
            this.Viewlabel.Location = new System.Drawing.Point(12, 320);
            this.Viewlabel.Name = "Viewlabel";
            this.Viewlabel.Size = new System.Drawing.Size(542, 60);
            this.Viewlabel.TabIndex = 4;
            this.Viewlabel.Text = "3. Для вывода информации о своем читательском билете,\r\nвведите ваш ID(если не зна" +
    "ете - спросите у Сотрудника библиотеки.)\r\nи нажмите на кнопку OK.";
            // 
            // HelpUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 394);
            this.Controls.Add(this.Viewlabel);
            this.Controls.Add(this.Infolabel);
            this.Controls.Add(this.Searchlabel);
            this.Controls.Add(this.Tablelabel);
            this.MaximizeBox = false;
            this.Name = "HelpUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tablelabel;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.Label Infolabel;
        private System.Windows.Forms.Label Viewlabel;
    }
}