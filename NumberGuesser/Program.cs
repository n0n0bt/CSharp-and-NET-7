
// The NameSpace
namespace NumberGuesser
{   
    //Main Class
    class Program
    {   // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo to get info

            GreetUser();// Ask for usersname and greet

            while (true)
            {
                // int correctNumber = 7;


                // Create a new random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 11);

                // Init guess variable
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");



                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure its a number

                    if (!int.TryParse(input, out guess))
                    {
                       // Print error message
                       PrintColorMessage(ConsoleColor.Red, "Please use an actual number!");

                        // Keep going
                        continue;
                    }



                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again!");
                    }
                }


                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!");

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get the answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue; 

                } else if(answer == "N")
                {
                    return;
                }
            }


        }


        
      
        // Get and display app info
        static void GetAppInfo()
        {
            // Set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Naumche Joshevski";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }


        // Greet user function
        static void GreetUser()
        {
            // Ask User's Name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();

        }
    }
}