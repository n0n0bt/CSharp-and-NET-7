using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuizz
{
    public class Category
    {
        public void ChooseCategory()
        {
            Console.WriteLine("Please choose category for this Quizz: ");
            Console.WriteLine("1. History");
            Console.WriteLine("2. Geography");
            Console.WriteLine("3. Sport");

            int category = Convert.ToInt32(int.Parse(Console.ReadLine()));

            switch (category)
            {
                case 1:
                    Console.WriteLine("You have selected the History category!");
                    QuizzQuestions.SetHistoryQuestions();
                    QuizzSettings.StatementsAndLoops();
                    NewGameSetter.SetNewGame();
                    break;

                case 2:
                    Console.WriteLine("You have selected the Geography category!");
                    QuizzQuestions.SetGeographyQuestions();
                    QuizzSettings.StatementsAndLoops();
                    NewGameSetter.SetNewGame();
                    break;

                case 3:
                    Console.WriteLine("You have selected the Sport category!");
                    QuizzQuestions.SetSportQuestions();
                    QuizzSettings.StatementsAndLoops();
                    NewGameSetter.SetNewGame();
                    break;

                default:
                    Console.WriteLine("Please select correctly!");
                    break;
            }
        }
    
    }
}
