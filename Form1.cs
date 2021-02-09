using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Progammer: Lisa Duong
// Project: Duong_1
// Due Date: 02/17/2020
// Description: Individual Assignment #1
namespace Duong_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
   
        }

        private void dateTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void rateTextBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                // all variables
                string firstName;
                string lastName;
                double roomNumber;
                double subtotal;
                double roomcharge;
                double numberNights;
                double nightlyRate;
                double minibar;
                double telephone;
                double misc;
                double additionalcharges;
                double taxrate;
                double taxamount;
                double totalCharges;
                // guest & room information
                firstName = firstNameTextBox.Text;
                lastName = lastNameTextBox.Text;
                // Get room inputs
                roomNumber = double.Parse(roomNumberTextBox.Text);
                numberNights = double.Parse(numberNightsTextBox.Text);
                nightlyRate = double.Parse(rateTextBox.Text);
                rateTextBox.Text = nightlyRate.ToString("c");
                roomcharge = (numberNights * nightlyRate);
                roomChargesOutput.Text = roomcharge.ToString("c");
                if (string.IsNullOrEmpty(miniBarTextBox.Text) || string.IsNullOrWhiteSpace(telephoneTextBox.Text) || string.IsNullOrWhiteSpace(miscTextBox.Text))
                {
                    // If additional charges textbox is empty, run this code
                    miniBarTextBox.Text = ("$0.00");
                    telephoneTextBox.Text = ("$0.00");
                    miscTextBox.Text = ("$0.00");
                    additionalChargesOutput.Text = ("$0.00");
                    subtotal = roomcharge + 0;
                    subtotalOutput.Text = subtotal.ToString("c");
                    taxamount = subtotal * .07;
                    taxOutput.Text = taxamount.ToString("c");
                    totalCharges = subtotal + taxamount;
                    totalOutput.Text = totalCharges.ToString("c");
                    //focus on clear button
                    clearButton.Focus();
                }
                else
                {
                    // if not empty, run this code
                    minibar = double.Parse(miniBarTextBox.Text);
                    telephone = double.Parse(telephoneTextBox.Text);
                    misc = double.Parse(miscTextBox.Text);
                    miniBarTextBox.Text = minibar.ToString("c");
                    telephoneTextBox.Text = telephone.ToString("c");
                    miscTextBox.Text = misc.ToString("c");
                    additionalcharges = minibar + telephone + misc;
                    additionalChargesOutput.Text = additionalcharges.ToString("c");
                    // calculate subtotal
                    subtotal = roomcharge + additionalcharges;
                    subtotalOutput.Text = subtotal.ToString("c");
                    // calculate tax amount
                    // tax rate constant
                    // constant current tax rate, 7%
                    taxrate = .07;
                    taxamount = subtotal * taxrate;
                    taxOutput.Text = taxamount.ToString("c");
                    // calculate total charges
                    totalCharges = subtotal + taxamount;
                    totalOutput.Text = totalCharges.ToString("c");
                    // focus to clear button after
                    clearButton.Focus();
                }
            }
            // display error message     
            catch
            {
                MessageBox.Show("Invalid Input.");
            }
        
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            checkoutDatePicker.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            roomNumberTextBox.Text = "";
            numberNightsTextBox.Text = "";
            rateTextBox.Text = "";
            miniBarTextBox.Text = "";
            telephoneTextBox.Text = "";
            miscTextBox.Text = "";
            roomChargesOutput.Text = "";
            additionalChargesOutput.Text = "";
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";

            // focus to first data entry
            checkoutDatePicker.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close form when Exit button is pressed
            this.Close();
        }

        private void miniBarTextBox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            // show instructions when Help button is pressed
            MessageBox.Show("Please enter guest check-out date and proceed to fill in the following: " +
                "Guest First and Last Name, Room Number, Number of nights occupied, Nightly room rate, and additional charges which can include minibar, telephone and misc. charges. " +
                "When all completed, press Total button for the billing summary. " +
                "Press Clear button to clear all inputs and outputs. " +
                "Press Help button for this instruction message. " +
                "Press Exit button to close check-out program.");
        }

        private void checkoutDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void taxOutput_Click(object sender, EventArgs e)
        {

        }
    }
    }

