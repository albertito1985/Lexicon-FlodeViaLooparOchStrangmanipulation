using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lexicon_FlodeViaLooparOchStrangmanipulation;

namespace Lexicon_FlodeViaLooparOchstrangmanipulation.Helpers
{
    public class MenuHelper
    {
        private List<MenuOption> MenuOptionsList {  get; set; }

        public MenuHelper(List<MenuOption> optionsList)
        {
            MenuOptionsList = optionsList;
        }
        public void ShowMenu()
        {
            Console.WriteLine("---------------Main Menu---------------");
            foreach (MenuOption option in MenuOptionsList)
            {
                Console.WriteLine($"{option.Command}: {option.Description}");

            }
            Console.WriteLine("---------------------------------------");
        }

         public int PromptOptionChoice()
        {
            Console.WriteLine("Type the number of the option you want to follow.");
            Console.Write("Option: ");
            return Utilities.NumberInput();
        }

        public bool ValidateAndExecuteOption(int choice)
        {
            bool exit = false;

            foreach(MenuOption option in MenuOptionsList)
            {
                if(option.Command == choice)
                {
                    exit = option.Handler();
                    break;
                }
            }

            return exit;
        }
    }
}
