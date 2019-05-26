namespace Okulova_CourseWork
{
    partial class Staff_ChangeBook
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
            this.Titletextbox = new System.Windows.Forms.TextBox();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IDlabel = new System.Windows.Forms.Label();
            this.IDtextbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Foundbutton = new System.Windows.Forms.Button();
            this.Genrelabel = new System.Windows.Forms.Label();
            this.Genretextbox = new System.Windows.Forms.TextBox();
            this.Issuetlabel = new System.Windows.Forms.Label();
            this.Issuetextbox = new System.Windows.Forms.TextBox();
            this.Countlabel = new System.Windows.Forms.Label();
            this.Counttextbox = new System.Windows.Forms.TextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.Author2combobox = new System.Windows.Forms.ComboBox();
            this.Author3combobox = new System.Windows.Forms.ComboBox();
            this.Author1combobox = new System.Windows.Forms.ComboBox();
            this.Authorslabel = new System.Windows.Forms.Label();
            this.Clearbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(548, 537);
            this.dataGrid.TabIndex = 0;
            // 
            // Titletextbox
            // 
            this.Titletextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Titletextbox.Location = new System.Drawing.Point(181, 20);
            this.Titletextbox.Name = "Titletextbox";
            this.Titletextbox.Size = new System.Drawing.Size(211, 23);
            this.Titletextbox.TabIndex = 10;
            this.Titletextbox.Leave += new System.EventHandler(this.Titletextbox_Leave);
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.BackColor = System.Drawing.Color.Transparent;
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Titlelabel.ForeColor = System.Drawing.Color.White;
            this.Titlelabel.Location = new System.Drawing.Point(17, 17);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(158, 24);
            this.Titlelabel.TabIndex = 9;
            this.Titlelabel.Text = "Название книги:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Foundbutton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.IDlabel);
            this.panel1.Controls.Add(this.IDtextbox);
            this.panel1.Location = new System.Drawing.Point(566, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 537);
            this.panel1.TabIndex = 11;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.BackColor = System.Drawing.Color.Transparent;
            this.IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDlabel.ForeColor = System.Drawing.Color.White;
            this.IDlabel.Location = new System.Drawing.Point(132, 13);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(171, 24);
            this.IDlabel.TabIndex = 11;
            this.IDlabel.Text = "Введите ID книги:";
            // 
            // IDtextbox
            // 
            this.IDtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDtextbox.Location = new System.Drawing.Point(110, 44);
            this.IDtextbox.Name = "IDtextbox";
            this.IDtextbox.Size = new System.Drawing.Size(211, 23);
            this.IDtextbox.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Clearbutton);
            this.panel2.Controls.Add(this.Author2combobox);
            this.panel2.Controls.Add(this.Author3combobox);
            this.panel2.Controls.Add(this.Author1combobox);
            this.panel2.Controls.Add(this.Authorslabel);
            this.panel2.Controls.Add(this.OKbutton);
            this.panel2.Controls.Add(this.Countlabel);
            this.panel2.Controls.Add(this.Counttextbox);
            this.panel2.Controls.Add(this.Issuetlabel);
            this.panel2.Controls.Add(this.Issuetextbox);
            this.panel2.Controls.Add(this.Genrelabel);
            this.panel2.Controls.Add(this.Genretextbox);
            this.panel2.Controls.Add(this.Titlelabel);
            this.panel2.Controls.Add(this.Titletextbox);
            this.panel2.Location = new System.Drawing.Point(3, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 387);
            this.panel2.TabIndex = 13;
            // 
            // Foundbutton
            // 
            this.Foundbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Foundbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Foundbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Foundbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Foundbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Foundbutton.Location = new System.Drawing.Point(161, 88);
            this.Foundbutton.Name = "Foundbutton";
            this.Foundbutton.Size = new System.Drawing.Size(97, 43);
            this.Foundbutton.TabIndex = 14;
            this.Foundbutton.Text = "Найти";
            this.Foundbutton.UseVisualStyleBackColor = false;
            this.Foundbutton.Click += new System.EventHandler(this.Foundbutton_Click);
            // 
            // Genrelabel
            // 
            this.Genrelabel.AutoSize = true;
            this.Genrelabel.BackColor = System.Drawing.Color.Transparent;
            this.Genrelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Genrelabel.ForeColor = System.Drawing.Color.White;
            this.Genrelabel.Location = new System.Drawing.Point(56, 63);
            this.Genrelabel.Name = "Genrelabel";
            this.Genrelabel.Size = new System.Drawing.Size(119, 24);
            this.Genrelabel.TabIndex = 11;
            this.Genrelabel.Text = "Жанр книги:";
            // 
            // Genretextbox
            // 
            this.Genretextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Genretextbox.Location = new System.Drawing.Point(181, 66);
            this.Genretextbox.Name = "Genretextbox";
            this.Genretextbox.Size = new System.Drawing.Size(211, 23);
            this.Genretextbox.TabIndex = 12;
            this.Genretextbox.Leave += new System.EventHandler(this.Genretextbox_Leave);
            // 
            // Issuetlabel
            // 
            this.Issuetlabel.AutoSize = true;
            this.Issuetlabel.BackColor = System.Drawing.Color.Transparent;
            this.Issuetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Issuetlabel.ForeColor = System.Drawing.Color.White;
            this.Issuetlabel.Location = new System.Drawing.Point(48, 111);
            this.Issuetlabel.Name = "Issuetlabel";
            this.Issuetlabel.Size = new System.Drawing.Size(127, 24);
            this.Issuetlabel.TabIndex = 13;
            this.Issuetlabel.Text = "Год выпуска:";
            // 
            // Issuetextbox
            // 
            this.Issuetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Issuetextbox.Location = new System.Drawing.Point(181, 114);
            this.Issuetextbox.Name = "Issuetextbox";
            this.Issuetextbox.Size = new System.Drawing.Size(211, 23);
            this.Issuetextbox.TabIndex = 14;
            this.Issuetextbox.Leave += new System.EventHandler(this.Issuetextbox_Leave);
            // 
            // Countlabel
            // 
            this.Countlabel.AutoSize = true;
            this.Countlabel.BackColor = System.Drawing.Color.Transparent;
            this.Countlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Countlabel.ForeColor = System.Drawing.Color.White;
            this.Countlabel.Location = new System.Drawing.Point(53, 157);
            this.Countlabel.Name = "Countlabel";
            this.Countlabel.Size = new System.Drawing.Size(122, 24);
            this.Countlabel.TabIndex = 15;
            this.Countlabel.Text = "Количество:";
            // 
            // Counttextbox
            // 
            this.Counttextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Counttextbox.Location = new System.Drawing.Point(181, 160);
            this.Counttextbox.Name = "Counttextbox";
            this.Counttextbox.Size = new System.Drawing.Size(211, 23);
            this.Counttextbox.TabIndex = 16;
            // 
            // OKbutton
            // 
            this.OKbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.OKbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.OKbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.OKbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKbutton.Location = new System.Drawing.Point(221, 328);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(97, 43);
            this.OKbutton.TabIndex = 17;
            this.OKbutton.Text = "Изменить";
            this.OKbutton.UseVisualStyleBackColor = false;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // Author2combobox
            // 
            this.Author2combobox.FormattingEnabled = true;
            this.Author2combobox.Location = new System.Drawing.Point(285, 248);
            this.Author2combobox.Name = "Author2combobox";
            this.Author2combobox.Size = new System.Drawing.Size(121, 21);
            this.Author2combobox.TabIndex = 21;
            // 
            // Author3combobox
            // 
            this.Author3combobox.FormattingEnabled = true;
            this.Author3combobox.Location = new System.Drawing.Point(145, 248);
            this.Author3combobox.Name = "Author3combobox";
            this.Author3combobox.Size = new System.Drawing.Size(121, 21);
            this.Author3combobox.TabIndex = 20;
            // 
            // Author1combobox
            // 
            this.Author1combobox.FormattingEnabled = true;
            this.Author1combobox.Location = new System.Drawing.Point(3, 248);
            this.Author1combobox.Name = "Author1combobox";
            this.Author1combobox.Size = new System.Drawing.Size(121, 21);
            this.Author1combobox.TabIndex = 19;
            // 
            // Authorslabel
            // 
            this.Authorslabel.AutoSize = true;
            this.Authorslabel.BackColor = System.Drawing.Color.Transparent;
            this.Authorslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authorslabel.ForeColor = System.Drawing.Color.White;
            this.Authorslabel.Location = new System.Drawing.Point(165, 214);
            this.Authorslabel.Name = "Authorslabel";
            this.Authorslabel.Size = new System.Drawing.Size(84, 24);
            this.Authorslabel.TabIndex = 18;
            this.Authorslabel.Text = "Авторы:";
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Clearbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Clearbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clearbutton.Location = new System.Drawing.Point(78, 328);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(97, 43);
            this.Clearbutton.TabIndex = 22;
            this.Clearbutton.Text = "Очистить";
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Staff_ChangeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Staff_ChangeBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение книг";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox Titletextbox;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox IDtextbox;
        private System.Windows.Forms.Button Foundbutton;
        private System.Windows.Forms.Label Genrelabel;
        private System.Windows.Forms.TextBox Genretextbox;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Label Countlabel;
        private System.Windows.Forms.TextBox Counttextbox;
        private System.Windows.Forms.Label Issuetlabel;
        private System.Windows.Forms.TextBox Issuetextbox;
        private System.Windows.Forms.ComboBox Author2combobox;
        private System.Windows.Forms.ComboBox Author3combobox;
        private System.Windows.Forms.ComboBox Author1combobox;
        private System.Windows.Forms.Label Authorslabel;
        private System.Windows.Forms.Button Clearbutton;
    }
}