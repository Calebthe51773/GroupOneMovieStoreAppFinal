using System.Collections.Generic;

namespace GroupOneMovieStoreAppFinal
{
    public static class AdminDB
    {
        public static List<User> Users { get; set; } = new List<User>();

        public static void LoadUsers()
        {
            if (Users.Count == 0)
            {
                Users.Add(new User("admin", true));
                Users.Add(new User("john", false));
                Users.Add(new User("jane", false));
            }
        }

        public static void SaveUsers()
        {
       
        }
    }
}