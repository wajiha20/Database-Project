using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationProject
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReserveRoom a = new FormReserveRoom();
            a.Show();
        }

        private void displyRomBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDisplayRoom a = new FormDisplayRoom();
            a.Show();
        }

        private void otherBillBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddOtherBills a = new FormAddOtherBills();
            a.Show();
        }

        private void issueBillBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIssueBills a = new FormIssueBills();
            a.Show();
        }

        private void updProfileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChangePassword a = new FormChangePassword();
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain m = new FormMain();
            m.Show();
        }
    }
}
