
///This class handles all interactions between the user an the application:

namespace Assignment3
{
    public partial class MainForm : Form
    {
        //creating an instance variable an object of the BMI Calculator class:
        private BMICalculator bmiCalc = new BMICalculator();

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
            textName.Text = "   ";
            textHeightLeft.Text = "   ";
            textHeightRight.Text = "   ";
            textWeight.Text = "   ";
            bmiResult.Text = "       ";
            weightResult.Text = "       ";
        }

        /// <summary>
        /// This three method bellow are used to read the input that the user are providing. 
        /// The methods reads the user inputs name, height and weight in three different methods.
        /// The methods retuern the valuse that the user are given if they are correct/ valid and
        /// send them to the Class BMICalculator using setters and getters. : 

        /// </summary>

        private void ReaName()
        {
            //local variable to temporaly save the user input
            string userName = textName.Text.Trim();//trim removes any unnesecary spaces. 

            //if statments that checking the value that the user is given us. 
            if (!string.IsNullOrEmpty (textName.Text) )
            {
                bmiCalc.Name = textName.Text;
            }
            else
            {
                bmiCalc.Name = "No name provided!";

            }
        }

        private void readHeightLeft()
        {
            //local variable to temporaly save the user input
            double userHeightLeft = 0;
            double.TryParse(textHeightLeft.Text, out userHeightLeft);

            //if statments that checking the value that the user is given us. 
            if (userHeightLeft == 0.0)
            {
                bmiCalc.HeightLeft = userHeightLeft;
            }
            else
            {
                bmiCalc.HeightLeft = "Invalid!";

            }
        }

        private void readHeightRight()
        {
            //local variable to temporaly save the user input
            double userHeightRight = 0;
            double.TryParse(textHeightRight.Text, out userHeightRight);

            //if statments that checking the value that the user is given us. 
            if (userHeightRight == 0.0)
            {
                bmiCalc.HeightRight = userHeightRight;
            }
            else
            {
                bmiCalc.HeightRight= "Invalid!";

            }
        }

        private void ReadWeight()
        {
            //local variable to temporaly save the user input
            double userWeight = 0;
            double.TryParse(textWeight.Text, out userWeight);

            //if statments that checking the value that the user is given us. 
            if (userWeight == 0.0)
            {
                bmiCalc.Weight = userWeight;
            }
            else
            {
                bmiCalc.Weight = "Invalid!";

            }
        }


    }