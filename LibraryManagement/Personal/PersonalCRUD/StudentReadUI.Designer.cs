
namespace LibraryManagement.Personal.PersonalCRUD
{
    partial class StudentReadUI
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnStudentList = new System.Windows.Forms.Button();
            this.BtnBookList = new System.Windows.Forms.Button();
            this.BtnTakeBook = new System.Windows.Forms.Button();
            this.BtnGiveBook = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(202, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(202, 137);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(102, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(120, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Adı";
            // 
            // BtnStudentList
            // 
            this.BtnStudentList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.BtnStudentList.Location = new System.Drawing.Point(370, 87);
            this.BtnStudentList.Name = "BtnStudentList";
            this.BtnStudentList.Size = new System.Drawing.Size(143, 33);
            this.BtnStudentList.TabIndex = 4;
            this.BtnStudentList.Text = "Öğrenci Listele";
            this.BtnStudentList.UseVisualStyleBackColor = false;
            this.BtnStudentList.Click += new System.EventHandler(this.BtnStudentList_Click);
            // 
            // BtnBookList
            // 
            this.BtnBookList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.BtnBookList.Location = new System.Drawing.Point(370, 140);
            this.BtnBookList.Name = "BtnBookList";
            this.BtnBookList.Size = new System.Drawing.Size(143, 33);
            this.BtnBookList.TabIndex = 5;
            this.BtnBookList.Text = "Kitapları Listele";
            this.BtnBookList.UseVisualStyleBackColor = false;
            this.BtnBookList.Click += new System.EventHandler(this.BtnBookList_Click);
            // 
            // BtnTakeBook
            // 
            this.BtnTakeBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.BtnTakeBook.Location = new System.Drawing.Point(243, 239);
            this.BtnTakeBook.Name = "BtnTakeBook";
            this.BtnTakeBook.Size = new System.Drawing.Size(92, 33);
            this.BtnTakeBook.TabIndex = 7;
            this.BtnTakeBook.Text = "Kitabı Al";
            this.BtnTakeBook.UseVisualStyleBackColor = false;
            this.BtnTakeBook.Click += new System.EventHandler(this.BtnTakeBook_Click);
            // 
            // BtnGiveBook
            // 
            this.BtnGiveBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.BtnGiveBook.Location = new System.Drawing.Point(123, 239);
            this.BtnGiveBook.Name = "BtnGiveBook";
            this.BtnGiveBook.Size = new System.Drawing.Size(92, 33);
            this.BtnGiveBook.TabIndex = 6;
            this.BtnGiveBook.Text = "Kitabı Ver";
            this.BtnGiveBook.UseVisualStyleBackColor = false;
            this.BtnGiveBook.Click += new System.EventHandler(this.BtnGiveBook_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 188);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(75, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kitabı Alış Tarihi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(11, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(539, 28);
            this.label13.TabIndex = 40;
            this.label13.Text = "Ögrenci Kitap Teslimiyet Bilgisi Sayfasi";
            // 
            // StudentReadUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(562, 320);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BtnTakeBook);
            this.Controls.Add(this.BtnGiveBook);
            this.Controls.Add(this.BtnBookList);
            this.Controls.Add(this.BtnStudentList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Name = "StudentReadUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kitap Teslim Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnStudentList;
        private System.Windows.Forms.Button BtnBookList;
        private System.Windows.Forms.Button BtnTakeBook;
        private System.Windows.Forms.Button BtnGiveBook;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
    }
}