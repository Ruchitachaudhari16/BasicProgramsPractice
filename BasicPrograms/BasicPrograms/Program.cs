using System;

namespace BasicPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {

                Console.WriteLine("1:Arithmatic Operations");
                Console.WriteLine("2:SizeOfDataTypes");
                Console.WriteLine("3:Area of Circle");
                Console.WriteLine("4:DaysMonthYear");
                Console.WriteLine("5:SwapNumbers");
                Console.WriteLine("6:ASCII Value");
                Console.WriteLine("Enter the Choice");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ArithmeticOperations arithmeticOperati = new ArithmeticOperations();
                        arithmeticOperati.ArithmaticOperations();
                        break;

                    case 2:
                        SizeOfDataTypes sizeOfDataTypes = new SizeOfDataTypes();
                        sizeOfDataTypes.Size();
                        break;

                    case 3:
                        AreaOfCircle areaOfCircle = new AreaOfCircle();
                        areaOfCircle.CheckAreaOfCircle();
                        break;

                    case 4:
                        DaysMonthYear daysMonthYear = new DaysMonthYear();
                        daysMonthYear.CheckDays();
                        break;

                    case 5:
                        SwapTwoVariable swapTwo = new SwapTwoVariable();
                        swapTwo.SwapVariables();
                        break;

                    case 6:
                        AsciiValue asciiValue = new AsciiValue();
                        asciiValue.CheckAsciiValue();
                        break;


                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
                Console.ReadKey();
                Console.Clear();
            }
            while (choice != 7);

                Console.ReadLine();





            


        }
    }
    }



