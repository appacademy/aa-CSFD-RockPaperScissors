using RockPaperScissors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Implementations
{
    public class AlwaysPicksPaper : IChoiceGetter
    {
        public int GetChoice()
        {
            return 2;
        }
    }
}
