using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsStats.StarWarsStatsApp
{
    public class ConsoleUserInteraction : IConsoleUserInteraction
    {
        public void PromptUser()
        {
            Console.WriteLine(@"The statistics of which property would you like to see?
population
diameter
surface water"
            );
        }

        public string ReadInput()
        {
            bool validInput = false;
            string userInput = "";
            do
            {
                userInput = Console.ReadLine();
                if (userInput == "population" || userInput == "diameter" || userInput == "surface water")
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
            while (!validInput);
            return userInput;
        }

        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
