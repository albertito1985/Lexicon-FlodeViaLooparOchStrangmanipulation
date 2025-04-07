using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_FlodeViaLooparOchStrangmanipulation
{
    internal class MenuOption
    {
        static int inputCount = 0;
        public int command;
        public string description;

        public MenuOption(string inputDescription)
        {
            command = inputCount;
            description = inputDescription;
            inputCount++;
        }

    }
}
