﻿using System;

namespace CorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Program Press- 1-CoinFlip,2-LeapYear,3-Poweroftwo,4-HormonicNumber,5-EvenOdd,6-VowelConstant,7-Exit");
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
                        HarmonicNumber hormonic = new HarmonicNumber();
                        hormonic.FindNumber();
                        break;
                    case 5:
                        EvenOdd even = new EvenOdd();
                        even.EvenOddCheck();
                        break;
                    case 6:
                        VowelConstant vowel = new VowelConstant();
                        vowel.CheckVowel();
                        break;
                    case 7:
                        LargestOfThree large = new LargestOfThree();
                        large.CheckThreeNumbers();
                        break;

                    case 8:
                        flag = false;
                        break;
                }
            }
        }
    }
}
