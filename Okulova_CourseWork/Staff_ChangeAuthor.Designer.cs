namespace Okulova_CourseWork
{
    partial class Staff_ChangeAuthor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Foundbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Countrytextbox = new System.Windows.Forms.TextBox();
            this.Patronymictextbox = new System.Windows.Forms.TextBox();
            this.FirstNametextbox = new System.Windows.Forms.TextBox();
            this.LastNametextbox = new System.Windows.Forms.TextBox();
            this.Countlabel = new System.Windows.Forms.Label();
            this.Issuelabel = new System.Windows.Forms.Label();
            this.Genrelabel = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.IDlabel = new System.Windows.Forms.Label();
            this.IDtextbox = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Foundbutton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.IDlabel);
            this.panel1.Controls.Add(this.IDtextbox);
            this.panel1.Location = new System.Drawing.Point(476, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 537);
            this.panel1.TabIndex = 13;
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
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Countrytextbox);
            this.panel2.Controls.Add(this.Patronymictextbox);
            this.panel2.Controls.Add(this.FirstNametextbox);
            this.panel2.Controls.Add(this.LastNametextbox);
            this.panel2.Controls.Add(this.Countlabel);
            this.panel2.Controls.Add(this.Issuelabel);
            this.panel2.Controls.Add(this.Genrelabel);
            this.panel2.Controls.Add(this.Titlelabel);
            this.panel2.Controls.Add(this.Clearbutton);
            this.panel2.Controls.Add(this.OKbutton);
            this.panel2.Location = new System.Drawing.Point(3, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 387);
            this.panel2.TabIndex = 13;
            // 
            // Countrytextbox
            // 
            this.Countrytextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Countrytextbox.Location = new System.Drawing.Point(55, 276);
            this.Countrytextbox.Name = "Countrytextbox";
            this.Countrytextbox.Size = new System.Drawing.Size(211, 23);
            this.Countrytextbox.TabIndex = 30;
            this.Countrytextbox.Leave += new System.EventHandler(this.Countrytextbox_Leave);
            // 
            // Patronymictextbox
            // 
            this.Patronymictextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Patronymictextbox.Location = new System.Drawing.Point(55, 198);
            this.Patronymictextbox.Name = "Patronymictextbox";
            this.Patronymictextbox.Size = new System.Drawing.Size(211, 23);
            this.Patronymictextbox.TabIndex = 29;
            this.Patronymictextbox.Leave += new System.EventHandler(this.Patronymictextbox_Leave);
            // 
            // FirstNametextbox
            // 
            this.FirstNametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNametextbox.Location = new System.Drawing.Point(55, 123);
            this.FirstNametextbox.Name = "FirstNametextbox";
            this.FirstNametextbox.Size = new System.Drawing.Size(211, 23);
            this.FirstNametextbox.TabIndex = 28;
            this.FirstNametextbox.Leave += new System.EventHandler(this.FirstNametextbox_Leave);
            // 
            // LastNametextbox
            // 
            this.LastNametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNametextbox.Location = new System.Drawing.Point(54, 46);
            this.LastNametextbox.Name = "LastNametextbox";
            this.LastNametextbox.Size = new System.Drawing.Size(211, 23);
            this.LastNametextbox.TabIndex = 27;
            this.LastNametextbox.Leave += new System.EventHandler(this.LastNametextbox_Leave);
            // 
            // Countlabel
            // 
            this.Countlabel.AutoSize = true;
            this.Countlabel.BackColor = System.Drawing.Color.Transparent;
            this.Countlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Countlabel.ForeColor = System.Drawing.Color.White;
            this.Countlabel.Location = new System.Drawing.Point(117, 249);
            this.Countlabel.Name = "Countlabel";
            this.Countlabel.Size = new System.Drawing.Size(75, 24);
            this.Countlabel.TabIndex = 26;
            this.Countlabel.Text = "Страна";
            // 
            // Issuelabel
            // 
            this.Issuelabel.AutoSize = true;
            this.Issuelabel.BackColor = System.Drawing.Color.Transparent;
            this.Issuelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Issuelabel.ForeColor = System.Drawing.Color.White;
            this.Issuelabel.Location = new System.Drawing.Point(103, 171);
            this.Issuelabel.Name = "Issuelabel";
            this.Issuelabel.Size = new System.Drawing.Size(103, 24);
            this.Issuelabel.TabIndex = 25;
            this.Issuelabel.Text = "Отчество:";
            // 
            // Genrelabel
            // 
            this.Genrelabel.AutoSize = true;
            this.Genrelabel.BackColor = System.Drawing.Color.Transparent;
            this.Genrelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Genrelabel.ForeColor = System.Drawing.Color.White;
            this.Genrelabel.Location = new System.Drawing.Point(130, 96);
            this.Genrelabel.Name = "Genrelabel";
            this.Genrelabel.Size = new System.Drawing.Size(51, 24);
            this.Genrelabel.TabIndex = 24;
            this.Genrelabel.Text = "Имя:";
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.BackColor = System.Drawing.Color.Transparent;
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Titlelabel.ForeColor = System.Drawing.Color.White;
            this.Titlelabel.Location = new System.Drawing.Point(110, 19);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(96, 24);
            this.Titlelabel.TabIndex = 23;
            this.Titlelabel.Text = "Фамилия:";
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Clearbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Clearbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clearbutton.Location = new System.Drawing.Point(36, 341);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(97, 43);
            this.Clearbutton.TabIndex = 22;
            this.Clearbutton.Text = "Очистить";
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
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
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.BackColor = System.Drawing.Color.Transparent;
            this.IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDlabel.ForeColor = System.Drawing.Color.White;
            this.IDlabel.Location = new System.Drawing.Point(77, 17);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(171, 24);
            this.IDlabel.TabIndex = 11;
            this.IDlabel.Text = "Введите ID книги:";
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
            this.dataGrid.Location = new System.Drawing.Point(5, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(465, 537);
            this.dataGrid.TabIndex = 12;
            // 
            // Staff_ChangeAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Staff_ChangeAuthor";
            this.Text = "Изменение авторов";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Foundbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox IDtextbox;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox Countrytextbox;
        private System.Windows.Forms.TextBox Patronymictextbox;
        private System.Windows.Forms.TextBox FirstNametextbox;
        private System.Windows.Forms.TextBox LastNametextbox;
        private System.Windows.Forms.Label Countlabel;
        private System.Windows.Forms.Label Issuelabel;
        private System.Windows.Forms.Label Genrelabel;
        private System.Windows.Forms.Label Titlelabel;
    }
}