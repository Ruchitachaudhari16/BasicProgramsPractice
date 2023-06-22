using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class ArithmeticOperations
    {
        //Arithmatic Operations.
        public void ArithmaticOperations()
        {
            int a,b,result;
            Console.WriteLine("Enter the values of a,b");
            a = Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a choice1");
            int choice = Convert.ToInt32(Console.ReadLine());
              
           
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition Operation");
                        result = a + b;
                        Console.WriteLine("Addition is:" + result);
                        break;

                    case 2:
                        Console.WriteLine("Subtraction Operation");
                        result = a - b;
                        Console.WriteLine("Subtraction is:" + result);
                        break;

                    case 3:
                        Console.WriteLine("Multiplication Operation");
                        result = a * b;
                        Console.WriteLine("Multiplication is:" + result);
                        break;

                    case 4:
                        Console.WriteLine("Division Opration");
                        result = a / b;
                        Console.WriteLine("Division is:" + result);
                        break;

                        default:
                        Console.WriteLine("Invalid Choise");
                        break;

                }
            }
        }
        
    }

