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
using System.Text.RegularExpressions;

namespace Prototype1
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void buttonSettingsDashboard_Click(object sender, EventArgs e)
        {

        }

        private void buttonSettingsBookings_Click(object sender, EventArgs e)
        {

        }

        private void buttonSettingsBooks_Click(object sender, EventArgs e)
        {

        }

        private void buttonSettingsUsers_Click(object sender, EventArgs e)
        {

        }

        private void buttonSettingsSettings_Click(object sender, EventArgs e)
        {

        }

        private void buttonSettingsLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();//restarts form back to login page
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUnlock_Click(object sender, EventArgs e)
        {
            Db.UnlockLibrarian();//unlocks librarian 
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = textBoxPasswordNew.Text;//saves to variable
            string newPasswordConfirmed = textBoxPasswordNewConfirm.Text;//saves to variable
            bool hasUpperCase = Regex.IsMatch(newPassword, @"[A-Z]");
            bool hasLowerCase = Regex.IsMatch(newPassword, @"[a-z]");
            bool hasNumber = Regex.IsMatch(newPassword, @"[0-9]");
            bool hasSymbol = Regex.IsMatch(newPassword, @"[^a-zA-Z0-9]");
            if (newPassword == newPasswordConfirmed)
            {
                if (newPassword.Length >= 8 && hasUpperCase == true && hasLowerCase == true && hasNumber == true && hasSymbol == true)
                {
                    Db.ChangeLibrarianPassword(newPassword);//changes librarian password
                    MessageBox.Show("Successfully Changed Password");//reports passwords not matching
                }
                else
                {
                    MessageBox.Show("Unable to change password. Does not meet the requirements\n- At least 8 characters\n- A mixture of upper and lower case letter\n- Has" +
                    " number\nHas symbols");//reports password requirements
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match");//reports passwords not matching
            }
        }
    }
}