using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BensAssignment5.BPUtilityClasses
{
    class BPValidations
    {
        public bool ValidatePostalCode(string postal) // validates canadian postal code
        {
            postal = postal.Replace(" ", "");
            string pattern = @"^([A-Y][0-9][A-Z]\s?[0-9][A-Z][0-9])?$";

            Regex reg = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);

            if (!(reg.IsMatch(postal)))
                return false;
            return true;
        }
        
        public bool ValidateUsZipCode(string zipCode) // validates american zip code
        {
            string value = "";

            foreach (char c in zipCode)
            {
                if (char.IsDigit(c))
                {
                    value += c;
                }
            }
            if (value.Length == 5 || value.Length == 9)
                return true;
            else
                return false;
        }

        public bool ValidatePhoneNumber(string phoneNumber) // validates a north american phone number
        {
            string pattern = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            Regex reg = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);

            if (!(reg.IsMatch(phoneNumber)))
                return false;
            return true;
        }
    }
}
