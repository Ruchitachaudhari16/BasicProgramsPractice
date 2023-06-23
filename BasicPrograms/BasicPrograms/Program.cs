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
                Console.WriteLine("7:Even Odd Number");
                Console.WriteLine("8:Positive Negetive Number");
                Console.WriteLine("9:Largest Number among 2 Number");
                Console.WriteLine("10:Reverse Number");
                Console.WriteLine("11:Check Palindrome number");
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

                        case 7:
                            EvenOddNumber evenOddNumber= new EvenOddNumber();
                        evenOddNumber.CheckEvenOdd();
                        break;

                        case 8:
                            PositiveNegative positiveNegative = new PositiveNegative();
                        positiveNegative.CheckPosNeg(); 
                        break;

                        case 9:
                            LargestNumber largestNumber = new LargestNumber();
                        largestNumber.LargestNumberCheck();
                        break;

                        case 10:
                            ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.CheckReverseNumber();
                        break;

                        case 11:
                            Palindrome palindrome = new Palindrome();
                        palindrome.CheckPalindrome();
                        break;


                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
                Console.ReadKey();
                Console.Clear();
            }
            while (choice != 13);

                Console.ReadLine();





            


        }
    }
    }



