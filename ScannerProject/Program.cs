using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScannerProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.CurrentCulture = new CultureInfo("en-US");
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Office 2013 Light Gray");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Helper.Utility.ConnectDB();

            Application.Run(new BaseApplication());
        }
    }
}
