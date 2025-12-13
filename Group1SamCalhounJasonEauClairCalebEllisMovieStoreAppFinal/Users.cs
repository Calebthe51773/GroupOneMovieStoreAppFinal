using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneMovieStoreAppFinal
{
    public class Users
    {
        public Users(){}
        public Users(string firstName, string lastName, string contactInfo) => (this.FirstName, this.LastName, this.ContactInfo) = (firstName, lastName, contactInfo);
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string ContactInfo { get; set; } = "";
        public bool IsAdmin { get; set; } = false;
        public Titles MovieCheckedOut { get; set; }
        public string GetUserInfo() => $"{FirstName} {LastName}, {ContactInfo}";

    }
}
