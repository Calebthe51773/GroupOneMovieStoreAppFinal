using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneMovieStoreAppFinal
{
    public class Titles
    {
        public Titles() { }
        public Titles(string title, bool checkedOut) => (this.TitleName, this.CheckedOut) = (title, checkedOut);
        public string TitleName { get; set; } = "";
        public bool CheckedOut { get; set; } = false;
        public DateTime CheckDate { get; set; } = new DateTime(2001, 01, 01);

        public string GetTitleText() => $"{TitleName}";

    }
}
