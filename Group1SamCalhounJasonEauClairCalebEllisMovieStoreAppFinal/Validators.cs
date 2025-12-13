using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneMovieStoreAppFinal
{
    public static class Validators
    {
        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = $"{name} is a required field.\n";
            }
            return msg;
        }

        public static string IsValidContactInfo(string value, string name)
        {
            string msg = IsPresent(value, name);
            if (!value.Contains('@') || !value.Contains('.') && !Int32.TryParse(value, out _))
            {
                msg += $"{name} must be a valid email address or phone number.\n";
            }
            return msg;
        }
    }
}
