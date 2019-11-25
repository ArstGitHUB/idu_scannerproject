using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScannerProject
{
    public class CurrentUser
    {
        public static string UserID = "";
        public static bool IsAdministrator = false;
        public static string Role = "";

        public static bool Login(string username, string password)
        {
            if (Helper.Utility.ValidateLogin(username, password))
            {
                CurrentUser.UserID = username;
                CurrentUser.Role = "Scanner";
                CurrentUser.IsAdministrator = true;

                return true;
            }

            return false;
        }

        public static void Logout()
        {
            ScannerProject.Helper.DBConnection.oCompany = null;
            CurrentUser.UserID = "";
            CurrentUser.Role = "";
            CurrentUser.IsAdministrator = false;
        }
    }
}
