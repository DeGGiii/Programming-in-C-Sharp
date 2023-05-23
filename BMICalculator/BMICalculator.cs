using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class BMICalculator
    {
        //Instance of variables for inputs
        private double height;
        private double weight;

        private UnitTypes unit;

        //Default Constructor
        public BMICalculator()
        {
            unit = UnitTypes.Metric;
        }

        #region Getters and setters
        //Getters and Setters
        public double getHeight()
        {
           return height;
        }

        public void setHeight(double height)
        {
            if(height >= 0)
            this.height = height;
        }

        public double getWeight()
        { 
            return weight;
        }

        public void setWeight(double weight)
        {
            if(weight >= 0)
            this.weight = weight;
        }

        public UnitTypes getUnit() 
        {
            return unit;        
        }

        public void setUnit(UnitTypes unit)
        {
            this.unit = unit;
        }

        #endregion

        //Calculation of the program

        
        /// <summary>
        /// Calculating the BMI dependning on the given value from user
        /// </summary>
        /// <returns>BMI Value from the calculation</returns>
        public double CalculateBMI()
        {
            //metric values
            double bmiValue = 0.0;
            double factor = 1.0;

            if(unit == UnitTypes.Imperial)
            {
                factor = 703.0;
            }

            bmiValue = factor * weight / (height * height);

            return bmiValue;
        }

        public string BmiWeightCategory()
        {
            double bmi = CalculateBMI();
            string stringOut = string.Empty;

            if (bmi < 18.5)
            {
                stringOut = "Underweight";
            }
            else if (bmi <= 24.9)
            {
                stringOut = "Normal weight";
            }
            else if (bmi <= 29.9)
            {
                stringOut = "Overweight(Pre-Obesity)";
            }
            else if (bmi <= 34.9)
            {
                stringOut = "Overweight(Obesity class 1)";
            }
            else if (bmi <= 39.9)
            {
                stringOut = "Overweight(Obesity class 2)";
            }
            else if (bmi >= 40)
            {
                stringOut = "Overweight(Obesity class 3)";
            }

            return stringOut;
        }
    }
}
