using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MsTestUserRegistration
{
    public class UserRegistration
    {
        public static string firstNamePattern = "^[A-Z]{1}[a-z]{2}";
        public static string lastNamePattern = "^[A-Z]{1}[a-z]{2}";
        public static string mobilePattern = "^([9][1])[ ]*[6-9]{1}[0-9]{9}$";
        public static string passwordPatternR3 = "^(?=.*?[0-9])(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[@#$&*.!?]).{8,}";

        public static string Pattern(string userInput, string pattern)
        {
            if (Regex.IsMatch(userInput, pattern))
                return "true";
            else
                return "false";
        }
        
        public static string FirstName(string name)
        {
            var firstNameMatch = Pattern(name, firstNamePattern);
            return firstNameMatch;
        }
        
        public static string LastName(string name)
        {
            var lastNameMatch = Pattern(name, lastNamePattern);
            return lastNameMatch;
        }
        
        public static string MobileNumber(string number)
        {
            var numberMatch = Pattern(number, mobilePattern);
            return numberMatch;
        }
        
        public static string Password(string pass)
        {
            var passMatch = Pattern(pass, passwordPatternR3);
            return passMatch;
        }
    }
}
