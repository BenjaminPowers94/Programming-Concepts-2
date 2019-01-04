using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BensAssignment5.BPUtilityClasses
{
    class BPNumericUtilities
    {
        public bool IsNumeric(string isStr) => double.TryParse(isStr, out double result); // boolean method that returns true if parameter contains only a number also allows decimals and commas

        public bool IsNumeric(object isObj) => Regex.IsMatch(isObj.GetType().GetProperty("Text").GetValue(isObj).ToString(), @"^\-?\d+(\.\d+)?$"); // boolean method that returns true if parameter contains only a number also allows decimals and commas

        public bool IsInteger(string isStr) => int.TryParse(isStr, out int result); // boolean method that returns true if parameter contains only a number doesnt, allow decimals or commas

        public bool IsInteger(double isDbl) => Regex.IsMatch(isDbl.ToString(), @"^\-?[0-9]+$"); // boolean method that returns true if parameter contains only a number, doesnt allow decimals or commas

        public bool IsInteger(object isObj) => int.TryParse(isObj.GetType().GetProperty("Text").GetValue(isObj).ToString(), out int result); // boolean method that returns true if parameter contains only a number, doesnt allow decimals or commas

        public string ReturnNumeric(string isStr) => !Regex.IsMatch(isStr, @"\d") ? null : isStr.Contains("-") ? new String(isStr.Where(x => char.IsDigit(x) || x == '.').ToArray()).Insert(0, "-") : new String(isStr.Where(x => char.IsDigit(x) || x == '.').ToArray()); // extracts everything but numbers and displays only numbers

        public void CheckKeyPress(KeyPressEventArgs e) // allows user to only enter numeric values 
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
