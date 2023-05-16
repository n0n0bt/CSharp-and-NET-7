using Practice;

Console.WriteLine("Helllllllooooo");
Console.WriteLine(Directory.GetCurrentDirectory());

//ReadATextFile.CreateAFile();
//ReadATextFile.ReadFile();

ReadATextFileWithUsing readATextFileWithUsing = new ReadATextFileWithUsing(Path.Combine(Directory.GetCurrentDirectory(), "input.txt"));
readATextFileWithUsing.ReadFile();
