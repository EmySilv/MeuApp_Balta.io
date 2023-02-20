using System;

namespace MeuApp
{
    public static class TypeForCoin
    {
        public static void Show()
        {
            Console.Clear();
            
            //trabalhando com moeda, é recomendado usar decimal
            decimal valor = 10.25m;
            Console.WriteLine(valor);

            Console.ReadKey();
            Menu.Show();
        }
    }
}