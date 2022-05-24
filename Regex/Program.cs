using RegexValidation;
using System;

namespace RegexValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pattern pattern = new Pattern();
            //Console.WriteLine(pattern.ValidateName("Abhishek"));

            //LastName lastName = new LastName();
            //Console.WriteLine(lastName.ValidateLastName("Narwariya"));

            //Email email = new Email();
            //Console.WriteLine(email.IsValidMail("abhisheknarwariya813@gmail.com"));

            ValidMobile validMobile = new ValidMobile();
            Console.WriteLine(validMobile.ValidateMobileNo("91 8574657890"));

        }


    }
}