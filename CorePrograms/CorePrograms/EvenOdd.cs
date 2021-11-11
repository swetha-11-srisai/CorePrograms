using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class EvenOdd
    {
        public void EvenOddCheck()
        {
            Console.WriteLine("Enter the number to check whether the number is even or odd");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num%2 == 0)
            {
                Console.WriteLine("The number is an even number");
            }
            else
                Console.WriteLine("The number is an odd");
        }
    }
}
