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


namespace LibraryManagement.Personal.CRUD
{
    public partial class PersonalUpdateUI : Form
    {
        public PersonalUpdateUI()
        {
            InitializeComponent();
        }

        private void PersonalUpdateUI_Load(object sender, EventArgs e)
        {
        }

        private void BtnPerList_Click(object sender, EventArgs e)
        {
            
            List<EntityPersonal> PerList = LogicPersonal.LLPersonalList();
            dataGridView1.DataSource = PerList;
            dataGridView1.Columns["Repassword"].Visible = false;
        }

        private void BtnPerUpdate_Click(object sender, EventArgs e)
        {
            EntityPersonal ent = new EntityPersonal();
            ent.Id = Convert.ToInt32(TxtPerID.Text);
            ent.Name = TxtPerName.Text;
            ent.LastName = TxtPerLastName.Text;
            ent.Password = TxtPerPassword1.Text;
            ent.Repassword = TxtPerPassword2.Text;
            ent.Gender = TxtPerGender.Text;
            ent.PerUserName = TxtPerUserName.Text;
            LogicPersonal.LLPersonalGuncelle(ent);
        }

        private void BtnPerDelete_Click(object sender, EventArgs e)
        {
            EntityPersonal ent = new EntityPersonal();
            ent.Id = Convert.ToInt32(TxtPerID.Text);
            LogicPersonal.LLPersonalSil(ent.Id);
        }
        private void dataGridView1_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtPerID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtPerName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtPerLastName.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtPerGender.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtPerUserName.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
    }
}
