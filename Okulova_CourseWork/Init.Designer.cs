namespace Okulova_CourseWork
{
    partial class Init
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
            this.Infolabel = new System.Windows.Forms.Label();
            this.Passportlabel = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.PassporttextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Infolabel
            // 
            this.Infolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Infolabel.ForeColor = System.Drawing.Color.Black;
            this.Infolabel.Location = new System.Drawing.Point(136, 9);
            this.Infolabel.Name = "Infolabel";
            this.Infolabel.Size = new System.Drawing.Size(186, 83);
            this.Infolabel.TabIndex = 0;
            this.Infolabel.Text = "Введите, пожалуйста, ваши данные:";
            this.Infolabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Passportlabel
            // 
            this.Passportlabel.AutoSize = true;
            this.Passportlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passportlabel.ForeColor = System.Drawing.Color.Black;
            this.Passportlabel.Location = new System.Drawing.Point(12, 122);
            this.Passportlabel.Name = "Passportlabel";
            this.Passportlabel.Size = new System.Drawing.Size(138, 20);
            this.Passportlabel.TabIndex = 1;
            this.Passportlabel.Text = "Номер паспорта:";
            this.Passportlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passwordlabel.ForeColor = System.Drawing.Color.Black;
            this.Passwordlabel.Location = new System.Drawing.Point(79, 181);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(71, 20);
            this.Passwordlabel.TabIndex = 2;
            this.Passwordlabel.Text = "Пароль:";
            this.Passwordlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassporttextBox
            // 
            this.PassporttextBox.Location = new System.Drawing.Point(204, 122);
            this.PassporttextBox.Name = "PassporttextBox";
            this.PassporttextBox.Size = new System.Drawing.Size(178, 20);
            this.PassporttextBox.TabIndex = 3;
            this.PassporttextBox.WordWrap = false;
            this.PassporttextBox.Leave += new System.EventHandler(this.PassporttextBox_Leave);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(204, 183);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(178, 20);
            this.PasswordtextBox.TabIndex = 4;
            this.PasswordtextBox.UseSystemPasswordChar = true;
            this.PasswordtextBox.WordWrap = false;
            this.PasswordtextBox.Leave += new System.EventHandler(this.PasswordtextBox_Leave);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clearbutton.Location = new System.Drawing.Point(36, 253);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(90, 34);
            this.Clearbutton.TabIndex = 5;
            this.Clearbutton.Text = "Очистить";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKbutton.Location = new System.Drawing.Point(180, 253);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(90, 34);
            this.OKbutton.TabIndex = 6;
            this.OKbutton.Text = "ОК";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancelbutton.Location = new System.Drawing.Point(330, 253);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(90, 34);
            this.Cancelbutton.TabIndex = 7;
            this.Cancelbutton.Text = "Отмена";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(456, 299);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.PassporttextBox);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.Passportlabel);
            this.Controls.Add(this.Infolabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Init";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аутентификация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Infolabel;
        private System.Windows.Forms.Label Passportlabel;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.TextBox PassporttextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button Cancelbutton;
    }
}