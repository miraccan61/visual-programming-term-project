
namespace LibraryManagement.Personal.CRUD
{
    partial class CategoryInformationUI
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
            this.TxtCatId = new System.Windows.Forms.TextBox();
            this.TxtCatName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCatAdd = new System.Windows.Forms.Button();
            this.BtnCatList = new System.Windows.Forms.Button();
            this.BtnCatUpdate = new System.Windows.Forms.Button();
            this.BtnCatDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(73, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori ID";
            // 
            // TxtCatId
            // 
            this.TxtCatId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TxtCatId.Location = new System.Drawing.Point(189, 99);
            this.TxtCatId.Name = "TxtCatId";
            this.TxtCatId.Size = new System.Drawing.Size(136, 27);
            this.TxtCatId.TabIndex = 0;
            // 
            // TxtCatName
            // 
            this.TxtCatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TxtCatName.Location = new System.Drawing.Point(189, 153);
            this.TxtCatName.Name = "TxtCatName";
            this.TxtCatName.Size = new System.Drawing.Size(136, 27);
            this.TxtCatName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(66, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori Adı";
            // 
            // BtnCatAdd
            // 
            this.BtnCatAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.BtnCatAdd.ForeColor = System.Drawing.Color.Black;
            this.BtnCatAdd.Location = new System.Drawing.Point(387, 95);
            this.BtnCatAdd.Name = "BtnCatAdd";
            this.BtnCatAdd.Size = new System.Drawing.Size(120, 37);
            this.BtnCatAdd.TabIndex = 2;
            this.BtnCatAdd.Text = "Ekle";
            this.BtnCatAdd.UseVisualStyleBackColor = false;
            this.BtnCatAdd.Click += new System.EventHandler(this.BtnCatAdd_Click);
            // 
            // BtnCatList
            // 
            this.BtnCatList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.BtnCatList.ForeColor = System.Drawing.Color.Black;
            this.BtnCatList.Location = new System.Drawing.Point(534, 95);
            this.BtnCatList.Name = "BtnCatList";
            this.BtnCatList.Size = new System.Drawing.Size(120, 37);
            this.BtnCatList.TabIndex = 4;
            this.BtnCatList.Text = "Listele";
            this.BtnCatList.UseVisualStyleBackColor = false;
            this.BtnCatList.Click += new System.EventHandler(this.BtnCatList_Click);
            // 
            // BtnCatUpdate
            // 
            this.BtnCatUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.BtnCatUpdate.ForeColor = System.Drawing.Color.Black;
            this.BtnCatUpdate.Location = new System.Drawing.Point(387, 149);
            this.BtnCatUpdate.Name = "BtnCatUpdate";
            this.BtnCatUpdate.Size = new System.Drawing.Size(120, 37);
            this.BtnCatUpdate.TabIndex = 3;
            this.BtnCatUpdate.Text = "Güncelle";
            this.BtnCatUpdate.UseVisualStyleBackColor = false;
            this.BtnCatUpdate.Click += new System.EventHandler(this.BtnCatUpdate_Click);
            // 
            // BtnCatDelete
            // 
            this.BtnCatDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.BtnCatDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnCatDelete.Location = new System.Drawing.Point(534, 149);
            this.BtnCatDelete.Name = "BtnCatDelete";
            this.BtnCatDelete.Size = new System.Drawing.Size(120, 37);
            this.BtnCatDelete.TabIndex = 5;
            this.BtnCatDelete.Text = "Sil";
            this.BtnCatDelete.UseVisualStyleBackColor = false;
            this.BtnCatDelete.Click += new System.EventHandler(this.BtnCatDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(619, 174);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(197, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(377, 28);
            this.label13.TabIndex = 38;
            this.label13.Text = "Kategori Hakkinda Sayfasi";
            // 
            // CategoryInformationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(747, 436);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnCatDelete);
            this.Controls.Add(this.BtnCatUpdate);
            this.Controls.Add(this.BtnCatList);
            this.Controls.Add(this.BtnCatAdd);
            this.Controls.Add(this.TxtCatName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCatId);
            this.Controls.Add(this.label1);
            this.Name = "CategoryInformationUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Düzenleme Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCatId;
        private System.Windows.Forms.TextBox TxtCatName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCatAdd;
        private System.Windows.Forms.Button BtnCatList;
        private System.Windows.Forms.Button BtnCatUpdate;
        private System.Windows.Forms.Button BtnCatDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label13;
    }
}