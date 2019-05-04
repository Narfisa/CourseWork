namespace Okulova_CourseWork
{
    partial class User
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
            this.Searchlabel = new System.Windows.Forms.Label();
            this.Searchtextbox = new System.Windows.Forms.TextBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Inlabel = new System.Windows.Forms.Label();
            this.IncomboBox = new System.Windows.Forms.ComboBox();
            this.Tablelabel = new System.Windows.Forms.Label();
            this.TablecomboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OKbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IDlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.BackColor = System.Drawing.Color.Transparent;
            this.Searchlabel.Font = new System.Drawing.Font("Lucida Fax", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlabel.Location = new System.Drawing.Point(90, 18);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(63, 25);
            this.Searchlabel.TabIndex = 33;
            this.Searchlabel.Text = "Поиск";
            // 
            // Searchtextbox
            // 
            this.Searchtextbox.BackColor = System.Drawing.Color.White;
            this.Searchtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Searchtextbox.Location = new System.Drawing.Point(19, 46);
            this.Searchtextbox.Name = "Searchtextbox";
            this.Searchtextbox.Size = new System.Drawing.Size(210, 23);
            this.Searchtextbox.TabIndex = 32;
            this.Searchtextbox.TextChanged += new System.EventHandler(this.Searchtextbox_TextChanged);
            // 
            // DataGrid
            // 
            this.DataGrid.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.GridColor = System.Drawing.Color.Silver;
            this.DataGrid.Location = new System.Drawing.Point(12, 22);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(606, 498);
            this.DataGrid.TabIndex = 31;
            // 
            // Inlabel
            // 
            this.Inlabel.AutoSize = true;
            this.Inlabel.BackColor = System.Drawing.Color.Transparent;
            this.Inlabel.Font = new System.Drawing.Font("Lucida Fax", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inlabel.Location = new System.Drawing.Point(104, 97);
            this.Inlabel.Name = "Inlabel";
            this.Inlabel.Size = new System.Drawing.Size(31, 25);
            this.Inlabel.TabIndex = 35;
            this.Inlabel.Text = "В:";
            // 
            // IncomboBox
            // 
            this.IncomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IncomboBox.FormattingEnabled = true;
            this.IncomboBox.Location = new System.Drawing.Point(51, 125);
            this.IncomboBox.Name = "IncomboBox";
            this.IncomboBox.Size = new System.Drawing.Size(134, 21);
            this.IncomboBox.TabIndex = 36;
            // 
            // Tablelabel
            // 
            this.Tablelabel.AutoSize = true;
            this.Tablelabel.BackColor = System.Drawing.Color.Transparent;
            this.Tablelabel.Font = new System.Drawing.Font("Lucida Fax", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tablelabel.Location = new System.Drawing.Point(72, 182);
            this.Tablelabel.Name = "Tablelabel";
            this.Tablelabel.Size = new System.Drawing.Size(91, 25);
            this.Tablelabel.TabIndex = 37;
            this.Tablelabel.Text = "Таблицы:";
            // 
            // TablecomboBox
            // 
            this.TablecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TablecomboBox.FormattingEnabled = true;
            this.TablecomboBox.Items.AddRange(new object[] {
            "Книги",
            "Авторы"});
            this.TablecomboBox.Location = new System.Drawing.Point(51, 233);
            this.TablecomboBox.Name = "TablecomboBox";
            this.TablecomboBox.Size = new System.Drawing.Size(133, 21);
            this.TablecomboBox.TabIndex = 38;
            this.TablecomboBox.SelectedIndexChanged += new System.EventHandler(this.TablecomboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TablecomboBox);
            this.panel1.Controls.Add(this.Searchlabel);
            this.panel1.Controls.Add(this.Tablelabel);
            this.panel1.Controls.Add(this.Searchtextbox);
            this.panel1.Controls.Add(this.IncomboBox);
            this.panel1.Controls.Add(this.Inlabel);
            this.panel1.Location = new System.Drawing.Point(624, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 269);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OKbutton);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.IDlabel);
            this.panel2.Location = new System.Drawing.Point(624, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 200);
            this.panel2.TabIndex = 40;
            // 
            // OKbutton
            // 
            this.OKbutton.BackColor = System.Drawing.Color.Transparent;
            this.OKbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OKbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKbutton.Location = new System.Drawing.Point(88, 162);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 41;
            this.OKbutton.Text = "ОК";
            this.OKbutton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 40;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.BackColor = System.Drawing.Color.Transparent;
            this.IDlabel.Font = new System.Drawing.Font("Lucida Fax", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.Location = new System.Drawing.Point(17, 14);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(212, 75);
            this.IDlabel.TabIndex = 39;
            this.IDlabel.Text = "Введите ваш ID для\r\nотображения вашего\r\nчитательского билета:";
            this.IDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 531);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.User_HelpButtonClicked);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.TextBox Searchtextbox;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Label Inlabel;
        private System.Windows.Forms.ComboBox IncomboBox;
        private System.Windows.Forms.Label Tablelabel;
        private System.Windows.Forms.ComboBox TablecomboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label IDlabel;
    }
}