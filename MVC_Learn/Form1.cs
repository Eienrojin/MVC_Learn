namespace MVC_Learn
{
    public partial class Form1 : Form
    {
        Controller _contrl = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double _a = 0;
            double _b = 0;
            bool _safe = true;

            try
            {
                _a = Convert.ToDouble(ATextBox.Text);
                _b = Convert.ToDouble(BTextBox.Text);
            }
            catch (FormatException)
            {
                ResultTextBox.Text = "E√√Œ√";
                _safe = false;
            }

            if (_safe)
            {
                double result = _contrl.GetSqrt(_a, _b);

                ResultTextBox.Text = result.ToString();
            }
        }

        private void ATextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}