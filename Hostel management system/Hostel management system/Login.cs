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
            if(NameText.Text == " " ||  emailText.Text == " ")
            {
                MessageBox.Show("please fill all fields");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand ("select count (*) from account where u_id = '"+NameText.Text+"'",con);
                int a = (int)cmd.ExecuteScalar();
                if (a > 0)
                {
                    MessageBox.Show("Record already exist");
                }
                else
                {
                    con.Close();
                    con.Open();
                    string haji = "insert into account (u_id,u_pass) values ('" + NameText.Text + "','"+emailText.Text+"')";
                    SqlCommand cmd1 = new SqlCommand(haji, con);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("saved...");
                    NameText.Clear();
                    emailText.Clear();
                    con.Close();

                    Form1 open = new Form1();
                    open.Show();
                    this.Hide();
                        
                }
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
