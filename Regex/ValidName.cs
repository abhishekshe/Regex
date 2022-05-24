using System;
using System.Text.RegularExpressions;


namespace RegexValidation
{
    public class Pattern
    {
        public static string ValidLastName = "^[A-Z][a-z]{3,}";

        public bool ValidateName(string Name)
        {
            return Regex.IsMatch(Name, ValidLastName);
        }
    }
}