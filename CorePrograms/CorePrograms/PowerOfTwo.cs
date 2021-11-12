using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class PowerOfTwo
    {

		const int BASE = 2;
		int power, result = 1;
		public void Calculate()
		{
			
		    Console.WriteLine("Enter the Power No.");
			int power = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= power; i++)
			{
				result = result * BASE;
				Console.WriteLine("power of the result:" + result);
			}
		}
	}
}
