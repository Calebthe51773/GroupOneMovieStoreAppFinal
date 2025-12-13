using System.Collections.Generic;
using System.Linq;

namespace GroupOneMovieStoreAppFinal
{
    public static class AdminDB
    {
        public static List<User> Users { get; private set; }

        public static void LoadUsers()
        {
            Users = new List<User>
            {
                new User("Sam", true),
                new User("Employee", false)
            };
        }

        public static User GetDefaultUser()
        {
            return Users.FirstOrDefault(u => u.IsAdmin)
                   ?? Users.FirstOrDefault();
        }
    }
}
