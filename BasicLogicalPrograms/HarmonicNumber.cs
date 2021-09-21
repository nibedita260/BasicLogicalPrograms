using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class HarmonicNumber
    {
        public void PrintHarmonicNum()
        {
            int N;
            float harmonic = 1;
            Console.WriteLine("Enter number to print Nth Harmonic number");
            N = Convert.ToInt32(Console.ReadLine());
            for(int i=2;i<=N;i++)
            {
                harmonic += (float)1 / i;
            }
            Console.WriteLine("The Nth Harmonic number:" + harmonic);
        }
    }
}
