using System;

namespace RegexExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Example");
            RegexValidation rege = new RegexValidation();
            bool ValidResult = rege.ValidateFirstName();
            Console.WriteLine("Name"+" "+ValidResult);
            bool ValidResu = rege.ValidateLasttName();
            Console.WriteLine("Name" + " " + ValidResu);
        }
    }
}
