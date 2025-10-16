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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prototype1
{
    public partial class FormLogin : Form
    {
        private int attempts = 0;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string usernameAttempt = textBoxUsername.Text;//attempted username
            string passwordAttempt = textBoxPassword.Text;//attempted password
            if (usernameAttempt == "librarian")
            {
                attempts++;//increments login attempt
                string librarianLocked = Db.CheckLibrarianLocked();
                if (librarianLocked == "1")//librarian is locked out
                {
                    MessageBox.Show("Locked Out\nContact Admin");//shows login failed 
                }
                else if (librarianLocked == "0")//librarian isn't locked out
                {
                    if (attempts > 10)//user exceeds number of attempts
                    {
                        Db.LockLibrarian();//locks librarian out
                        MessageBox.Show("Locked Out\nContact Admin");//shows login failed 
                    }
                    else if (attempts < 11)//user hasn't exceeded number of attempts
                    {
                        string realPassword = Db.GetLibrarianDetails(usernameAttempt);
                        if (passwordAttempt == realPassword)//if password is correct
                        {
                            FormDashboard LoadDashboard = new FormDashboard();//creates method
                            LoadDashboard.ShowDialog();//loads form
                        }
                        else
                        {
                            MessageBox.Show("Login failed");//shows login failed
                        }
                    }
                }
            }
            else if (usernameAttempt == "admin")
            {
                if (textBoxPassword.Text == Global.globalAdminPassword.ToString()) //checks admin password
                {
                    Global.globalSettingsVisible = true;
                    FormDashboard LoadDashboard = new FormDashboard();//creates method
                    LoadDashboard.ShowDialog();//loads form
                    this.Close();
                }
                else
                        {
                    MessageBox.Show("Login failed");//shows login failed
                }
            }
            else
            {
                MessageBox.Show("Login failed");//shows login failed
            }
            textBoxUsername.Text = "";//clears textbox
            textBoxPassword.Text = "";//clears textbox
        }
    

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact Admin");//outputs message
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
