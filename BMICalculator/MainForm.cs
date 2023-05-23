using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BMICalculator
{
    public partial class MainForm : Form
    {
        private string name = "NoName";

        BMICalculator bMICalculator = new BMICalculator();
        //Declare and create an instance of the BMI Calculator

        //Declare and create an instance of the SavingsCalculator
        SavingsCalculator savingsCalculator = new SavingsCalculator();
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text += " Jagtej Sidhu";

            radioBtnMetric.Checked = true;
            
        }

        //updates the radiobutton depending on what radiobutton in pressed.
        private void UpdateHeightText()
        {
          if (radioBtnMetric.Checked)
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";
            } else
            {
                lblHeight.Text = "Height (ft, in)";
                lblWeight.Text = "Weight (lbs)";
            }

        }

        private double ReadDouble(string str, out bool success)
        {
            double value = -1.00;
            success = false;
            if (double.TryParse(str, out value)) 
            {
            success = true;
            }

            return value;
        }


        //Reading input in the savings calc.

        private void ReadSavingInput()
        {
            bool success;

            double num1;
            double num2;
            double result;

            double monthlyDeposit = ReadDouble(txtMonthlyDeposit.Text, out success);
            if(success)
            {
                savingsCalculator.setMonthlyDeposit(monthlyDeposit);
            }
            else
            {
                MessageBox.Show("Invalid value for monthly deposit!");
                return;
            }

            double period = ReadDouble(txtPeriod.Text, out success);
            if (success)
            {
                savingsCalculator.setPeriod(period);
            }
            else
            {
                MessageBox.Show("Invalid value for period");
                return;
            }

            double.TryParse(txtMonthlyDeposit.Text, out num1);
            double.TryParse(txtPeriod.Text, out num2);
            result = num1 * (num2 * 12);
            txtAmountPaid.Text = result.ToString("f2");
            txtFinalBalance.Text = savingsCalculator.CalculateFutureVal().ToString("f2");
        }

        //Method that combines all the different read methods
        private bool ReadInputBMI()
        {
            ReadUnit();
            ReadName();
            bool heightOK = ReadHeight();
            bool weightOK = ReadWeight();
            

            return heightOK && weightOK;
        }

        private void ReadUnit()
        {
            if (radioBtnMetric.Checked)
            {
                bMICalculator.setUnit(UnitTypes.Metric);
            } else
            {
                bMICalculator.setUnit(UnitTypes.Imperial);
            }
        }

        //reads the input of height from user
        private bool ReadHeight()
        {
            double height = 0.0;

            bool ok = double.TryParse(txtHeight.Text, out height);
            if (ok)
            {
                DisplayResults();
            }
            else MessageBox.Show("The height value is invalid!", "Error");

            double inch = 0.0;

            if (radioBtnImperial.Checked)
            {
                ok = ok && double.TryParse(txtHeight.Text, out inch);
                if (ok)
                {
                    DisplayResults();
                }
                else

                {
                    MessageBox.Show("The inch value is invalid!", "Error");
                }
            }

            //Changed to correct value depending on which Unit is checked in.
            if(bMICalculator.getUnit() == UnitTypes.Metric)
            {
                height = height / 100.0;
            } else
            {
                height = height * 12.0 + inch;
            }

            bMICalculator.setHeight(height);
            return ok;
        }
        //reads the input of weight from user
        private bool ReadWeight()
        {

            double weight = 0.0;

            //try parse 

            bool ok = double.TryParse(txtWeight.Text, out weight);
            if (ok)
            {
                DisplayResults();
            }
            else
            {
                MessageBox.Show("The weight value is invalid!", "Error");
            }

            bMICalculator.setWeight(weight);
            return ok;
        }

        //Read the input from user name
        private void ReadName()
        {
            name = txtName.Text;
            name = name.Trim();
        }

        private void DisplayResults()
        {
            txtBMI.Text = bMICalculator.CalculateBMI().ToString("f2");
            txtWeightCat.Text = bMICalculator.BmiWeightCategory().ToString();
            grpBoxResults.Text = "Results for " + name;

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();
            if (ok)
            {
                ReadInputBMI();
            }
        }

        private void radioBtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightText();
        }

        private void radioBtnImperial_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightText();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCalcSavings_Click(object sender, EventArgs e)
        {
            ReadSavingInput();
           
        }

        private void lblHeight_Click(object sender, EventArgs e)
        {

        }
    }
}
