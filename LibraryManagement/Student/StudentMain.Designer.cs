
namespace LibraryManagement.Student
{
    partial class StudentMain
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
            this.btnStudentInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnListBooks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnStudentRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStudentInfo
            // 
            this.btnStudentInfo.BackColor = System.Drawing.Color.IndianRed;
            this.btnStudentInfo.Location = new System.Drawing.Point(604, 27);
            this.btnStudentInfo.Name = "btnStudentInfo";
            this.btnStudentInfo.Size = new System.Drawing.Size(162, 55);
            this.btnStudentInfo.TabIndex = 0;
            this.btnStudentInfo.Text = "Öğrenci Bilgi Güncelleme";
            this.btnStudentInfo.UseVisualStyleBackColor = false;
            this.btnStudentInfo.Click += new System.EventHandler(this.btnStudentInfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 256);
            this.dataGridView1.TabIndex = 1;
            // 
            // BtnListBooks
            // 
            this.BtnListBooks.BackColor = System.Drawing.Color.IndianRed;
            this.BtnListBooks.Location = new System.Drawing.Point(25, 95);
            this.BtnListBooks.Name = "BtnListBooks";
            this.BtnListBooks.Size = new System.Drawing.Size(122, 47);
            this.BtnListBooks.TabIndex = 2;
            this.BtnListBooks.Text = "Alınan Kitaplar";
            this.BtnListBooks.UseVisualStyleBackColor = false;
            this.BtnListBooks.Click += new System.EventHandler(this.BtnListBooks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "You are welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // BtnStudentRead
            // 
            this.BtnStudentRead.BackColor = System.Drawing.Color.IndianRed;
            this.BtnStudentRead.Location = new System.Drawing.Point(202, 95);
            this.BtnStudentRead.Name = "BtnStudentRead";
            this.BtnStudentRead.Size = new System.Drawing.Size(162, 47);
            this.BtnStudentRead.TabIndex = 9;
            this.BtnStudentRead.Text = "Kitap Al";
            this.BtnStudentRead.UseVisualStyleBackColor = false;
            this.BtnStudentRead.Click += new System.EventHandler(this.BtnStudentRead_Click);
            // 
            // StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnStudentRead);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnListBooks);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStudentInfo);
            this.Name = "StudentMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Ana Sayfası";
            this.Load += new System.EventHandler(this.StudentMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudentInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnListBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnStudentRead;
    }
}