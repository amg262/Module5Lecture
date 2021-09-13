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
                input = Console.ReadLine().Trim().ToUpper();

                Console.WriteLine(input);

                switch (input)
                {
                    case "U":
                        Console.Write("Enter value to count up from 1>");
                        Int32.TryParse(Console.ReadLine(), out int max);

                        for (int i = 0; i <= max; i++)
                        {
                            Console.Write(i + "\t");
                        }

                        break;
                    case "D":
                        Console.Write("Enter value to count up from 10>");
                        Int32.TryParse(Console.ReadLine(), out int min);

                        while (min >= 10)
                        {
                            Console.WriteLine("Enter valid # less than 10");
                            //Int32.TryParse(Console.ReadLine(), out min);
                            min = Convert.ToInt32(Console.ReadLine());
                        }

                        for (int i = 0; i <= min; i--)
                        {
                            Console.Write(i + "\t");
                        }

                        break;
                    default: break;
                }
            } while (input != "E");
        }

        static void Main(string[] args)
        {
            Lecture4Review();
        }
    }
}