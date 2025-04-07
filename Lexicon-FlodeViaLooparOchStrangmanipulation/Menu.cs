using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Lexicon_FlodeViaLooparOchstrangmanipulation.Helpers;

namespace Lexicon_FlodeViaLooparOchStrangmanipulation
{
    static public class Menu
    {
        //public delegate bool MenuHandler();

        
        static  public List<MenuOption> MenuOptionsList = new List<MenuOption> {
            new MenuOption ("Exit", HandleExit),
            new MenuOption ("Check Customer", HandleSingleCustomer),
            new MenuOption ("Check group", HandleGroup),
            new MenuOption ("Echo 10 times",HandleEcho10Times),
            new MenuOption ("Write the 3rd word",HandleRepeat3rdWord)
        };

        static public bool HandleExit()
        {
            return true;
        }

        static public bool HandleRepeat3rdWord()
        {
            bool validatedInput = false;
            string input;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("----------Write the 3rd word-----------");
                Console.Write("Please enter more than 3 words: ");
                input = Utilities.StringInput();
                if (input != "invalid")
                {
                    var choppedInput = input.Split(" ");
                    if (choppedInput.Length >= 3)
                    {
                        validatedInput = true;
                        Console.WriteLine($"3rd word: {choppedInput[2]}.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid number of words.");
                    }
                        
                }
            } while (!validatedInput);

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");

            return false;
        }

        static public bool HandleEcho10Times()
        {
            bool validatedInput = false;
            Console.WriteLine("");
            Console.WriteLine("-------------Echo 10 times--------------");

            do {
                Console.Write("Enter something: ");
                string input = Utilities.StringInput();
                if (input != "invalid")
                {
                    validatedInput = true;
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write($"{i}. {input}, ");
                    }
                }
            } while (!validatedInput);
            
            Console.WriteLine("\n");
            return false;
        }

        static public bool HandleGroup()
        {
            Console.WriteLine("");
            Console.WriteLine("-------------Check Group---------------");
            Console.Write("How many persons are there in the group? ");
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

            return false;
        }

        static public bool HandleSingleCustomer()
        {
            Console.WriteLine("");
            Console.WriteLine("-------------Check Customer------------");
            Client newClient = CreateClient();
            Console.WriteLine($"{newClient.PriceType} price: {newClient.Price}Kr");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");
            return false;
        }

        static public Client CreateClient()
        {
            int age;
            bool validatedAge = false;
            do {
                Console.Write("Please enter the age of the client: ");
                age = Utilities.NumberInput();
                if(age != -1)
                { 
                    validatedAge = true;
                }
            } while (!validatedAge);
            return new Client(age);

        }


    }
}
