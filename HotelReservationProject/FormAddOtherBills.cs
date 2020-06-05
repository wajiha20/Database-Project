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

namespace HotelReservationProject
{
    public partial class FormAddOtherBills : Form
    {
        public FormAddOtherBills()
        {
            InitializeComponent();
        }
        public string sqlconn = @"Data Source=.\SQLEXPRESS2012;Initial Catalog=Hotel;User id=sa; password=123456789";

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from ROOM where Room_id='" + textBox1.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("this room does not exist");
                return;
            }
            reader.Close();
            cmd.CommandText = "insert into UNPAID_CHARGE values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" +textBox5.Text + "')";
            //cmd.Parameters.AddWithValue("@ID", userId);
            reader = cmd.ExecuteReader();
            reader.Close();
            cmd.CommandText = "select max(Extrabill_id) from EXTRA_BILLS";
            reader = cmd.ExecuteReader();
            reader.Close();
            Int32 extId = (Int32)cmd.ExecuteScalar();
            extId++;
            cmd.CommandText = "insert into EXTRA_BILLS values(@extraID,'" + textBox1.Text + "')";
            cmd.Parameters.AddWithValue("@extraID", extId);
            reader = cmd.ExecuteReader();
            backBtn_Click(sender, e);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager m = new FormManager();
            m.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
