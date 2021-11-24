using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Experiment3_3B
{
    enum MonthName
    {
        January, February, March, April, May, June, July, August, September, October, November, December
    }
    class WhatDay
    {
        static System.Collections.ICollection DaysInMonths = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input the year: ");
                string year = Console.ReadLine();
                int yearNum = int.Parse(year);
                bool isLeapYear = yearNum % 4 == 0 && yearNum % 100 != 0 || yearNum % 400 == 0;
                int maxDayNum = isLeapYear ? 366 : 365;
                if (isLeapYear)
                {
                    DaysInMonths = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; ;
                }
                Console.Write("Please input a day number between 1 and {0}: ",maxDayNum);
                string line = Console.ReadLine();
                int dayNum = int.Parse(line);
                if (dayNum < 1 | dayNum > maxDayNum)
                {
                    throw new ArgumentOutOfRangeException("Day out of range");
                }
                int monthNum = 0;
                foreach (int daysInMonth in DaysInMonths)
                {
                    if (dayNum <= daysInMonth)
                    {
                        break;
                    }
                    else
                    {
                        dayNum -= daysInMonth;
                        monthNum++;
                    }
                }
                MonthName temp = (MonthName)monthNum;
                string monthName = Enum.Format(typeof(MonthName), temp, "g");
                Console.WriteLine("{0} {1}", dayNum, monthName);
            }
            catch (Exception caught)
            {
                Console.WriteLine(caught);
            }
        }
    }
}
