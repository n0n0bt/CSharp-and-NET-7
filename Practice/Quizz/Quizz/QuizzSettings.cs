using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuizz
{
    public class QuizzSettings
    {
        public static void StatementsAndLoops()
        {
            foreach (Question question in QuizzQuestions.Questions)
            {
                Console.WriteLine(question.Text);

                for (int i = 0; i < question.Options.Length; i++)
                {
                    Console.WriteLine($"{i + 1}.{question.Options[i]}");
                }

                string userAnswer = Console.ReadLine().Trim();


                if (userAnswer.ToLower() == question.Answer.ToLower())
                {
                    Console.WriteLine("You guessed right!");
                }
                else
                {
                    Console.WriteLine($"Inccorect! The right answer was {question.Answer}");
                }

            }
        }
    }
}
