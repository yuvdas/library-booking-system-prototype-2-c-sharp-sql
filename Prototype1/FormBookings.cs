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
    public partial class FormBookings : Form
    {
        public FormBookings()
        {
            InitializeComponent();
        }

        private void buttonBookingsDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard LoadDashboard = new FormDashboard();//creates method
            LoadDashboard.ShowDialog();//loads form
        }

        private void buttonBookingsAdd_Click(object sender, EventArgs e)
        {
            string bookingRoom = textBoxBookingsAddRoom.Text;//saves to variable
            string bookingEvent = textBoxBookingsAddEvent.Text;//saves to variable
            string bookingDD = textBoxBookingsAddDay.Text;//saves to variable
            string bookingMM = textBoxBookingsAddMonth.Text;//saves to variable
            string bookingTime = textBoxBookingsAddHour.Text;//saves to variable
            string user_id = textBoxBookingsAddUserID.Text;//saves to variable
            string bookingDate = bookingDD + "/" + bookingMM + "/" + DateTime.Now.ToString();//gets data in date format
            Db.AddBooking(bookingRoom, bookingEvent, bookingDate, bookingTime, user_id);//uses function
        }

        private void buttonBookingsUpdate_Click(object sender, EventArgs e)
        {
            string booking_id = textBoxBookingsUpdateBookingID.Text;//saves to variable
            string bookingRoom = textBoxBookingsUpdateRoom.Text;//saves to variable
            string bookingEvent = textBoxBookingsUpdateEvent.Text;//saves to variable
            string bookingDD = textBoxBookingsUpdateDay.Text;//saves to variable
            string bookingMM = textBoxBookingsUpdateMonth.Text;//saves to variable
            string bookingTime = textBoxBookingsUpdateHour.Text;//saves to variable
            string user_id = textBoxBookingsUpdateUserID.Text;//saves to variable
            string bookingDate = bookingDD + "/" + bookingMM + "/" + DateTime.Now.ToString();//gets data in date format
            Db.UpdateBooking(booking_id, bookingRoom, bookingEvent, bookingDate, bookingTime, user_id);//uses function
        }

        private void buttonBookingsDelete_Click(object sender, EventArgs e)
        {
            string booking_id = textBoxBookingsUpdateBookingID.Text;//saves to variable
            Db.DeleteBooking(booking_id);//uses function
        }

        private void buttonBookingsBooks_Click(object sender, EventArgs e)
        {
            FormBooks LoadBooks = new FormBooks();//creates method
            LoadBooks.ShowDialog();//loads form
        }

        private void buttonBookingsLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();//restarts form back to login page
        }

        private void buttonBookingsSettings_Click(object sender, EventArgs e)
        {
            FormSettings LoadSettings = new FormSettings();//creates method
            LoadSettings.ShowDialog();//loads form
        }

        private void buttonBookingsUsers_Click(object sender, EventArgs e)
        {
            FormUsers LoadUsers = new FormUsers();//creates method
            LoadUsers.ShowDialog();//loads form
        }

        private void buttonBookingsBookings_Click(object sender, EventArgs e)
        {
            FormBookings LoadBookings = new FormBookings();//creates method
            LoadBookings.ShowDialog();//loads form

        }
    }
}
