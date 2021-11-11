using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class SwapTwoNumbers
    {
        public void Swap()
        {
            int num1, num2;
            Console.WriteLine("Enter the value of num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of num2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            //Before Swapping
            Console.WriteLine("Before Swapping");
            Console.WriteLine("num1=" + num1);
            Console.WriteLine("num2=" + num2);
            //swapping
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            //After Swapping
            Console.WriteLine("Values after swapping are:");
            Console.WriteLine("num1=" + num1);
            Console.WriteLine("num2=" + num2);
        }
    }
}
