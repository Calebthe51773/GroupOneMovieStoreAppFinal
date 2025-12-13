using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneMovieStoreAppFinal
{
    public static class MovieLibraryDB
    {
        private const string dir = @"C:\C#\Files\";
        private const string path = dir + "Customers.txt";

        public static void SaveTitles(List<Titles> titles)
        {
            StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            foreach (Titles title in titles)
            {
                textOut.Write(title.TitleName + "|");
                textOut.WriteLine(title.CheckedOut.ToString());
            }

            textOut.Close();
        }

        public static List<Titles> GetTitles()
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            StreamReader textIn =
                new StreamReader(
                    new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            List<Titles> titles = new List<Titles>();

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";
                string[] columns = row.Split('|');
                Titles title = new Titles
                {
                    TitleName = columns[0],
                    CheckedOut = Convert.ToBoolean(columns[1])
                };
                titles.Add(title);
            }

            textIn.Close();

            return titles;
        }
    }
}
