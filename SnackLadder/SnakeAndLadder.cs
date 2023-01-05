﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackLadder
{
    public class SnakeAndLadder
    {
        public void StartPlaying()
        {
            int StartPoint = 0;
            int RanDomDice;
            int ComputerChoice;
            int count = 0;
            Console.WriteLine("Game Started! Good Luck ");

            while (StartPoint != 100)
            {
                Random Random = new Random();
                RanDomDice = Random.Next(1, 7);
                Console.WriteLine("player Role Dice number is:" + " " + RanDomDice);
                ComputerChoice = Random.Next(0, 3);
                Console.WriteLine("Dice value:" + ComputerChoice);
                switch (ComputerChoice)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        count++;
                        break;
                    case 1:
                        StartPoint += RanDomDice;
                        count++;
                        if (StartPoint > 100)
                        {

                            StartPoint -= StartPoint;
                        }
                        Console.WriteLine("Got Ladder and Position of the Player: " + StartPoint);
                        break;
                    case 2:
                        StartPoint -= RanDomDice;
                        count++;
                        if (StartPoint < 0)
                        {
                            StartPoint = 0;
                        }
                        Console.WriteLine("Snake Attack and Position of the Player: " + StartPoint);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Dice Role to Win the Game is " + count);
            }
        }
    }

}
