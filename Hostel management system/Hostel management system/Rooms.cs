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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-O7OKFA7\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");
        void FillRoomDGv()
        {
            con.Open();
            string myquery = "Select * from rooms";
            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            FillRoomDGv();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }
        string roombooked;
        private void button1_Click(object sender, EventArgs e)
        {

            if (room_number.Text == "")
            {
                MessageBox.Show("Enter the room number");
            }
            else
            {
                if (Yesradio.Checked == true)
                    roombooked = "Busy";
                else
                    roombooked = "Free";

                con.Open();
                string query = "insert into rooms values('" + room_number.Text + "','" + room_status.SelectedItem.ToString() + "','" + roombooked + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Successfully added");
                con.Close();
                FillRoomDGv();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (room_number.Text == "")
            {
                MessageBox.Show("Enter the room number");
            }
            else
            {


                con.Open();
                string query = "delete from rooms where room_num=" + room_number.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Successfully deleted");
                con.Close();
                FillRoomDGv();
            }
        }

        private void RoomDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            room_number.Text= RoomDGV.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void room_number_OnValueChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (room_number.Text == "")
            {
                MessageBox.Show("Enter the room number");
            }
            else
            {
                if (Yesradio.Checked == true)
                    roombooked = "Busy";
                else
                    roombooked = "Free";

                con.Open();
                string query = "update rooms set room_status='" + room_status.SelectedItem.ToString() + "',Booked = '" + roombooked + "' where room_num='" + room_number.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Successfully Updated");
                con.Close();
                FillRoomDGv();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}



            