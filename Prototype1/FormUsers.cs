using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype1
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void buttonUsersAdd_Click(object sender, EventArgs e)
        {
            string forename = textBoxUsersAddForename.Text;//saves to variable
            string surname = textBoxUsersAddSurname.Text;//saves to variable
            string email = textBoxUsersAddAddress.Text;//saves to variable
            string phone = textBoxUsersAddPhone.Text;//saves to variable
            Db.AddUser(forename, surname, email, phone);//uses function
        }

        private void buttonUsersUpdate_Click(object sender, EventArgs e)
        {
            string user_id = textBoxUsersUpdateUserID.Text;//saves to variable
            string forename = textBoxUsersAddForename.Text;//saves to variable
            string surname = textBoxUsersAddSurname.Text;//saves to variable
            string email = textBoxUsersAddAddress.Text;//saves to variable
            string phone = textBoxUsersAddPhone.Text;//saves to variable
            Db.UpdateUser(forename, surname, email, phone, user_id);//uses function
        }

        private void buttonUsersDelete_Click(object sender, EventArgs e)
        {
            string user_id = textBoxUsersDeleteUserID.Text;//saves to variable
            Db.DeleteUser(user_id);//uses function
        }

        private void buttonUsersDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard LoadDashboard = new FormDashboard();//creates method
            LoadDashboard.ShowDialog();//loads form
        }

        private void buttonUsersBookings_Click(object sender, EventArgs e)
        {
            FormBookings LoadBookings = new FormBookings();//creates method
            LoadBookings.ShowDialog();//loads form
        }

        private void buttonUsersBooks_Click(object sender, EventArgs e)
        {

            FormBooks LoadBooks = new FormBooks();//creates method
            LoadBooks.ShowDialog();//loads form
        }

        private void buttonUsersUsers_Click(object sender, EventArgs e)
        {
            FormUsers LoadUsers = new FormUsers();//creates method
            LoadUsers.ShowDialog();//loads form
        }

        private void buttonUsersSettings_Click(object sender, EventArgs e)
        {

            FormSettings LoadSettings = new FormSettings();//creates method
            LoadSettings.ShowDialog();//loads form
        }

        private void buttonUsersLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();//restarts form back to login page
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet3.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.databaseDataSet3.Users);
            // TODO: This line of code loads data into the 'databaseDataSet4.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.databaseDataSet4.Staff);

        }
    }
}
