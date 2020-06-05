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
    public partial class FormUpdateRates : Form
    {
        public FormUpdateRates()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager m = new FormManager();
            m.Show();
        }

        private void FormUpdateRates_Load(object sender, EventArgs e)
        {

        }
        public string sqlconn = @"Data Source=.\SQLEXPRESS2012;Initial Catalog=Hotel;User id=sa; password=123456789";
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            SqlConnection con = new SqlConnection(sqlconn);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Charges_per_day from ROOM where Room_id='" + textBox1.Text + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Room does not exist");
                return;
            }
            reader.Close();
            Int32 charges = (Int32)cmd.ExecuteScalar();
            if (Convert.ToInt32(textBox2.Text) != charges)
            {
                MessageBox.Show("Please enter Correct Current Rate");
                return;
            }
            reader.Close();
            cmd.CommandText = "update ROOM set Charges_per_day='" + textBox3.Text + "' where Room_id='" + textBox1.Text + "'";
            reader = cmd.ExecuteReader();
            reader.Close();
            backBtn_Click(sender, e);
        }
    }
}
