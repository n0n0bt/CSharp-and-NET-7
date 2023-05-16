using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class ReadATextFileWithUsing
    {
        private string _filePath;


        public ReadATextFileWithUsing(string filePath)
        {
            _filePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
        }


        internal void ReadFile()
        {
            string line;

            using (StreamReader sr = new StreamReader(_filePath))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                line = sr.ReadLine();

                while (line != null)
                {
                    line = sr.ReadLine();
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.White;

            }
        }
    }
}
