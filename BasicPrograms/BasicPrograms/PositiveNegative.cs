using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class PositiveNegative
    {
        public void CheckPosNeg()
        {
            Console.WriteLine("Check weather the number is Positive or Negetive");
            int number=int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("Number is Positive");
            }
            else
            {
                Console.WriteLine("Number is Negitive");
            }
        }
    }
}
