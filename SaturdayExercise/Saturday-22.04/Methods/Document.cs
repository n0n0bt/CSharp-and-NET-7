using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_22._04.Methods
{
    public class Document
    {
        public Document(string name, int pages)
        {
            this.Name = name;
            this.NumOfPages = pages;
            this.createOn = DateTime.Now;
        }

        public string Name { get; set; }
        public int NumOfPages { get; set; }
        public DateTime createOn { get; set; }



        public void Present()
        {
            Console.WriteLine($"Name:{Name}, Number of pages: {NumOfPages}, Created on: {createOn}");
        }
    }
}
