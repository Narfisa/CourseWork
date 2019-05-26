namespace Okulova_CourseWork
{
    partial class Staff_Out
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
            this.FoundBookbutton = new System.Windows.Forms.Button();
            this.IDBooklabel = new System.Windows.Forms.Label();
            this.IDBooktextbox = new System.Windows.Forms.TextBox();
            this.Step1label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Step2label = new System.Windows.Forms.Label();
            this.FoundUserbutton = new System.Windows.Forms.Button();
            this.IDUserlabel = new System.Windows.Forms.Label();
            this.IDUsertextbox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Step3label = new System.Windows.Forms.Label();
            this.Countlabel = new System.Windows.Forms.Label();
            this.Counttextbox = new System.Windows.Forms.TextBox();
            this.Searchlabel = new System.Windows.Forms.Label();
            this.Searchtextbox = new System.Windows.Forms.TextBox();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 35);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(454, 514);
            this.dataGrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Step1label);
            this.panel1.Controls.Add(this.FoundBookbutton);
            this.panel1.Controls.Add(this.IDBooklabel);
            this.panel1.Controls.Add(this.IDBooktextbox);
            this.panel1.Location = new System.Drawing.Point(472, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 145);
            this.panel1.TabIndex = 1;
            // 
            // FoundBookbutton
            // 
            this.FoundBookbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.FoundBookbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.FoundBookbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.FoundBookbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoundBookbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoundBookbutton.Location = new System.Drawing.Point(105, 95);
            this.FoundBookbutton.Name = "FoundBookbutton";
            this.FoundBookbutton.Size = new System.Drawing.Size(97, 43);
            this.FoundBookbutton.TabIndex = 17;
            this.FoundBookbutton.Text = "Найти";
            this.FoundBookbutton.UseVisualStyleBackColor = false;
            this.FoundBookbutton.Click += new System.EventHandler(this.FoundBookbutton_Click);
            // 
            // IDBooklabel
            // 
            this.IDBooklabel.AutoSize = true;
            this.IDBooklabel.BackColor = System.Drawing.Color.Transparent;
            this.IDBooklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDBooklabel.ForeColor = System.Drawing.Color.White;
            this.IDBooklabel.Location = new System.Drawing.Point(72, 39);
            this.IDBooklabel.Name = "IDBooklabel";
            this.IDBooklabel.Size = new System.Drawing.Size(171, 24);
            this.IDBooklabel.TabIndex = 15;
            this.IDBooklabel.Text = "Введите ID книги:";
            // 
            // IDBooktextbox
            // 
            this.IDBooktextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDBooktextbox.Location = new System.Drawing.Point(50, 66);
            this.IDBooktextbox.Name = "IDBooktextbox";
            this.IDBooktextbox.Size = new System.Drawing.Size(211, 23);
            this.IDBooktextbox.TabIndex = 16;
            // 
            // Step1label
            // 
            this.Step1label.AutoSize = true;
            this.Step1label.BackColor = System.Drawing.Color.Transparent;
            this.Step1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Step1label.ForeColor = System.Drawing.Color.Black;
            this.Step1label.Location = new System.Drawing.Point(3, 11);
            this.Step1label.Name = "Step1label";
            this.Step1label.Size = new System.Drawing.Size(63, 24);
            this.Step1label.TabIndex = 18;
            this.Step1label.Text = "Шаг 1.";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Step2label);
            this.panel2.Controls.Add(this.FoundUserbutton);
            this.panel2.Controls.Add(this.IDUserlabel);
            this.panel2.Controls.Add(this.IDUsertextbox);
            this.panel2.Location = new System.Drawing.Point(472, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 145);
            this.panel2.TabIndex = 19;
            // 
            // Step2label
            // 
            this.Step2label.AutoSize = true;
            this.Step2label.BackColor = System.Drawing.Color.Transparent;
            this.Step2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Step2label.ForeColor = System.Drawing.Color.Black;
            this.Step2label.Location = new System.Drawing.Point(3, 11);
            this.Step2label.Name = "Step2label";
            this.Step2label.Size = new System.Drawing.Size(63, 24);
            this.Step2label.TabIndex = 18;
            this.Step2label.Text = "Шаг 2.";
            // 
            // FoundUserbutton
            // 
            this.FoundUserbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.FoundUserbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.FoundUserbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.FoundUserbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoundUserbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoundUserbutton.Location = new System.Drawing.Point(105, 95);
            this.FoundUserbutton.Name = "FoundUserbutton";
            this.FoundUserbutton.Size = new System.Drawing.Size(97, 43);
            this.FoundUserbutton.TabIndex = 17;
            this.FoundUserbutton.Text = "Найти";
            this.FoundUserbutton.UseVisualStyleBackColor = false;
            this.FoundUserbutton.Click += new System.EventHandler(this.FoundUserbutton_Click);
            // 
            // IDUserlabel
            // 
            this.IDUserlabel.AutoSize = true;
            this.IDUserlabel.BackColor = System.Drawing.Color.Transparent;
            this.IDUserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDUserlabel.ForeColor = System.Drawing.Color.White;
            this.IDUserlabel.Location = new System.Drawing.Point(32, 39);
            this.IDUserlabel.Name = "IDUserlabel";
            this.IDUserlabel.Size = new System.Drawing.Size(246, 24);
            this.IDUserlabel.TabIndex = 15;
            this.IDUserlabel.Text = "Введите ID пользователя:";
            // 
            // IDUsertextbox
            // 
            this.IDUsertextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDUsertextbox.Location = new System.Drawing.Point(50, 66);
            this.IDUsertextbox.Name = "IDUsertextbox";
            this.IDUsertextbox.Size = new System.Drawing.Size(211, 23);
            this.IDUsertextbox.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Step3label);
            this.panel3.Controls.Add(this.Countlabel);
            this.panel3.Controls.Add(this.Counttextbox);
            this.panel3.Location = new System.Drawing.Point(472, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 145);
            this.panel3.TabIndex = 20;
            // 
            // Step3label
            // 
            this.Step3label.AutoSize = true;
            this.Step3label.BackColor = System.Drawing.Color.Transparent;
            this.Step3label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Step3label.ForeColor = System.Drawing.Color.Black;
            this.Step3label.Location = new System.Drawing.Point(3, 11);
            this.Step3label.Name = "Step3label";
            this.Step3label.Size = new System.Drawing.Size(63, 24);
            this.Step3label.TabIndex = 18;
            this.Step3label.Text = "Шаг 3.";
            // 
            // Countlabel
            // 
            this.Countlabel.AutoSize = true;
            this.Countlabel.BackColor = System.Drawing.Color.Transparent;
            this.Countlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Countlabel.ForeColor = System.Drawing.Color.White;
            this.Countlabel.Location = new System.Drawing.Point(72, 58);
            this.Countlabel.Name = "Countlabel";
            this.Countlabel.Size = new System.Drawing.Size(167, 24);
            this.Countlabel.TabIndex = 15;
            this.Countlabel.Text = "Количество книг:";
            // 
            // Counttextbox
            // 
            this.Counttextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Counttextbox.Location = new System.Drawing.Point(50, 85);
            this.Counttextbox.Name = "Counttextbox";
            this.Counttextbox.Size = new System.Drawing.Size(211, 23);
            this.Counttextbox.TabIndex = 16;
            this.Counttextbox.Leave += new System.EventHandler(this.Counttextbox_Leave);
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.BackColor = System.Drawing.Color.Transparent;
            this.Searchlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Searchlabel.ForeColor = System.Drawing.Color.Black;
            this.Searchlabel.Location = new System.Drawing.Point(12, 9);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(69, 24);
            this.Searchlabel.TabIndex = 19;
            this.Searchlabel.Text = "Поиск:";
            // 
            // Searchtextbox
            // 
            this.Searchtextbox.Location = new System.Drawing.Point(87, 12);
            this.Searchtextbox.Name = "Searchtextbox";
            this.Searchtextbox.Size = new System.Drawing.Size(379, 20);
            this.Searchtextbox.TabIndex = 21;
            this.Searchtextbox.TextChanged += new System.EventHandler(this.Searchtextbox_TextChanged);
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Clearbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Clearbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clearbutton.Location = new System.Drawing.Point(508, 506);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(97, 43);
            this.Clearbutton.TabIndex = 19;
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
            this.OKbutton.Location = new System.Drawing.Point(653, 506);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(97, 43);
            this.OKbutton.TabIndex = 22;
            this.OKbutton.Text = "Выдать";
            this.OKbutton.UseVisualStyleBackColor = false;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // Staff_Out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Searchtextbox);
            this.Controls.Add(this.Searchlabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Staff_Out";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выдача книг";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Step1label;
        private System.Windows.Forms.Button FoundBookbutton;
        private System.Windows.Forms.Label IDBooklabel;
        private System.Windows.Forms.TextBox IDBooktextbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Step2label;
        private System.Windows.Forms.Button FoundUserbutton;
        private System.Windows.Forms.Label IDUserlabel;
        private System.Windows.Forms.TextBox IDUsertextbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Step3label;
        private System.Windows.Forms.Label Countlabel;
        private System.Windows.Forms.TextBox Counttextbox;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.TextBox Searchtextbox;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button OKbutton;
    }
}