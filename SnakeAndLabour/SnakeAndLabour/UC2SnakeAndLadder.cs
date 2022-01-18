using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLabour
{
    internal class UC2SnakeAndLadder()
    {
        private int InitialPosition { get; } = 0;
    private int CurrentPosition { get; set; }

    private int RollDice()
    {
        Random random = new Random();
        return random.Next(0, 7);
    }

    public static void Solution()
    {
        UC2SnakeAndLadder app = new UC2SnakeAndLadder();
        app.CurrentPosition = app.InitialPosition;
        Console.WriteLine($"Current position is at: {app.CurrentPosition}");
        Console.WriteLine($"Result of rolling dice: {app.RollDice()}");






    }
}
