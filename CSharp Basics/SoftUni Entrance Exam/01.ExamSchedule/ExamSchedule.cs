using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ExamSchedule
    {
        static void Main(string[] args)
        {
            int startHour = int.Parse(Console.ReadLine());
            //while (startHour > 12 || startHour < 1)
            //{
            //    startHour = int.Parse(Console.ReadLine());
            //}

            int startMinutes = int.Parse(Console.ReadLine());
            //while (startMinutes > 59 || startMinutes < 0)
            //{
            //    startMinutes = int.Parse(Console.ReadLine());
            //}

            string partOfTheDay = Console.ReadLine();
            //while (partOfTheDay != "AM" && partOfTheDay != "PM")
            //{
            //    partOfTheDay = Console.ReadLine();
            //}

            int durationHours = int.Parse(Console.ReadLine());
            //while (durationHours > 23 || durationHours < 0)
            //{
            //    durationHours = int.Parse(Console.ReadLine());
            //}

            int durationMinutes = int.Parse(Console.ReadLine());
            //while (durationMinutes > 59 || durationMinutes < 0)
            //{
            //    durationMinutes = int.Parse(Console.ReadLine());
            //}

            for (int i = 1; i <= durationHours; i++)
            {
                startHour++;
                if (startHour > 12)
                {
                    startHour = 1;
                    if (partOfTheDay == "AM")
                    {
                        partOfTheDay = "PM";
                    }
                    else if (partOfTheDay == "PM")
                    {
                        partOfTheDay = "AM";
                    }
                }
            }
            for (int i = 1; i <= durationMinutes; i++)
            {
                startMinutes++;
                if (startMinutes > 59)
                {
                    startMinutes = 0;
                    startHour++;
                    if (startHour > 11)
                    {
                        if (partOfTheDay == "AM")
                        {
                            partOfTheDay = "PM";
                        }
                        else if (partOfTheDay == "PM")
                        {
                            partOfTheDay = "AM";
                        }
                    }
                }
            }
            Console.WriteLine("{0:00}:{1:00}:{2}", startHour, startMinutes, partOfTheDay);
        }
    }
}
