using System.Security.Cryptography.X509Certificates;
using Lexicon_FlodeViaLooparOchstrangmanipulation.Helpers;

namespace Lexicon_FlodeViaLooparOchStrangmanipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            bool exit = false;
            MenuHelper programMenu = new(Menu.MenuOptionsList);

            do
            {
                programMenu.ShowMenu();
                choice = programMenu.PromptOptionChoice();
                exit = programMenu.ValidateAndExecuteOption(choice);
            } while (!exit);
        }
    }
}
