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
            this.Inlabel = new System.Windows.Forms.Label();
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
            // Inlabel
            // 
            this.Inlabel.AutoSize = true;
            this.Inlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Inlabel.ForeColor = System.Drawing.Color.Black;
            this.Inlabel.Location = new System.Drawing.Point(12, 201);
            this.Inlabel.Name = "Inlabel";
            this.Inlabel.Size = new System.Drawing.Size(541, 40);
            this.Inlabel.TabIndex = 1;
            this.Inlabel.Text = "2. Если вы хотите осуществить поиск по выбранной таблице, укажите\r\nстолбец, по ко" +
    "торому будет производиться поиск в списке \'В\'";
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Searchlabel.ForeColor = System.Drawing.Color.Black;
            this.Searchlabel.Location = new System.Drawing.Point(12, 276);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(537, 80);
            this.Searchlabel.TabIndex = 2;
            this.Searchlabel.Text = "3. После этого, вы можете воспользоваться строкой поиска. \r\nТак, если вы осуществ" +
    "ляете поиск по столбцу \'Название\' \r\nи ищите книгу \"Война и мир\", то целесообразн" +
    "о будет вводить \"Вой\",\r\n\"Война\" и т.п.";
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
            this.Viewlabel.Location = new System.Drawing.Point(12, 390);
            this.Viewlabel.Name = "Viewlabel";
            this.Viewlabel.Size = new System.Drawing.Size(542, 60);
            this.Viewlabel.TabIndex = 4;
            this.Viewlabel.Text = "4. Для вывода информации о своем читательском билете,\r\nвведите ваш ID(если не зна" +
    "ете - спросите у Сотрудника библиотеки.)\r\nи нажмите на кнопку OK.";
            // 
            // HelpUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.Viewlabel);
            this.Controls.Add(this.Infolabel);
            this.Controls.Add(this.Searchlabel);
            this.Controls.Add(this.Inlabel);
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
        private System.Windows.Forms.Label Inlabel;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.Label Infolabel;
        private System.Windows.Forms.Label Viewlabel;
    }
}