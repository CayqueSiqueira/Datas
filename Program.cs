using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace Datas
{
    class Datas
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Datas
            Console.WriteLine("____Datas____");
             var data = new DateTime();// a data é uma estrutura que tem um valor padrão
             Console.WriteLine(data);

             data = DateTime.Now;//Pegar a data atual
             Console.WriteLine(data);
             Console.WriteLine();

            //Obtendo valores da data
            Console.WriteLine("____Obtendo valores da data____");
            data = new DateTime(2025, 11, 15, 8, 10, 01);//datetime com ano mes dia hora minuto e segundo definidos
            Console.WriteLine(data);
            Console.WriteLine(data.Year +"/"+ data.Month+"/"+data.Day+" "+data.Hour+":"+data.Minute+":"+data.Second);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine((int)data.DayOfWeek);
            Console.WriteLine(data.DayOfYear);
            Console.WriteLine(data.Second);
            Console.WriteLine();

            //Formatando dados
            Console.WriteLine("____Formatando dados____");
            data = DateTime.Now;
            // M - mes \ m - minuto \ d - dia \ y - ano \ h - hora \ s - segundo \ f - fração de segundo \ Y - dia do ano
            var formatada = String.Format("{0:yyyy-mm-dd}",data);
            Console.WriteLine(formatada);
            var formatada2 = String.Format("{0:dd-mm-yyyy}",data);
            Console.WriteLine(formatada2);

            var formatada3 = String.Format("{0:dd-mm-yyyy hh-mm-ss}",data);
            Console.WriteLine(formatada3);

            var formatada4 = String.Format("{0:dd-mm-yyyy hh-mm-ss ff zz} ",data);//zz time zone
            Console.WriteLine(formatada4);
            Console.WriteLine();

            //padroes de formatação
            data = DateTime.Now;
            Console.WriteLine("____Padrões de formatação____");
            Console.WriteLine(String.Format("{0:d}", data));//data numerica
            Console.WriteLine(String.Format("{0:D}", data));//data por extenso
            Console.WriteLine(String.Format("{0:f}", data));//data por extenso com hora
            Console.WriteLine(String.Format("{0:F}", data));//data por extenso com hora e segundos
            Console.WriteLine(String.Format("{0:g}", data));//data numerica com hora
            Console.WriteLine(String.Format("{0:G}", data));//data numerica com hora e segundos
            Console.WriteLine(String.Format("{0:m}", data));//mes e dia
            Console.WriteLine(String.Format("{0:r}", data));//data e hora em formato de rfc1123
            Console.WriteLine(String.Format("{0:s}", data));//data e hora em formato de iso8601
            Console.WriteLine(String.Format("{0:u}", data));//data e hora em formato universal
            Console.WriteLine(String.Format("{0:U}", data));//data e hora em formato universal completo
            Console.WriteLine(String.Format("{0:Y}", data));//mes e ano
            Console.WriteLine();


            //Adicionando valores
            Console.WriteLine("____Adicionando valores____");
            // var dia = data.Day + 1; evitar fazer isso
            Console.WriteLine(data);            
            data = data.AddDays(12);
            Console.WriteLine(data);            
            data = data.AddMonths(13);
            Console.WriteLine(data);  
            data = data.AddYears(2);
            Console.WriteLine(data);  
            Console.WriteLine();

            //Comparação de datas
            Console.WriteLine("____Comparação de datas____");
            
            data = DateTime.Now;
            DateTime? data1 = null;
            Console.WriteLine(data1);
            Console.WriteLine(data1.HasValue);
            Console.WriteLine(data1.GetValueOrDefault());

            if (data == DateTime.Now)
            {
                Console.WriteLine("As datas são iguais");
            }
            else
            {
                Console.WriteLine("As datas são diferentes");
            }

            if (data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("As datas são iguais");
            }
            else
            {
                Console.WriteLine("As datas são diferentes");
            }

            if (data < DateTime.Now)
            {
                Console.WriteLine(data + " < " + DateTime.Now);//o DateTime.Now pega frações de segundos
            }

        }
    }
}