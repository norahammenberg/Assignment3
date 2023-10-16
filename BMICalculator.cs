using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///This c´lass should not interact with the user, this class is only to be used for logics:

namespace Assignment3
{
    internal class BMICalculator
    {
        //instance variables:
         
        private double userHeight = 0;
        private double userWeight = 0;
        private UnitTypes unit;

        /// <summary>
        /// this is a default constructor that tells our application to by default start with unit Metrics:
        /// </summary>
        public BMICalculator()
        {
            unit = UnitTypes.Metric;
        }


        #region Setters and Getter: 
        ///<summery>
        ///Here I providing getters and setters for all the information we need to use that is provided by the user. I use getters and seeters to provid this iformtion to our private instance variables
        ///because this can not be access by the mainform.
        /// </summery>
        public double gettingUserHeight()
        {
            return userHeight;
        }
        public void settingUserHeight(double newHeight)
        {
            //checking the value that is not minus or zero
            if (newHeight >= 0)
            {
                userHeight = newHeight;
            }
           
        }


        public double gettingUserWeight()
        {
            return userHeight;
        }
        public void settingUserWeight(double newWeight)
        {
            if (newWeight >= 0)
            { 
                userWeight = newWeight;
            }
           
        }


        /// <summary>
        /// setters and getters frot the unit. We need to know what value the user like the calculation to be in: metric or imperial
        /// </summary>
        public UnitTypes gettingUnitType()
        {

            return unit;
        }
        public void settingUnitType(UnitTypes newUnit)
        {
            //we do not need to do any inoput check becasue there can not be any other input. 
            unit = newUnit;
        }
        #endregion


        //calculations: 
        public double calculateBMI()
        {
            //local variables
            //for metric input
            double bmiValue = 0.0;
            double factor = 1.0;

            // for imperial input:
            if (unit == UnitTypes.Imperial) 
            {
                factor = 703.0;
            }

            bmiValue = factor * userWeight / (userHeight * userHeight);
            return bmiValue;

        }

        public string bmiWeightCat()
        {
            double bmi = calculateBMI();
            string stringForUser = String.Empty;

            if ( bmi < 18.5)
            {
                stringForUser = "Underweight";
            }
            else if ( bmi <= 24.9)
            {
                stringForUser = " Normal weight";
            }
            else if ( bmi <= 29.9)
            {
                stringForUser = "Overweight (Pre-obesity)";
            }
            else if (bmi <= 34.9)
            {
                stringForUser = "Overweight (Obesity 1)";
            }
            else if (bmi <= 39.9)
            {
                stringForUser = "Overweight (Obesity 2)";
            }
            else 
            {
                stringForUser = "Overweight (Obesity 3)";
            }
            return stringForUser;
        }
    }
}
