using System;

namespace MeuApp
{
    public static class FormatDatas
    {
        public static void Show()
        {
            Console.Clear();
            var data = DateTime.Now;

            // Y = ano, M = mês, D = dia
            var format = String.Format("{0}", data);
            Console.WriteLine(format);

            Console.ReadKey();
            Menu.Show();
        }
    }
}
