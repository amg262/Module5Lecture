using System;

namespace Module5Lecture
{
    class Program
    {
        static void Lecture4Review()
        {
            //Counting program - menu with sentinel

            string input = "";

            do
            {
                Console.Write("U.  Count Up\nD.  Count Down\nE.  Exit\n>");
                input = Console.ReadLine();

                Console.WriteLine(input);

                switch (input)
                {
                    case "U":
                    case "u":
                        Console.Write("Enter value to count up from 1>");
                        Int32.TryParse(Console.ReadLine(), out int max);

                        for (int i = 0; i <= max; i++)
                        {
                            
                        }
                }
            } while (input != "E");
        }

        static void Main(string[] args)
        {
        }
    }
}