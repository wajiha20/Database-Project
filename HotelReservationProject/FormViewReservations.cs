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
    public partial class FormViewReservations : Form
    {
        public FormViewReservations()
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
        private void yearlyBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlconn);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT g.Room_id  ,g.Guest_name, g.Check_in_date, g.No_of_persons , g.Phone_no , g.Stay_Limit, g.Address, g.CNIC  FROM  GUEST g WHERE year(g.Check_in_date)=year(getdate())  ", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();
        }

        private void dailyBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlconn);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT g.Room_id  ,g.Guest_name, g.Check_in_date, g.No_of_persons , g.Phone_no , g.Stay_Limit, g.Address, g.CNIC  FROM  GUEST g WHERE year(g.Check_in_date)=day(getdate())  ", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();
        }

        private void weeklyBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlconn);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT g.Room_id  ,g.Guest_name, g.Check_in_date, g.No_of_persons , g.Phone_no , g.Stay_Limit, g.Address, g.CNIC  FROM  GUEST g WHERE year(g.Check_in_date)=datepart(wk,getdate())  ", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();
        }

        private void monthlyBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlconn);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT g.Room_id  ,g.Guest_name, g.Check_in_date, g.No_of_persons , g.Phone_no , g.Stay_Limit, g.Address, g.CNIC  FROM  GUEST g WHERE year(g.Check_in_date)=month(getdate())  ", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
