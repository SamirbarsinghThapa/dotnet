using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 2024;
            int month = 11;
            var calendar = CreateCalendar(year, month);
            foreach (var week in calendar)
            {
                foreach (var day in week)
                {
                    if (day == 0)
                        Console.Write("   ");
                    else
                        Console.Write(day.ToString("00") + " ");
                }
                Console.WriteLine();
            }
        }

        static int[][] CreateCalendar(int year, int month)
        {

            int numDays = DateTime.DaysInMonth(year, month);

            int startDay = (int)new DateTime(year, month, 1).DayOfWeek;


            int[][] calendar = new int[6][];
            int currentDay = 1;


            for (int week = 0; week < 6; week++)
            {
                calendar[week] = new int[7];

                for (int dayOfWeek = 0; dayOfWeek < 7; dayOfWeek++)
                {
                    if (week == 0 && dayOfWeek < startDay)
                    {

                        calendar[week][dayOfWeek] = 0;
                    }
                    else if (currentDay <= numDays)
                    {

                        calendar[week][dayOfWeek] = currentDay++;
                    }
                    else
                    {

                        calendar[week][dayOfWeek] = 0;
                    }
                }
            }
                    return calendar;
                }

            }
        }
    

