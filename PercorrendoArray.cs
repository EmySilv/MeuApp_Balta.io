using System;
using System.Globalization;

namespace MeuApp
{
    public static class PercorrendoArray
    {
        public static void Show()
        {
            Console.Clear();

            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            meuArray[0] = 12;

            Console.WriteLine(meuArray.Length);
            //

            //percorrendo o array todo
            for (var index = 0; index < meuArray.Length; index++)
            {
                Console.WriteLine(meuArray[index]);

            }

            //meuArray.Length
            //nmr total de elementos do array
            // Console.WriteLine(meuArray[0]);
            // Console.WriteLine(meuArray[1]);
            // Console.WriteLine(meuArray[2]);
            // Console.WriteLine(meuArray[3]);
            // Console.WriteLine(meuArray[4]);

            Console.ReadKey();
            Menu.Show();
        }
    }
}