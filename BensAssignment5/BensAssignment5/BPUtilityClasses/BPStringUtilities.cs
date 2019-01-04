using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BensAssignment5.BPUtilityClasses
{
    class BPStringUtilities
    {
        public static string CapitalizeFirstCharacter(string input) // shifts first char to uppercase
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }

        public static string OnlyDigits(string numbersOnly) // only accepts numbers
        {
            return new string(numbersOnly.Where(c => Char.IsDigit(c)).ToArray());
        }

        public static string ReformattingPhoneNumbers(string phoneNumbers) // accepts 7 or 10 digit phone numbers adds dashes aswell
        {
            Regex sevenNumbers = new Regex(@"^\d\d\d\d\d\d\d$");
            if (sevenNumbers.IsMatch(phoneNumbers))
            {
                phoneNumbers = phoneNumbers.Insert(3, "-");
            }
            Regex tenNumbers = new Regex(@"^\d\d\d\d\d\d\d\d\d\d$");
            if (tenNumbers.IsMatch(phoneNumbers))
            {
                phoneNumbers = phoneNumbers.Insert(3, "-");
                phoneNumbers = phoneNumbers.Insert(7, "-");
            }
            return phoneNumbers;
        }

        public static string ReformattingPostalCode(string canadaPostalCode) // capitalizes all characters and adds space if necessary 
        {
            if (!string.IsNullOrEmpty(canadaPostalCode))
            {
                canadaPostalCode = canadaPostalCode.ToUpper();
                if (canadaPostalCode != " ")
                {
                    canadaPostalCode = canadaPostalCode.Insert(3, " ");
                }
                return canadaPostalCode;
            }
            else
            {
                return null;
            }
        }

        public static string ReformattingZipCode(string americanZipCode) // formats an american zip code 
        {
            Regex fiveNumbers = new Regex(@"^\d\d\d\d\d$");
            if (fiveNumbers.IsMatch(americanZipCode))
            {
                return americanZipCode;
            }
            Regex nineNumbers = new Regex(@"^\d\d\d\d\d\d\d\d\d$");
            if (nineNumbers.IsMatch(americanZipCode))
            {
                americanZipCode = americanZipCode.Insert(5, "-");
            }
            return americanZipCode;
        }

        public static string FullName(string fName, string lName) => (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName)) ? fName + lName : lName.ToUpper()[0] + lName.Substring(1).ToLower() + ", " + fName.ToUpper()[0] + fName.Substring(1).ToLower(); // shifts first letter in first and last name to uppercase
    }
}
