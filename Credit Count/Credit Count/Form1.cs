using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs; // Implementing My_Dialogs.cs into the program

namespace Credit_Count
{
    public partial class Form1 : Form
    {
        int count1p = 0, count2p = 0, count5p = 0, count10p = 0, count20p = 0, count50p = 0, count100p = 0, count200p = 0;
        int total_pence; // Defining individual integers for each coin in GBP currency that as as counters for their respective units or coins
        double total_mixed;
        int Number_of_Credits; // An integer to define the sum of clicked coins in pence and a double acting as the decimal counterpart, also an int to as a counter for the number of credits outputted
        
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count1p = count1p - count1p; // deducts count1p by itself therefore essentially resetting itself
            textBox_Counter_1p.Text = count1p.ToString(); // Sets count1p back to 0 publically
            count2p = count2p - count2p; // deducts count2p by itself therefore essentially resetting itself
            textBox_Counter_2p.Text = count2p.ToString(); // Sets count2p back to 0 publically
            count5p = count5p - count5p; // deducts count5p by itself therefore essentially resetting itself
            textBox_Counter_5p.Text = count5p.ToString(); // Sets count5p back to 0 publically
            count10p = count10p - count10p; // deducts count10p by itself therefore essentially resetting itself
            textBox_Counter_10p.Text = count10p.ToString(); // Sets count10p back to 0 publically
            count20p = count20p - count20p; // deducts count20p by itself therefore essentially resetting itself
            textBox_Counter_20p.Text = count20p.ToString(); // Sets count20p back to 0 publically
            count50p = count50p - count50p; // deducts count50p by itself therefore essentially resetting itself
            textBox_Counter_50p.Text = count50p.ToString(); // Sets count50p back to 0 publically
            count100p = count100p - count100p; // deducts count100p by itself therefore essentially resetting itself
            textBox_Counter_100p.Text = count100p.ToString(); // Sets count100p back to 0 publically
            count200p = count200p - count200p; // deducts count200p by itself therefore essentially resetting itself
            textBox_Counter_200p.Text = count200p.ToString(); // Sets count200p back to 0 publically
            total_mixed = total_mixed - total_mixed; // deducts total_mixed by itself therefore essentially resetting itself
            textBox_TotalValueMixed.Text = total_mixed.ToString(); // Sets decimal total of clicked coins back to 0 publically
            total_pence = total_pence - total_pence; // deducts total_pence by itself therefore essentially resetting itself
            textBox_TotalValue.Text = total_pence.ToString(); // Sets total of clicked coins back to 0 publically
            Number_of_Credits = Number_of_Credits - Number_of_Credits; // deducts Number_of_Credits by itself therefore essentially resetting itself
            textBox_NumberOfCredits.Text = Number_of_Credits.ToString(); // Sets credit total back to 0 publically
            textBox_CostPerCredit.Text = (""); // resets the cost per credit inputbox to blank
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_NumberOfCredits_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_CostPerCredit_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_Coins_1p_Click(object sender, EventArgs e) // event triggers on the click of the 1p coin
        {
            if (textBox_CostPerCredit.Text == "0" || textBox_CostPerCredit.Text == "") // if the inputted cost per credit is either 0 or blank
            { // An if statement that triggers when the Cost Per Credit inputbox has a legitimate value for an input
                MessageBox.Show("You have not entered the cost of a credit!"); // Message prompt to indicate no/an incorrect input is currently in use for the cost per credit
            }
            else count1p = count1p + 1; // the count of 1ps increments (a previously mentioned variable)
            textBox_Counter_1p.Text = count1p.ToString(); // increments the count of inputted 1ps by 1
            total_pence = total_pence + 1; // increments the total count of inputted currency by 1p per instance
            textBox_TotalValue.Text = total_pence.ToString(); // uses the aforementioned increment to convert into string format 
            total_mixed = total_mixed + 0.01; // increments the total count of inputted currency by 0.01
            textBox_TotalValueMixed.Text = total_mixed.ToString(); // converts said variable to string for following code
            Number_of_Credits = total_pence / Convert.ToInt32(textBox_CostPerCredit.Text); // divides total inputted in pence by converted cost per credit to finalize a number of credits
                textBox_NumberOfCredits.Text = Number_of_Credits.ToString(); // converts this number of credits into a string format for displaying in the user program view
        }

        private void pictureBox_Coins_2p_Click(object sender, EventArgs e) // event triggers on the click of the 2p coin
        {
            if (textBox_CostPerCredit.Text == "0" || textBox_CostPerCredit.Text == "")  // if the inputted cost per credit is either 0 or blank
            {
                MessageBox.Show("You have not entered the cost of a credit!"); //Message prompt indicates no/incorrect input for cost per credit
            }
            else count2p = count2p + 1; // the count of 2ps increments (a previously mentioned variable)
            textBox_Counter_2p.Text = count2p.ToString(); // increments the count of inputted 2ps by 1
            total_pence = total_pence + 2; // increments the total count of inputted currency by 2p per instance
            textBox_TotalValue.Text = total_pence.ToString(); // uses the aforementioned increment to convert into string format
            total_mixed = total_mixed + 0.02; // increments the total count of inputted currency by 0.02
            textBox_TotalValueMixed.Text = total_mixed.ToString(); // converts said variable to string for following code
            Number_of_Credits = total_pence / Convert.ToInt32(textBox_CostPerCredit.Text); // divides total inputted in pence by converted cost per credit to finalize a number of credits
            textBox_NumberOfCredits.Text = Number_of_Credits.ToString(); // converts this number of credits into a string format for displaying in the user program view
        }

        private void pictureBox_Coins_5p_Click(object sender, EventArgs e) // event triggers on the click of the 5p coin
        {
            if (textBox_CostPerCredit.Text == "0" || textBox_CostPerCredit.Text == "")  // if the inputted cost per credit is either 0 or blank
            {
                MessageBox.Show("You have not entered the cost of a credit!"); //Message prompt indicates no/incorrect input for cost per credit
            }
            else count5p = count5p + 1; // the count of 5ps increments (a previously mentioned variable)
            textBox_Counter_5p.Text = count5p.ToString(); // increments the count of inputted 5ps by 1
            total_pence = total_pence + 5; // increments the total count of inputted currency by 5p per instance
            textBox_TotalValue.Text = total_pence.ToString(); // uses the aforementioned increment to convert into string format
            total_mixed = total_mixed + 0.05; // increments the total count of inputted currency by 0.05
            textBox_TotalValueMixed.Text = total_mixed.ToString(); // converts said variable to string for following code
            Number_of_Credits = total_pence / Convert.ToInt32(textBox_CostPerCredit.Text); // divides total inputted in pence by converted cost per credit to finalize a number of credits
            textBox_NumberOfCredits.Text = Number_of_Credits.ToString(); // converts this number of credits into a string format for displaying in the user program view
        }

        private void pictureBox_Coins_10p_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Coins_20p_Click(object sender, EventArgs e)
        {
 
        }

        private void pictureBox_Coins_50p_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Coins_100p_Click(object sender, EventArgs e)
        {
 
        }

        private void pictureBox_Coins_200p_Click(object sender, EventArgs e)
        {
 
        }

        private void pictureBox_Coins_10p_Click_1(object sender, EventArgs e) // event triggers on the click of the 10p coin
        {
            if (textBox_CostPerCredit.Text == "0" || textBox_CostPerCredit.Text == "")  // if the inputted cost per credit is either 0 or blank
            {
                MessageBox.Show("You have not entered the cost of a credit!"); //Message prompt indicates no/incorrect input for cost per credit
            }
            else count10p = count10p + 1; // the count of 10ps increments (a previously mentioned variable)
            textBox_Counter_10p.Text = count10p.ToString(); // increments the count of inputted 10ps by 1
            total_pence = total_pence + 10; // increments the total count of inputted currency by 10p per instance
            textBox_TotalValue.Text = total_pence.ToString(); // uses the aforementioned increment to convert into string format
            total_mixed = total_mixed + 0.10; // increments the total count of inputted currency by 0.1
            textBox_TotalValueMixed.Text = total_mixed.ToString(); // converts said variable to string for following code
            Number_of_Credits = total_pence / Convert.ToInt32(textBox_CostPerCredit.Text); // divides total inputted in pence by converted cost per credit to finalize a number of credits
            textBox_NumberOfCredits.Text = Number_of_Credits.ToString(); // converts this number of credits into a string format for displaying in the user program view
        }

        private void pictureBox_Coins_20p_Click_1(object sender, EventArgs e) // event triggers on the click of the 20p coin
        {
            if (textBox_CostPerCredit.Text == "0" || textBox_CostPerCredit.Text == "")  // if the inputted cost per credit is either 0 or blank
            {
                MessageBox.Show("You have not entered the cost of a credit!"); //Message prompt indicates no/incorrect input for cost per credit
            }
            else count20p = count20p + 1; // the count of 20ps increments (a previously mentioned variable)
            textBox_Counter_20p.Text = count20p.ToString(); // increments the count of inputted 20ps by 1
            total_pence = total_pence + 20; // increments the total count of inputted currency by 20p per instance
            textBox_TotalValue.Text = total_pence.ToString(); // uses the aforementioned increment to convert into string format
            total_mixed = total_mixed + 0.20; // increments the total count of inputted currency by 0.2
            textBox_TotalValueMixed.Text = total_mixed.ToString(); // converts said variable to string for following code
            Number_of_Credits = total_pence / Convert.ToInt32(textBox_CostPerCredit.Text); // divides total inputted in pence by converted cost per credit to finalize a number of credits
            textBox_NumberOfCredits.Text = Number_of_Credits.ToString(); // converts this number of credits into a string format for displaying in the user program view
        }

        private void pictureBox_Coins_50p_Click_1(object sender, EventArgs e) // event triggers on the click of the 50p coin
        {
            if (textBox_CostPerCredit.Text == "0" || textBox_CostPerCredit.Text == "")  // if the inputted cost per credit is either 0 or blank
            {
                MessageBox.Show("You have not entered the cost of a credit!"); //Message prompt indicates no/incorrect input for cost per credit
            }
            else count50p = count50p + 1; // the count of 50ps increments (a previously mentioned variable)
            textBox_Counter_50p.Text = count50p.ToString(); // increments the count of inputted 50ps by 1
            total_pence = total_pence + 50; // increments the total count of inputted currency by 50p per instance
            textBox_TotalValue.Text = total_pence.ToString(); // uses the aforementioned increment to convert into string format
            total_mixed = total_mixed + 0.50; // increments the total count of inputted currency by 0.5
            textBox_TotalValueMixed.Text = total_mixed.ToString(); // converts said variable to string for following code
            Number_of_Credits = total_pence / Convert.ToInt32(textBox_CostPerCredit.Text); // divides total inputted in pence by converted cost per credit to finalize a number of credits
            textBox_NumberOfCredits.Text = Number_of_Credits.ToString(); // converts this number of credits into a string format for displaying in the user program view
        }

        private void pictureBox_Coins_100p_Click_1(object sender, EventArgs e) // event triggers on the click of the 100p coin
        {
            if (textBox_CostPerCredit.Text == "0" || textBox_CostPerCredit.Text == "")  // if the inputted cost per credit is either 0 or blank
            {
                MessageBox.Show("You have not entered the cost of a credit!"); //Message prompt indicates no/incorrect input for cost per credit
            }
            else count100p = count100p + 1; // the count of 100ps increments (a previously mentioned variable)
            textBox_Counter_100p.Text = count100p.ToString(); // increments the count of inputted 100ps by 1
            total_pence = total_pence + 100; // increments the total count of inputted currency by 100p per instance
            textBox_TotalValue.Text = total_pence.ToString(); // uses the aforementioned increment to convert into string format
            total_mixed = total_mixed + 1.00; // increments the total count of inputted currency by 1
            textBox_TotalValueMixed.Text = total_mixed.ToString(); // converts said variable to string for following code
            Number_of_Credits = total_pence / Convert.ToInt32(textBox_CostPerCredit.Text); // divides total inputted in pence by converted cost per credit to finalize a number of credits
            textBox_NumberOfCredits.Text = Number_of_Credits.ToString(); // converts this number of credits into a string format for displaying in the user program view
        }

        private void pictureBox_Coins_200p_Click_1(object sender, EventArgs e) // event triggers on the click of the 200p coin
        {
            if (textBox_CostPerCredit.Text == "0" || textBox_CostPerCredit.Text == "")  // if the inputted cost per credit is either 0 or blank
            {
                MessageBox.Show("You have not entered the cost of a credit!"); //Message prompt indicates no/incorrect input for cost per credit
            }
            else count200p = count200p + 1; // the count of 200ps increments (a previously mentioned variable)
            textBox_Counter_200p.Text = count200p.ToString(); // increments the count of inputted 200ps by 1
            total_pence = total_pence + 200; // increments the total count of inputted currency by 200p per instance
            textBox_TotalValue.Text = total_pence.ToString(); // uses the aforementioned increment to convert into string format
            total_mixed = total_mixed + 2.00; // increments the total count of inputted currency by 2
            textBox_TotalValueMixed.Text = total_mixed.ToString(); // converts said variable to string for following code
            Number_of_Credits = total_pence / Convert.ToInt32(textBox_CostPerCredit.Text); // divides total inputted in pence by converted cost per credit to finalize a number of credits
            textBox_NumberOfCredits.Text = Number_of_Credits.ToString(); // converts this number of credits into a string format for displaying in the user program view
        }
    }
}