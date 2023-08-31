using RockPaperScissors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Implementations
{
    public class RandomPicker : IChoiceGetter
    {
        private Random _rng = new Random();

        public int GetChoice()
        {
            return _rng.Next(1, 4);
        }
    }
}
