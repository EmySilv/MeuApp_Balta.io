using System;

namespace MeuApp
{
    public static class Switch
    {
        public static void Show()
        {
            int valor = 1;
            switch (valor)
            {
                case 1: Console.WriteLine("1"); break;
                case 2: Console.WriteLine("2"); break;
                case 3: Console.WriteLine("3"); break;
                default: Console.WriteLine("4"); break;

            }
            
            Console.ReadKey();
            Menu.Show();
        }
    }
}