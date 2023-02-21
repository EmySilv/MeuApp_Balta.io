using System;

namespace MeuApp
{
    public static class MyDateTime
    {
        public static void Show()
        {
            Console.Clear();

            Console.WriteLine(DateTime.DaysInMonth(2020, 2));//ver quantos dias tem no mês, dado o ano e o mês, não é array, é enumerador
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());//horario de verão, traz true or false tb

            Console.ReadKey();
            Menu.Show();

        }
        static bool IsWeekend(DayOfWeek today)
        {//função parecida com if else, para saber o dia da semana tb

            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }


    }
}