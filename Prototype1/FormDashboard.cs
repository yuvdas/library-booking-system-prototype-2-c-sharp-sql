using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Prototype1
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            if (Global.globalSettingsVisible == true)
            {
                buttonDashboardSettings.Visible = true;
            }
        }

        private void buttonDashboardDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard LoadDashboard = new FormDashboard();//creates method
            LoadDashboard.ShowDialog();//loads form
        }

        private void buttonDashboardBookings_Click(object sender, EventArgs e)
        {
            FormBookings LoadBookings = new FormBookings();//creates method
            LoadBookings.ShowDialog();//loads form
        }

        private void buttonDashboardBooks_Click(object sender, EventArgs e)
        {
            FormBooks LoadBooks = new FormBooks();//creates method
            LoadBooks.ShowDialog();//loads form
        }

        private void buttonDashboardUsers_Click(object sender, EventArgs e)
        {
            FormUsers LoadUsers = new FormUsers();//creates method
            LoadUsers.ShowDialog();//loads form
        }

        private void buttonDashboardSettings_Click(object sender, EventArgs e)
        {
            FormSettings LoadSettings = new FormSettings();//creates method
            LoadSettings.ShowDialog();//loads form
        }

        private void buttonDashboardLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();//restarts form back to login page
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewUpcomingDeadlines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet2.Bookings' table. You can move, or remove it, as needed.
            this.bookingsTableAdapter.Fill(this.databaseDataSet2.Bookings);
            // TODO: This line of code loads data into the 'databaseDataSet1.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter1.Fill(this.databaseDataSet1.Books);
            // TODO: This line of code loads data into the 'databaseDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.databaseDataSet.Books);

        }
    }
}
