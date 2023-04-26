using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuizz
{
    public static class QuizzQuestions
    {
        public static Question[] Questions { get; private set; }

        public static void SetGeographyQuestions()
        {
            Questions = new Question[]
            {
                new Question("What is the name of the tallest mountain in the world?",
                    "Mount Everest",
                    new string[] {"Himalayas", "Mount Everest", "Alps","Lhotse"}),

                new Question("What is the biggest continent of the world?",
                    "Asia",
                    null)
            };
        }

        public static void SetHistoryQuestions()
        {
            Questions = new Question[]
            {
                new Question("What was the main reason for the outbreak of World War I in 1914?",
                    "All of the above",
                    new string[] { "Germany's aggressive foreign policy", "Austria-Hungary's assassination of Archduke Franz Ferdinand", "Russia's support for Serbia", "All of the above"}),

                new Question("Which ancient civilization built the Machu Picchu complex in the Andes Mountains of Peru?",
                    "Incas",
                    new string[]{"Aztecs", "Incas", "Mayas", "Olmecs", }),

                new Question("Who was the first woman to be elected as the Prime Minister of a country?",
                    "Golda Meir",
                    new string[]{ "Indira Gandhi", "Margaret Thatcher", "Golda Meir", "Sirimavo Bandaranaike", })
            };

        }

        public static void SetSportQuestions()
        {
            Questions = new Question[]
            {
                new Question("Which country has won the most FIFA World Cup titles?",
                    "Brazil",
                    new string[] { "Germany", "Brazil", "Argentina", "Italy"}),

                new Question("Who is the all-time leading scorer in NBA history?",
                    "Kareem Abdul-Jabbar",
                    new string[]{ "Michael Jordan", "Kobe Bryant", "Kareem Abdul-Jabbar", "LeBron James", }),

                new Question("What is the national sport of Japan?",
                    "Sumo",
                    null)
            };

        }


    }
}