using System;

namespace MeuApp
{
    public static class Timespan
    {
        public static void Show()
        {
            Console.Clear();

            var timeSpan = new TimeSpan(); //timespan é unidade de medida
            Console.WriteLine(timeSpan);
            
            var timeSpanNanoSegundo = new TimeSpan(1); 
            Console.WriteLine(timeSpanNanoSegundo);
            
            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8); //definidno a hora com os três parametros
            Console.WriteLine(timeSpanHoraMinutoSegundo);
            
            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10); 
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);
            
            var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100); // o nome já diz
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            //usados principalmente em calculos de data
            
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo - timeSpanHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);//faz alguma coisa com dia
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(5, 6, 20)));
            
            Console.ReadKey();
            Menu.Show();
        }
    }
}