using RockPaperScissors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Implementations
{
    public class ConsolePicker : IChoiceGetter
    {
        public int GetChoice()
        {
            Console.Clear();
            Console.WriteLine("Enter 1 for Rock, 2 for Paper, 3 for Scissors.");

            int value;

            while(true)
            {               
                Console.Write("Enter Choice: ");

                if(int.TryParse(Console.ReadLine(), out value))
                {
                    if(value >= 1 && value <= 3)
                    {
                        return value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry, 1, 2 or 3");
                    }
                }
                else
                {
                    Console.WriteLine("That is not a number.");
                }
            }
        }
    }
}
