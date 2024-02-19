using System;
using GuessingGame;

namespace FirstApp
{
    public partial class Form1 : Form
    {
        Game num = new Game(0);
        int guess = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void GuessClick(object sender, EventArgs e)
        {
            if (num.getTries() == 0 || num.isWin())
            {
                return;
            }
            try
            {
                guess = Int32.Parse(guessTextBox.Text);
            }
            catch
            {
                responseLabel.Text = "NaN";
                return;
            }
            if (guess < 1 || guess > 100)
            {
                responseLabel.Text = "Pick a valid number";
                return;
            }
            string output = num.MakeGuess(guess);
            triesLabel.Text = num.getTries().ToString();
            responseLabel.Text = output;
            if (output.Contains("You"))
            {
                difficultyLabel.Text = "Select Difficulty";
                easyButton.Enabled = true;
                mediumButton.Enabled = true;
                hardButton.Enabled = true;
            }

        }

        private void DiffE(object sender, EventArgs e)
        {
            GameInit(8);
        }

        private void DiffM(object sender, EventArgs e)
        {
            GameInit(5);
        }

        private void DiffH(object sender, EventArgs e)
        {
            GameInit(3);
        }
        private void GameInit(int tries)
        {
            num = new Game(tries);
            triesLabel.Text = Convert.ToString(tries);
            difficultyLabel.Text = "";
            responseLabel.Text = "";
            easyButton.Enabled = false;
            mediumButton.Enabled = false;
            hardButton.Enabled = false;
        }
    }
}