using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class Quotient
    {
        public void CheckRemainder()
        {
            int dividend, divisor, quotient, remainder;
            Console.WriteLine("Enter dividend: ");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divisor: ");
            divisor = Convert.ToInt32(Console.ReadLine());
            quotient = Convert.ToInt32(Console.ReadLine());
            remainder = Convert.ToInt32(Console.ReadLine());
            quotient = dividend / divisor;
            Console.WriteLine("Quotient: "+quotient);
            remainder = dividend % divisor;
            Console.WriteLine("Remainder: "+remainder);
        }
    }
}
