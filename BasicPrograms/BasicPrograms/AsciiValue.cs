using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
   public  class AsciiValue
    {
        public void CheckAsciiValue()
        {
            char charcter;
            Console.WriteLine("Enter a character");
            charcter=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("ASCII value of :" + charcter+ " " + Convert.ToInt32(charcter));

        }
    }
}
