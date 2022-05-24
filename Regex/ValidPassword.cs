using System;
using System.Text.RegularExpressions;


namespace RegexValidation
{
    public class Password
    {
        public static string ValidPassword = "^[A-Za-z0-9]{8,20}";

        public bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, ValidPassword);
        }
    }
}