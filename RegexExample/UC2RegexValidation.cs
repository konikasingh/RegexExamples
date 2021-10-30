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

        public bool ValidateFirstName()
        {
            return Regex.IsMatch("Konika", NAME_REGEX);
           
        }
        public bool ValidateLasttName()
        {
            return Regex.IsMatch("Singh", NAME_REGEX);

        }
    }
}
