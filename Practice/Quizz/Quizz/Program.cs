using TheQuizz;

Console.WriteLine("Hello, World!");

// We need a class(type) that will contains Questions

// Home work: Make a new class for Choosing witch category the user want's

QuizzQuestions.SetGeographyQuestions();

foreach (Question question in QuizzQuestions.Questions)
{
    Console.WriteLine(question.Text);

    for (int i = 0;i<question.Options.Length; i++)
    {
        Console.WriteLine($"{i + 1}.{question.Options[i]}");
    }

    string userAnswer = Console.ReadLine().Trim();


    if (userAnswer.ToLower() == question.Answer.ToLower())
    {
        Console.WriteLine("You guessed right!");
    } else
    {
        Console.WriteLine($"Inccorect! The right answer was {question.Answer}");
    }

    Console.WriteLine();
}

bool newGame = Console.ReadLine().ToLower() == "yes";

if (newGame)
{
    // we need to create new game with another Category
    // ex. QuizzQuestions.SetGeographyQuestions();



}