using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
   public class DaysMonthYear
    {
        public const int day = 7;
        public const int month = 30;
        public const int year = 365;
        public void CheckDays()
        {

            Console.WriteLine("Enter the number of Days");
            int days=Convert.ToInt32(Console.ReadLine());

            int years = days / year;
            Console.WriteLine("Days to year is:" + years);

            int weeks = days / day;
            Console.WriteLine("Days to weeks is:"+weeks);

            int months = days / month;
            Console.WriteLine("Days to Months is:"+months);
        }
    }
}
