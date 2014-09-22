using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3lonerevision
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int numberOfSalaries = ReadInt("Enter total number of salaries: ");
                Console.Write("\n");
                if (numberOfSalaries >= 2)
                {
                    ProcessSalaries(numberOfSalaries);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Enter at least two salaries to perform a calculation!");
                    Console.ResetColor();
                    Console.WriteLine("");
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Press any key for new calculation - ESC closes application.");
                    Console.ResetColor();
                }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        static void ProcessSalaries(int count)
        {
            int[] salaries = new int[count];
            int[] salariesUnsorted = new int[count];
            int number = 1;
            for (int i = 0; i < count; i++)
            {
                salaries[i] = ReadInt("Input salary " + number++ + ": ");
            }

            Array.Copy(salaries, salariesUnsorted, count);
            Array.Sort(salaries);

            if (count % 2 != 0)
            {
                int median = salaries.Length / 2;
                Console.WriteLine("---------------------------");
                Console.WriteLine("Median salary  : {0,10:c0}", salaries[median]);

                //mittersta värdet = medianlön      
            }

            else
            {
                int value1 = salaries.Length / 2;
                int value2 = value1 - 1;
                int median = salaries[value1] + salaries[value2];
                Console.WriteLine("---------------------------");
                Console.WriteLine("Median salary  : {0,10:c0}", median / 2);
                //Två mittersta värdena/2 = medianlön
            }
            //averagepayuträkning

            int totalPay = 0;

            for (int j = 0; j < count; j++)
            {
                totalPay += salaries[j];
            }
            Console.WriteLine("Average salary : {0,10:c0}", totalPay / count);


            int salarySpread = salaries.Max() - salaries.Min();
            Console.WriteLine("Salary spread  : {0,10:c0}", salarySpread);
            Console.WriteLine("---------------------------");

            for (int k = 0; k < count; k++)
            {
                if (k % 3 == 0)
                {
                    Console.WriteLine("");
                }

                Console.Write("{0,9}", salariesUnsorted[k]);
            }
            Console.WriteLine("\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Press any key for a new calculation - ESC closes the application.");
            Console.ResetColor();
        }

        static int ReadInt(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    int numberOfSalaries = int.Parse(Console.ReadLine());
                    return numberOfSalaries;
                    
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" is not a valid format. Please enter a valid format!");
                    Console.ResetColor();
                }

              
            }

        }

    }
}