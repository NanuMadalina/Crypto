using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti textul dorit: \n");

            string text = Console.ReadLine();

            text = text.ToUpper();

            for (int i = 0; i < 26; i++)
            {


                string output = "";
                foreach (char letter in text)
                {
                    if (letter == ' ')
                    {
                        output += " ";
                        continue;

                    }

                    int letCode = ((int)(letter) + i - 65) % 26 + 65;
                    char let = (char)letCode;
                    output += let.ToString();

                }
                Console.WriteLine(i + " " + output);

            }

            Console.ReadLine();

        }
    }
}
