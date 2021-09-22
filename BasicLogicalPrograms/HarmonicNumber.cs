using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class HarmonicNumber
    {
        public void PrintHarmonicNum()
        {
            int n;
            float harmonic = 1;
            Console.WriteLine("Enter number to print Nth Harmonic number");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                harmonic += 1 / (float)i;
            }
            Console.Write("\nSum of Series upto {0} terms : {1} \n", n, harmonic);
        }
    }
}