using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceCalculatorJH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtnJH_Click(object sender, EventArgs e)
        {
            // Variables used.
            const decimal ANNUAL_INTERESTJH = 0.07m;
            decimal inheritanceJH = 0.00m;
            decimal balanceJH = 0.00m;
            decimal inflationRateJH = 0m;
            decimal yearlyWithdrawalJH = 40000m;
            int yearJH = 2019;
            decimal interestEarned = 0.00m;

            // Clear the list box
            accInheritanceListBxJH.Items.Clear();

            // Get the initial inheritance amount.
            if (decimal.TryParse(inheritInputBoxJH.Text, out inheritanceJH))
            {
                // Get the initial balance after first withdrawal.
                balanceJH = inheritanceJH;
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            // Get the selected inflation rate.
            if (threeRadioBtnJH.Checked)
            {
                inflationRateJH = 0.03m;
            }
            else if(fourRadioBtnJH.Checked)
            { 
                inflationRateJH = 0.04m;
            }
            else
            {
                MessageBox.Show("WTF!! Check something, yo.");
                return;
            }
            
            // The following loop calculates annual interest earned, adding it back to the balance while taking
            // into consideration the yearly withdrawal + the inflation rate.
            while (balanceJH >= yearlyWithdrawalJH)
            {
                yearlyWithdrawalJH += inflationRateJH * yearlyWithdrawalJH;
                balanceJH += ANNUAL_INTERESTJH * balanceJH;
                interestEarned = ANNUAL_INTERESTJH * balanceJH;
                yearJH += 1;
                balanceJH -= yearlyWithdrawalJH;

                // Display each year in the listbox.
                accInheritanceListBxJH.Items.Add("Year " + yearJH.ToString() + "   Interest Earned -" + interestEarned.ToString() + "Balance-  " + balanceJH.ToString());

            }
        }

        private void welcomePictureJH_Click(object sender, EventArgs e)
        {
            welcomePictureJH.Visible = false;
        }

        private void clearBtnJH_Click(object sender, EventArgs e)
        {
            // Clear the form.
            inheritInputBoxJH.Text = "";
            accInheritanceListBxJH.Items.Clear();
        }

        private void exitBtnJH_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
