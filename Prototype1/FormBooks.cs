using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype1
{
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
        }

        private void buttonBooksLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();//restarts form back to login page
        }

        private void buttonBooksBookings_Click(object sender, EventArgs e)
        {
            FormBookings LoadBookings = new FormBookings();//creates method
            LoadBookings.ShowDialog();//loads form
        }

        private void buttonBooksBooks_Click(object sender, EventArgs e)
        {
            FormBooks LoadBooks = new FormBooks();//creates method
            LoadBooks.ShowDialog();//loads form
        }

        private void buttonBooksUsers_Click(object sender, EventArgs e)
        {
            FormUsers LoadUsers = new FormUsers();//creates method
            LoadUsers.ShowDialog();//loads form
        }

        private void buttonBooksSettings_Click(object sender, EventArgs e)
        {

            FormSettings LoadSettings = new FormSettings();//creates method
            LoadSettings.ShowDialog();//loads form
        }

        private void buttonBooksBorrow_Click(object sender, EventArgs e)
        {
            string book_id = textBoxBooksBorrowBookID.Text;//saves to variable
            string user_id = textBoxBooksBorrowUserID.Text;//saves to variable
            DateTime today = DateTime.Now.Date;//gets today's date
            DateTime dueDate = today.AddDays(7);//adds 7 days to calcualte due date
            string return_date = (dueDate.ToShortDateString()).ToString();
            Db.BorrowBook(book_id, user_id, return_date);//uses function
        }

        private void buttonBooksReturn_Click(object sender, EventArgs e)
        {
            string user_id = (textBoxBooksReturnUserID.Text);//saves to variable
            string book_id = (textBoxBooksReturnBookID.Text);//saves to variable
            string oldFine = Db.GetFine(user_id);
            string GetDate = Db.GetDate(user_id, book_id);
            DateTime todayDate = DateTime.Now.Date;//gets today's date
            DateTime returnDate = DateTime.Parse(GetDate);
            double newFine = double.Parse(oldFine);
            if (todayDate > returnDate)//book overdue
            {
                int overdueDays = (todayDate - returnDate).Days;
                for (int i = 0; i < overdueDays; i++)
                {
                    newFine += 0.25;
                    if (newFine >= 10)
                    {
                        newFine = 10;  // Cap the fine at 10
                        break;
                    }

                }
                string userFine = newFine.ToString();
                Db.AddFine(user_id, userFine);
                Db.ReturnBook(book_id, user_id);//uses function
            }
            else
            {
                Db.ReturnBook(book_id, user_id);//uses function
            }
        }

        private void buttonBooksAdd_Click(object sender, EventArgs e)
        {
            string bookTitle = textBoxBooksAddTitle.Text;//saves to variable
            string bookAuthor = textBoxBooksAddAuthor.Text;//saves to variable
            Db.AddBook(bookTitle, bookAuthor);//uses function
        }

        private void buttonBooksUpdate_Click(object sender, EventArgs e)
        {
            string bookTitle = textBoxBooksAddTitle.Text;//saves to variable
            string bookAuthor = textBoxBooksAddAuthor.Text;//saves to variable
            int book_id = int.Parse(textBoxBooksUpdateBookID.Text);//saves to variable
            Db.UpdateBook(bookTitle, bookAuthor, book_id);//uses function
        }

        private void buttonBooksDelete_Click(object sender, EventArgs e)
        {
            string book_id = textBoxBooksDeleteBookID.Text;//saves to variable
            Db.DeleteBook(book_id);//uses function
        }

        private void buttonBooksDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard LoadDashboard = new FormDashboard();//creates method
            LoadDashboard.ShowDialog();//loads form
        }
    }
}
