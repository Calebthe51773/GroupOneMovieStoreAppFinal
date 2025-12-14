using System;
using System.Windows.Forms;

namespace GroupOneMovieStoreAppFinal
{
    /// <summary>
    /// The main entry point for the Movie Store application.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main method that starts the application.
        /// Initializes visual styles, loads user data,
        /// and launches the rental store form.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Load users from the user database
            AdminDB.LoadUsers();

            // For demonstration purposes, use the first user (admin)
            User currentUser = AdminDB.Users.Count > 0 ? AdminDB.Users[0] : null;

            // Ensure at least one user exists before launching the application
            if (currentUser == null)
            {
                MessageBox.Show("No users found. Add users in AdminDB.");
                return;
            }

            // Start the application with the rental store form
            Application.Run(new frmRentalStore(currentUser));
        }
    }
}
