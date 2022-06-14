using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hostel_management_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-O7OKFA7\\SQLEXPRESS;Initial Catalog=Hostel Management System;Integrated Security=True");
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
            if (emailText.Text == "Password")
            {
                emailText.Text = "";
                emailText.ForeColor = Color.Black;
            }
        }

        private void emailText_Leave(object sender, EventArgs e)
        {
            if (emailText.Text == "")
            {
                emailText.Text = "Password";
                emailText.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = NameText.Text;
            string pass = emailText.Text;

            if (username.Equals("Admin") && pass.Equals("123"))
            {
                Form1 Home = new Form1();
                Home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }

          
                        
            
           
        }

        private void emailText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        }
}
