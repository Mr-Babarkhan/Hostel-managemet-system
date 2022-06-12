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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-O7OKFA7\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");
        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (studentid.Text == "" || studentname.Text == "" || student_fname.Text == "" || studentaddress.Text == "" || student_phone.Text == "" || student_email.Text == "" || student_clg.Text == "")
            {
                MessageBox.Show("Please fill empty spaces");
            }
            else
            {
               

                con.Open();
                string std = "insert into student values('" + studentid.Text + "','" + studentname.Text + "','" + student_fname.Text + "','" + studentaddress.Text + "','" + student_phone.Text + "','" + student_email.Text + "','" + student_clg.Text + "','" + stud_room.SelectedItem.ToString() + "','" + stud_status.SelectedItem.ToString() + "')";
                SqlCommand cmd = new SqlCommand(std, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Successfully added");
                con.Close();
                //FillRoomDGv();
            }
        }
    }
}
