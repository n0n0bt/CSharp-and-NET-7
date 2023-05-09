using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

WriteLine("Hellooo");

SectionTitle("Writing to text streams");

// define a file to write to 
string textFile = Combine(CurrentDirectory, "streams.txt");

//create a text fiole nd return a helper writer
StreamWriter text = File.CreateText(textFile);

foreach (string item in Viper.Callsigns)
{
    text.WriteLine(item);
}

text.Close();
WriteLine("{0} contains {1:N0} bytes.", textFile, new FileInfo(textFile).Length);
WriteLine(File.ReadAllText(textFile));