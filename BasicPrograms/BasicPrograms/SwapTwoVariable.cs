using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public  class SwapTwoVariable
    {
        public void SwapVariables()
        {
            Console.WriteLine("Enter the value of variables:");
            int numberOne, numberTwo;
            numberOne=Convert.ToInt32(Console.ReadLine());
            numberTwo=Convert.ToInt32(Console.ReadLine());
            numberOne = numberOne + numberTwo;
            numberTwo=numberOne-numberTwo;
            numberOne = numberOne - numberTwo;
            Console.WriteLine("NumberOne  after Swapping:"+numberOne);
            Console.WriteLine("NumberTwo after Swapping:"+numberTwo);
        }
    }
}
