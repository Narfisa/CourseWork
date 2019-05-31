namespace Okulova_CourseWork
{
    partial class Staff_AddAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_AddAuthor));
            this.Countrytextbox = new System.Windows.Forms.TextBox();
            this.Patronymictextbox = new System.Windows.Forms.TextBox();
            this.FirstNametextbox = new System.Windows.Forms.TextBox();
            this.LastNametextbox = new System.Windows.Forms.TextBox();
            this.Countlabel = new System.Windows.Forms.Label();
            this.Issuelabel = new System.Windows.Forms.Label();
            this.Genrelabel = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Countrytextbox
            // 
            this.Countrytextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Countrytextbox.Location = new System.Drawing.Point(234, 209);
            this.Countrytextbox.Name = "Countrytextbox";
            this.Countrytextbox.Size = new System.Drawing.Size(211, 23);
            this.Countrytextbox.TabIndex = 22;
            this.Countrytextbox.Leave += new System.EventHandler(this.Countrytextbox_Leave);
            // 
            // Patronymictextbox
            // 
            this.Patronymictextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Patronymictextbox.Location = new System.Drawing.Point(234, 147);
            this.Patronymictextbox.Name = "Patronymictextbox";
            this.Patronymictextbox.Size = new System.Drawing.Size(211, 23);
            this.Patronymictextbox.TabIndex = 21;
            this.Patronymictextbox.Leave += new System.EventHandler(this.Patronymictextbox_Leave);
            // 
            // FirstNametextbox
            // 
            this.FirstNametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNametextbox.Location = new System.Drawing.Point(234, 81);
            this.FirstNametextbox.Name = "FirstNametextbox";
            this.FirstNametextbox.Size = new System.Drawing.Size(211, 23);
            this.FirstNametextbox.TabIndex = 20;
            this.FirstNametextbox.Leave += new System.EventHandler(this.FirstNametextbox_Leave);
            // 
            // LastNametextbox
            // 
            this.LastNametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNametextbox.Location = new System.Drawing.Point(234, 20);
            this.LastNametextbox.Name = "LastNametextbox";
            this.LastNametextbox.Size = new System.Drawing.Size(211, 23);
            this.LastNametextbox.TabIndex = 19;
            this.LastNametextbox.Leave += new System.EventHandler(this.LastNametextbox_Leave);
            // 
            // Countlabel
            // 
            this.Countlabel.AutoSize = true;
            this.Countlabel.BackColor = System.Drawing.Color.Transparent;
            this.Countlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Countlabel.ForeColor = System.Drawing.Color.White;
            this.Countlabel.Location = new System.Drawing.Point(33, 209);
            this.Countlabel.Name = "Countlabel";
            this.Countlabel.Size = new System.Drawing.Size(75, 24);
            this.Countlabel.TabIndex = 18;
            this.Countlabel.Text = "Страна";
            // 
            // Issuelabel
            // 
            this.Issuelabel.AutoSize = true;
            this.Issuelabel.BackColor = System.Drawing.Color.Transparent;
            this.Issuelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Issuelabel.ForeColor = System.Drawing.Color.White;
            this.Issuelabel.Location = new System.Drawing.Point(33, 144);
            this.Issuelabel.Name = "Issuelabel";
            this.Issuelabel.Size = new System.Drawing.Size(103, 24);
            this.Issuelabel.TabIndex = 17;
            this.Issuelabel.Text = "Отчество:";
            // 
            // Genrelabel
            // 
            this.Genrelabel.AutoSize = true;
            this.Genrelabel.BackColor = System.Drawing.Color.Transparent;
            this.Genrelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Genrelabel.ForeColor = System.Drawing.Color.White;
            this.Genrelabel.Location = new System.Drawing.Point(33, 81);
            this.Genrelabel.Name = "Genrelabel";
            this.Genrelabel.Size = new System.Drawing.Size(51, 24);
            this.Genrelabel.TabIndex = 16;
            this.Genrelabel.Text = "Имя:";
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.BackColor = System.Drawing.Color.Transparent;
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Titlelabel.ForeColor = System.Drawing.Color.White;
            this.Titlelabel.Location = new System.Drawing.Point(33, 20);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(96, 24);
            this.Titlelabel.TabIndex = 15;
            this.Titlelabel.Text = "Фамилия:";
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Cancelbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Cancelbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancelbutton.Location = new System.Drawing.Point(348, 289);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(97, 43);
            this.Cancelbutton.TabIndex = 14;
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
            this.Clearbutton.Location = new System.Drawing.Point(194, 289);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(97, 43);
            this.Clearbutton.TabIndex = 13;
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
            this.Addbutton.Location = new System.Drawing.Point(37, 289);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(97, 43);
            this.Addbutton.TabIndex = 12;
            this.Addbutton.Text = "Добавить";
            this.Addbutton.UseVisualStyleBackColor = false;
            // 
            // Staff_AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Countrytextbox);
            this.Controls.Add(this.Patronymictextbox);
            this.Controls.Add(this.FirstNametextbox);
            this.Controls.Add(this.LastNametextbox);
            this.Controls.Add(this.Countlabel);
            this.Controls.Add(this.Issuelabel);
            this.Controls.Add(this.Genrelabel);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Addbutton);
            this.MaximizeBox = false;
            this.Name = "Staff_AddAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление Автора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Countrytextbox;
        private System.Windows.Forms.TextBox Patronymictextbox;
        private System.Windows.Forms.TextBox FirstNametextbox;
        private System.Windows.Forms.TextBox LastNametextbox;
        private System.Windows.Forms.Label Countlabel;
        private System.Windows.Forms.Label Issuelabel;
        private System.Windows.Forms.Label Genrelabel;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button Addbutton;
    }
}