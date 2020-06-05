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
    public partial class FormDisplayRoom : Form
    {
        public FormDisplayRoom()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (FormLoginAs.ln == "manager")
            {
                this.Hide();
                FormManager m = new FormManager();
                m.Show();
            }
            else
            {
                this.Hide();
                FormAdmin m = new FormAdmin();
                m.Show();
            }
        }
        public string sqlconn = @"Data Source=.\SQLEXPRESS2012;Initial Catalog=Hotel;User id=sa; password=123456789";
        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(sqlconn);
            string sql = "";
            if (comboBox1.Text == "ALL ROOMS")
                sql = "SELECT * FROM ROOM";
            else if (comboBox1.Text == "RESERVED ROOMS")
                sql = "SELECT * FROM ROOM WHERE Status='False'";
            else if (comboBox1.Text == "AVAILABLE ROOMS")
                sql = "SELECT * FROM ROOM WHERE Status='True'";
            else
            {
                MessageBox.Show("Please select any option");
                return;
            }
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataadapter.Fill(ds, "Room_table");
            conn.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Room_table";
        }

        
    }
}
