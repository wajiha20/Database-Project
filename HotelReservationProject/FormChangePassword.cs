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
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager m = new FormManager();
            m.Show();
        }
        public string sqlconn = @"Data Source=.\SQLEXPRESS2012;Initial Catalog=Hotel;User id=sa; password=123456789";
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Password from LOGINS where User_name='Manager' or User_name='Admin'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            string pwd = (string)cmd.ExecuteScalar();
            if (pwd != textBox1.Text)
            {
                MessageBox.Show("Please Enter Correct Current Password");
                return;
            }
            cmd.CommandText = "update LOGINS set Password='" + textBox2.Text + "' where User_name='Manager' or User_name='Admin'";
            reader = cmd.ExecuteReader();
            if (FormLoginAs.ln == "manager")
            {
                this.Hide();
                FormManager m = new FormManager();
                m.Show();
            }
            else
            {
                this.Hide();
                FormAdmin a = new FormAdmin();
                a.Show();
            }
        }
    }
}
