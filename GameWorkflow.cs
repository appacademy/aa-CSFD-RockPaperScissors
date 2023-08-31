using RockPaperScissors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class GameWorkflow
    {
        private IChoiceGetter _playerOne;
        private IChoiceGetter _playerTwo;

        public GameWorkflow(IChoiceGetter playerOneImpl, IChoiceGetter playerTwoImpl)
        {
            _playerOne = playerOneImpl;
            _playerTwo = playerTwoImpl;
        }

        public void Run()
        {
            Console.Clear();
            int choice1 = _playerOne.GetChoice();
            Console.Clear();
            int choice2 = _playerTwo.GetChoice();

            Console.WriteLine($"Player one picked {ConsoleIO.GetChoiceText(choice1)}");
            Console.WriteLine($"Player two picked {ConsoleIO.GetChoiceText(choice2)}");

            switch (GetResult(choice1, choice2))
            {
                case GameResult.TIE:
                    Console.WriteLine($"It's a tie!");
                    break;
                case GameResult.PLAYER1WIN:
                    Console.WriteLine("Player One Wins!");
                    break;
                case GameResult.PLAYER2WIN:
                    Console.WriteLine("Player Two Wins!");
                    break;
            }
        }

        public GameResult GetResult(int playerOneChoice, int playerTwoChoice)
        {
            if(playerOneChoice == playerTwoChoice)
            {
                return GameResult.TIE;
            }

            // player one win conditions
            if((playerOneChoice == (int)PlayerChoice.ROCK && playerTwoChoice == (int)PlayerChoice.SCISSORS) ||
                (playerOneChoice == (int)PlayerChoice.PAPER && playerTwoChoice == (int)PlayerChoice.ROCK || 
                (playerOneChoice == (int)PlayerChoice.SCISSORS && playerTwoChoice == (int)PlayerChoice.PAPER)))
            {
                return GameResult.PLAYER1WIN;
            }

            return GameResult.PLAYER2WIN;
        }
    }
}
