using System;
using System.Windows.Forms;

namespace GroupOneMovieStoreAppFinal
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Load users
            AdminDB.LoadUsers();

            // For demo, use first user (admin)
            User currentUser = AdminDB.Users.Count > 0 ? AdminDB.Users[0] : null;

            if (currentUser == null)
            {
                MessageBox.Show("No users found. Add users in AdminDB.");
                return;
            }

            Application.Run(new frmRentalStore(currentUser));
        }
    }
}
