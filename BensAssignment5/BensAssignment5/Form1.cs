using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BensAssignment5.BPUtilityClasses;
//-----------------------------------
// Ben Powers
// Assignment 5 (Utility Classes)
// Student Number 7986250
// Wednesday, August 8, 2018
//-----------------------------------

namespace BensAssignment5
{
    public partial class Form1 : Form
    {
        BPNumericUtilities numbers = new BPNumericUtilities(); //instance of BPNumericUtilites class
        BPValidations valid = new BPValidations(); // instance of BPValidations class

        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e) // Submit Button to display results
        {
            try // try catch to handle errors 
            {
                // calling BPNumericUtilites, BPStringUtilites, and BPValidation classes
                isNumericLbl.Text = numbers.IsNumeric(isNumericStringTextBox.Text).ToString();

                isNumeriObjLbl.Text = numbers.IsNumeric(isNumericObjectTextBox).ToString();

                isIntStringLbl.Text = numbers.IsInteger(isIntegerStringTextBox.Text).ToString();

                isIntegerDoubleLbl.Text = double.TryParse(isIntegerDoubleTextBox.Text, out double result) ? numbers.IsInteger(result).ToString() : false.ToString();

                isIntergerObjLbl.Text = numbers.IsInteger(isIntegerObjectTextBox).ToString();

                returnNumericLbl.Text = numbers.ReturnNumeric(returnNumericTextBox.Text);

                capitalizeFirstCharLbl.Text = BPStringUtilities.CapitalizeFirstCharacter(capitalizeFirstCharacterTextBox.Text);

                onlyDigitsLbl.Text = BPStringUtilities.OnlyDigits(getOnlyDigitsTextBox.Text);

                reformattingPhoneNumLbl.Text = BPStringUtilities.ReformattingPhoneNumbers(reformattingPhoneNumTextBox.Text);

                reformattingPostalCodeLbl.Text = BPStringUtilities.ReformattingPostalCode(reformattingPostalCodeTextBox.Text);

                reformattingZipCodeLbl.Text = BPStringUtilities.ReformattingZipCode(reformattingZipCodeTextBox.Text);

                fullNmLbl.Text = BPStringUtilities.FullName(firstNameTextBox.Text, lastNameTextBox.Text);

                postalCodeValidationLbl.Text = valid.ValidatePostalCode(postalCodeValidationTextBox.Text).ToString();

                zipCodeValidationLbl.Text = valid.ValidateUsZipCode(zipCodeValidationTextBox.Text).ToString();

                phoneNumberValidationLbl.Text = valid.ValidatePhoneNumber(phoneNumberValidationTextBox.Text).ToString();
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void textBoxCheckKeyPress_KeyPress(object sender, KeyPressEventArgs e) 
        {
            numbers.CheckKeyPress(e); // allows user to only enter numeric values
        }

        private void buttonPrefill_Click_1(object sender, EventArgs e) // pre fill with all correct answers
        {
            isNumericStringTextBox.Text = "100";
            isNumericObjectTextBox.Text = "1000";
            isIntegerStringTextBox.Text = "2000";
            isIntegerDoubleTextBox.Text = "2323";
            isIntegerObjectTextBox.Text = "2323";
            returnNumericTextBox.Text = "23232";
            capitalizeFirstCharacterTextBox.Text = "ben";
            getOnlyDigitsTextBox.Text = "12ben12powers12";
            reformattingPhoneNumTextBox.Text = "1234567890";
            reformattingPostalCodeTextBox.Text = "n2a3b8";
            reformattingZipCodeTextBox.Text = "12345";
            firstNameTextBox.Text = "benjamin";
            lastNameTextBox.Text = "powers";
            postalCodeValidationTextBox.Text = "n2b 3b8";
            zipCodeValidationTextBox.Text = "12334";
            phoneNumberValidationTextBox.Text = "5195955959";
        }
    }
}
