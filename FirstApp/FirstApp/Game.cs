using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Game
    {
        private int tries;
        private int number;
        private bool win = false;
        public Game(int tries)
        {
            this.tries = tries;
            Random x = new Random();
            this.number = x.Next(1, 101);
        }
        public string MakeGuess(int guess)
        {
            tries--;
            if (guess == number)
            {
                win = true;
                return $"You Win!";
            }
            if (tries == 0)
            {
                return $"You Lose! The number was {number}.";
            }
            if (guess > number)
            {
                return $"Go Lower.";
            }
            return $"Go Higher.";
        }
        public int getTries()
        {
            return tries;
        }
        public bool isWin()
        {
            return win;
        }
    }
}
