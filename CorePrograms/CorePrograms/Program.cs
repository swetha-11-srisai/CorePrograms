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
                Console.WriteLine("Enter your Choice Number to Execute the Program Press- 1-CoinFlip,2-LeapYear,3-Poweroftwo,4-HormonicNumber,5-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CoreProgram core = new CoreProgram();
                        core.CoinFlip();
                        break;
                    case 2:
                        LeapYear leap = new LeapYear();
                        leap.CheckLeapYear();
                        break;
                    case 3:
                        PowerOfTwo powertwo = new PowerOfTwo();
                        powertwo.Calculate();
                        break;
                    case 4:
                        HarmonicNumber hormonic = new HarmonicNumber();
                        hormonic.FindNumber();
                        break;

                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
