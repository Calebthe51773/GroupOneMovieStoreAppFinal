using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneMovieStoreAppFinal
{
    public static class UserDB
    {
        private const string dir = @"C:\C#\Files\";
        private const string path = dir + "Users.txt";

        public static void SaveUsers(List<Users> users)
        {
            StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            foreach (Users user in users)
            {
                textOut.Write(user.FirstName + "|");
                textOut.Write(user.LastName + "|");
                textOut.Write(user.ContactInfo + "|");
                textOut.WriteLine(user.IsAdmin.ToString());
            }

            textOut.Close();
        }

        public static List<Users> GetUsers()
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            StreamReader textIn =
                new StreamReader(
                    new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            List<Users> users = new List<Users>();

            while (textIn.Peek() != -1)
            {                
                string row = textIn.ReadLine() ?? "";
                string[] columns = row.Split('|');
                Users user = new Users
                {
                    FirstName = columns[0],
                    LastName = columns[1],
                    ContactInfo = columns[2],
                    IsAdmin = Convert.ToBoolean(columns[3])
                };
                users.Add(user);
            }

            textIn.Close();

            return users;
        }
        
    }
}
