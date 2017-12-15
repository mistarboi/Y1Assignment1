using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs;

namespace Credit_Count
{
    public partial class Form1 : Form
    {
        int count1p = 0, count2p = 0, count5p = 0, count10p = 0, count20p = 0, count50p = 0, count100p = 0, count200p = 0;
        int total_pence;
        double total_mixed;
        int Number_of_Credits;
        
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void pictureBox_Coins_1p_Click(object sender, EventArgs e)
        {
            if (textBox_CostPerCredit.Text == "0" || textBox_CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not entered the cost of a credit!");
            }
            else count1p = count1p + 1;
            textBox_Counter_1p.Text = count1p.ToString();
            total_pence = total_pence + 1;
            textBox_TotalValue.Text = total_pence.ToString();
            total_mixed = total_mixed + 0.01;
            textBox_TotalValueMixed.Text = total_mixed.ToString();
            Number_of_Credits = total_pence / Convert.ToInt32(textBox_CostPerCredit.Text);
            textBox_NumberOfCredits.Text = Number_of_Credits.ToString();
        }

        private void pictureBox_Coins_2p_Click(object sender, EventArgs e)
        {
            if (textBox_CostPerCredit.Text == "0" || textBox_CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not entered the cost of a credit!");
            }
            else count2p = count2p + 1;
            textBox_Counter_2p.Text = count2p.ToString();
            total_pence = total_pence + 2;
            textBox_TotalValue.Text = total_pence.ToString();
            total_mixed = total_mixed + 0.02;
            textBox_TotalValueMixed.Text = total_mixed.ToString();
            Number_of_Credits = total_pence / Convert.ToInt32(textBox_CostPerCredit.Text);
            textBox_NumberOfCredits.Text = Number_of_Credits.ToString();
        }

        private void pictureBox_Coins_5p_Click(object sender, EventArgs e)
        {
            if (textBox_CostPerCredit.Text == "0" || textBox_CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not entered the cost of a credit!");
            }
            else count5p = count5p + 1;
            textBox_Counter_5p.Text = count5p.ToString();
            total_pence = total_pence + 5;
            textBox_TotalValue.Text = total_pence.ToString();
            total_mixed = total_mixed + 0.05;
            textBox_TotalValueMixed.Text = total_mixed.ToString();
            Number_of_Credits = total_pence / Convert.ToInt32(textBox_CostPerCredit.Text);
            textBox_NumberOfCredits.Text = Number_of_Credits.ToString();
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

        private void pictureBox_Coins_10p_Click_1(object sender, EventArgs e)
        {
            if (textBox_CostPerCredit.Text == "0" || textBox_CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not entered the cost of a credit!");
            }
            else count10p = count10p + 1;
            textBox_Counter_10p.Text = count10p.ToString();
            total_pence = total_pence + 10;
            textBox_TotalValue.Text = total_pence.ToString();
            total_mixed = total_mixed + 0.10;
            textBox_TotalValueMixed.Text = total_mixed.ToString();
            Number_of_Credits = total_pence / Convert.ToInt32(textBox_CostPerCredit.Text);
            textBox_NumberOfCredits.Text = Number_of_Credits.ToString();
        }

        private void pictureBox_Coins_20p_Click_1(object sender, EventArgs e)
        {
            if (textBox_CostPerCredit.Text == "0" || textBox_CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not entered the cost of a credit!");
            }
            else count20p = count20p + 1;
            textBox_Counter_20p.Text = count20p.ToString();
            total_pence = total_pence + 20;
            textBox_TotalValue.Text = total_pence.ToString();
            total_mixed = total_mixed + 0.20;
            textBox_TotalValueMixed.Text = total_mixed.ToString();
            Number_of_Credits = total_pence / Convert.ToInt32(textBox_CostPerCredit.Text);
            textBox_NumberOfCredits.Text = Number_of_Credits.ToString();
        }

        private void pictureBox_Coins_50p_Click_1(object sender, EventArgs e)
        {
            if (textBox_CostPerCredit.Text == "0" || textBox_CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not entered the cost of a credit!");
            }
            else count50p = count50p + 1;
            textBox_Counter_50p.Text = count50p.ToString();
            total_pence = total_pence + 50;
            textBox_TotalValue.Text = total_pence.ToString();
            total_mixed = total_mixed + 0.50;
            textBox_TotalValueMixed.Text = total_mixed.ToString();
            Number_of_Credits = total_pence / Convert.ToInt32(textBox_CostPerCredit.Text);
            textBox_NumberOfCredits.Text = Number_of_Credits.ToString();
        }

        private void pictureBox_Coins_100p_Click_1(object sender, EventArgs e)
        {
            if (textBox_CostPerCredit.Text == "0" || textBox_CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not entered the cost of a credit!");
            }
            else count100p = count100p + 1;
            textBox_Counter_100p.Text = count100p.ToString();
            total_pence = total_pence + 100;
            textBox_TotalValue.Text = total_pence.ToString();
            total_mixed = total_mixed + 1.00;
            textBox_TotalValueMixed.Text = total_mixed.ToString();
            Number_of_Credits = total_pence / Convert.ToInt32(textBox_CostPerCredit.Text);
            textBox_NumberOfCredits.Text = Number_of_Credits.ToString();
        }

        private void pictureBox_Coins_200p_Click_1(object sender, EventArgs e)
        {
            if (textBox_CostPerCredit.Text == "0" || textBox_CostPerCredit.Text == "")
            {
                MessageBox.Show("You have not entered the cost of a credit!");
            }
            else count200p = count200p + 1;
            textBox_Counter_200p.Text = count200p.ToString();
            total_pence = total_pence + 200;
            textBox_TotalValue.Text = total_pence.ToString();
            total_mixed = total_mixed + 2.00;
            textBox_TotalValueMixed.Text = total_mixed.ToString();
            Number_of_Credits = total_pence / Convert.ToInt32(textBox_CostPerCredit.Text);
            textBox_NumberOfCredits.Text = Number_of_Credits.ToString();
        }
    }
}