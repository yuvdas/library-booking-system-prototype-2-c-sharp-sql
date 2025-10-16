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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Prototype1
{
    class Db
    {
        public static OleDbConnection GetConnection()//connect to database method
        {
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Prototype2\Prototype1\Database.accdb'";//database directory              
            return new OleDbConnection(directory);//returns database connection
        }

        public static string GetLibrarianDetails(string usernameAttempt)//gets database data
        {
            string returnedValue = "";//returns value
            OleDbConnection databaseConnection = Db.GetConnection();//connects to database
            string query = "select * from Staff where username = 'librarian'";//requests desired account's record 
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//creates query command
            try//attempts 
            {
                databaseConnection.Open();//open database
                OleDbDataReader reader = command.ExecuteReader();//runs query in database
                while (reader.Read())//reads selected data
                {
                    string realPassword = "user_password";//data needed from desired field
                    returnedValue = reader[realPassword].ToString();//value to return
                    return returnedValue;
                }
            }
            catch (Exception ex)//if it fails
            {
                returnedValue = "Error" + ex;
                return returnedValue;//returns error
            }
            finally
            {
                databaseConnection.Close();//closes database connection
            }
            return returnedValue;//returns 
        }

        public static string CheckLibrarianLocked()//gets database data
        {
            string returnedValue = "";//returns value
            OleDbConnection databaseConnection = Db.GetConnection();//connects to database
            string query = "select * from Staff where username = 'librarian'";//requests desired account's record 
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//creates query command
            try//attempts 
            {
                databaseConnection.Open();//open database
                OleDbDataReader reader = command.ExecuteReader();//runs query in database
                while (reader.Read())//reads selected data
                {
                    string librarianLockedOut = "locked";//data needed from desired field
                    returnedValue = reader[librarianLockedOut].ToString();//value to return
                    return returnedValue;
                }
            }
            catch (Exception ex)//if it fails
            {
                returnedValue = "Error" + ex;
                return returnedValue;//returns error
            }
            finally
            {
                databaseConnection.Close();//closes database connection
            }
            return returnedValue;//returns 
        }

        public static string ChangeLibrarianPassword(string newPassword)//gets account details
        {
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Prototype2\Prototype1\Database.accdb'";//database directory        
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "update Staff set userPassword = '" + newPassword + "' where username = 'librarian'";//sql command to update password 
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//create command for query 
            string returnedValue;
            try
            {
                databaseConnection.Open();//open database
                command.ExecuteNonQuery();//runs query in database
                returnedValue = "Done";
                return returnedValue;
            }

            catch (Exception ex)//if it fails
            {
                returnedValue = "Exception in DBHandler" + ex;
                return returnedValue;//returns error
            }

            finally
            {
                databaseConnection.Close();//closes database connection
            }
        }

        public static string LockLibrarian()//gets account details
        {
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Prototype2\Prototype1\Database.accdb'";//database directory        
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "update Staff set locked = 1 where username = 'librarian'";//sql command to lock librarian 
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//create command for query 
            string returnedValue;
            try
            {
                databaseConnection.Open();//open database
                command.ExecuteNonQuery();//runs query in database
                returnedValue = "Done";
                return returnedValue;
            }

            catch (Exception ex)//if it fails
            {
                returnedValue = "Exception in DBHandler" + ex;
                return returnedValue;//returns error
            }

            finally
            {
                databaseConnection.Close();//closes database connection
            }
        }

        public static string UnlockLibrarian()//gets account details
        {
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Prototype2\Prototype1\Database.accdb'";//database directory        
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "update Staff set locked = 0 where username = 'librarian'";////sql command to unlock librarian 
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//create command for query 
            string returnedValue;
            try
            {
                databaseConnection.Open();//open database
                command.ExecuteNonQuery();//runs query in database
                returnedValue = "ok";
                return returnedValue;
            }

            catch (Exception ex)//if it fails
            {
                returnedValue = "Exception in DBHandler" + ex;
                return returnedValue;//returns error
            }

            finally
            {
                databaseConnection.Close();//closes database connection
            }
        }

        public static string AddBooking(string bookingRoom, string bookingEvent, string bookingDate, string bookingTime, string user_id)
        {
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Prototype2\Prototype1\Database.accdb'";//database directory               
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "insert into Bookings( room, event, date, time, user_id)  values ( '" + bookingRoom + "' , '" + bookingEvent + "' " +
                ", '" + bookingDate + "' , '" + bookingTime + "' , '" + user_id + "')";//sql command adds new row of data
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//create command for query 
            string returnedValue;
            try
            {
                databaseConnection.Open();//open database
                command.ExecuteNonQuery();//runs query in database
                returnedValue = "Done";
                return returnedValue;
            }

            catch (Exception ex)//if it fails
            {
                returnedValue = "Exception in DBHandler" + ex;
                return returnedValue;//returns error
                MessageBox.Show("Error");
            }

            finally
            {
                databaseConnection.Close();//closes database connection
            }
        }

        public static string UpdateBooking(string booking_id, string bookingRoom, string bookingEvent, string bookingDate, string bookingTime, string user_id)//data to update
        {
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Prototype2\Prototype1\Database.accdb'";//database directory               
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "update Bookings set room = '" + bookingRoom + "', event = '" + bookingEvent + "', date = '" + bookingDate + "'," +
                " time = '" + bookingTime + "', user_id = '" + user_id + "' where booking_id = '" + booking_id + "'";//sql command to update booking details
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//create command for query 
            string returnedValue;
            try
            {
                databaseConnection.Open();//open database
                command.ExecuteNonQuery();//runs query in database
                returnedValue = "Done";
                return returnedValue;
            }

            catch (Exception ex)//if it fails
            {
                returnedValue = "Exception in DBHandler" + ex;
                return returnedValue;//returns error
                MessageBox.Show("Error");
            }

            finally
            {
                databaseConnection.Close();//closes database connection
            }
        }

        public static string DeleteBooking(string booking_id)//gets account details
        {
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Prototype2\Prototype1\Database.accdb'";//database directory               
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "delete from Bookings where booking_id = '" + booking_id + "'";////sql command to unlock librarian 
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//create command for query 
            string returnedValue;
            try
            {
                databaseConnection.Open();//open database
                command.ExecuteNonQuery();//runs query in database
                returnedValue = "Done";
                return returnedValue;
            }

            catch (Exception ex)//if it fails
            {
                returnedValue = "Exception in DBHandler" + ex;
                return returnedValue;//returns error
                MessageBox.Show("Error");
            }

            finally
            {
                databaseConnection.Close();//closes database connection
            }
        }

        public static string BorrowBook(string book_id, string user_id, string return_date)
        {
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Prototype2\Prototype1\Database.accdb'";//database directory               
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "update Books set return_date = '" + return_date + "', user_id = '" + user_id + "' where book_id = '" + book_id + "'";
            //sql command to update booking details
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//create command for query 
            string returnedValue;
            try
            {
                databaseConnection.Open();//open database
                command.ExecuteNonQuery();//runs query in database
                returnedValue = "Done";
                return returnedValue;
            }

            catch (Exception ex)//if it fails
            {
                returnedValue = "Exception in DBHandler" + ex;
                return returnedValue;//returns error
                MessageBox.Show("Error");
            }

            finally
            {
                databaseConnection.Close();//closes database connection
            }
        }
        
        public static string ReturnBook(string book_id, string user_id)
        {
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Prototype2\Prototype1\Database.accdb'";//database directory               
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "update Books set return_date = '" + null + "', user_id = '" + null + "' where book_id = '" + book_id + "' and user_id = '" + user_id + "'";
            //sql command to update  details
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//create command for query 
            string returnedValue;
            try
            {
                databaseConnection.Open();//open database
                command.ExecuteNonQuery();//runs query in database
                returnedValue = "Done";
                return returnedValue;
            }

            catch (Exception ex)//if it fails
            {
                returnedValue = "Exception in DBHandler" + ex;
                return returnedValue;//returns error
                MessageBox.Show("Error");
            }

            finally
            {
                databaseConnection.Close();//closes database connection
            }
        }

        public static string GetFine(string user_id)//gets database data
        {
            string returnedValue = "";//returns value
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Prototype2\Prototype1\Database.accdb'";//database directory               
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "select * from Users where user_id = '" + user_id + "'";//requests desired account's record 
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//creates query command
            try//attempts 
            {
                databaseConnection.Open();//open database
                OleDbDataReader reader = command.ExecuteReader();//runs query in database
                while (reader.Read())//reads selected data
                {
                    string realPassword = "fine";//data needed from desired field
                    returnedValue = reader[realPassword].ToString();//value to return
                    return returnedValue;
                }
            }
            catch (Exception ex)//if it fails
            {
                returnedValue = "Error" + ex;
                return returnedValue;//returns error
                MessageBox.Show("Error");
            }
            finally
            {
                databaseConnection.Close();//closes database connection
            }
            return returnedValue;//returns 
        }

        public static string AddFine(string user_id, string fine)
        {
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Prototype2\Prototype1\Database.accdb'";//database directory               
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "insert into Users( fine)  values ( '" + fine + "' where user_id = '" + user_id + "')";//sql command adds new row of data
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//create command for query 
            string returnedValue;
            try
            {
                databaseConnection.Open();//open database
                command.ExecuteNonQuery();//runs query in database
                returnedValue = "Done";
                return returnedValue;
            }

            catch (Exception ex)//if it fails
            {
                returnedValue = "Exception in DBHandler" + ex;
                return returnedValue;//returns error
                MessageBox.Show("Error");
            }

            finally
            {
                databaseConnection.Close();//closes database connection
            }
        }

        public static string AddBook(string title, string author)
        {
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Prototype2\Prototype1\Database.accdb'";//database directory               
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "insert into Books( title, author)  values ( '" + title + "' , '" + author + "')";//sql command adds new row of data
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//create command for query 
            string returnedValue;
            try
            {
                databaseConnection.Open();//open database
                command.ExecuteNonQuery();//runs query in database
                returnedValue = "Done";
                return returnedValue;
            }

            catch (Exception ex)//if it fails
            {
                returnedValue = "Exception in DBHandler" + ex;
                return returnedValue;//returns error
                MessageBox.Show("Error");
            }

            finally
            {
                databaseConnection.Close();//closes database connection
            }
        }

        public static string UpdateBook(string title, string author, int book_id)//data to update
        {
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Prototype2\Prototype1\Database.accdb'";//database directory               
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "update Bookings set title = '" + title + "', author = '" + author + "' where book_id = '" + book_id + "'";//sql command to update  details
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//create command for query 
            string returnedValue;
            try
            {
                databaseConnection.Open();//open database
                command.ExecuteNonQuery();//runs query in database
                returnedValue = "Done";
                return returnedValue;
            }

            catch (Exception ex)//if it fails
            {
                returnedValue = "Exception in DBHandler" + ex;
                return returnedValue;//returns error
                MessageBox.Show("Error");
            }

            finally
            {
                databaseConnection.Close();//closes database connection
            }
        }

        public static string DeleteBook(string book_id)//gets account details
        {
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Prototype2\Prototype1\Database.accdb'";//database directory               
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "delete from Books where book_id = '" + book_id + "'";////sql command to delete record
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//create command for query 
            string returnedValue;
            try
            {
                databaseConnection.Open();//open database
                command.ExecuteNonQuery();//runs query in database
                returnedValue = "Done";
                return returnedValue;
            }

            catch (Exception ex)//if it fails
            {
                returnedValue = "Exception in DBHandler" + ex;
                return returnedValue;//returns error
                MessageBox.Show("Error");
            }

            finally
            {
                databaseConnection.Close();//closes database connection
            }
        }

        public static string AddUser(string first_name, string surname, string email, string phone)
        {
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Prototype2\Prototype1\Database.accdb'";//database directory               
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "insert into Users( first_name, surname, email, phone)  values ( '" + first_name + "' , '" + surname + "' " +
                ", '" + email + "' , '" + phone + "')";//sql command adds new row of data
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//create command for query 
            string returnedValue;
            try
            {
                databaseConnection.Open();//open database
                command.ExecuteNonQuery();//runs query in database
                returnedValue = "Done";
                return returnedValue;
            }

            catch (Exception ex)//if it fails
            {
                returnedValue = "Exception in DBHandler" + ex;
                return returnedValue;//returns error
                MessageBox.Show("Error");
            }

            finally
            {
                databaseConnection.Close();//closes database connection
            }
        }

        public static string UpdateUser(string first_name, string surname, string email, string phone, string user_id)//data to update
        {
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Prototype2\Prototype1\Database.accdb'";//database directory               
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "update Users set first_name = '" + first_name + "', surname = '" + surname + "', email = '" + email + "'," +
                " phone = '" + phone + "' where user_id = '" + user_id + "'";//sql command to update 
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//create command for query 
            string returnedValue;
            try
            {
                databaseConnection.Open();//open database
                command.ExecuteNonQuery();//runs query in database
                returnedValue = "Done";
                return returnedValue;
            }

            catch (Exception ex)//if it fails
            {
                returnedValue = "Exception in DBHandler" + ex;
                return returnedValue;//returns error
                MessageBox.Show("Error");
            }

            finally
            {
                databaseConnection.Close();//closes database connection
            }
        }

        public static string DeleteUser(string user_id)//gets account details
        {
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Prototype2\Prototype1\Database.accdb'";//database directory               
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "delete from Users where user_id = '" + user_id + "'";////sql command to unlock librarian 
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//create command for query 
            string returnedValue;
            try
            {
                databaseConnection.Open();//open database
                command.ExecuteNonQuery();//runs query in database
                returnedValue = "Done";
                return returnedValue;
            }

            catch (Exception ex)//if it fails
            {
                returnedValue = "Exception in DBHandler" + ex;
                return returnedValue;//returns error
                MessageBox.Show("Error");
            }

            finally
            {
                databaseConnection.Close();//closes database connection
            }
        }

        public static string GetDate(string user_id, string book_id)//gets database data
        {
            string returnedValue = "";//returns value
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Prototype2\Prototype1\Database.accdb'";//database directory               
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "select * from Books where user_id = '" + user_id + "' and book_id = '" + book_id + "'";//requests desired account's record 
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//creates query command
            try//attempts 
            {
                databaseConnection.Open();//open database
                OleDbDataReader reader = command.ExecuteReader();//runs query in database
                while (reader.Read())//reads selected data
                {
                    string realPassword = "return_date";//data needed from desired field
                    returnedValue = reader[realPassword].ToString();//value to return
                    return returnedValue;
                }
            }
            catch (Exception ex)//if it fails
            {
                returnedValue = "Error" + ex;
                return returnedValue;//returns error
                MessageBox.Show("Error");
            }
            finally
            {
                databaseConnection.Close();//closes database connection
            }
            return returnedValue;//returns 
        }



    }
}
