using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype1
{
    internal class Global
    {
        private static string adminUsername = "admin";//admin username
        private static string adminPassword = "^A3^&Pj7!z6Z4a7aFn9B";//admin password
        private static bool settingsVisible = false;//checks if settings are visible
        public static string globalAdminUsername//makes a global variable for admin username 
        {
            get { return adminUsername; }//gets string from local variable for admin username 
            set { adminUsername = value; }//assigns string to global variable
        }

        public static string globalAdminPassword//makes a global variable for sdmin password 
        {
            get { return adminPassword; }//gets string from local variable for admin password
            set { adminPassword = value; }//assigns string to global variable
        }

        public static bool globalSettingsVisible//makes a global variable for if settings are visible
        {
            get { return settingsVisible; }//gets string from local variable
            set { settingsVisible = value; }//assigns string to global variable
        }
    }
}
