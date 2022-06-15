using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_ExeCRUDWinForm_A
{
    public partial class FormDaftar : Form
    {
        DataTable dt;
        DataRow dr;
        String code;

        public FormDaftar()
        {   
            InitializeComponent();

            this.formVaksinTableAdapter1.Fill(this.vaksinDataSet.FormVaksin);
            this.formVaksinTableAdapter1.Fill(this.vaksinDataSet.FormVaksin);
            txtid.Enabled = false;
            txtnama.Enabled = false;
            txtnik.Enabled = false;
            txtttl.Enabled = false;
            txtalamat.Enabled = false;
            btnSave.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDaftar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vaksinDataSet1.FormVaksin' table. You can move, or remove it, as needed.
            this.formVaksinTableAdapter1.Fill(this.vaksinDataSet1.FormVaksin);
            // TODO: This line of code loads data into the 'vaksinDataSet.FormVaksin' table. You can move, or remove it, as needed.
            this.formVaksinTableAdapter.Fill(this.vaksinDataSet.FormVaksin);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }
    }
}
