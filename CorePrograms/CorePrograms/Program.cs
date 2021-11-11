using System;

namespace CorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Program Press- 1-CoinFlip, 2-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CoreProgram core = new CoreProgram();
                        core.CoinFlip();
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
