
namespace LibraryManagement.Student.StudentCRUD
{
    partial class StudentBookUI
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnTakeBook = new System.Windows.Forms.Button();
            this.BtnReleaseBook = new System.Windows.Forms.Button();
            this.BtnGetBooks = new System.Windows.Forms.Button();
            this.cmbBookName = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(269, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(171, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(129, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Alış Tarihi";
            // 
            // BtnTakeBook
            // 
            this.BtnTakeBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(104)))));
            this.BtnTakeBook.ForeColor = System.Drawing.Color.White;
            this.BtnTakeBook.Location = new System.Drawing.Point(269, 206);
            this.BtnTakeBook.Name = "BtnTakeBook";
            this.BtnTakeBook.Size = new System.Drawing.Size(138, 41);
            this.BtnTakeBook.TabIndex = 4;
            this.BtnTakeBook.Text = "Kitabı Al";
            this.BtnTakeBook.UseVisualStyleBackColor = false;
            this.BtnTakeBook.Click += new System.EventHandler(this.BtnTakeBook_Click);
            // 
            // BtnReleaseBook
            // 
            this.BtnReleaseBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(104)))));
            this.BtnReleaseBook.ForeColor = System.Drawing.Color.White;
            this.BtnReleaseBook.Location = new System.Drawing.Point(439, 207);
            this.BtnReleaseBook.Name = "BtnReleaseBook";
            this.BtnReleaseBook.Size = new System.Drawing.Size(138, 40);
            this.BtnReleaseBook.TabIndex = 5;
            this.BtnReleaseBook.Text = "Kitabı Ver";
            this.BtnReleaseBook.UseVisualStyleBackColor = false;
            this.BtnReleaseBook.Click += new System.EventHandler(this.BtnReleaseBook_Click);
            // 
            // BtnGetBooks
            // 
            this.BtnGetBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(104)))));
            this.BtnGetBooks.ForeColor = System.Drawing.Color.White;
            this.BtnGetBooks.Location = new System.Drawing.Point(443, 86);
            this.BtnGetBooks.Name = "BtnGetBooks";
            this.BtnGetBooks.Size = new System.Drawing.Size(122, 34);
            this.BtnGetBooks.TabIndex = 8;
            this.BtnGetBooks.Text = "Kitapları listele";
            this.BtnGetBooks.UseVisualStyleBackColor = false;
            this.BtnGetBooks.Click += new System.EventHandler(this.BtnGetBooks_Click);
            // 
            // cmbBookName
            // 
            this.cmbBookName.FormattingEnabled = true;
            this.cmbBookName.Location = new System.Drawing.Point(269, 92);
            this.cmbBookName.Name = "cmbBookName";
            this.cmbBookName.Size = new System.Drawing.Size(150, 24);
            this.cmbBookName.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(249)))));
            this.label13.Location = new System.Drawing.Point(131, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(467, 28);
            this.label13.TabIndex = 42;
            this.label13.Text = "Öğrenci Kitap Teslim Alma Sayfasi";
            // 
            // StudentBookUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(739, 305);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbBookName);
            this.Controls.Add(this.BtnGetBooks);
            this.Controls.Add(this.BtnReleaseBook);
            this.Controls.Add(this.BtnTakeBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "StudentBookUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kitap Teslim Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnTakeBook;
        private System.Windows.Forms.Button BtnReleaseBook;
        private System.Windows.Forms.Button BtnGetBooks;
        private System.Windows.Forms.ComboBox cmbBookName;
        private System.Windows.Forms.Label label13;
    }
}