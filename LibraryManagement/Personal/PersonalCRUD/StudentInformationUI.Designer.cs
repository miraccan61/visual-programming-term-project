
namespace LibraryManagement.Personal.CRUD
{
    partial class StudentInformationUI
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
            this.BtnStudentList = new System.Windows.Forms.Button();
            this.BtnStudentUpdate = new System.Windows.Forms.Button();
            this.BtnStudentDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtStudentId = new System.Windows.Forms.TextBox();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.TxtStudentLastName = new System.Windows.Forms.TextBox();
            this.TxtStudentDebt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnStudentAdd = new System.Windows.Forms.Button();
            this.CmbStudentGender = new System.Windows.Forms.ComboBox();
            this.LabelStudentGender = new System.Windows.Forms.Label();
            this.TxtStudentPassword1 = new System.Windows.Forms.TextBox();
            this.TxtStudentPassword2 = new System.Windows.Forms.TextBox();
            this.TxtStudentUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStudentList
            // 
            this.BtnStudentList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(99)))), ((int)(((byte)(171)))));
            this.BtnStudentList.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnStudentList.Location = new System.Drawing.Point(384, 270);
            this.BtnStudentList.Name = "BtnStudentList";
            this.BtnStudentList.Size = new System.Drawing.Size(119, 44);
            this.BtnStudentList.TabIndex = 9;
            this.BtnStudentList.Text = "Listele";
            this.BtnStudentList.UseVisualStyleBackColor = false;
            this.BtnStudentList.Click += new System.EventHandler(this.StudentList_Click);
            // 
            // BtnStudentUpdate
            // 
            this.BtnStudentUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(99)))), ((int)(((byte)(171)))));
            this.BtnStudentUpdate.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnStudentUpdate.Location = new System.Drawing.Point(551, 270);
            this.BtnStudentUpdate.Name = "BtnStudentUpdate";
            this.BtnStudentUpdate.Size = new System.Drawing.Size(111, 44);
            this.BtnStudentUpdate.TabIndex = 10;
            this.BtnStudentUpdate.Text = "Güncelle";
            this.BtnStudentUpdate.UseVisualStyleBackColor = false;
            this.BtnStudentUpdate.Click += new System.EventHandler(this.BtnStudentUpdate_Click);
            // 
            // BtnStudentDelete
            // 
            this.BtnStudentDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(99)))), ((int)(((byte)(171)))));
            this.BtnStudentDelete.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnStudentDelete.Location = new System.Drawing.Point(697, 270);
            this.BtnStudentDelete.Name = "BtnStudentDelete";
            this.BtnStudentDelete.Size = new System.Drawing.Size(111, 44);
            this.BtnStudentDelete.TabIndex = 11;
            this.BtnStudentDelete.Text = "Sil";
            this.BtnStudentDelete.UseVisualStyleBackColor = false;
            this.BtnStudentDelete.Click += new System.EventHandler(this.BtnStudentDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(241, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Öğrenci ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(234, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Öğrenci Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(211, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Öğrenci Soyadı";
            // 
            // TxtStudentId
            // 
            this.TxtStudentId.Location = new System.Drawing.Point(350, 90);
            this.TxtStudentId.Name = "TxtStudentId";
            this.TxtStudentId.Size = new System.Drawing.Size(120, 22);
            this.TxtStudentId.TabIndex = 0;
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.Location = new System.Drawing.Point(350, 132);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(120, 22);
            this.TxtStudentName.TabIndex = 1;
            // 
            // TxtStudentLastName
            // 
            this.TxtStudentLastName.Location = new System.Drawing.Point(350, 171);
            this.TxtStudentLastName.Name = "TxtStudentLastName";
            this.TxtStudentLastName.Size = new System.Drawing.Size(120, 22);
            this.TxtStudentLastName.TabIndex = 2;
            // 
            // TxtStudentDebt
            // 
            this.TxtStudentDebt.Location = new System.Drawing.Point(688, 85);
            this.TxtStudentDebt.Name = "TxtStudentDebt";
            this.TxtStudentDebt.Size = new System.Drawing.Size(121, 22);
            this.TxtStudentDebt.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(540, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Kütüphane Borcu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(886, 192);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnStudentAdd
            // 
            this.BtnStudentAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(99)))), ((int)(((byte)(171)))));
            this.BtnStudentAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnStudentAdd.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnStudentAdd.Location = new System.Drawing.Point(224, 270);
            this.BtnStudentAdd.Name = "BtnStudentAdd";
            this.BtnStudentAdd.Size = new System.Drawing.Size(119, 44);
            this.BtnStudentAdd.TabIndex = 8;
            this.BtnStudentAdd.Text = "Ekle";
            this.BtnStudentAdd.UseVisualStyleBackColor = false;
            this.BtnStudentAdd.Click += new System.EventHandler(this.BtnStudentAdd_Click);
            // 
            // CmbStudentGender
            // 
            this.CmbStudentGender.FormattingEnabled = true;
            this.CmbStudentGender.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.CmbStudentGender.Location = new System.Drawing.Point(350, 206);
            this.CmbStudentGender.Name = "CmbStudentGender";
            this.CmbStudentGender.Size = new System.Drawing.Size(121, 24);
            this.CmbStudentGender.TabIndex = 3;
            // 
            // LabelStudentGender
            // 
            this.LabelStudentGender.AutoSize = true;
            this.LabelStudentGender.ForeColor = System.Drawing.SystemColors.Info;
            this.LabelStudentGender.Location = new System.Drawing.Point(259, 206);
            this.LabelStudentGender.Name = "LabelStudentGender";
            this.LabelStudentGender.Size = new System.Drawing.Size(57, 17);
            this.LabelStudentGender.TabIndex = 15;
            this.LabelStudentGender.Text = "Cinsiyet";
            // 
            // TxtStudentPassword1
            // 
            this.TxtStudentPassword1.Location = new System.Drawing.Point(688, 169);
            this.TxtStudentPassword1.Name = "TxtStudentPassword1";
            this.TxtStudentPassword1.Size = new System.Drawing.Size(121, 22);
            this.TxtStudentPassword1.TabIndex = 6;
            // 
            // TxtStudentPassword2
            // 
            this.TxtStudentPassword2.Location = new System.Drawing.Point(688, 203);
            this.TxtStudentPassword2.Name = "TxtStudentPassword2";
            this.TxtStudentPassword2.Size = new System.Drawing.Size(121, 22);
            this.TxtStudentPassword2.TabIndex = 7;
            // 
            // TxtStudentUserName
            // 
            this.TxtStudentUserName.Location = new System.Drawing.Point(688, 127);
            this.TxtStudentUserName.Name = "TxtStudentUserName";
            this.TxtStudentUserName.Size = new System.Drawing.Size(121, 22);
            this.TxtStudentUserName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(520, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Öğrenci Kullanıcı Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(621, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(581, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Şifre Tekrar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(219)))));
            this.label13.Location = new System.Drawing.Point(316, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(413, 28);
            this.label13.TabIndex = 39;
            this.label13.Text = "Ögrenci Kisisel Bilgisi Sayfasi";
            // 
            // StudentInformationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(122)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1013, 565);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtStudentUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtStudentPassword2);
            this.Controls.Add(this.TxtStudentPassword1);
            this.Controls.Add(this.LabelStudentGender);
            this.Controls.Add(this.CmbStudentGender);
            this.Controls.Add(this.BtnStudentAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtStudentDebt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtStudentLastName);
            this.Controls.Add(this.TxtStudentName);
            this.Controls.Add(this.TxtStudentId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnStudentDelete);
            this.Controls.Add(this.BtnStudentUpdate);
            this.Controls.Add(this.BtnStudentList);
            this.Name = "StudentInformationUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Bilgi Düzenleme Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStudentList;
        private System.Windows.Forms.Button BtnStudentUpdate;
        private System.Windows.Forms.Button BtnStudentDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtStudentId;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.TextBox TxtStudentLastName;
        private System.Windows.Forms.TextBox TxtStudentDebt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnStudentAdd;
        private System.Windows.Forms.ComboBox CmbStudentGender;
        private System.Windows.Forms.Label LabelStudentGender;
        private System.Windows.Forms.TextBox TxtStudentPassword1;
        private System.Windows.Forms.TextBox TxtStudentPassword2;
        private System.Windows.Forms.TextBox TxtStudentUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
    }
}