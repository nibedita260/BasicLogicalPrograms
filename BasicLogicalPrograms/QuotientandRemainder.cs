using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class QuotientandRemainder
    {
        public float  CompQuotientandRemainder(float n1,float n2)
        {
            float Quotient = n1 / n2;
            float Reminder = n1 % n2;
            Console.WriteLine("Quotient and Remainder:" + Quotient + " " + Reminder);
            return Quotient;
        }
    }
}
