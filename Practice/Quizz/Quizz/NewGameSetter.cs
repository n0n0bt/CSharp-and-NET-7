using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuizz
{
    internal class NewGameSetter
    {
        public static void SetNewGame()
        {
            Console.WriteLine("Another game? Yes / No");

            Category category = new Category();
            bool newGame = Console.ReadLine().ToLower() == "yes";

            if (newGame)
            {
                category.ChooseCategory();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("End Game!");
                Console.WriteLine("Come again later :)");
                Console.WriteLine();
            }

        }
    }
}
