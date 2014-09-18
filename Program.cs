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
            //Läs in antal index i arrayen (löner i arrayen)
            int numberOfSalaries = ReadInt("Enter total number of salaries: ");
            int[] salaries = new int[numberOfSalaries];

            //Läs in de olika lönerna med hjälp av array
            ProcessSalaries(numberOfSalaries);


           //Sortera lönerna i storleksordning
            

            //Läs ut medianlönen, udda antal - mittersta, jämt antal - två mittersta / 2

            //Skriv ut.
        }
	 
        static void ProcessSalaries(int count)
        {
            int[] salaries = new int[count];

            for (int i = 0; i < count ; i++)
            {
                Console.Write("Enter the salary number {0}:", i);
                salaries[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(salaries);

            if (count % 2 != 0)
            {
                int median;
                median = salaries.Length / 2;
                Console.WriteLine("---------------------------");
                Console.Write("Median salary  : {0,10:c0}", salaries[median]);
                Console.WriteLine("\n");
                //mittersta värdet = medianlön      
            }

            else 
            {
                int median;
                int value1;
                int value2;
                value1 = salaries.Length / 2;
                value2 = value1 - 1;
                median = salaries[value1] + salaries[value2];
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
            Console.WriteLine("Average salary : {0,10:c0}" , totalPay/count);

            

            //Console.Write("Medianlön:{0}");
            //Console.WriteLine("Average Salary: ");
            Console.WriteLine("Salary spread:");
            Console.WriteLine("---------------------------");

        }
            

        static int ReadInt(string prompt)
        {
            Console.Write(prompt);
            int numberOfSalaries = int.Parse(Console.ReadLine());
            return numberOfSalaries;
        }

    }
}
