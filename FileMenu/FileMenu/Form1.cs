using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//-----------------------------------
// Ben Powers
// Assignment 3 (File Menu)
// Student Number 7986250
// Wednesday, July 11, 2018
//-----------------------------------

namespace FileMenu
{
    public partial class FormFiles : Form
    {
        public FormFiles()
        {
            InitializeComponent();
        }

        StreamWriter sw = null;
        StreamReader sr = null;
        string fileName = "";
        string fileMode = "";

        // Allows user to create or Open an existing file
        private void createOpenButton_Click(object sender, EventArgs e)
        {
            if(createNewRadioButton.Checked) // if create new button selected create/open button will create a new file 
            {
                fileName = fileNameTextBox.Text;
                fileMode = "write";
            }
            else if(openRadioButton.Checked) // if open existing selected create/open button will open an existing file from saved files
            {
                DialogResult result = openFileDialog1.ShowDialog();
                fileName = openFileDialog1.FileName;
                fileNameTextBox.Text = fileName;
            }
            else
            {
                mdLabel.Text = fileName + "error on radio button file";
            }
            if(!File.Exists(fileName))
            {
                mdLabel.Text = fileName + "file created";
            }
            else
            {
                mdLabel.Text = fileName + "file opened for appending";
            }
        }

        // When form is filled correctly the user can click the write record button to create a file
        private void writeRecordButton_Click(object sender, EventArgs e)
        {
            string transact = "";
            string dateString = "";
            string toolPurchased = "";
            string serialNumber = "";
            double price = 0;
            int qty = 0;
            double amount = 0;
            fileMode = "write";

            // converting all text from user to strings 
            transact = transactionTextBox.Text.ToString();
            dateString = dateTextBox.Text.ToString();
            toolPurchased = purchasedTextBox.Text.ToString();
            serialNumber = sinTextBox.Text.ToString();
            string textString = "";

            if(transact != "" && dateString != "" && toolPurchased !="" && serialNumber != "" && priceTextBox.Text != "" && qtyTextBox.Text != "" & amountTextBox.Text != "") // checking to make sure everything has been inputed correctly
            {
                price = Convert.ToDouble(priceTextBox.Text); // converting into double with currency 
                qty = Convert.ToInt16(qtyTextBox.Text); // converting to integer
                amount = Convert.ToDouble(amountTextBox.Text); // converting into double with currency 

                textString = transact + "," + dateString + "," + toolPurchased + "," + serialNumber + "," + price.ToString() + "," + qty.ToString() + "," + amount.ToString(); ;

                using (sw = File.AppendText(fileName))
                {
                    sw.WriteLine(textString);
                }
                mdLabel.Text = "1 record written";

                fileNameTextBox.Text = "";
                transactionTextBox.Text = "";
                dateTextBox.Text = "";
                sinTextBox.Text = "";
                purchasedTextBox.Text = "";
                priceTextBox.Text = "";
                qtyTextBox.Text = "";
                amountTextBox.Text = "";
            }
            else
            {
                MessageBox.Show(" fields not complete");
            }
        }

        // Displays data to the RichTextBox
        private void displayDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                // read and display data
                fileMode = "read";
                fileNameTextBox.Text = fileName;
                int itemsDisplayed = 0;
                decimal price = 0;
                int qty = 0;
                decimal amount = 0;
                dataDisplayLabel.Text = "";
                string textString = "";
                string[] sArr; // array for tools 

                string fLine = "#         Purchase-Date    Serial #       Manufacturing Tools       Price    " +
                    "strin          Qty         Amount" + Environment.NewLine; // displays on top of richtextbox 
                fLine += "-----------------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;

                if (fileMode == "write")
                {
                    sw.Close();
                }

                if (fileName == "")
                    return;

                using (sr = File.OpenText(fileName))
                {
                    while (!sr.EndOfStream)
                    {
                        textString = sr.ReadLine();
                        if (textString != "")
                        {
                            sArr = textString.Split(',');
                            // using an array to organize user input and format correctly to display the data from user 
                            fLine += String.Format("{0,-4}", sArr[0]);
                            fLine += "\t" + " " + String.Format("{0,-12}", sArr[1]);
                            fLine += "\t" + " " + String.Format("{0,-5}", sArr[3]);

                            sArr[2].Trim();

                            if (sArr[2].Length < 12)
                            {
                                fLine += "\t" + " " + String.Format("{0,-20}", sArr[2]) + "\t";
                            }
                            else
                            {
                                fLine += "\t" + " " + String.Format("{0,-20}", sArr[2]);
                            }

                            price = Convert.ToDecimal(sArr[4]); // converting price to decimal 
                            qty = Convert.ToInt32(sArr[5]); // converting quantity to inerger
                            amount = Convert.ToDecimal(sArr[6]); // converting amount to decimal 

                            fLine += "\t" + " " + String.Format("{0:c}", price);
                            fLine += "\t" + " " + String.Format("{0,6}", qty);
                            fLine += "\t" + "\t" + String.Format("{0:c}", amount);
                            fLine += Environment.NewLine; // creates new line for user
                            itemsDisplayed++; // allows user to continue using the application using an array 
                        }
                    }

                    fLine += "-----------------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;

                    dataDisplayLabel.Text = fLine;

                    mdLabel.Text = " Items displayed " + itemsDisplayed;
                }
            }
            catch
            {
                MessageBox.Show("Nothing to display");
            }
        }

        // Closes the file 
        private void closeFile_Click(object sender, EventArgs e)
        {
            try // try catch to prevent error message when user trys to close file with no file open
            {
                if (fileMode == "read")
                {
                    sr.Close(); // closes the file if open
                    mdLabel.Text = fileName + " file now closed";
                    dataDisplayLabel.Text = ""; // clears form display 
                }
                else
                {
                    sw.Close();
                    mdLabel.Text = fileName + " file now closed";
                }
            }
            catch
            {
                MessageBox.Show("Nothing to close");
            }
        }

        // deletes records manually through selecting a transaction number
        private void deleteButton_Click(object sender, EventArgs e)
        {
            string transact = "";
            string textStr = null;
            string newStr = null;

            fileMode = "write";

            transact = transactionTextBox.Text.ToString();

            if (transact != "") // if transact isnt empty it will perform this if statement 
            {
                sr = File.OpenText(fileName);

                while ((textStr = sr.ReadLine()) != null)
                {
                    if (transact == textStr.Split(',')[0])
                    {
                        continue;
                    }
                    else
                    {
                        newStr += textStr + Environment.NewLine;
                    }
                }

                sr.Close();
                sw = File.CreateText(fileName);
                sw.WriteLine(newStr);

                mdLabel.Text = "Deleted the record";
                transactionTextBox.Text = "";

                sw.Close();
            }
            else
            {
                MessageBox.Show("Enter a valid transaction # to delete");
            }
        }

        // Deletes the whole File
        private void deleteAllButton_Click_1(object sender, EventArgs e)
        {
                if (File.Exists(fileName)) // if file is open on the form and user selects delete whole file it will be deleted
                {
                    File.Delete(fileName); // deletes file that is open on the form
                    mdLabel.Text = "File Deleted";
                    fileNameTextBox.Text = fileName = "";
                }
                else
                {
                    MessageBox.Show("Please Select a file to delete!"); // no file is selected to delete
                }
        }
    }
}