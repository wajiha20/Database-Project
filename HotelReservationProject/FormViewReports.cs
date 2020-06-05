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
    public partial class FormViewReports : Form
    {
        public FormViewReports()
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
        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlconn);
            con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT  r.Charges_per_day, r.Capacity, g.Room_id ,g.Guest_name, g.Check_in_date, g.Check_out_date, g.No_of_persons , g.Phone_no , g.Stay_limit, g.Address, g.CNIC , b.Bill_id , b.Room_charges , b.Check_in_date , b.Check_out_date, b.Extra_dues , b.Extrabill_id FROM  GUEST g , ROOM r , BILL b WHERE month(g.Check_in_date)=month(getdate())  AND g.Room_id=r.Room_id AND b.Room_id=g.Room_id", con);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT   g.Room_id ,g.Guest_name, g.Phone_no , g.Stay_limit,g.Address, g.CNIC  ,b.Extradues FROM  GUEST g , ROOM r ,BILLS b WHERE month(g.Check_in_date)=month(getdate())  AND g.Room_id=r.Room_id AND b.Room_id=r.Room_id", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlconn);
            con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT  r.Charges_per_day, r.Capacity, g.Room_id ,g.Guest_name, g.Check_in_date, g.Check_out_date, g.No_of_persons , g.Phone_no , g.Stay_limit, g.Address, g.CNIC , b.Bill_id , b.Room_charges , b.Check_in_date , b.Check_out_date , b.Extra_dues , b.Extrabill_id FROM  GUEST g , ROOM r , BILL b WHERE year(gi.arrival_date)=year(getdate())  AND g.Room_id=r.Room_id AND b.Room_id=g.Room_id", con);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT  r.Charges_per_day, r.Capacity, g.Room_id ,g.Guest_name, g.Check_in_date, g.Check_out_date, g.No_of_persons , g.Phone_no , g.Stay_limit, g.Address, g.CNIC  FROM  GUEST g , ROOM r , BILL b WHERE month(g.Check_in_date)=month(getdate())  AND g.Room_id=r.Room_id AND b.Room_id=g.Room_id", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();
        }
    }
}
