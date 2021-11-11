using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class CoreProgram
    {
        public void CoinFlip()
        {
            Console.WriteLine("Enter the Number of times want to flip the coin");
            int num = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int headCount = 0, tailCount = 0;
            double percentage;
            for (int i = 0; i < num; i++)
            {
                double flip = random.NextDouble();
                if (flip < 0.5)
                {
                    Console.WriteLine("Heads");
                    headCount++;
                    percentage = (headCount / num) * 100;
                    Console.WriteLine("Percentage of Heads vs Tails is: " + percentage);
                }
                else
                {
                    Console.WriteLine("Tails");
                    tailCount++;
                    percentage = (tailCount / num) * 100;
                    Console.WriteLine("Percentage of Heads vs Tails is: " + percentage);
                }

            }
        }
    }
}

