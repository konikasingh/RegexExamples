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
    }
}
