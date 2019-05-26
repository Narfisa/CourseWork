namespace Okulova_CourseWork
{
    partial class Staff_AddStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_AddStaff));
            this.BirthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.Birthdaylabel = new System.Windows.Forms.Label();
            this.Phonetextbox = new System.Windows.Forms.TextBox();
            this.LastNametextbox = new System.Windows.Forms.TextBox();
            this.FirstNametextbox = new System.Windows.Forms.TextBox();
            this.Phonelabel = new System.Windows.Forms.Label();
            this.LastNamelabel = new System.Windows.Forms.Label();
            this.FirstNamelabel = new System.Windows.Forms.Label();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Passporttextbox = new System.Windows.Forms.TextBox();
            this.Passportlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BirthdayPicker
            // 
            this.BirthdayPicker.Location = new System.Drawing.Point(202, 287);
            this.BirthdayPicker.MaxDate = new System.DateTime(2019, 5, 8, 0, 0, 0, 0);
            this.BirthdayPicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.BirthdayPicker.Name = "BirthdayPicker";
            this.BirthdayPicker.Size = new System.Drawing.Size(211, 20);
            this.BirthdayPicker.TabIndex = 37;
            this.BirthdayPicker.Value = new System.DateTime(2019, 5, 8, 0, 0, 0, 0);
            // 
            // Birthdaylabel
            // 
            this.Birthdaylabel.AutoSize = true;
            this.Birthdaylabel.BackColor = System.Drawing.Color.Transparent;
            this.Birthdaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birthdaylabel.ForeColor = System.Drawing.Color.White;
            this.Birthdaylabel.Location = new System.Drawing.Point(57, 273);
            this.Birthdaylabel.Name = "Birthdaylabel";
            this.Birthdaylabel.Size = new System.Drawing.Size(106, 48);
            this.Birthdaylabel.TabIndex = 36;
            this.Birthdaylabel.Text = "Дата \r\nрождения:";
            this.Birthdaylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Phonetextbox
            // 
            this.Phonetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phonetextbox.Location = new System.Drawing.Point(202, 152);
            this.Phonetextbox.Name = "Phonetextbox";
            this.Phonetextbox.Size = new System.Drawing.Size(211, 23);
            this.Phonetextbox.TabIndex = 34;
            this.Phonetextbox.Leave += new System.EventHandler(this.Phonetextbox_Leave);
            // 
            // LastNametextbox
            // 
            this.LastNametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNametextbox.Location = new System.Drawing.Point(202, 86);
            this.LastNametextbox.Name = "LastNametextbox";
            this.LastNametextbox.Size = new System.Drawing.Size(211, 23);
            this.LastNametextbox.TabIndex = 33;
            this.LastNametextbox.Leave += new System.EventHandler(this.LastNametextbox_Leave);
            // 
            // FirstNametextbox
            // 
            this.FirstNametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNametextbox.Location = new System.Drawing.Point(202, 25);
            this.FirstNametextbox.Name = "FirstNametextbox";
            this.FirstNametextbox.Size = new System.Drawing.Size(211, 23);
            this.FirstNametextbox.TabIndex = 32;
            this.FirstNametextbox.Leave += new System.EventHandler(this.FirstNametextbox_Leave);
            // 
            // Phonelabel
            // 
            this.Phonelabel.AutoSize = true;
            this.Phonelabel.BackColor = System.Drawing.Color.Transparent;
            this.Phonelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phonelabel.ForeColor = System.Drawing.Color.White;
            this.Phonelabel.Location = new System.Drawing.Point(68, 149);
            this.Phonelabel.Name = "Phonelabel";
            this.Phonelabel.Size = new System.Drawing.Size(95, 24);
            this.Phonelabel.TabIndex = 30;
            this.Phonelabel.Text = "Телефон:";
            // 
            // LastNamelabel
            // 
            this.LastNamelabel.AutoSize = true;
            this.LastNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.LastNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNamelabel.ForeColor = System.Drawing.Color.White;
            this.LastNamelabel.Location = new System.Drawing.Point(68, 83);
            this.LastNamelabel.Name = "LastNamelabel";
            this.LastNamelabel.Size = new System.Drawing.Size(91, 24);
            this.LastNamelabel.TabIndex = 29;
            this.LastNamelabel.Text = "Фамилия";
            // 
            // FirstNamelabel
            // 
            this.FirstNamelabel.AutoSize = true;
            this.FirstNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.FirstNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNamelabel.ForeColor = System.Drawing.Color.White;
            this.FirstNamelabel.Location = new System.Drawing.Point(108, 22);
            this.FirstNamelabel.Name = "FirstNamelabel";
            this.FirstNamelabel.Size = new System.Drawing.Size(51, 24);
            this.FirstNamelabel.TabIndex = 28;
            this.FirstNamelabel.Text = "Имя:";
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Cancelbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Cancelbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancelbutton.Location = new System.Drawing.Point(349, 429);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(97, 43);
            this.Cancelbutton.TabIndex = 27;
            this.Cancelbutton.Text = "Отмена";
            this.Cancelbutton.UseVisualStyleBackColor = false;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Clearbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Clearbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clearbutton.Location = new System.Drawing.Point(195, 429);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(97, 43);
            this.Clearbutton.TabIndex = 26;
            this.Clearbutton.Text = "Очистить";
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Addbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Addbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addbutton.Location = new System.Drawing.Point(38, 429);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(97, 43);
            this.Addbutton.TabIndex = 25;
            this.Addbutton.Text = "Добавить";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Passporttextbox
            // 
            this.Passporttextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passporttextbox.Location = new System.Drawing.Point(202, 220);
            this.Passporttextbox.Name = "Passporttextbox";
            this.Passporttextbox.Size = new System.Drawing.Size(211, 23);
            this.Passporttextbox.TabIndex = 39;
            this.Passporttextbox.Leave += new System.EventHandler(this.Passporttextbox_Leave);
            // 
            // Passportlabel
            // 
            this.Passportlabel.AutoSize = true;
            this.Passportlabel.BackColor = System.Drawing.Color.Transparent;
            this.Passportlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passportlabel.ForeColor = System.Drawing.Color.White;
            this.Passportlabel.Location = new System.Drawing.Point(72, 219);
            this.Passportlabel.Name = "Passportlabel";
            this.Passportlabel.Size = new System.Drawing.Size(91, 24);
            this.Passportlabel.TabIndex = 38;
            this.Passportlabel.Text = "Паспорт:";
            // 
            // Staff_AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 491);
            this.Controls.Add(this.Passporttextbox);
            this.Controls.Add(this.Passportlabel);
            this.Controls.Add(this.BirthdayPicker);
            this.Controls.Add(this.Birthdaylabel);
            this.Controls.Add(this.Phonetextbox);
            this.Controls.Add(this.LastNametextbox);
            this.Controls.Add(this.FirstNametextbox);
            this.Controls.Add(this.Phonelabel);
            this.Controls.Add(this.LastNamelabel);
            this.Controls.Add(this.FirstNamelabel);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Addbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Staff_AddStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker BirthdayPicker;
        private System.Windows.Forms.Label Birthdaylabel;
        private System.Windows.Forms.TextBox Phonetextbox;
        private System.Windows.Forms.TextBox LastNametextbox;
        private System.Windows.Forms.TextBox FirstNametextbox;
        private System.Windows.Forms.Label Phonelabel;
        private System.Windows.Forms.Label LastNamelabel;
        private System.Windows.Forms.Label FirstNamelabel;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.TextBox Passporttextbox;
        private System.Windows.Forms.Label Passportlabel;
    }
}