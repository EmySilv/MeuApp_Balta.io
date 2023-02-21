using System;
using System.Globalization;

namespace MeuApp
{
    public static class MyArrays
    {
        public static void Show()
        {
            Console.Clear();

            var meuArray = new Teste[2];
            meuArray[0] = new Teste();

            Console.WriteLine(meuArray[0].Id);
            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
            Console.WriteLine(meuArray[3]);
            Console.WriteLine(meuArray[4]);

            Console.ReadKey();
            Menu.Show();
        }

        struct Teste{
            public int Id{ get; set; }
        }
    }
}