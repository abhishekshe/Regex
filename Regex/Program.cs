using RegexValidation;
using System;

namespace RegexValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine(pattern.ValidateName("Abhishek"));
        }


    }
}