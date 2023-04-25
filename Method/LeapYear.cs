using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class LeapYear
    {
        public static void Lyear()
        {
            // Take input from the user
            Console.Write("Enter a year (format: YYYY): ");
            int year = Convert.ToInt32(Console.ReadLine());

            // Determine if it's a leap year
            bool isLeapYear = false;

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        isLeapYear = true;
                    }
                }
                else
                {
                    isLeapYear = true;
                }
            }

            // Print the result
            if (isLeapYear)
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }

        }
    }
}
