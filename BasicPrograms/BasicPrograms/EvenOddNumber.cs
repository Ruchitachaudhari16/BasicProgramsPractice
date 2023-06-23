using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
   public  class EvenOddNumber
    {
        //Even Odd Number
        public void CheckEvenOdd()
        {
            Console.WriteLine("Enter the number to check weather it is Even or Odd");
            int number=int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else 
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}
