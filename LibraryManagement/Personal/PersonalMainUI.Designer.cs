
namespace LibraryManagement.Personal
{
    partial class PersonalMainUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnWriterMenu = new System.Windows.Forms.Button();
            this.BtnStudentMenu = new System.Windows.Forms.Button();
            this.BtnBookMenu = new System.Windows.Forms.Button();
            this.BtnStudentBookMenu = new System.Windows.Forms.Button();
            this.BtnShowStudentRead = new System.Windows.Forms.Button();
            this.BtnGraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(77)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(175, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(77)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(321, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(77)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label3.Location = new System.Drawing.Point(23, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hoşgeldiniz:";
            // 
            // BtnWriterMenu
            // 
            this.BtnWriterMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(252)))), ((int)(((byte)(213)))));
            this.BtnWriterMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnWriterMenu.FlatAppearance.BorderSize = 0;
            this.BtnWriterMenu.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWriterMenu.Location = new System.Drawing.Point(28, 102);
            this.BtnWriterMenu.Name = "BtnWriterMenu";
            this.BtnWriterMenu.Size = new System.Drawing.Size(185, 55);
            this.BtnWriterMenu.TabIndex = 0;
            this.BtnWriterMenu.Text = "Yazar Düzenleme Menüsü";
            this.BtnWriterMenu.UseVisualStyleBackColor = false;
            this.BtnWriterMenu.Click += new System.EventHandler(this.BtnWriterMenu_Click);
            // 
            // BtnStudentMenu
            // 
            this.BtnStudentMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(252)))), ((int)(((byte)(213)))));
            this.BtnStudentMenu.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.BtnStudentMenu.Location = new System.Drawing.Point(229, 102);
            this.BtnStudentMenu.Name = "BtnStudentMenu";
            this.BtnStudentMenu.Size = new System.Drawing.Size(185, 55);
            this.BtnStudentMenu.TabIndex = 1;
            this.BtnStudentMenu.Text = "Öğrenci Düzenleme Menüsü";
            this.BtnStudentMenu.UseVisualStyleBackColor = false;
            this.BtnStudentMenu.Click += new System.EventHandler(this.BtnStudentMenu_Click);
            // 
            // BtnBookMenu
            // 
            this.BtnBookMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(252)))), ((int)(((byte)(213)))));
            this.BtnBookMenu.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.BtnBookMenu.Location = new System.Drawing.Point(434, 102);
            this.BtnBookMenu.Name = "BtnBookMenu";
            this.BtnBookMenu.Size = new System.Drawing.Size(185, 55);
            this.BtnBookMenu.TabIndex = 2;
            this.BtnBookMenu.Text = "Kitap Düzenleme Menüsü";
            this.BtnBookMenu.UseVisualStyleBackColor = false;
            this.BtnBookMenu.Click += new System.EventHandler(this.BtnBookMenu_Click);
            // 
            // BtnStudentBookMenu
            // 
            this.BtnStudentBookMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(252)))), ((int)(((byte)(213)))));
            this.BtnStudentBookMenu.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.BtnStudentBookMenu.Location = new System.Drawing.Point(434, 203);
            this.BtnStudentBookMenu.Name = "BtnStudentBookMenu";
            this.BtnStudentBookMenu.Size = new System.Drawing.Size(185, 54);
            this.BtnStudentBookMenu.TabIndex = 3;
            this.BtnStudentBookMenu.Text = "Öğrenci Kitap Düzenleme Menüsü";
            this.BtnStudentBookMenu.UseVisualStyleBackColor = false;
            this.BtnStudentBookMenu.Click += new System.EventHandler(this.BtnStudentBookMenu_Click);
            // 
            // BtnShowStudentRead
            // 
            this.BtnShowStudentRead.AutoEllipsis = true;
            this.BtnShowStudentRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(252)))), ((int)(((byte)(213)))));
            this.BtnShowStudentRead.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.BtnShowStudentRead.Location = new System.Drawing.Point(28, 203);
            this.BtnShowStudentRead.Name = "BtnShowStudentRead";
            this.BtnShowStudentRead.Size = new System.Drawing.Size(174, 54);
            this.BtnShowStudentRead.TabIndex = 4;
            this.BtnShowStudentRead.Text = "Öğrenci Almış Olduğu Kitaplar";
            this.BtnShowStudentRead.UseVisualStyleBackColor = false;
            this.BtnShowStudentRead.Click += new System.EventHandler(this.BtnShowStudentRead_Click);
            // 
            // BtnGraph
            // 
            this.BtnGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(252)))), ((int)(((byte)(213)))));
            this.BtnGraph.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.BtnGraph.Location = new System.Drawing.Point(229, 203);
            this.BtnGraph.Name = "BtnGraph";
            this.BtnGraph.Size = new System.Drawing.Size(185, 54);
            this.BtnGraph.TabIndex = 8;
            this.BtnGraph.Text = "Grafikler";
            this.BtnGraph.UseVisualStyleBackColor = false;
            this.BtnGraph.Click += new System.EventHandler(this.BtnGraph_Click);
            // 
            // PersonalMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(77)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(695, 337);
            this.Controls.Add(this.BtnGraph);
            this.Controls.Add(this.BtnShowStudentRead);
            this.Controls.Add(this.BtnStudentBookMenu);
            this.Controls.Add(this.BtnBookMenu);
            this.Controls.Add(this.BtnStudentMenu);
            this.Controls.Add(this.BtnWriterMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonalMainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Ana Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnWriterMenu;
        private System.Windows.Forms.Button BtnStudentMenu;
        private System.Windows.Forms.Button BtnBookMenu;
        private System.Windows.Forms.Button BtnStudentBookMenu;
        private System.Windows.Forms.Button BtnShowStudentRead;
        private System.Windows.Forms.Button BtnGraph;
    }
}