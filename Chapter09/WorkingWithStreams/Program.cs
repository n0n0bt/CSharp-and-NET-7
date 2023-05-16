using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
using System.Xml;

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

SectionTitle("Writing to XML streams");

// define a file path to write to
string xmlFile = Combine(CurrentDirectory, "streams.xml");

// declare variables for the filestream and XML writer
FileStream? xmlFileStream = null;
XmlWriter? xml = null;

try
{
    // create a file stream
    xmlFileStream = File.Create(xmlFile);

    // wrap the file stream in an XML writer helper
    // and automatically indent nested elements
    xml = XmlWriter.Create(xmlFileStream, new XmlWriterSettings { Indent = true });

    // write the XML declaration
    xml.WriteStartDocument();

    // write a root element
    xml.WriteStartElement("callsigns");

    foreach (string item in Viper.Callsigns)
    {
        xml.WriteElementString("callsign", item);
    }

    // write the closre root element
    xml.WriteEndElement();

    // close helper and stream
    xml.Close();
    xmlFileStream.Close();

}
catch (Exception ex)
{
    // if the path doesn't exist the exception will be caught
    WriteLine($"{ex.GetType()} says {ex.Message}");
}

finally
{
    if (xml != null)
    {
        xml.Dispose();
        WriteLine("The XML writer's unmanaged resources have been disposed.");
    }
    if (xmlFileStream != null)
    {
        xmlFileStream.Dispose();
        WriteLine("The file stream's unmanaged resources have been disposed.");
    }
}

// output all the contents of the file
WriteLine("{0} contains {1:N0} bytes.",
arg0: xmlFile,
arg1: new FileInfo(xmlFile).Length);
WriteLine(File.ReadAllText(xmlFile));