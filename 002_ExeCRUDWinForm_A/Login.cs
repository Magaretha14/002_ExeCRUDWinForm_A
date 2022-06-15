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
    public partial class MyVaksin : Form
    {
        readonly string Username = "MagarethaWS";
        readonly string Password = "Put1414";
        public MyVaksin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == Username && textPassword.Text == Password && checkBox1.Checked == true)
            {
                new MainMenu().Show();
                this.Hide();
            }
            else if (textUsername.Text == "" && textPassword.Text == "")
            {
                MessageBox.Show("Anda belum mengisi username dan password. Username = MagarethaWS, Password = Put1414");
            }
            else if (textUsername.Text == Username && textPassword.Text == "")
            {
                MessageBox.Show("Password Salah");
            }
            else if (textUsername.Text == "" && textPassword.Text == Password)
            {
                MessageBox.Show("Username Salah");
            }
            else if (textUsername.Text == Username && textPassword.Text == Password && checkBox1.Checked == false)
            {
                MessageBox.Show("Setujui term and conditions terlebih dahulu");
            }
            else
            {
                MessageBox.Show("Username dan Password Salah. Username = MagarethaWS, Password = Put1414");
                textUsername.Clear();
                textPassword.Clear();
                textUsername.Focus();
                textPassword.Focus();
            }

        }
    }
}
