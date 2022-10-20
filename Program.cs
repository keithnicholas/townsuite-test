using System;

namespace TownSuite_Programming_Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("A program that prints the number from 1 to 100. Prints \"Support\" for multiple of 3, \"Training\" for multiple of 5, and" +
                "print \"SupportTraining\" if both conditions are satisfied ");
            printToN(100);
        }

        public static void printToN(int n)
        {
            for(int i =1;i <= n;i++)
            {
                bool divBy3 = i % 3 == 0;
                bool divBy5 = i % 5 == 0;

                bool divBoth = divBy3 && divBy5;

                // Only one of these conditions can be true at any given iteration
                if(divBoth)
                {
                    Console.WriteLine("Support Training");
                }
                else if(divBy3)
                {
                    Console.WriteLine("Support");
                }
                else if(divBy5)
                {
                    Console.WriteLine("Training");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
