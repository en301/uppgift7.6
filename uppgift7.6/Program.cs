using System;
using System.Collections.Generic;

namespace uppgift_7_6
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in matvarorna du vill handla");
            string varor = Console.ReadLine().ToLower();
            string[] deladvaror = varor.Split(' ');
            Console.WriteLine("Skriv in matvarornas priser");
            string priser = Console.ReadLine();
            string[] deladpriser = priser.Split(' ');
            Dictionary<string, int> matlista = new Dictionary<string, int>();

            for (int i = 0; i < deladvaror.Length; i++)
            {
                matlista[deladvaror[i]] = int.Parse(deladpriser[i]);
            }
            Console.WriteLine("Skriv ut din handlingslista");
            string svar = Console.ReadLine().ToLower();
            string[] deladsvar = svar.Split(' ');
            int sum = 0;

            for (int i = 0;i < deladsvar.Length; i++)
            {
                sum += matlista[deladsvar[i]];
            }
            Console.WriteLine("Priset för handlingslistan är " + sum + "kr");
            Console.ReadKey();

        }
    }
}