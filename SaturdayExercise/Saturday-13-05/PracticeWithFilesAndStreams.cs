using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_13_05
{
    public class PracticeWithFilesAndStreams
    {
        public static void Main()
        {
            try
            {
                string file = @"C:\Users\Privat\Documents\CodeAcademy\code-academy\CSharp-and-NET-7\newtext.txt";

                //Creating File
                FileStream fs = new FileStream(file, FileMode.Create);

                //Adding current date and time in file
                byte[] bdata = Encoding.Default.GetBytes(DateTime.Now.ToString());

                fs.Write(bdata, 0, bdata.Length);

                Console.WriteLine("Data Added");

                fs.Close();

                //Reading File
                string data;

                FileStream fsread = new FileStream(file, FileMode.Open, FileAccess.Read);

                using (StreamReader sr = new StreamReader(fsread))
                {
                    data = sr.ReadToEnd();
                }


                Console.WriteLine(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }

            Console.ReadKey();
        }


        public static void Main1()
        {
            try
            {
                string binaryFile = @"C:\Users\Privat\Documents\CodeAcademy\code-academy\CSharp-and-NET-7\newbinary.dat";

                FileStream fileStream = new FileStream(binaryFile, FileMode.Create);
                BinaryWriter writer = new BinaryWriter(fileStream);

                byte[] bdata = Encoding.Default.GetBytes(DateTime.Now.ToString());
                writer.Write(bdata, 0, bdata.Length);

                Console.WriteLine("Data Added");
                writer.Close();
                fileStream.Close();

                FileStream fstreamRead = new FileStream(binaryFile, FileMode.Open, FileAccess.Read);

                string data;
                using (BinaryReader reader = new BinaryReader(fstreamRead))
                {
                    data = reader.ReadString();
                }

                Console.WriteLine("Read from file: " + data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }


        public static void Main2()
        {
            try
            {
                string originalString = "I am reading File Handling at Complete C#";

                // Write the string to a StringWriter
                StringWriter stringWriter = new StringWriter();
                stringWriter.Write(originalString);

                // Manipulate the string using the StringWriter
                string manipulatedString = stringWriter.ToString().ToUpper();

                // Read the manipulated string using StringReader
                StringReader stringReader = new StringReader(manipulatedString);
                string readString = stringReader.ReadLine();

                // Output the results
                Console.WriteLine("Original string: " + originalString);
                Console.WriteLine("Manipulated string: " + manipulatedString);
                Console.WriteLine("Read string: " + readString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadLine();
        }


        public static void Main3()
        {
            try
            {
                string directoryPath = @"C:\Users\Privat\Documents\CodeAcademy\code-academy\CSharp-and-NET-7\hehe";
                string filePath = Path.Combine(directoryPath, "text.txt");

                Directory.CreateDirectory(directoryPath);

                File.WriteAllText(filePath, "File Handling");

                DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

                FileInfo fileInfo = new FileInfo(filePath);

                Console.WriteLine("Directory Information:");
                Console.WriteLine("Path: " + directoryInfo.FullName);
                Console.WriteLine("Creation Time: " + directoryInfo.CreationTime);
                Console.WriteLine("Last Write Time: " + directoryInfo.LastWriteTime);
                Console.WriteLine();

                // Print file information
                Console.WriteLine("File Information:");
                Console.WriteLine("Path: " + fileInfo.FullName);
                Console.WriteLine("Creation Time: " + fileInfo.CreationTime);
                Console.WriteLine("Last Write Time: " + fileInfo.LastWriteTime);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
