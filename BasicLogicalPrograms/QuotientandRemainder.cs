using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class QuotientandRemainder
    {
        public void CompQuotientandRemainder(float dividend, float divisor)
        {
            float Quotient = dividend / divisor;
            float Reminder = dividend % divisor;
            Console.WriteLine("Quotient and Remainder:" + Quotient + " " + Reminder);
        }
    }
}
