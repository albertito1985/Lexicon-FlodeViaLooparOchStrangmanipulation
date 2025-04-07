using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_FlodeViaLooparOchStrangmanipulation
{
    public class MenuOption
    {
        static int inputCount = 0;
        public delegate void HandlerFunction();
        //public int command;
        //public string description;
        //public HandlerFunction handler;

        public int Command { get; set; }
        public string Description{ get; set; }
        public HandlerFunction Handler { get; set; }

        public MenuOption(string inputDescription, HandlerFunction inputFunction)
        {
            Command = inputCount;
            Description = inputDescription;
            Handler = inputFunction;
            inputCount++;
        }

    }
}
