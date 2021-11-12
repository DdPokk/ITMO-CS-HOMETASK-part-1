using System;
using System.Collections.Generic;

namespace Project5
{
    class Century
    {
        private int centuryNum;

        public Century(int num)
        {
            this.centuryNum = num;
        }

        public void printNiceDates()
        {
            int startYear = (this.centuryNum - 1) * 100 + 1;
            for (int i = 0; i < 100; ++i)
            {
                int year = startYear + i;
                int shortYear = year % 100;
                for (int month = 1; month <= 12; ++month)
                {
                    if (month > shortYear)
                        break;
                    int monthDuration = DateTime.DaysInMonth(year, month);
                    for (int day = 1; day <= monthDuration; ++day)
                    {
                        if (day * month > shortYear)
                            break;
                        if (day * month == shortYear)
                            Console.WriteLine("Nice date: {0}.{1}.{2}", day, month, year);
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Century twentyOne = new Century(21);
            twentyOne.printNiceDates();
        }
    }
}