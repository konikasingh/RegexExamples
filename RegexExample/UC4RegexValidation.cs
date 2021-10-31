using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexExample
{
    public class RegexValidation
    {
        public static string NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3,}$";
        public static string MOBILENUMBER_REGEX = "^(?:[0-9]{2}[ ][0-9]{10})$";
        public static string EMAIL_REGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][0-9a-zA-Z]+[.][a-zA-Z]{2,4}([a-zA-Z]{2,3}){0,1}";
        public static string PASSWORD_REGEX = "^[0A-Za-z0-9]{8,}[@$%^&*#]";

        //Validating the First name with first word capital and other are small:
        public bool ValidateFirstName()
        {
            return Regex.IsMatch("Konika", NAME_REGEX);
           
        }

        //Validating the last name with first word capital and other are small:
        public bool ValidateLasttName()
        {
            return Regex.IsMatch("Singh", NAME_REGEX);

        }

        //Validating the last mobile number in which country code and space is followed and then the 10 digit mobile number:
        public bool ValidMobileNumber()
        {
            return Regex.IsMatch("91 8766567855", MOBILENUMBER_REGEX);

        }

        //Validating the email address with all the required options:
        public bool ValidEmail()
        {
            // VALID EMAIL ADDRESSES:
            return Regex.IsMatch("abc@yahoo.com", EMAIL_REGEX);
           // return Regex.IsMatch("abc-100@yahoo.com,", EMAIL_REGEX);
            //return Regex.IsMatch("abc.100@yahoo.com", EMAIL_REGEX);
            //return Regex.IsMatch("abc111@abc.com,", EMAIL_REGEX);
            //return Regex.IsMatch("abc-100@abc.net,", EMAIL_REGEX);
            //return Regex.IsMatch("abc.100@abc.com.au", EMAIL_REGEX);
            //return Regex.IsMatch("abc@1.com,", EMAIL_REGEX);
            //return Regex.IsMatch("abc@gmail.com.com", EMAIL_REGEX);
            // return Regex.IsMatch("abc+100@gmail.com", EMAIL_REGEX);

            //INVALID EMAIL ADDRESSES:
            //return Regex.IsMatch("abc", EMAIL_REGEX);
            //return Regex.IsMatch("abc@.com.my", EMAIL_REGEX);
            //return Regex.IsMatch("abc123@gmail.a", EMAIL_REGEX);
            //return Regex.IsMatch("abc123@.com", EMAIL_REGEX);
            //return Regex.IsMatch("abc123@.com.com", EMAIL_REGEX);
            //return Regex.IsMatch(".abc@abc.com", EMAIL_REGEX);
            //return Regex.IsMatch("abc()*@gmail.com", EMAIL_REGEX);
            //return Regex.IsMatch("abc@%*.com", EMAIL_REGEX);
            //return Regex.IsMatch("abc..2002@gmail.com", EMAIL_REGEX);
            //return Regex.IsMatch("abc.@gmail.comt", EMAIL_REGEX);
            //return Regex.IsMatch("abc@abc@gmail.com", EMAIL_REGEX);
            //return Regex.IsMatch("abc@gmail.com.1a", EMAIL_REGEX);
            //return Regex.IsMatch("abc@gmail.com.aa.au", EMAIL_REGEX);

        }
        public bool ValidPassword()
        {
            return Regex.IsMatch("Konika56@#", PASSWORD_REGEX);
        }
    }
}
