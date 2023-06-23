using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class LargestNumber
    {
        public void LargestNumberCheck()
        {
            Console.WriteLine("Enter the number to check which number is Largest");
            int numberOne, numberTwo;
            numberOne=int.Parse(Console.ReadLine());
            numberTwo=int.Parse(Console.ReadLine());
            if (numberOne > numberTwo)
            {
                Console.WriteLine("NumberOne is Largest Number");
            }
            else 
            {
                Console.WriteLine("NumberTwo is Largest Number");
            }

        }
        
    }
}
