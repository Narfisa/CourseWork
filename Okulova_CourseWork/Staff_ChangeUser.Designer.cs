namespace Okulova_CourseWork
{
    partial class Staff_ChangeUser
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.OKbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Foundbutton = new System.Windows.Forms.Button();
            this.IDlabel = new System.Windows.Forms.Label();
            this.IDtextbox = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.BirthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.Birthdaylabel = new System.Windows.Forms.Label();
            this.Adresstextbox = new System.Windows.Forms.TextBox();
            this.Phonetextbox = new System.Windows.Forms.TextBox();
            this.LastNametextbox = new System.Windows.Forms.TextBox();
            this.FirstNametextbox = new System.Windows.Forms.TextBox();
            this.Adresslabel = new System.Windows.Forms.Label();
            this.Phonelabel = new System.Windows.Forms.Label();
            this.LastNamelabel = new System.Windows.Forms.Label();
            this.FirstNamelabel = new System.Windows.Forms.Label();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BirthdayPicker);
            this.panel2.Controls.Add(this.Birthdaylabel);
            this.panel2.Controls.Add(this.Adresstextbox);
            this.panel2.Controls.Add(this.Phonetextbox);
            this.panel2.Controls.Add(this.LastNametextbox);
            this.panel2.Controls.Add(this.FirstNametextbox);
            this.panel2.Controls.Add(this.Adresslabel);
            this.panel2.Controls.Add(this.Phonelabel);
            this.panel2.Controls.Add(this.LastNamelabel);
            this.panel2.Controls.Add(this.FirstNamelabel);
            this.panel2.Controls.Add(this.Clearbutton);
            this.panel2.Controls.Add(this.OKbutton);
            this.panel2.Location = new System.Drawing.Point(3, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 387);
            this.panel2.TabIndex = 13;
            // 
            // OKbutton
            // 
            this.OKbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.OKbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.OKbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.OKbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKbutton.Location = new System.Drawing.Point(193, 341);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(97, 43);
            this.OKbutton.TabIndex = 17;
            this.OKbutton.Text = "Изменить";
            this.OKbutton.UseVisualStyleBackColor = false;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Foundbutton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.IDlabel);
            this.panel1.Controls.Add(this.IDtextbox);
            this.panel1.Location = new System.Drawing.Point(475, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 537);
            this.panel1.TabIndex = 15;
            // 
            // Foundbutton
            // 
            this.Foundbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Foundbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Foundbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Foundbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Foundbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Foundbutton.Location = new System.Drawing.Point(117, 90);
            this.Foundbutton.Name = "Foundbutton";
            this.Foundbutton.Size = new System.Drawing.Size(97, 43);
            this.Foundbutton.TabIndex = 14;
            this.Foundbutton.Text = "Найти";
            this.Foundbutton.UseVisualStyleBackColor = false;
            this.Foundbutton.Click += new System.EventHandler(this.Foundbutton_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.BackColor = System.Drawing.Color.Transparent;
            this.IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDlabel.ForeColor = System.Drawing.Color.White;
            this.IDlabel.Location = new System.Drawing.Point(39, 17);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(246, 24);
            this.IDlabel.TabIndex = 11;
            this.IDlabel.Text = "Введите ID пользователя:";
            // 
            // IDtextbox
            // 
            this.IDtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDtextbox.Location = new System.Drawing.Point(58, 44);
            this.IDtextbox.Name = "IDtextbox";
            this.IDtextbox.Size = new System.Drawing.Size(211, 23);
            this.IDtextbox.TabIndex = 12;
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(4, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(465, 537);
            this.dataGrid.TabIndex = 14;
            // 
            // BirthdayPicker
            // 
            this.BirthdayPicker.Location = new System.Drawing.Point(55, 283);
            this.BirthdayPicker.MaxDate = new System.DateTime(2019, 5, 8, 0, 0, 0, 0);
            this.BirthdayPicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.BirthdayPicker.Name = "BirthdayPicker";
            this.BirthdayPicker.Size = new System.Drawing.Size(211, 20);
            this.BirthdayPicker.TabIndex = 35;
            this.BirthdayPicker.Value = new System.DateTime(2019, 5, 8, 0, 0, 0, 0);
            // 
            // Birthdaylabel
            // 
            this.Birthdaylabel.AutoSize = true;
            this.Birthdaylabel.BackColor = System.Drawing.Color.Transparent;
            this.Birthdaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birthdaylabel.ForeColor = System.Drawing.Color.White;
            this.Birthdaylabel.Location = new System.Drawing.Point(90, 256);
            this.Birthdaylabel.Name = "Birthdaylabel";
            this.Birthdaylabel.Size = new System.Drawing.Size(160, 24);
            this.Birthdaylabel.TabIndex = 34;
            this.Birthdaylabel.Text = "Дата  рождения:";
            this.Birthdaylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Adresstextbox
            // 
            this.Adresstextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adresstextbox.Location = new System.Drawing.Point(55, 218);
            this.Adresstextbox.Name = "Adresstextbox";
            this.Adresstextbox.Size = new System.Drawing.Size(211, 23);
            this.Adresstextbox.TabIndex = 33;
            this.Adresstextbox.Leave += new System.EventHandler(this.Adresstextbox_Leave);
            // 
            // Phonetextbox
            // 
            this.Phonetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phonetextbox.Location = new System.Drawing.Point(55, 158);
            this.Phonetextbox.Name = "Phonetextbox";
            this.Phonetextbox.Size = new System.Drawing.Size(211, 23);
            this.Phonetextbox.TabIndex = 32;
            this.Phonetextbox.Leave += new System.EventHandler(this.Phonetextbox_Leave);
            // 
            // LastNametextbox
            // 
            this.LastNametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNametextbox.Location = new System.Drawing.Point(55, 93);
            this.LastNametextbox.Name = "LastNametextbox";
            this.LastNametextbox.Size = new System.Drawing.Size(211, 23);
            this.LastNametextbox.TabIndex = 31;
            this.LastNametextbox.Leave += new System.EventHandler(this.LastNametextbox_Leave);
            // 
            // FirstNametextbox
            // 
            this.FirstNametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNametextbox.Location = new System.Drawing.Point(55, 33);
            this.FirstNametextbox.Name = "FirstNametextbox";
            this.FirstNametextbox.Size = new System.Drawing.Size(211, 23);
            this.FirstNametextbox.TabIndex = 30;
            this.FirstNametextbox.Leave += new System.EventHandler(this.FirstNametextbox_Leave);
            // 
            // Adresslabel
            // 
            this.Adresslabel.AutoSize = true;
            this.Adresslabel.BackColor = System.Drawing.Color.Transparent;
            this.Adresslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adresslabel.ForeColor = System.Drawing.Color.White;
            this.Adresslabel.Location = new System.Drawing.Point(127, 191);
            this.Adresslabel.Name = "Adresslabel";
            this.Adresslabel.Size = new System.Drawing.Size(72, 24);
            this.Adresslabel.TabIndex = 29;
            this.Adresslabel.Text = "Адрес:";
            // 
            // Phonelabel
            // 
            this.Phonelabel.AutoSize = true;
            this.Phonelabel.BackColor = System.Drawing.Color.Transparent;
            this.Phonelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phonelabel.ForeColor = System.Drawing.Color.White;
            this.Phonelabel.Location = new System.Drawing.Point(120, 131);
            this.Phonelabel.Name = "Phonelabel";
            this.Phonelabel.Size = new System.Drawing.Size(95, 24);
            this.Phonelabel.TabIndex = 28;
            this.Phonelabel.Text = "Телефон:";
            // 
            // LastNamelabel
            // 
            this.LastNamelabel.AutoSize = true;
            this.LastNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.LastNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNamelabel.ForeColor = System.Drawing.Color.White;
            this.LastNamelabel.Location = new System.Drawing.Point(119, 66);
            this.LastNamelabel.Name = "LastNamelabel";
            this.LastNamelabel.Size = new System.Drawing.Size(96, 24);
            this.LastNamelabel.TabIndex = 27;
            this.LastNamelabel.Text = "Фамилия:";
            // 
            // FirstNamelabel
            // 
            this.FirstNamelabel.AutoSize = true;
            this.FirstNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.FirstNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNamelabel.ForeColor = System.Drawing.Color.White;
            this.FirstNamelabel.Location = new System.Drawing.Point(138, 6);
            this.FirstNamelabel.Name = "FirstNamelabel";
            this.FirstNamelabel.Size = new System.Drawing.Size(51, 24);
            this.FirstNamelabel.TabIndex = 26;
            this.FirstNamelabel.Text = "Имя:";
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Clearbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Clearbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clearbutton.Location = new System.Drawing.Point(40, 341);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(97, 43);
            this.Clearbutton.TabIndex = 25;
            this.Clearbutton.Text = "Очистить";
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Staff_ChangeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Staff_ChangeUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение пользователя";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Foundbutton;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox IDtextbox;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DateTimePicker BirthdayPicker;
        private System.Windows.Forms.Label Birthdaylabel;
        private System.Windows.Forms.TextBox Adresstextbox;
        private System.Windows.Forms.TextBox Phonetextbox;
        private System.Windows.Forms.TextBox LastNametextbox;
        private System.Windows.Forms.TextBox FirstNametextbox;
        private System.Windows.Forms.Label Adresslabel;
        private System.Windows.Forms.Label Phonelabel;
        private System.Windows.Forms.Label LastNamelabel;
        private System.Windows.Forms.Label FirstNamelabel;
        private System.Windows.Forms.Button Clearbutton;
    }
}