namespace BmiCalculator
{
    public partial class MainPage : ContentPage
    {
        const double UnderWeight = 18.5;
        const double NormalWeight = 18.5;
        const double OverWeight = 18.5;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var weight =double.Parse(Weight.Text);
            var height =double.Parse(Height.Text) /100;

            var formula = weight / (height * weight);

            BMI.Text = formula.ToString("F2");

            string result = BmiResult(formula);
            DisplayAlert("Result", result, "Ok");
        }

        private string BmiResult(double formula)
        {
            if(formula < UnderWeight)
            {
                return "You are UnderWeight";
            }

            else if(formula <= NormalWeight)
            {
                return "You have Normal Wight";
            }

            else if(formula <= OverWeight)
            {
                return "You are OverWeight";
            }

            else
            {
                return "You are Obese";
            }
        }
    }
}
