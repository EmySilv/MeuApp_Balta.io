using System;

namespace MeuApp
{
    public static class AdicionadoValores
    {
        public static void Show()
        {

            Console.Clear();

            var data = DateTime.Now;


            Console.WriteLine("Incrementando 12 dias");
            Console.WriteLine(data.AddDays(12));

            Console.WriteLine("Incrementando 1 mês");
            Console.WriteLine(data.AddMonths(1));

            Console.WriteLine("Incrementando 2 anos");
            Console.WriteLine(data.AddYears(2));


            Console.ReadKey();
            Menu.Show();
        }
    }
}