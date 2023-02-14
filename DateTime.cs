using System;

namespace MeuApp
{
    public static class DateTime
    {
        public static void Show()
        {
            Console.Clear();

            Console.WriteLin(DateTime.DaysInMonth(2020, 2));//ver quantos dias tem no mês, dado o ano e o mês, não é array, é enumerador
            Console.WriteLin(IsWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLin(DateTime.Now.IsDaylinghtSavingTime());//horario de verão, traz true or false tb

            Console.ReadKey();

        }

        static boll IsWeekend(DayOfWeek today)
        {//função parecida com if else, para saber o dia da senaba tb

            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
            Console.ReadKey();
            Menu.Show();
        }


    }
}