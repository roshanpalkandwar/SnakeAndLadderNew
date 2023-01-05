using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackLadder
{
    public class SnakeAndLadder
    {
        public int StartPoint = 0;
        int RanDomDice;
        public void StartPlaying()
        {
            Console.WriteLine("Game Started! Good Luck ");
            Console.WriteLine("You are at " + StartPoint);
            Random Random = new Random();
            RanDomDice = Random.Next(1, 7);
            Console.WriteLine("player Role Dice number is:" + " " + RanDomDice);
        }
    }
}
