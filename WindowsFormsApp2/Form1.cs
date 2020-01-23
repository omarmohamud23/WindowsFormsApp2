using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }






        private void button1_Click(object sender, EventArgs e) 
        {

            bool creditvalid = Double.TryParse(txtCreditAdded.Text, out double creditadded);
            bool costoneparkwithcardvalid = Double.TryParse(txtOneParkWithCard.Text, out double costoneparkwithcard);
            bool costoneparkwithnocardvalid = Double.TryParse(txtOneParkNoCard.Text, out double costoneparkwithnocard);

            if (creditvalid && costoneparkwithcardvalid)
            {
                int DaysParking = (int)(creditadded / costoneparkwithcard);
                double CreditRemaining = (creditadded % costoneparkwithcard);
                double oneDaysavings = (costoneparkwithnocard -costoneparkwithcard );
                double totalsavings = DaysParking * oneDaysavings;


                txtDaysParking.Text = DaysParking.ToString("c");
                txtCreditRemaining.Text = CreditRemaining.ToString("c");
                txtCreditRemaining.Text = CreditRemaining.ToString("c");
                textsavings.Text = totalsavings.ToString("c");
            }
            else
            {
                MessageBox.Show("Please Enter Numbers", "Error");
            }




        }
    }
}
