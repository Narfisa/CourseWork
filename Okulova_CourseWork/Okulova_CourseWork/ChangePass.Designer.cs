namespace Okulova_CourseWork
{
    partial class ChangePass
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
            this.Passportlabel = new System.Windows.Forms.Label();
            this.PassporttextBox = new System.Windows.Forms.TextBox();
            this.PasstextBox = new System.Windows.Forms.TextBox();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.NewPasstextBox = new System.Windows.Forms.TextBox();
            this.NewPasslabel = new System.Windows.Forms.Label();
            this.NewPassAgaintextBox = new System.Windows.Forms.TextBox();
            this.NewPassAgainlabel = new System.Windows.Forms.Label();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Changebutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Passportlabel
            // 
            this.Passportlabel.AutoSize = true;
            this.Passportlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passportlabel.Location = new System.Drawing.Point(30, 35);
            this.Passportlabel.Name = "Passportlabel";
            this.Passportlabel.Size = new System.Drawing.Size(172, 24);
            this.Passportlabel.TabIndex = 0;
            this.Passportlabel.Text = "Введите паспорт:";
            // 
            // PassporttextBox
            // 
            this.PassporttextBox.Location = new System.Drawing.Point(208, 39);
            this.PassporttextBox.Name = "PassporttextBox";
            this.PassporttextBox.Size = new System.Drawing.Size(243, 20);
            this.PassporttextBox.TabIndex = 1;
            this.PassporttextBox.Leave += new System.EventHandler(this.PassporttextBox_Leave);
            // 
            // PasstextBox
            // 
            this.PasstextBox.Location = new System.Drawing.Point(210, 117);
            this.PasstextBox.Name = "PasstextBox";
            this.PasstextBox.Size = new System.Drawing.Size(243, 20);
            this.PasstextBox.TabIndex = 3;
            this.PasstextBox.UseSystemPasswordChar = true;
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passwordlabel.Location = new System.Drawing.Point(32, 113);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(162, 24);
            this.Passwordlabel.TabIndex = 2;
            this.Passwordlabel.Text = "Введите пароль:";
            // 
            // NewPasstextBox
            // 
            this.NewPasstextBox.Location = new System.Drawing.Point(210, 199);
            this.NewPasstextBox.Name = "NewPasstextBox";
            this.NewPasstextBox.Size = new System.Drawing.Size(243, 20);
            this.NewPasstextBox.TabIndex = 5;
            this.NewPasstextBox.UseSystemPasswordChar = true;
            // 
            // NewPasslabel
            // 
            this.NewPasslabel.AutoSize = true;
            this.NewPasslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPasslabel.Location = new System.Drawing.Point(51, 195);
            this.NewPasslabel.Name = "NewPasslabel";
            this.NewPasslabel.Size = new System.Drawing.Size(143, 24);
            this.NewPasslabel.TabIndex = 4;
            this.NewPasslabel.Text = "Новый пароль:";
            // 
            // NewPassAgaintextBox
            // 
            this.NewPassAgaintextBox.Location = new System.Drawing.Point(210, 280);
            this.NewPassAgaintextBox.Name = "NewPassAgaintextBox";
            this.NewPassAgaintextBox.Size = new System.Drawing.Size(243, 20);
            this.NewPassAgaintextBox.TabIndex = 7;
            this.NewPassAgaintextBox.UseSystemPasswordChar = true;
            // 
            // NewPassAgainlabel
            // 
            this.NewPassAgainlabel.AutoSize = true;
            this.NewPassAgainlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPassAgainlabel.Location = new System.Drawing.Point(86, 276);
            this.NewPassAgainlabel.Name = "NewPassAgainlabel";
            this.NewPassAgainlabel.Size = new System.Drawing.Size(108, 24);
            this.NewPassAgainlabel.TabIndex = 6;
            this.NewPassAgainlabel.Text = "Еще разок:";
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Clearbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Clearbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clearbutton.Location = new System.Drawing.Point(272, 359);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(97, 43);
            this.Clearbutton.TabIndex = 9;
            this.Clearbutton.Text = "Очистить";
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Changebutton
            // 
            this.Changebutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Changebutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Changebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Changebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Changebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Changebutton.Location = new System.Drawing.Point(115, 359);
            this.Changebutton.Name = "Changebutton";
            this.Changebutton.Size = new System.Drawing.Size(97, 43);
            this.Changebutton.TabIndex = 8;
            this.Changebutton.Text = "Изменить";
            this.Changebutton.UseVisualStyleBackColor = false;
            this.Changebutton.Click += new System.EventHandler(this.Changebutton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.OKbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.OKbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.OKbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKbutton.Location = new System.Drawing.Point(200, 195);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(97, 43);
            this.OKbutton.TabIndex = 10;
            this.OKbutton.Text = "ОК";
            this.OKbutton.UseVisualStyleBackColor = false;
            this.OKbutton.Click += new System.EventHandler(this.Foundbutton_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Changebutton);
            this.Controls.Add(this.NewPassAgaintextBox);
            this.Controls.Add(this.NewPassAgainlabel);
            this.Controls.Add(this.NewPasstextBox);
            this.Controls.Add(this.NewPasslabel);
            this.Controls.Add(this.PasstextBox);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.PassporttextBox);
            this.Controls.Add(this.Passportlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Passportlabel;
        private System.Windows.Forms.TextBox PassporttextBox;
        private System.Windows.Forms.TextBox PasstextBox;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.TextBox NewPasstextBox;
        private System.Windows.Forms.Label NewPasslabel;
        private System.Windows.Forms.TextBox NewPassAgaintextBox;
        private System.Windows.Forms.Label NewPassAgainlabel;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button Changebutton;
        private System.Windows.Forms.Button OKbutton;
    }
}