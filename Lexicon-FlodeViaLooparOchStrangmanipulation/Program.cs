using System.Security.Cryptography.X509Certificates;

namespace Lexicon_FlodeViaLooparOchStrangmanipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            bool exit = false;
            Menu mainMenu = new Menu();

            do
            {
                mainMenu.ShowMenu();
                choice = mainMenu.PromptOptionChoice();
                exit = mainMenu.ValidateAndExecuteOption(choice);
            } while (!exit);
        }
    }
}
