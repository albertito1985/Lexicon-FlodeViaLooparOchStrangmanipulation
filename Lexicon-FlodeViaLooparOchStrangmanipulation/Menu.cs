using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Lexicon_FlodeViaLooparOchstrangmanipulation.Helpers;

namespace Lexicon_FlodeViaLooparOchStrangmanipulation
{
    public class Menu
    {
        List<MenuOption> MenuOptionsList = new List<MenuOption> {
            new MenuOption ("Exit"),
            new MenuOption ("Check Customer"),
            new MenuOption ("Check group")
        };
        

        public void ShowMenu()
        {
            Console.WriteLine("---------------Main Menu---------------");
            foreach (MenuOption option in MenuOptionsList)
            {
                Console.WriteLine($"{option.command}: {option.description}");

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
            if(choice == 0)
            {
                exit = true;
                Console.WriteLine("Good Bye!");
            }
            else if(choice == 1)
            {
                
                handleSingleCustomer(); //det finns en nästlad if-sats inom Utilities.NumberInput samt i constructorn till Client;
            }
            else if(choice == 2)
            {
                handleGroup();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("");
            }
            return exit;
        }

        private void handleGroup()
        {
            Console.WriteLine("");
            Console.WriteLine("-------------Check Group---------------");
            Console.Write("How many persons are in the group? ");
            int groupSize = Utilities.NumberInput();
            List<Client> clientList= new List<Client>();
            int totalPrice=0;
            for (int i=1;i<=groupSize; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Customer {i}");
                Client newClient = CreateClient();
                clientList.Add(newClient);
                totalPrice += newClient.Price;
            }
            Console.WriteLine("");
            Console.WriteLine("----------------Summary----------------");
            Console.WriteLine($"Clients Quantity: {groupSize}");
            Console.WriteLine($"Total Price: {totalPrice}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");

        }

        private void handleSingleCustomer()
        {
            Console.WriteLine("");
            Console.WriteLine("-------------Check Customer------------");
            Client newClient = CreateClient();
            Console.WriteLine($"{newClient.PriceType} price: {newClient.Price}Kr");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");
        }

        public Client CreateClient()
        {
            int age;
            bool validatedAge = false;
            do {
                Console.Write("Please enter the age of the client: ");
                age = Utilities.NumberInput();
            } while (validatedAge);
            return new Client(age);

        }


    }
}
