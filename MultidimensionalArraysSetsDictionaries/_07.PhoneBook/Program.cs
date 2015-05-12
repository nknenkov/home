using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            Console.WriteLine("Enter name and phone number separated by space(name phone)");
            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "search")
                {
                    break;
                }
                if (phoneBook.ContainsKey(input[0]))
                {
                    phoneBook[input[0]] = input[1];
                }
                else
                {
                    phoneBook.Add(input[0], input[1]);
                }
            }
            while (true)
            {
                string name = Console.ReadLine();
                if (name == String.Empty)
                {
                    break;
                }
                if (phoneBook.ContainsKey(name))
                {
                    Console.WriteLine("{0} -> {1}", name, phoneBook[name]);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", name);
                }
            }
        }
    }
}
