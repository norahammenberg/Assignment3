
///This class handles all interactions between the user an the application:

namespace Assignment3
{
    public partial class MainForm : Form
    {
        //creating an instance variable an object of the BMI Calculator class:
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
        /// This method is used to initializing the Graphic user Interface. It clears all input and output. When a new user use it it will be clear from all old inouts and outputs. 
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
        /// This method reads the user name and allocate it to "reslt for"
        /// </summary>
        private void readName()
        {
            //show the name that the user provided and triming the input to remove the spaces in the beginning and the end:
            name = textName.Text.Trim();

            //setting the provided name in the result box:
            resultText.Text = "Result for " + name;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// /You have to write this
        /// </summary>
        /// <returns></returns>
        private bool readHeight()
        {
            //local variable to temporaly save the user input
            double userHeight = 0.0;

            //local variable to save transfer the uservaluse to double and check if it is an ok value:
            bool okValueByUser = double.TryParse(feetCm.Text, out userHeight);
            if (!okValueByUser)
            {
                MessageBox.Show("Invalide!", "Error");
            }

            ///for inches as well
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
            if (bmiCalc.gettingUnitType() == UnitTypes.Metric)
            {
                userHeight = userHeight / 100.0;
            }
            else if (bmiCalc.gettingUnitType() == UnitTypes.Imperial) 
            {
                userHeight = (userHeight *12) + inches;
            }

            bmiCalc.settingUserHeight(userHeight);

            //returningn this value:
            return okValueByUser;
        }


















        /// <summary>
        /// you have to write thsi
        /// </summary>
        /// <returns></returns>
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
        /// 
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
        /// This method reads all inputs by calling the three above methods:
        /// </summary>
        /// <returns> the okay value inputed by the user</returns>
        private bool readInput()
        {
            //reading all input by calling the following methods:
            readName();

            bool heightOk = readHeight();
            bool weightOk = readWeight();
            readUnit();

            return heightOk && weightOk;
        }

        private void calcResultDisply()
        {
            double bmi = bmiCalc.calculateBMI();
           
            bmiResult.Text = bmi.ToString("f2");//f2= telling the program to show a 2 floating number.
            weightResult.Text = bmiCalc.bmiWeightCat().ToString();

        }



        /// <summary>
        /// This is the method the is executing when the user press the button on the application. 
        /// The method checks if the input is okay/True. and if it is it is calling the method displayResult.
        /// if it is nit true it eill give the user a messagebox that tells them toaddress the issues. 
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

        private void inche_TextChanged(object sender, EventArgs e)
        {
            
        }
    }


}