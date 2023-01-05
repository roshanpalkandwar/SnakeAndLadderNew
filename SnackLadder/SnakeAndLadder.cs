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
        int ComputerChoice;
        
        public void StartPlaying()
        {
            Console.WriteLine("Game Started! Good Luck ");
            Console.WriteLine("You are at " + StartPoint);
            Random Random = new Random();
            RanDomDice = Random.Next(1, 7);
            Console.WriteLine("player Role Dice number is:" + " " + RanDomDice);
            ComputerChoice = Random.Next(0, 3);
            Console.WriteLine("Dice value:" + ComputerChoice);
            switch (ComputerChoice)
            {
                case 0:
                    Console.WriteLine("No Play");
                    break;
                case 1:
                    StartPoint += RanDomDice;
                    if (StartPoint > 100)
                    {

                        StartPoint -= StartPoint;
                    }
                    
                    Console.WriteLine("Got Ladder:" + StartPoint);
                    break;
                case 2:
                    StartPoint -= RanDomDice;
                    if (StartPoint < 0)
                    {
                        StartPoint = 0;
                    }
                    Console.WriteLine("Snake Attack:" + StartPoint);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            
        }
    }
    
}
