
///This class handles all interactions between the user an the application:

namespace Assignment3
{
    public partial class MainForm : Form
    {
        //creating an instance variable, an object of the BMI Calculator class:
        private BMICalculator bmiCalc = new BMICalculator();

        //creating this instance varibale to store the name of the user:
        private string name = String.Empty;


        /// <summary>
        /// Initializa method.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }


        /// <summary>
        /// This method is used to initializing the Graphic user Interface. It clears all input and output. When a new user use it.
        /// </summary>
        private void InitializeGUI()
        {
            //default setting for the radiobutten that the metric is clicked:
            radioButtonKG.Checked = true;
            textName.Text = string.Empty;
            feetCm.Text = string.Empty;
            inche.Text = string.Empty;
            textWeight.Text = string.Empty;
            bmiResult.Text = string.Empty;
            weightResult.Text = string.Empty;
        }
        /// <summary>
        /// This method is used to update the text for the hight and the weight. Depending on what ever th user pick, metric or imperial.
        /// if metric is used the are asked to provide cm and kg.
        /// if imperial is used thay will need to provid feet and inches and lbl?
        /// </summary>
        private void updateTHWText()
        {
            if (radioButtonFT.Checked)
            {
                height.Text = "Height (ft, in)";
                weight.Text = "Weight  (lbs)";
                inche.Visible = true;
                bmiResult.Text = string.Empty;
                weightResult.Text = string.Empty;
            }
            else
            {
                height.Text = "Height (cm)";
                weight.Text = "Weight  (Kg)";
                inche.Visible = false;
                bmiResult.Text = string.Empty;
                weightResult.Text = string.Empty;
            }
        }

        /// <summary>
        /// This method checking what radiobutton the user picks: depending what the user picks that corresponding unit is sett by calling the eetingUnitType method in tht BMI calcolator: 
        /// </summary>
        private void readUnit()
        {
            if (radioButtonKG.Checked)
            {
                bmiCalc.settingUnitType(UnitTypes.Metric);
            }
            else 
            {
                bmiCalc.settingUnitType(UnitTypes.Imperial);
            }
        }

        /// <summary>
        /// This method reads the user name and allocate it to "result for" in the interface.
        /// The method triming the input to remove the spaces in the beginning and the end:
        /// </summary>
        private void readName()
        {
            name = textName.Text.Trim();

            //setting the provided name in the result box:
            resultText.Text = "Result for " + name;
        }

        /// <summary>
        /// The method readingHight reads the users inout in the height box.
        /// the method checks if a true value, a number, have been provided. Have it not a message box will tell the user that it wa an invalude input. 
        /// If the value is correct itt will be set by using the settingUserHeight method in the BMI calculator so the value can be used to calculate the BMI.
        /// 
        /// depending if the user pick metric or emperial a different calculation to convert to meters or inches will be executed. 
        /// </summary>
        /// <returns>returning a true or false value depending on if the user have provided a accuret value</returns>
        private bool readHeight()
        {
            //local variable to temporaly save the user input
            double userHeight = 0.0;
            bool okValueByUser = double.TryParse(feetCm.Text, out userHeight);

            if (!okValueByUser)
            {
                MessageBox.Show("Invalide!", "Error");
            }

            //for imperial
            double inches = 0.0;
            if (radioButtonFT.Checked)
            {
                okValueByUser = okValueByUser && double.TryParse(inche.Text, out inches);//out is use to declare that this is an output value.

                if (!okValueByUser)
                {
                    MessageBox.Show("Invalide", "Error");
                }
            }

            //converting cm to m, and feet needs to be conferter to inches:
            if (radioButtonKG.Checked)
            {
                userHeight = userHeight / 100.0;
            }
            else if (radioButtonFT.Checked)
            {
                userHeight = userHeight * 12.00 + inches;
            }

            //setting the userHeight:
            bmiCalc.settingUserHeight(userHeight);

            return okValueByUser;
        }

        /// <summary>
        /// This method do the same as the above method but for weight, except here we dn't need to do anything for imperial/metric nputs all inputs for the weight will be used the same. 
        /// </summary>
        /// <returns>returning a true or false value depending on if the user have provided a accuret value</returns>
        private bool readWeight()
        {
            //local variable to temporaly save the user input
            double userWeight = 0.0;

            //local variable to save transfer the uservaluse to double and check if it is an ok value:
            bool okValuseByUser = double.TryParse(textWeight.Text, out userWeight);

            if (!okValuseByUser)
            {
                MessageBox.Show("Invalide!");
            }

            //sending the users weight to BMI Calculater:
            bmiCalc.settingUserWeight(userWeight);

            //returningn this value:
            return okValuseByUser;
        }

        /// <summary>
        /// This method reads all inputs by calling the three above methods:
        /// </summary>
        /// <returns> the okay value inputed by the user</returns>
        private bool readInput()
        {            
            //reading all input by calling the following methods:
            readUnit();
            readName();

            bool heightOk = readHeight();
            bool weightOk = readWeight();
          
            return heightOk && weightOk;
        }

        /// <summary>
        /// A method that calulat the result by calling the calculatBMI method in the BMI calculator class:
        /// and displaying the result by adding the different needed result at the right place in the interface:
        /// </summary>
        private void calcResultDisply()
        {
            double bmi = bmiCalc.calculateBMI();
            bmiResult.Text = bmi.ToString("f2");//f2= telling the program to show a 2 floating number.
            weightResult.Text = bmiCalc.bmiWeightCat().ToString();
        }

        /// <summary>
        /// This is the method the is executing when the user press the button on the application. 
        /// The method checks if the input is okay/True. and if it is it is calling the method readInput.
        /// the the method calcResultDisply is called to be executed when the button is clicked. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            //reading all input by calling the following methods:
            bool okValue = readInput();

            //calculate
            calcResultDisply();

        }

        /// <summary>
        /// when the user click on the radiobutton for metric the updateTHWText is called to change the height and weight lable:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonKG_CheckedChanged(object sender, EventArgs e)
        {
            //calling the update text method:
            updateTHWText();
        }

        /// <summary>
        /// when the user click on the radiobutton for imperial the updateTHWText is called to change the height and weight lable:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonFT_CheckedChanged(object sender, EventArgs e)
        {
            //calling the update text method:
            updateTHWText();
        }

    }
}