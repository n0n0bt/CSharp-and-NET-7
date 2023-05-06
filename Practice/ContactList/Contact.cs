using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    public class Contact
    {
        private string _name;

        public string Name
        {
            set { _name = value; }
        }
        public string Surname { get; set; }
        public string Address { get; set; }
        public List<string> PhoneNumbers { get; set; }

        public Contact()
        {
            
        }

        public Contact(string name, string surname, string address, List<string> phoneNumbers)
        {
            _name = name.Length > 4 && name.Length < 10 ? name : throw new Exception("Invalid name");
            
            Surname = surname;
            Address = address;

            if (phoneNumbers.Count <= 5)
            {
                bool flag = true;

                for (int i = 0; i < phoneNumbers.Count; i++)
                {
                    if  (!(phoneNumbers[i].Count() == 9 && (phoneNumbers[i].StartsWith("070")) ||
                        (phoneNumbers[i].StartsWith("071")) ||(phoneNumbers[i].StartsWith("072")) ||
                        (phoneNumbers[i].StartsWith("075")) || (phoneNumbers[i].StartsWith("076"))))
                    {
                        flag = false;
                    }
                }

                if (flag)
                {

                    PhoneNumbers = phoneNumbers;
                }

            }
            else
            {
                throw new Exception("List is more than 5 elements");
            }

        }

        public string getName()
        {
            return _name;
        }

        public List<string> getNumbers()
        {
            string savePosition = "";

            // sortiranje na niza

            for (int i = 0; i < PhoneNumbers.Count -1; i++)
            {
                for (int j = 1; j < PhoneNumbers.Count; j++)
                {
                    if (PhoneNumbers[i].CompareTo(PhoneNumbers[j + 1]) > 0)
                    {
                        savePosition = PhoneNumbers[i];
                        PhoneNumbers[i] = PhoneNumbers[j];
                        PhoneNumbers[j] = savePosition;
                    }
                }
            }

            return PhoneNumbers;
        }

        public string addNumber(string  number)
        {
            if (PhoneNumbers.Count<5)
            {
                PhoneNumbers.Add(number);
                return "Added number";
            }
            else
            {
                return "Not added number";
            }
        }

        public string Print()
        {
            string numbers = "";
            int i = 0;
            foreach (var num in PhoneNumbers)
            {
                numbers += $"Number {PhoneNumbers.IndexOf(num)}: {num}";
            }
            string message = $"Name: {_name}, Surname: {Surname}, Adress: {Address}";

            return message;
        }

    }
}
