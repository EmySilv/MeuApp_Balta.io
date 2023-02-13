using System;

namespace MeuApp
{
    public static class ValueTypes
    {
        public static void Show()
        {
            /*AULA DE VALUE TYPES E REFERENCE TYPES*/
            int x = 25;
            int y = x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            x = 32;
            Console.WriteLine(x);
            Console.WriteLine(y);

            var arr = new String[2];
            arr[0] = "Item 1";

            var arr2 = arr;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            arr[0] = "Item 2";
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);


            Console.ReadKey();
            Menu.Show();
        }
    }
}