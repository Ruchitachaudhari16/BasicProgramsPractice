using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class Palindrome
    {
        //Palindrome Number
        public void CheckPalindrome()
        {
            int number;
            
            Console.WriteLine("Enter the number check weather it is Palindrome or not");
            number =int.Parse(Console.ReadLine());   
            int remainder,result = 0;
            int temp=number;
            while (number != 0)
            {
                remainder = number % 10;
                result = result*10+remainder;
                number = number/10;
            }
            number = temp;
            if (number == result)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else 
            {
                Console.WriteLine("Number is not a Palindrome Number");
            }
        }
    }
}
