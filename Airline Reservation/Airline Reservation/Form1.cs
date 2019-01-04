using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-------------------------
// Ben Powers
// Assignment 1 (Airline Reservation From)
// Student Number 7986250
// "Friday, May 31, 2018"
//-------------------------
namespace Airline_Reservation
{
    // Multi Dimension Array used for reservations and cancellations
    public partial class BensAirLineReservation : Form
    {
        Button[,] buttonArray = new Button[5, 3];
        public BensAirLineReservation()
        {
            InitializeComponent();

            buttonArray[0, 0] = airlineButton1;
            buttonArray[0, 1] = airlineButton2;
            buttonArray[0, 2] = airlineButton3;
            buttonArray[1, 0] = airlineButton4;
            buttonArray[1, 1] = airlineButton5;
            buttonArray[1, 2] = airlineButton6;
            buttonArray[2, 0] = airlineButton7;
            buttonArray[2, 1] = airlineButton8;
            buttonArray[2, 2] = airlineButton9;
            buttonArray[3, 0] = airlineButton10;
            buttonArray[3, 1] = airlineButton11;
            buttonArray[3, 2] = airlineButton12;
            buttonArray[4, 0] = airlineButton13;
            buttonArray[4, 1] = airlineButton14;
            buttonArray[4, 2] = airlineButton15;
        }

        // Button book click for show all and seat color reservation
        private void buttonBook_Click(object sender, EventArgs e)
        {
            if(textBoxUserName.Text != "")
            {                
                int row = listBoxRow.SelectedIndex;
                int column = listBoxColumn.SelectedIndex;

                if(buttonArray[row, column].BackColor != Color.Red)
                {
                    textBoxShowAll.Text += "Passenger: " + textBoxUserName.Text + " Seat NO.: " + listBoxRow.GetItemText(listBoxRow.SelectedItem) + listBoxColumn.SelectedIndex + "\r\n";
                    buttonArray[row, column].BackColor = Color.Red;
                    buttonArray[row, column].Text = textBoxUserName.Text;
                    MessageBox.Show("You have booked a seat!");
                }
                else
                    MessageBox.Show("This seat is already booked!");
                    textBoxUserName.ResetText();

            }
            else
            {
                MessageBox.Show("Please enter your name!");
            }
        }

        // Cancels Reservations for all passengers booked
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                int row = listBoxRow.SelectedIndex;
                int column = listBoxColumn.SelectedIndex;

                textBoxShowAll.Text = "";
                textBoxShowWaitingList.Text = "";
                buttonArray[row, column].BackColor = Color.Green;
                buttonArray[row, column].Text = "";
                MessageBox.Show("You have cancelled your seat!");
            }
            catch
            {
                MessageBox.Show("Nothing to cancel!");
            }

        }

        // Adds passengers to waitlist only if all seats are booked
        private void buttonAddToWaitingList_Click(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = 0; i < buttonArray.GetLength(0); i++)
            {
                for (int j = 0; j < buttonArray.GetLength(1); j++)
                {
                    if (buttonArray[i, j].BackColor != Color.Red)
                        count++;
                }

            }

            if (count != 0)
                MessageBox.Show("Seats are still available!");
            else
            {
                textBoxShowWaitingList.Text += "Passenger: " + textBoxUserName.Text + " Seat NO.: " + listBoxRow.GetItemText(listBoxRow.SelectedItem) + listBoxColumn.SelectedIndex + "\r\n";
                MessageBox.Show("You have been added to the waitlist!");
            }
        }

        // Clears all resevervations for current passengers
        private void clearAllButton_Click(object sender, EventArgs e)
        {
            int row = listBoxRow.SelectedIndex;
            int column = listBoxColumn.SelectedIndex;

            foreach (Button b in buttonArray)
            {
                b.BackColor = Color.Green;
                b.Text = "";
            }

            textBoxShowAll.Text = "";

        }

        // Allows user to click buttons to reserve a seat
        private void airlineButton1_Click_1(object sender, EventArgs e)
        {
            listBoxRow.SelectedIndex = 0;
            listBoxColumn.SelectedIndex = 0;
        }

        // Allows user to click buttons to reserve a seat
        private void airlineButton2_Click(object sender, EventArgs e)
        {
            listBoxRow.SelectedIndex = 0;
            listBoxColumn.SelectedIndex = 1;
        }

        // Allows user to click buttons to reserve a seat
        private void airlineButton3_Click(object sender, EventArgs e)
        {
            listBoxRow.SelectedIndex = 0;
            listBoxColumn.SelectedIndex = 2;
        }

        // Allows user to click buttons to reserve a seat
        private void airlineButton4_Click(object sender, EventArgs e)
        {
            listBoxRow.SelectedIndex = 1;
            listBoxColumn.SelectedIndex = 0;
        }

        // Allows user to click buttons to reserve a seat
        private void airlineButton5_Click(object sender, EventArgs e)
        {
            listBoxRow.SelectedIndex = 1;
            listBoxColumn.SelectedIndex = 1;
        }

        // Allows user to click buttons to reserve a seat
        private void airlineButton6_Click(object sender, EventArgs e)
        {
            listBoxRow.SelectedIndex = 1;
            listBoxColumn.SelectedIndex = 2;
        }

        // Allows user to click buttons to reserve a seat
        private void airlineButton7_Click(object sender, EventArgs e)
        {
            listBoxRow.SelectedIndex = 2;
            listBoxColumn.SelectedIndex = 0;
        }

        // Allows user to click buttons to reserve a seat
        private void airlineButton8_Click(object sender, EventArgs e)
        {
            listBoxRow.SelectedIndex = 2;
            listBoxColumn.SelectedIndex = 1;
        }

        // Allows user to click buttons to reserve a seat
        private void airlineButton9_Click(object sender, EventArgs e)
        {
            listBoxRow.SelectedIndex = 2;
            listBoxColumn.SelectedIndex = 2;
        }

        // Allows user to click buttons to reserve a seat
        private void airlineButton10_Click(object sender, EventArgs e)
        {
            listBoxRow.SelectedIndex = 3;
            listBoxColumn.SelectedIndex = 0;
        }

        // Allows user to click buttons to reserve a seat
        private void airlineButton11_Click(object sender, EventArgs e)
        {
            listBoxRow.SelectedIndex = 3;
            listBoxColumn.SelectedIndex = 1;
        }

        // Allows user to click buttons to reserve a seat
        private void airlineButton12_Click(object sender, EventArgs e)
        {
            listBoxRow.SelectedIndex = 3;
            listBoxColumn.SelectedIndex = 2;
        }

        // Allows user to click buttons to reserve a seat
        private void airlineButton13_Click(object sender, EventArgs e)
        {
            listBoxRow.SelectedIndex = 4;
            listBoxColumn.SelectedIndex = 0;
        }

        // Allows user to click buttons to reserve a seat
        private void airlineButton14_Click(object sender, EventArgs e)
        {
            listBoxRow.SelectedIndex = 4;
            listBoxColumn.SelectedIndex = 1;
        }

        // Allows user to click buttons to reserve a seat
        private void airlineButton15_Click(object sender, EventArgs e)
        {
            listBoxRow.SelectedIndex = 4;
            listBoxColumn.SelectedIndex = 2;
        }

        // Fills all seats with same passenger name 
        private void buttonFillAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < buttonArray.GetLength(0); i++)
            {
                for (int j = 0; j < buttonArray.GetLength(1); j++)
                {
                    if (buttonArray[i, j].BackColor != Color.Red)
                    {
                        buttonArray[i, j].BackColor = Color.Red;
                        buttonArray[i, j].Text = "Ben Powers";
                    }
                       
                }

            }
        }


    }
}
