namespace Okulova_CourseWork
{
    partial class Staff_DeleteBook
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.SetIdlabel = new System.Windows.Forms.Label();
            this.Searchlabel = new System.Windows.Forms.Label();
            this.Searchtextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 58);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(555, 380);
            this.dataGrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Deletebutton);
            this.panel1.Controls.Add(this.IDtextBox);
            this.panel1.Controls.Add(this.SetIdlabel);
            this.panel1.Location = new System.Drawing.Point(573, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 280);
            this.panel1.TabIndex = 1;
            // 
            // Deletebutton
            // 
            this.Deletebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Deletebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deletebutton.Location = new System.Drawing.Point(64, 226);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(100, 33);
            this.Deletebutton.TabIndex = 38;
            this.Deletebutton.Text = "Удалить";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(64, 130);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(100, 20);
            this.IDtextBox.TabIndex = 37;
            // 
            // SetIdlabel
            // 
            this.SetIdlabel.AutoSize = true;
            this.SetIdlabel.BackColor = System.Drawing.Color.Transparent;
            this.SetIdlabel.Font = new System.Drawing.Font("Lucida Fax", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetIdlabel.Location = new System.Drawing.Point(19, 31);
            this.SetIdlabel.Name = "SetIdlabel";
            this.SetIdlabel.Size = new System.Drawing.Size(179, 75);
            this.SetIdlabel.TabIndex = 36;
            this.SetIdlabel.Text = "Введите ID книги,\r\nкоторую вы хотите\r\nудалить:";
            this.SetIdlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.BackColor = System.Drawing.Color.Transparent;
            this.Searchlabel.Font = new System.Drawing.Font("Lucida Fax", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlabel.Location = new System.Drawing.Point(61, 31);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(63, 25);
            this.Searchlabel.TabIndex = 35;
            this.Searchlabel.Text = "Поиск";
            // 
            // Searchtextbox
            // 
            this.Searchtextbox.BackColor = System.Drawing.Color.White;
            this.Searchtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Searchtextbox.Location = new System.Drawing.Point(127, 32);
            this.Searchtextbox.Name = "Searchtextbox";
            this.Searchtextbox.Size = new System.Drawing.Size(389, 23);
            this.Searchtextbox.TabIndex = 34;
            this.Searchtextbox.TextChanged += new System.EventHandler(this.Searchtextbox_TextChanged);
            // 
            // Staff_DeleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.Searchlabel);
            this.Controls.Add(this.Searchtextbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Staff_DeleteBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление книги";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label SetIdlabel;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.TextBox Searchtextbox;
    }
}