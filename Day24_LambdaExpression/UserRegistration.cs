using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day24_LambdaExpression
{
    internal class UserRegistration
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z}{2,}$";

        public static string REGEX_LASTNAME = "^[A-Z]{1}[a-zA-Z]{2,}$";

        public static string REGEX_EMAIL = "^[0-9a-zA-Z]+[.-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";

        public static string REGEX_PHONENUMBER = "^[/+91]*[ ]*[/-]*[0-9]{10}$";

        public static string REGEX_PASSWORD = "^[A-Za-z]{8,}$";

        public static string REGEX_PASSWORD2 = "^[A-Z]+[A-Za-z]{7,}$";

        public static string REGEX_PASSWORD3 = "^[A-Z0-9]+[A-Za-z0-9]{7,}$";

        public static string REGEX_PASSWORD4 = "^[A-Z0-9]+[A-Za-z0-9]{7,}[&^%$#@!]$";
        public bool ValidateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, REGEX_FIRSTNAME);
        }

        public bool ValidateLastName(String lastname)
        {
            return Regex.IsMatch(lastname, REGEX_LASTNAME);

        }
        public bool ValidateEmail(String email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);

        }
        public bool ValidatePhoneNumber(String phonenumber)
        {
            return Regex.IsMatch(phonenumber, REGEX_PHONENUMBER);
        }
        public bool ValidatePassword(String password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
        public bool ValidatePassword2(String password2)
        {
            return Regex.IsMatch(password2, REGEX_PASSWORD2);
        }
        public bool ValidatePassword3(String password3)
        {
            return Regex.IsMatch(password3, REGEX_PASSWORD3);
        }
        public bool ValidatePassword4(String password4)
        {
            return Regex.IsMatch(password4, REGEX_PASSWORD4);
        }
    }
}
   
