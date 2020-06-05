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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }

        private void displyRomBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDisplayRoom a = new FormDisplayRoom();
            a.Show();
        }

        private void resrvationRoomBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormViewReservations a = new FormViewReservations();
            a.Show();
        }

        private void viewReportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormViewReports a = new FormViewReports();
            a.Show();
        }

        private void updRateBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
           FormUpdateRates a = new FormUpdateRates();
            a.Show();
        }

        private void updProfileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChangePassword a = new FormChangePassword();
            a.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain m = new FormMain();
            m.Show();
        }
    }
}
