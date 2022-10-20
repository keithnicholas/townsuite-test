using System;

namespace TownSuite_Programming_Test
{
    public class Program
    {
        private static readonly int N = 100;
        private static readonly int BEGIN = 1;
        public static void Main(string[] args)
        {
            printToN(N);
        }

        public static void printToN(int n)
        {
            for(int i = BEGIN;i <= n;i++)
            {
                bool divBy3 = i % 3 == 0;
                bool divBy5 = i % 5 == 0;

                bool divBoth = divBy3 && divBy5;

                // Only one of these conditions can be true at any given iteration
                if(divBoth)
                {
                    Console.WriteLine("SupportTraining");
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
