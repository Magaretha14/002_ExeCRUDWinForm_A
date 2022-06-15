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

            this.formVaksinTableAdapter1.Fill(this.vaksinDataSet1.FormVaksin);
            this.formVaksinTableAdapter1.Fill(this.vaksinDataSet1.FormVaksin);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            txtnama.Enabled = true;
            txtnik.Enabled = true;
            txtttl.Enabled = true;
            txtalamat.Enabled = true;
            txtnama.Text = "";
            txtnik.Text = "";
            txtttl.Text = "";
            txtalamat.Text = "";
            int ctr, len;
            string codeval;
            dt = vaksinDataSet1.Tables["FormVaksin"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["id"].ToString();
            codeval = code.Substring(1, 3);
            ctr = Convert.ToInt32(codeval);
            if ((ctr >= 1) && (ctr < 9))
            {
                ctr = ctr + 1;
                txtid.Text = "V00" + ctr;
            }
            else if ((ctr >= 9) && (ctr < 9))
            {
                ctr = ctr + 1;
                txtid.Text = "V" + ctr;
            }

            btnAdd.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dt = vaksinDataSet1.Tables["FormVaksin"];
            dr = dt.NewRow();
            dr[0] = txtid.Text;
            dr[1] = txtnama.Text;
            dr[2] = txtnik.Text;
            dr[3] = txtttl.Text;
            dr[4] = txtalamat.Text;
            dt.Rows.Add(dr);
            formVaksinTableAdapter1.Update(vaksinDataSet1);
            txtid.Text = System.Convert.ToString(dr[0]);
            txtid.Enabled = false;
            txtnama.Enabled = false;
            txtnik.Enabled = false;
            txtttl.Enabled = false;
            txtalamat.Enabled = false;
            this.formVaksinTableAdapter1.Fill(this.vaksinDataSet1.FormVaksin);
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string code;
            code = txtid.Text;
            dr = vaksinDataSet1.Tables["FormVaksin"].Rows.Find(code);
            dr.Delete();
            formVaksinTableAdapter1.Update(vaksinDataSet1);
        }
    }
}
