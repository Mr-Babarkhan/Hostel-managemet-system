using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_management_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void NameText_Enter(object sender, EventArgs e)
        {
            if (NameText.Text == "Enter username")
            {
                NameText.Text = "";
                NameText.ForeColor = Color.Black;
            }
        }
        private void NameText_Leave(object sender, EventArgs e)
        {
            if (NameText.Text == "")
            {
                NameText.Text = "Enter username";
                NameText.ForeColor = Color.Silver;
            }
        }
        private void emailText_Enter(object sender, EventArgs e)
        {
            if (emailText.Text == "Email")
            {
                emailText.Text = "";
                emailText.ForeColor = Color.Black;
            }
        }

        private void emailText_Leave(object sender, EventArgs e)
        {
            if (emailText.Text == "")
            {
                emailText.Text = "Email";
                emailText.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
            this.Hide();
        }
        
        }
}
