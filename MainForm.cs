
///This class handles all interactions between the user an the application:

namespace Assignment3
{
    public partial class MainForm : Form
    {
        //creating an instance variable an object of the BMI Calculator class:
        private BMICalculator bmicalc = new BMICalculator();
        public MainForm()
        {
            InitializeComponent();
        }

    }
}