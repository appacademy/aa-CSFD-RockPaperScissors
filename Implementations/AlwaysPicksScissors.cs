using RockPaperScissors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Implementations
{
    public class AlwaysPicksScissors : IChoiceGetter
    {
        public int GetChoice()
        {
            return 3;
        }
    }
}
