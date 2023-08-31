using RockPaperScissors.Interfaces;
using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            IChoiceGetter p1Impl = ConsoleIO.GetImplementation("1");
            IChoiceGetter p2Impl = ConsoleIO.GetImplementation("2");

            GameWorkflow wf = new GameWorkflow(p1Impl, p2Impl);
            wf.Run();
        }
    }
}
