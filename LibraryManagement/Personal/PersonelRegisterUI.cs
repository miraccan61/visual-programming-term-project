using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;
// ALTER TABLE WriterTable ALTER COLUMN WriterID AUTOINCREMENT(1,1)
namespace LibraryManagement.Personal
{
    public partial class PersonelRegisterUI : Form
    {
        public PersonelRegisterUI()
        {
            InitializeComponent();
        }

        private void BtnSavePersonal_Click(object sender, EventArgs e)
        {
            EntityPersonal ent = new EntityPersonal();
            ent.PersonelName = TxtPersonalName.Text;
            ent.PersonelLastName = TxtPersonalLastName.Text;
            ent.PersonelPassword = TxtPersonalPassword.Text;
            ent.PersonelRepassword = TxtPersonalPassword2.Text;
            ent.PersonelUserName = TxtPerUserName.Text;
            ent.PersonelGender = CmbGender.Text;
            if (TxtPersonalPassword.Text == TxtPersonalPassword2.Text)
            {
                LogicPersonal.LLPersonalSave(ent);
                MessageBox.Show("Başarılı Bir Şekilde Kayıt Oldunuz");
                TxtPersonalName.Text = "";
                TxtPersonalLastName.Text = "";
                TxtPersonalPassword.Text = "";
                TxtPersonalPassword2.Text = "";
                TxtPerUserName.Text = "";
                CmbGender.Text = "";

            }
            else
            {
                MessageBox.Show("Şifreleriniz Uyuşmuyor Lütfen Kontrol Ediniz");
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonal> PerList = LogicPersonal.LLPersonalList();
            dataGridView1.DataSource = PerList;
            dataGridView1.Columns["PersonelRepassword"].Visible = false;
            dataGridView1.Columns["PersonelPassword"].Visible = false;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            EntityPersonal ent = new EntityPersonal();
            ent.PersonelId = Convert.ToInt32(TxtID.Text);
            ent.PersonelName = TxtPersonalName.Text;
            ent.PersonelLastName = TxtPersonalLastName.Text;
            ent.PersonelPassword = TxtPersonalPassword.Text;
            ent.PersonelRepassword = TxtPersonalPassword2.Text;
            ent.PersonelUserName = TxtPerUserName.Text;
            ent.PersonelGender = CmbGender.Text;
            if (TxtPersonalPassword.Text == TxtPersonalPassword2.Text)
            {
                LogicPersonal.LLPersonalUpdate(ent);
                MessageBox.Show("Başarılı Bir Şekilde Profilinizi Güncellediniz");
                TxtPersonalName.Text = "";
                TxtPersonalLastName.Text = "";
                TxtPersonalPassword.Text = "";
                TxtPersonalPassword2.Text = "";
                TxtPerUserName.Text = "";
                CmbGender.Text = "";

            }
            else
            {
                MessageBox.Show("Şifreleriniz Uyuşmuyor Lütfen Kontrol Ediniz");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (TxtID.Text != "")
            {
                EntityPersonal ent = new EntityPersonal();
                ent.PersonelId = Convert.ToInt32(TxtID.Text);
                LogicPersonal.LLPersonalDelete(ent.PersonelId);
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi");
                TxtPersonalName.Text = "";
                TxtPersonalLastName.Text = "";
                TxtPersonalPassword.Text = "";
                TxtPersonalPassword2.Text = "";
                TxtPerUserName.Text = "";
                CmbGender.Text = "";
            }
            else
            {
                MessageBox.Show("ID Alanını Boş Bırakmayınız");
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtPerUserName.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtPersonalName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtPersonalLastName.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbGender.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
