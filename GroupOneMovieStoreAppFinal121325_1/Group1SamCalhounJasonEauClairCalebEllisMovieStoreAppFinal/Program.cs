using System;
using System.Windows.Forms;

namespace GroupOneMovieStoreAppFinal
{
    internal static class Program
    {
        public static User CurrentUser;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            AdminDB.LoadUsers();
            CurrentUser = AdminDB.GetDefaultUser();

            Application.Run(new frmRentalStore(CurrentUser));
        }
    }
}
