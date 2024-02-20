using CurrencyConvert;
namespace CurrencyApp
{
    public partial class Form1 : Form
    {
        bool BGNtoEUR = true;
        bool EURtoBGN = false;
        Converter conv = new Converter();
        public Form1()
        {
            InitializeComponent();
        }

        private void Convert(object sender, EventArgs e)
        {

            double curr;
            if (!double.TryParse(amountTextBox.Text, out curr))
            {
                invalidLabel.Text = "NaN";
                return;
            }
            invalidLabel.Text = "";
            if (BGNtoEUR)
            {
                convertedTextBox.Text = conv.BGNtoEUR(curr).ToString();
                return;
            }
            convertedTextBox.Text = conv.EURtoBGN(curr).ToString();
        }

        private void BGNtoEURRadio_Click(object sender, EventArgs e)
        {
            BGNtoEUR = true;
            EURtoBGN = false;
        }

        private void EURtoBGNRadio_Click(object sender, EventArgs e)
        {
            EURtoBGN = true;
            BGNtoEUR = false;
        }
    }
}