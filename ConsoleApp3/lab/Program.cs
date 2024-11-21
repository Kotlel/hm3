using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4.1
            int day = 0;
            Console.WriteLine("Введите число от 1 до 365");
            day = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(1, 1, 1);
            Console.WriteLine($"{day} соответствует: {date.AddDays(day - 1).ToString("dd MMMM")}");
            // 4.2
            int dayexc = 0;
            while (true)
            {
                Console.WriteLine("Введите число от 1 до 365");
                dayexc = int.Parse(Console.ReadLine());
                if (dayexc <= 365 && dayexc > 0) break;
                else Console.WriteLine("Ошибка");
            }

            DateTime dateexc = new DateTime(1, 1, 1);
            Console.WriteLine($"{dayexc} соответствует: {dateexc.AddDays(dayexc - 1).ToString("dd MMMM")}");
            // 4.1
            int year = 0;
            Console.WriteLine("Введите год");
            year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && (year % 100 != 0)) || (year % 400 == 0))
            {
                int dayleap = 0;
                while (true)
                {
                    Console.WriteLine("Введите число от 1 до 366");
                    dayleap = int.Parse(Console.ReadLine());
                    if (dayleap <= 366 && dayleap > 0) break;
                    else Console.WriteLine("Ошибка");
                }

                DateTime dateleap = new DateTime(year, 1, 1);
                Console.WriteLine($"{dayleap} соответствует: {dateleap.AddDays(dayleap - 1).ToString("dd MMMM yyyy")}");
            }
            else
            {
                int daynotleap = 0;
                while (true)
                {
                    Console.WriteLine("Введите число от 1 до 365");
                    daynotleap = int.Parse(Console.ReadLine());
                    if (daynotleap <= 365 && daynotleap > 0) break;
                    else Console.WriteLine("Ошибка");
                }

                DateTime datenotleap = new DateTime(year, 1, 1);
                Console.WriteLine($"{daynotleap} соответствует: {datenotleap.AddDays(daynotleap - 1).ToString("dd MMMM yyyy")}");
            }
        }
    }
}
