using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
   public class ReverseNumber
    {
        public void CheckReverseNumber()
        {
            //Reverse Number
            int reverse = 0,remainder;
            Console.WriteLine("Enter the number to print the reverse Number");
            int number=int.Parse(Console.ReadLine());
            while (number != 0)
            {
                remainder = number % 10;
                reverse= reverse*10 + remainder;
                number=number/10;
            }
            Console.WriteLine("Reverse Number is:" + reverse);

        }
    }
}
