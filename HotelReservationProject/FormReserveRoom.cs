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
    public partial class FormReserveRoom : Form
    {
        public FormReserveRoom()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager m = new FormManager();
            m.Show();
        }
        public string sqlconn = @"Data Source=.\SQLEXPRESS2012;Initial Catalog=Hotel;User id=sa; password=123456789";
        private void DoneBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Please Fill all the Fields");
                return;
            }

            SqlConnection con = new SqlConnection(sqlconn);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ROOM where ROOM_ID='" + textBox6.Text + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Room does not exist");
                return;
            }
            SqlCommand c2 = new SqlCommand("select * from ROOM where STATUS='TRUE'", con);
            reader.Close();
            reader = c2.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("No Room Available");
                reader.Close();
                backBtn_Click(sender, e);
                return;
            }
            SqlCommand c3 = new SqlCommand("select Capacity from ROOM where Room_id='" + textBox6.Text + "' and Status ='TRUE'", con);
            reader.Close();
            reader = c3.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Room already reserved");
                return;
            }
            reader.Close();
            Int32 cap = (Int32)c3.ExecuteScalar();
            if (Convert.ToInt32(textBox3.Text) > cap)
            {
                MessageBox.Show("No Of Persons are Greater than Room Capacity");
                return;
            }
            SqlCommand altRoom1 = new SqlCommand("update ROOM set Status='False' where Room_id='" + textBox6.Text + "'", con);
            SqlCommand insGuestInfo = new SqlCommand("insert into GUEST values ('" + textBox2.Text + "','" + textBox5.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox7.Text + "','" + textBox4.Text + "','" + textBox6.Text + "',CAST(getdate() as DATE), (DAY(getdate()) + '" + textBox7.Text + "'))" , con);

            reader.Close();
            reader = altRoom1.ExecuteReader();
            reader.Close();
            reader = insGuestInfo.ExecuteReader();
            reader.Close();

            this.Hide();
            FormManager m = new FormManager();
            m.Show();
            backBtn_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormReserveRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
