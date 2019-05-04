namespace Okulova_CourseWork
{
    partial class MainStaff
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainStaff));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Showbutton = new System.Windows.Forms.Button();
            this.ShowLabel = new System.Windows.Forms.Label();
            this.ShowBox = new System.Windows.Forms.ComboBox();
            this.Searchlabel = new System.Windows.Forms.Label();
            this.Searchtextbox = new System.Windows.Forms.TextBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Addbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AddBox = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteBox = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Outbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Inbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Changecombobox = new System.Windows.Forms.ComboBox();
            this.Changebutton = new System.Windows.Forms.Button();
            this.Changelabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(6, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 460);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Showbutton);
            this.panel2.Controls.Add(this.ShowLabel);
            this.panel2.Controls.Add(this.ShowBox);
            this.panel2.Location = new System.Drawing.Point(6, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 160);
            this.panel2.TabIndex = 25;
            // 
            // Showbutton
            // 
            this.Showbutton.BackColor = System.Drawing.Color.Transparent;
            this.Showbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Showbutton.BackgroundImage")));
            this.Showbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Showbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Showbutton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Showbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Showbutton.Location = new System.Drawing.Point(2, 5);
            this.Showbutton.Name = "Showbutton";
            this.Showbutton.Size = new System.Drawing.Size(120, 90);
            this.Showbutton.TabIndex = 27;
            this.Showbutton.UseVisualStyleBackColor = false;
            this.Showbutton.Click += new System.EventHandler(this.Showbutton_Click);
            // 
            // ShowLabel
            // 
            this.ShowLabel.AutoSize = true;
            this.ShowLabel.BackColor = System.Drawing.Color.Transparent;
            this.ShowLabel.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.ShowLabel.Location = new System.Drawing.Point(2, 100);
            this.ShowLabel.Name = "ShowLabel";
            this.ShowLabel.Size = new System.Drawing.Size(120, 24);
            this.ShowLabel.TabIndex = 26;
            this.ShowLabel.Text = "Отобразить";
            // 
            // ShowBox
            // 
            this.ShowBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShowBox.FormattingEnabled = true;
            this.ShowBox.Items.AddRange(new object[] {
            "Книги",
            "Авторы",
            "Пользователи",
            "Сотрудники"});
            this.ShowBox.Location = new System.Drawing.Point(3, 136);
            this.ShowBox.Name = "ShowBox";
            this.ShowBox.Size = new System.Drawing.Size(120, 21);
            this.ShowBox.TabIndex = 1;
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.BackColor = System.Drawing.Color.Transparent;
            this.Searchlabel.Font = new System.Drawing.Font("Lucida Fax", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlabel.Location = new System.Drawing.Point(15, 181);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(63, 25);
            this.Searchlabel.TabIndex = 21;
            this.Searchlabel.Text = "Поиск";
            // 
            // Searchtextbox
            // 
            this.Searchtextbox.BackColor = System.Drawing.Color.White;
            this.Searchtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Searchtextbox.Location = new System.Drawing.Point(84, 183);
            this.Searchtextbox.Name = "Searchtextbox";
            this.Searchtextbox.Size = new System.Drawing.Size(401, 23);
            this.Searchtextbox.TabIndex = 20;
            // 
            // DataGrid
            // 
            this.DataGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.GridColor = System.Drawing.Color.Silver;
            this.DataGrid.Location = new System.Drawing.Point(16, 213);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(849, 450);
            this.DataGrid.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.Addbutton);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.AddBox);
            this.panel3.Location = new System.Drawing.Point(154, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(126, 160);
            this.panel3.TabIndex = 27;
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.Transparent;
            this.Addbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Addbutton.BackgroundImage")));
            this.Addbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Addbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Addbutton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbutton.ForeColor = System.Drawing.Color.Transparent;
            this.Addbutton.Location = new System.Drawing.Point(3, 5);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(120, 90);
            this.Addbutton.TabIndex = 28;
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(14, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Добавить";
            // 
            // AddBox
            // 
            this.AddBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddBox.FormattingEnabled = true;
            this.AddBox.Items.AddRange(new object[] {
            "Книги",
            "Авторы",
            "Пользователи",
            "Сотрудники"});
            this.AddBox.Location = new System.Drawing.Point(3, 136);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(120, 21);
            this.AddBox.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.Deletebutton);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.DeleteBox);
            this.panel4.Location = new System.Drawing.Point(303, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(126, 160);
            this.panel4.TabIndex = 28;
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.Transparent;
            this.Deletebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Deletebutton.BackgroundImage")));
            this.Deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Deletebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Deletebutton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton.Location = new System.Drawing.Point(3, 5);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(120, 90);
            this.Deletebutton.TabIndex = 29;
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(20, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Удалить";
            // 
            // DeleteBox
            // 
            this.DeleteBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeleteBox.FormattingEnabled = true;
            this.DeleteBox.Items.AddRange(new object[] {
            "Книги",
            "Авторы",
            "Пользователи",
            "Сотрудники"});
            this.DeleteBox.Location = new System.Drawing.Point(3, 136);
            this.DeleteBox.Name = "DeleteBox";
            this.DeleteBox.Size = new System.Drawing.Size(120, 21);
            this.DeleteBox.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.Outbutton);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(601, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(126, 160);
            this.panel5.TabIndex = 29;
            // 
            // Outbutton
            // 
            this.Outbutton.BackColor = System.Drawing.Color.Transparent;
            this.Outbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Outbutton.BackgroundImage")));
            this.Outbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Outbutton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Outbutton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Outbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Outbutton.Location = new System.Drawing.Point(3, 5);
            this.Outbutton.Name = "Outbutton";
            this.Outbutton.Size = new System.Drawing.Size(120, 90);
            this.Outbutton.TabIndex = 30;
            this.Outbutton.UseVisualStyleBackColor = false;
            this.Outbutton.Click += new System.EventHandler(this.Outbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label6.Location = new System.Drawing.Point(1, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "Выдача книг";
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackColor = System.Drawing.Color.Transparent;
            this.Searchbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Searchbutton.BackgroundImage")));
            this.Searchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Searchbutton.FlatAppearance.BorderSize = 0;
            this.Searchbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbutton.Location = new System.Drawing.Point(491, 183);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(26, 25);
            this.Searchbutton.TabIndex = 30;
            this.Searchbutton.UseVisualStyleBackColor = false;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.Inbutton);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(750, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(126, 160);
            this.panel6.TabIndex = 30;
            // 
            // Inbutton
            // 
            this.Inbutton.BackColor = System.Drawing.Color.Transparent;
            this.Inbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Inbutton.BackgroundImage")));
            this.Inbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Inbutton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Inbutton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Inbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inbutton.Location = new System.Drawing.Point(3, 5);
            this.Inbutton.Name = "Inbutton";
            this.Inbutton.Size = new System.Drawing.Size(120, 90);
            this.Inbutton.TabIndex = 31;
            this.Inbutton.UseVisualStyleBackColor = false;
            this.Inbutton.Click += new System.EventHandler(this.Inbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(5, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Приём книг";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.Changecombobox);
            this.panel7.Controls.Add(this.Changebutton);
            this.panel7.Controls.Add(this.Changelabel);
            this.panel7.Location = new System.Drawing.Point(452, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(126, 160);
            this.panel7.TabIndex = 31;
            // 
            // Changecombobox
            // 
            this.Changecombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Changecombobox.FormattingEnabled = true;
            this.Changecombobox.Items.AddRange(new object[] {
            "Книги",
            "Авторы",
            "Пользователи",
            "Сотрудники"});
            this.Changecombobox.Location = new System.Drawing.Point(3, 136);
            this.Changecombobox.Name = "Changecombobox";
            this.Changecombobox.Size = new System.Drawing.Size(120, 21);
            this.Changecombobox.TabIndex = 30;
            // 
            // Changebutton
            // 
            this.Changebutton.BackColor = System.Drawing.Color.Transparent;
            this.Changebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Changebutton.BackgroundImage")));
            this.Changebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Changebutton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Changebutton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Changebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Changebutton.Location = new System.Drawing.Point(3, 5);
            this.Changebutton.Name = "Changebutton";
            this.Changebutton.Size = new System.Drawing.Size(120, 90);
            this.Changebutton.TabIndex = 30;
            this.Changebutton.UseVisualStyleBackColor = false;
            this.Changebutton.Click += new System.EventHandler(this.Changebutton_Click);
            // 
            // Changelabel
            // 
            this.Changelabel.AutoSize = true;
            this.Changelabel.BackColor = System.Drawing.Color.Transparent;
            this.Changelabel.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Changelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Changelabel.Location = new System.Drawing.Point(7, 100);
            this.Changelabel.Name = "Changelabel";
            this.Changelabel.Size = new System.Drawing.Size(112, 24);
            this.Changelabel.TabIndex = 26;
            this.Changelabel.Text = "Изменение";
            // 
            // MainStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 681);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Searchlabel);
            this.Controls.Add(this.Searchtextbox);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainStaff";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ShowLabel;
        private System.Windows.Forms.ComboBox ShowBox;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.TextBox Searchtextbox;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AddBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DeleteBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Showbutton;
        private System.Windows.Forms.Button Outbutton;
        private System.Windows.Forms.Button Inbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox Changecombobox;
        private System.Windows.Forms.Button Changebutton;
        private System.Windows.Forms.Label Changelabel;
    }
}

