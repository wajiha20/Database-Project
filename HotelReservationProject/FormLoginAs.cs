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
    public partial class FormLoginAs : Form
    {
        public static string ln;
        public FormLoginAs()
        {
            InitializeComponent();
        }
        public static string username;
        public string sqlconn = @"Data Source=.\SQLEXPRESS2012;Initial Catalog=Hotel;User id=sa; password=123456789";
        private void enterBtn_Click(object sender, EventArgs e)
        {
            string log = textBox2.Text;
            string pass = textBox1.Text;
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Fill all the fields");
                return;
            }
            
            using (SqlConnection Conn = new SqlConnection(sqlconn))
            {
                if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Please Fill all the fields");
                    return;
                }
                Conn.Open();
                String query = String.Format(@"select * from dbo.LOGIN where User_name='{0}' and Password='{1}'", log, pass);
                SqlCommand comm = new SqlCommand(query, Conn);
                SqlDataReader rd = comm.ExecuteReader();

                if (!rd.HasRows)
                {
                    MessageBox.Show("Ivalid Email ID or Password");
                    return;
                }
                rd.Close();
                Int32 id = (Int32)comm.ExecuteScalar();
                if (id == 1)
                {
                    ln = "admin";
                    this.Hide();
                    FormAdmin a = new FormAdmin();
                    a.Show();
                }
                else if (id == 0)
                {
                    ln = "manager";
                    this.Hide();
                    FormManager m = new FormManager();
                    m.Show();
                }

                else
                {
                    MessageBox.Show("LOGIN FAILED");
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain m = new FormMain();
            m.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
