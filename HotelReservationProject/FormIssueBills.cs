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
    public partial class FormIssueBills : Form
    {
        public FormIssueBills()
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
        private void button2_Click(object sender, EventArgs e)
        {

            //        if (string.IsNullOrEmpty(textBox1.Text))
            //            MessageBox.Show("Please Fill all the Fields");
            //            return;
            //        }
            //        SqlConnection conn = new SqlConnection(sqlconn);
            //        conn.Open();
            //        SqlCommand cmd = new SqlCommand("select Guest_Name from Guest_Info where Guest_ID='" + GuestIDtxt.Text + "'", conn);
            //        SqlDataReader reader = cmd.ExecuteReader();
            //        if (!reader.HasRows)
            //        {
            //            MessageBox.Show("Guest ID is Invalid");
            //            return;
            //        }
            //        reader.Close();
            //        string name = (string)cmd.ExecuteScalar();
            //        if (name != Nametxt.Text)
            //        {
            //            MessageBox.Show("Guest Name is Invalid");
            //            return;
            //        }
            //        reader.Close();
            //        storeGuestID = GuestIDtxt.Text;
            //        Int32 billID, roomCrg, extCrg, extID, roomNo;
            //        DateTime arr;
            //        cmd.CommandText = "select max(Bill_ID) from Bill";
            //        billID = (Int32)cmd.ExecuteScalar();
            //        billID++;
            //        reader.Close();
            //        cmd.CommandText = "select Room_No,Charges_Per_Day from Room where Guest_ID='" + GuestIDtxt.Text + "'";
            //        reader = cmd.ExecuteReader();
            //        if (!reader.HasRows)
            //        {
            //            MessageBox.Show("invalid Guest ID");
            //            return;
            //        }
            //        reader.Read();
            //        roomNo = (Int32)reader["Room_No"];
            //        roomCrg = (Int32)reader["Charges_Per_Day"];
            //        reader.Close();
            //        cmd.CommandText = "select Arrival_Date from Guest_Info where Guest_ID='" + GuestIDtxt.Text + "'";
            //        arr = (DateTime)cmd.ExecuteScalar();
            //        reader.Close();
            //        cmd.CommandText = "select Food_Charges+Laundry_Charges from Unpaid_Dues where Guest_ID='" + GuestIDtxt.Text + "'";
            //        reader = cmd.ExecuteReader();
            //        if (reader.HasRows)
            //        {
            //            reader.Close();
            //            extCrg = (Int32)cmd.ExecuteScalar();
            //            reader.Close();
            //            cmd.CommandText = "select ExtraBill_ID from Extra_Bill where Guest_ID='" + GuestIDtxt.Text + "'";
            //            extID = (Int32)cmd.ExecuteScalar();
            //            cmd.CommandText = ("insert into Bill values(@billID1,@roomCrg1*(Day(getdate())-(Day(@arr1))),CAST(@arr1 as DATE),CAST(getdate() as DATE),@extCrg1,@extID1,@roomNo1,'" + GuestIDtxt.Text + "')");
            //            cmd.Parameters.AddWithValue("@billID1", billID);
            //            cmd.Parameters.AddWithValue("@roomCrg1", roomCrg);
            //            cmd.Parameters.AddWithValue("@arr1", arr);
            //            cmd.Parameters.AddWithValue("@extCrg1", extCrg);
            //            cmd.Parameters.AddWithValue("@extID1", extID);
            //            cmd.Parameters.AddWithValue("@roomNo1", roomNo);
            //            cmd.ExecuteReader();
            //        }
            //        else
            //        {
            //            cmd.CommandText = ("insert into Bill values(@billID1,@roomCrg1*(Day(getdate())-(Day(@arr1))),CAST(@arr1 as DATE),CAST(getdate() as DATE),0,NULL,@roomNo1,'" + GuestIDtxt.Text + "')");
            //            cmd.Parameters.AddWithValue("@billID1", billID);
            //            cmd.Parameters.AddWithValue("@roomCrg1", roomCrg);
            //            cmd.Parameters.AddWithValue("@arr1", arr);
            //            cmd.Parameters.AddWithValue("@roomNo1", roomNo);
            //            reader.Close();
            //            reader = cmd.ExecuteReader();
            //        }
            //        reader.Close();
            //        SqlCommand cmd1 = new SqlCommand("update Room set status='Available' where Guest_ID='" + GuestIDtxt.Text + "'", conn);
            //        reader = cmd1.ExecuteReader();
            //        reader.Close();
            //        SqlCommand cmd2 = new SqlCommand("update Room set Guest_ID = NULL where Guest_ID='" + GuestIDtxt.Text + "'", conn);
            //        reader = cmd2.ExecuteReader();
            //        reader.Close();
            //        Int32 ID1, ID3;
            //        SqlCommand cmd3 = new SqlCommand("select max(ExtraBill_ID) from Extra_Bill", conn);
            //        reader.Close();
            //        ID1 = (Int32)cmd3.ExecuteScalar();
            //        ID1++;
            //        SqlCommand cmd4 = new SqlCommand("select UnpaidDues_ID from Unpaid_Dues where Guest_ID='" + GuestIDtxt.Text + "'", conn);
            //        reader.Close();
            //        reader = cmd4.ExecuteReader();
            //        if (reader.HasRows)
            //        {
            //            reader.Close();
            //            ID3 = (Int32)cmd4.ExecuteScalar();
            //            SqlCommand cmd5 = new SqlCommand("insert into Extra_Bill values (@eID1,'" + GuestIDtxt.Text + "',@eID3)", conn);
            //            cmd5.Parameters.AddWithValue("@eID1", ID1);
            //            cmd5.Parameters.AddWithValue("@eID3", ID3);
            //            reader.Close();
            //            reader = cmd5.ExecuteReader();
            //        }
            //        else
            //        {
            //            reader.Close();
            //            SqlCommand cmd5 = new SqlCommand("insert into Extra_Bill values (@eID1,'" + GuestIDtxt.Text + "',NULL)", conn);
            //            cmd5.Parameters.AddWithValue("@eID1", ID1);
            //            reader = cmd5.ExecuteReader();
            //        }
            //        GenerateReceipt r = new GenerateReceipt();
            //        this.Hide();
            //        r.Show();
            //        r.textBox8_TextChanged(sender, e);
            //        r.GuestIDtxt_TextChanged(sender, e);
            //        r.RoomCrgtxt_TextChanged(sender, e);
            //        r.BillIDtxt_TextChanged(sender, e);
            //        r.ExtraCrgtxt_TextChanged(sender, e);
            //        r.StayLimittxt_TextChanged(sender, e);
            //        r.TotalCrgtxt_TextChanged(sender, e);
            //    }
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}