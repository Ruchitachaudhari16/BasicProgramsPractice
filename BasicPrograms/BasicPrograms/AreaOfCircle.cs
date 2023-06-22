using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
   public class AreaOfCircle
    {
        public void CheckAreaOfCircle()
        {
            //Area Of Circle
            Console.WriteLine("Enter the radius of circle");
            int radius=Convert.ToInt32(Console.ReadLine());
            //Area of Circle
            double area=Math.PI* radius*radius;
            Console.WriteLine("Area of Circle is:" + area);

        }
    }
}
