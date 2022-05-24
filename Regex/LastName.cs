using System;
using System.Text.RegularExpressions;


namespace RegexValidation
{
    public class LastName
    {
        public static string ValidLastName = "^[A-Z][a-z]{3,}";

        public bool ValidateLastName(string Name)
        {
            return Regex.IsMatch(Name, ValidLastName);
        }
    }
}