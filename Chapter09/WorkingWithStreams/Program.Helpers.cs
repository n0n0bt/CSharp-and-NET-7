partial class Program
{
   static void SectionTitle(string title)
    {
        ConsoleColor prevousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.Yellow;
        WriteLine("*");
        WriteLine($"* {title}");
        WriteLine("*");
        ForegroundColor = prevousColor;
    }
}


