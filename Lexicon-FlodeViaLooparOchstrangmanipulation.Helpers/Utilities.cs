namespace Lexicon_FlodeViaLooparOchstrangmanipulation.Helpers
{
    public static class Utilities
    {
        public static int NumberInput()
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Your input is not a number. ");
            }

                return -1;

        }
    }
}
