using System;
using System.Runtime.CompilerServices;

namespace Datas
{
    class Datas
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // var data = new DateTime();//1/1/0001 12:00:00 AM
            // var data2 = DateTime.Now;//3/16/2025 1:20:34 AM
            // var data3 = new DateTime(2020, 10, 12, 8, 23, 14);//datetime com ano mes dia hora minuto e segundo definidos
            // Console.WriteLine(data);
            // Console.WriteLine(data2);
            // Console.WriteLine(data3);
            // Console.WriteLine(data3.Year);
            // Console.WriteLine(data3.Month);
            // Console.WriteLine(data3.Day);
            // Console.WriteLine(data3.DayOfWeek);
            // Console.WriteLine(data3.DayOfYear);
            // Console.WriteLine(data3.Second);

            var data4 = DateTime.Now;
            //formatação de data
            // M - mes \ m - minuto \ d - dia \ y - ano \ h - hora \ s - segundo \ f - fração de segundo \ Y - dia do ano
            var formatada = String.Format("{0:yyyy-mm-dd}",data4);
            Console.WriteLine(formatada);
            var formatada2 = String.Format("{0:dd-mm-yyyy}",data4);
            Console.WriteLine(formatada2);

            var formatada3 = String.Format("{0:dd-mm-yyyy hh-mm-ss}",data4);
            Console.WriteLine(formatada3);

            var formatada4 = String.Format("{0:dd-mm-yyyy hh-mm-ss ff zz} ",data4);
            Console.WriteLine(formatada4);
        }
    }
}