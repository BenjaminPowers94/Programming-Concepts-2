using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
//-----------------------------------
// Ben Powers
// Assignment 2 (Member Maitinence)
// Student Number 7986250
// Friday, June 15, 2018
//-----------------------------------

namespace BensMemberMaitinence
{   
    public partial class Form1 : Form
    {
        string firstName; 
        string lastName;
        string spouseFirstName;
        string spouseLastName;
        string address;
        string city;
        string provinceCode;
        string postalCode;
        string phoneNumbers;
        string email;
        string fee;

        public Form1()
        {
            InitializeComponent();
        }
        //Submit button 
        private void submitButton_Click(object sender, EventArgs e)
        {
            firstName = memberFirstNameTextBox.Text;
            if (memberFirstNameTextBox.Text.Length > 0)
            {
                memberFirstNameTextBox.Text = Capitalize(firstName);
                memberFirstNameTextBox.BackColor = Color.LightGreen;
                firstLabel.Text = memberFirstNameTextBox.Text;
            }
            else
            {
                MessageBox.Show("Please Enter A Valid First Name");
                memberFirstNameTextBox.BackColor = Color.OrangeRed;                
            }

            lastName = memberLastNameTextBox.Text;
            if (memberLastNameTextBox.Text.Length > 0)
            {
                memberLastNameTextBox.Text = Capitalize(lastName);
                memberLastNameTextBox.BackColor = Color.LightGreen;
                lastLabel.Text = memberLastNameTextBox.Text;
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Last Name");
                memberLastNameTextBox.BackColor = Color.OrangeRed;
            }

            spouseFirstName = spousesFirstNameTextBox.Text;
            if (spousesFirstNameTextBox.Text.Length > 0)
            {
                spousesFirstNameTextBox.Text = Capitalize(spouseFirstName);
                spousesFirstNameTextBox.BackColor = Color.LightGreen;
                sFirstLabel.Text = spousesFirstNameTextBox.Text;
            }
            else
            {
                spousesFirstNameTextBox.BackColor = Color.OrangeRed;
            }

            spouseLastName = spousesLastNameTextBox.Text;
            if (spousesLastNameTextBox.Text.Length > 0)
            {
                spousesLastNameTextBox.Text = Capitalize(spouseLastName);
                spousesLastNameTextBox.BackColor = Color.LightGreen;
                sLastLabel.Text = spousesLastNameTextBox.Text;             
            }
            else
            {
                spousesLastNameTextBox.BackColor = Color.OrangeRed;
            }

            address = streetAddressTextBox.Text;
            if (streetAddressTextBox.Text.Length > 0)
            {
                streetAddressTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Street Address");
                streetAddressTextBox.BackColor = Color.OrangeRed;
            }

            city = cityTextBox.Text;
            if (cityTextBox.Text.Length > 0)
            {
                cityTextBox.Text = Capitalize(city);
                cityTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                MessageBox.Show("Please Enter A Valid City");
                cityTextBox.BackColor = Color.OrangeRed;
            }

            provinceCode = provinceCodeTextBox.Text;
            if (provinceCodeTextBox.Text.Length == 2)
            {
                provinceCodeTextBox.Text = provinceCode.ToUpper();
                provinceCodeTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Province Code");
                provinceCodeTextBox.BackColor = Color.OrangeRed;
            }

            postalCode = postalCodeTextBox.Text;
            if(postalCodeTextBox.Text.Length > 0)
            {
                postalCodeTextBox.Text = postalCode.ToUpper();
                postalCodeTextBox.BackColor = Color.LightGreen;
            }

            phoneNumbers = homePhoneTextBox.Text;
            phoneNumbers = phoneNumbers.Replace(" ", "");
            phoneNumbers = phoneNumbers.Replace("-", "");
            homePhoneTextBox.Text = phoneNumbers;
            if (homePhoneTextBox.Text.Length > 0)
            {
                homePhoneTextBox.BackColor = Color.LightGreen;
                homePhoneTextBox.Text = homePhoneTextBox.Text.Substring(0, 3) + "-" +
                homePhoneTextBox.Text.Substring(3, 3) + "-" +
                homePhoneTextBox.Text.Substring(6);
            }

            email = emailTextBox.Text;
            if (emailTextBox.Text.Length > 0)
            {
                emailTextBox.Text = email.ToLower();
                emailTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Email Address");
                emailTextBox.BackColor = Color.OrangeRed;
            }

            fee = feeTextBox.Text;
            if (feeTextBox.Text.Length > 0)
            {
                double dfee = 0.0;
                double.TryParse(fee, out dfee);
                feeTextBox.Text = string.Format("{0:00.00}", dfee);
                feeTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Fee");
                feeTextBox.BackColor = Color.OrangeRed;
            }

            // Booleans for Postal Code and Phone Number validations
            bool postalTest = true;
            bool phoneTest = true;
            if (!EmailValidation(email) || postalCode != "")
                postalTest = PostalCodeValidation(postalCode); // postal code bool
            else
                postalCodeTextBox.BackColor = Color.LightGreen;

            phoneTest = PhoneNumberValidation(phoneNumbers); // phone number bool
            if (postalTest == false)
            {
                MessageBox.Show("Please Enter A Valid Postal Code");
                postalCodeTextBox.BackColor = Color.OrangeRed;
            }
            if (phoneTest == false)
            {
                MessageBox.Show("Please Enter A Valid Phone Number");
                homePhoneTextBox.BackColor = Color.OrangeRed;
            }  
        }
        //Auto Fills Form
        private void preFillButton_Click(object sender, EventArgs e)
        {
            memberFirstNameTextBox.Text = "Johnny";
            memberLastNameTextBox.Text = "Sampson";
            spousesFirstNameTextBox.Text = "Suzy";
            spousesLastNameTextBox.Text = "Smith";
            streetAddressTextBox.Text = "21 Young Ave";
            cityTextBox.Text = "Toronto";
            provinceCodeTextBox.Text = "ON";
            postalCodeTextBox.Text = "N2B 4B7";
            homePhoneTextBox.Text = "519-616-1289";
            emailTextBox.Text = "Johnny@yahoo.ca";
            feeTextBox.Text = "700.00";
            firstLabel.Text = "";
            lastLabel.Text = "";
            sFirstLabel.Text = "";
            sLastLabel.Text = "";
        }
        //Closes the program
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Capitalizes method
        public string Capitalize(string value)
        {
            try
            {
                value = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
            catch (System.IndexOutOfRangeException ex)
            {
                MessageBox.Show("Error Occured: " + ex.Message + " Fill required field properly");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some sort of error occured: " + ex.Message);
            }
            return value;
        }
        //Method to validate postal codes 
        public bool PostalCodeValidation(string postal)
        {
            postal = postal.ToUpper();
            postal = postal.Replace(" ", "");
            string pattern = "^[ABCEGHJ-NPRSTVXY]{1}[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[ ]?[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[0-9]{1}$";

            Regex reg = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);

            if (!(reg.IsMatch(postal)))
                return false;
            return true;
        }
        //Method That Validates Phone Numbers
        public bool PhoneNumberValidation(string phoneNumber)
        {
            string pattern = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            Regex reg = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);

            if (!(reg.IsMatch(phoneNumber)))
                return false;
            return true;
        }
        //Method That Validates Email
        public bool EmailValidation(string email)
        {
            string pattern = @"^\w+@\w+\.\w+$";
            Regex reg = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);

            if (!(reg.IsMatch(email)))
                return false;
            return true;
        }
    }
}
