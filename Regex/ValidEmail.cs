using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegexValidation
{
    class Email
    {
        public static string validEmail = @"^([a-z]{1})([a-z0-9]*)([_.+-]?([a-z0-9]+))*\@([a-zA-Z0-9])+\.(com|net)(\.[a-z]{2})?$";
        public bool IsValidMail(string email)
        {
            return Regex.IsMatch(email, validEmail);
        }

    }
}