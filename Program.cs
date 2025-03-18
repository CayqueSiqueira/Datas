using System;
using System.Runtime.CompilerServices;

namespace Datas
{
    class Datas
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Datas
             var data = new DateTime();// a data é uma estrutura que tem um valor padrão
             Console.WriteLine(data);

             var data2 = DateTime.Now;//Pegar a data atual
             Console.WriteLine(data2);
             Console.WriteLine();

            //Obtendo valores da data
            var data3 = new DateTime(2025, 11, 15, 8, 10, 01);//datetime com ano mes dia hora minuto e segundo definidos
            Console.WriteLine(data3);
            Console.WriteLine(data3.Year +"/"+ data3.Month+"/"+data3.Day+" "+data3.Hour+":"+data3.Minute+":"+data3.Second);
            Console.WriteLine(data3.DayOfWeek);
            Console.WriteLine((int)data3.DayOfWeek);
            Console.WriteLine(data3.DayOfYear);
            Console.WriteLine(data3.Second);
            Console.WriteLine();

            //Formatando dados
            var data4 = DateTime.Now;
            // M - mes \ m - minuto \ d - dia \ y - ano \ h - hora \ s - segundo \ f - fração de segundo \ Y - dia do ano
            var formatada = String.Format("{0:yyyy-mm-dd}",data4);
            Console.WriteLine(formatada);
            var formatada2 = String.Format("{0:dd-mm-yyyy}",data4);
            Console.WriteLine(formatada2);

            var formatada3 = String.Format("{0:dd-mm-yyyy hh-mm-ss}",data4);
            Console.WriteLine(formatada3);

            var formatada4 = String.Format("{0:dd-mm-yyyy hh-mm-ss ff zz} ",data4);//zz time zone
            Console.WriteLine(formatada4);
        }
    }
}