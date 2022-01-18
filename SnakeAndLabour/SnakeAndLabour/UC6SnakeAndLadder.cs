using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLabour
{
    internal class UC6SnakeAndLadder
    {
        private const int _initialPosition = 0;
        private static int _currentPosition;

        private static int RollDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        private static string CheckOption()
        {
            Random random = new Random();
            int option = random.Next(0, 3);
        Step:
            switch (option)
            {
                case 0:
                    return "no_play";
                case 1:
                    return "ladder";
                case 2:
                    return "snake";
                default:
                    goto Step;
            }
        }

        private static int Play(string option, int position, int roll)
        {
            if (option == "ladder")
            {
                if (position + roll > 100) position += 0;
                else position += roll;
            }
            else if (option == "snake")
            {
                if (position - roll > 0) position -= roll;
            }
            else position -= 0;
            return position;
        }

        public static void Solution()
        {
            _currentPosition = _initialPosition;
            int count = 0;
            while (_currentPosition < 100)
            {
                string option = CheckOption();
                int roll = RollDice();
                _currentPosition = Play(option, _currentPosition, roll);
                Console.WriteLine($"You got: {option}/{roll} and Position is at: {_currentPosition}");
                count++;
            }
            Console.WriteLine($"\n Hey Player, You won after {count} times");
        }
    }
}




