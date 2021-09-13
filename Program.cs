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


        static void TryItOut()
        {
            /*
             * Loop asking for donation - store 3 amounts and print
             */
            double[] donations = new double[3];

            Console.WriteLine("#1 Donation");
            Double.TryParse(Console.ReadLine(), out donations[0]);

            Console.WriteLine("#2 Donation");
            Double.TryParse(Console.ReadLine(), out donations[1]);

            Console.WriteLine("#3 Donation");
            Double.TryParse(Console.ReadLine(), out donations[2]);

            Console.WriteLine($"Donation #1: {donations[0]:C}");
            Console.WriteLine($"Donation #2: {donations[1]:C}");
            Console.WriteLine($"Donation #3: {donations[2]:C}");

            Console.WriteLine($"Total: {(donations[0] + donations[1] + donations[2]):C}");
        }


        static void TryItOutLoop()
        {
            /*
             * Loop asking for donation - store 3 amounts and print
             */
            double[] donations = new double[3];
            double total = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1} Donation");
                Double.TryParse(Console.ReadLine(), out donations[i]);
                total += donations[i];
            }

            Console.WriteLine($"Total:  {total:C}");

        }

        static void Main(string[] args)
        {
            //Lecture4Review();
            //TryItOut();
            TryItOutLoop();
        }
    }
}