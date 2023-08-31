using RockPaperScissors.Implementations;
using RockPaperScissors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class ConsoleIO
    {
        public static IChoiceGetter GetImplementation(string playerNumber)
        {
            Console.Clear();
            Console.WriteLine($"Enter implementation for player {playerNumber}.");
            Console.WriteLine("1. Random Picker");
            Console.WriteLine("2. Console Picker");
            Console.WriteLine("3. Always Rock");
            Console.WriteLine("4. Always Paper");
            Console.WriteLine("5. Always Scissors\n");

            int value;

            while(true)
            {
                Console.Write("Enter choice: ");

                if(int.TryParse(Console.ReadLine(), out value))
                {
                    switch(value)
                    {
                        case 1:
                            return new RandomPicker();
                        case 2:
                            return new ConsolePicker();
                        case 3:
                            return new AlwaysPicksRock();
                        case 4:
                            return new AlwaysPicksPaper();
                        case 5:
                            return new AlwaysPicksScissors();
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("That is not a number.");
                }
            }
        }

        public static string GetChoiceText(int num)
        {
            if (num == 1)
            {
                return "Rock";
            }
            else if (num == 2)
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }
        }
    }
}
