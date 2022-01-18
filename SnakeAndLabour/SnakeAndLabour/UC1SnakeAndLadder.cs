using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLabour
{
    internal  class UC1SnakeAndLadder
    {
        private int InitialPosition { get; } = 0;
        private int CurrentPosition { get; set; }
        public static void Solution()
        {
            UC1SnakeAndLadder app = new UC1SnakeAndLadder();
            CurrentPosition = InitialPosition;
            Console.WriteLine($"current position is at {app.CurrentPosition}");
        }
    
    
    }
    
}
