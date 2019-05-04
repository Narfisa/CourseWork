namespace Okulova_CourseWork
{
    partial class Welcome
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
            this.components = new System.ComponentModel.Container();
            this.Welcomelabel = new System.Windows.Forms.Label();
            this.Todaylabel = new System.Windows.Forms.Label();
            this.Userbutton = new System.Windows.Forms.Button();
            this.Staffbutton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Welcomelabel
            // 
            this.Welcomelabel.AutoSize = true;
            this.Welcomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Welcomelabel.Location = new System.Drawing.Point(185, 31);
            this.Welcomelabel.Name = "Welcomelabel";
            this.Welcomelabel.Size = new System.Drawing.Size(215, 25);
            this.Welcomelabel.TabIndex = 0;
            this.Welcomelabel.Text = "Добро пожаловать!";
            // 
            // Todaylabel
            // 
            this.Todaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Todaylabel.Location = new System.Drawing.Point(12, 329);
            this.Todaylabel.Name = "Todaylabel";
            this.Todaylabel.Size = new System.Drawing.Size(558, 23);
            this.Todaylabel.TabIndex = 1;
            this.Todaylabel.Text = "\"";
            this.Todaylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Userbutton
            // 
            this.Userbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Userbutton.Location = new System.Drawing.Point(190, 129);
            this.Userbutton.Name = "Userbutton";
            this.Userbutton.Size = new System.Drawing.Size(210, 46);
            this.Userbutton.TabIndex = 2;
            this.Userbutton.Text = "Я - пользователь";
            this.Userbutton.UseVisualStyleBackColor = true;
            this.Userbutton.Click += new System.EventHandler(this.Userbutton_Click);
            // 
            // Staffbutton
            // 
            this.Staffbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Staffbutton.Location = new System.Drawing.Point(190, 224);
            this.Staffbutton.Name = "Staffbutton";
            this.Staffbutton.Size = new System.Drawing.Size(210, 46);
            this.Staffbutton.TabIndex = 3;
            this.Staffbutton.Text = "Я - сотрудник";
            this.Staffbutton.UseVisualStyleBackColor = true;
            this.Staffbutton.Click += new System.EventHandler(this.Staffbutton_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.Staffbutton);
            this.Controls.Add(this.Userbutton);
            this.Controls.Add(this.Todaylabel);
            this.Controls.Add(this.Welcomelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Init_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcomelabel;
        private System.Windows.Forms.Label Todaylabel;
        private System.Windows.Forms.Button Userbutton;
        private System.Windows.Forms.Button Staffbutton;
        private System.Windows.Forms.Timer timer;
    }
}