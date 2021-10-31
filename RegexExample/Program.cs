using System;

namespace RegexExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Example");
            RegexValidation rege = new RegexValidation(); //object creation of class

            bool ValidResult = rege.ValidateFirstName();
            Console.WriteLine("Name: "+" "+ValidResult); //print the valid result of first name

            bool ValidResu = rege.ValidateLasttName();
            Console.WriteLine("Name: " + " " + ValidResu); //print the valid result of last name

            bool ValidMobileResult = rege.ValidMobileNumber();
            Console.WriteLine("Mobile Number: " + " " + ValidMobileResult); //print the valid mobile number with country code:

            bool ValidEmail = rege.ValidEmail();
            Console.WriteLine("Email Address: " + " " + ValidEmail);
           // Console.WriteLine("Mobile" + " " + ValidEmail);
        }
    }
}
