using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class LargestOfThree
    {
        public void CheckThreeNumbers()
        {
            int num1, num2, num3;
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the 1st  number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the 2nd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the 3rd  number :");
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The 1st Number is the greatest among three. \n\n");
                }
                else
                    Console.WriteLine("The 3rd Number is the greatest among three. \n\n");

            }
            else if (num2 > num3)
                Console.WriteLine("The 2nd Number is the greatest among three \n\n");
            else
                Console.WriteLine("The 3rd Number is the greatest among three \n\n");
        }
    }
}
