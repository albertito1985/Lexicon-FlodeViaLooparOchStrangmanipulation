using System.Security.Cryptography.X509Certificates;

namespace Lexicon_FlodeViaLooparOchStrangmanipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            bool validatedInput = false;
            Menu mainMenu = new Menu();

            do
            {
                mainMenu.ShowMenu();
                choice = mainMenu.PromptOptionChoice();
                validatedInput = mainMenu.ValidateAndExecuteOption(choice);
            } while (!validatedInput);


            //bool running = true;

            //do
            //{
            //    MenuOption option1 = new MenuOption("something");

            //} while (!running);
        }
    }
}
