using System.Security.Cryptography.X509Certificates;

namespace Lexicon_FlodeViaLooparOchStrangmanipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            bool exit = false;

            do
            {
                Menu.ShowMenu();
                choice = Menu.PromptOptionChoice();
                exit = Menu.ValidateAndExecuteOption(choice);
            } while (!exit);
        }
    }
}
