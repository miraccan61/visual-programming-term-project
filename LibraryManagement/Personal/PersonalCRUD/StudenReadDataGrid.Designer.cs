
namespace LibraryManagement.Personal.PersonalCRUD
{
    partial class StudenReadDataGrid
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnListBook = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Adı";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(262, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 236);
            this.dataGridView1.TabIndex = 2;
            // 
            // BtnList
            // 
            this.BtnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(184)))), ((int)(((byte)(211)))));
            this.BtnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.BtnList.ForeColor = System.Drawing.Color.Black;
            this.BtnList.Location = new System.Drawing.Point(454, 67);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(88, 38);
            this.BtnList.TabIndex = 3;
            this.BtnList.Text = "Listele";
            this.BtnList.UseVisualStyleBackColor = false;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnListBook
            // 
            this.BtnListBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(184)))), ((int)(((byte)(211)))));
            this.BtnListBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.BtnListBook.ForeColor = System.Drawing.Color.Black;
            this.BtnListBook.Location = new System.Drawing.Point(262, 116);
            this.BtnListBook.Name = "BtnListBook";
            this.BtnListBook.Size = new System.Drawing.Size(144, 44);
            this.BtnListBook.TabIndex = 4;
            this.BtnListBook.Text = " Kitapları Listele";
            this.BtnListBook.UseVisualStyleBackColor = false;
            this.BtnListBook.Click += new System.EventHandler(this.BtnListBook_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(219)))));
            this.label13.Location = new System.Drawing.Point(217, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(395, 28);
            this.label13.TabIndex = 38;
            this.label13.Text = "Ögrenci Kitap Bilgisi Sayfasi";
            // 
            // StudenReadDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(86)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(846, 494);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BtnListBook);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "StudenReadDataGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kitap Bilgisi Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnListBook;
        private System.Windows.Forms.Label label13;
    }
}