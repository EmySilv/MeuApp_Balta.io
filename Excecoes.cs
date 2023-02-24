using System;

namespace MeuApp
{
    public static class Excecoes
    {
        public static void Show()
        {
            Console.Clear();
            //tudo que for exceção tem o exception

           var arr = new int[3];
           for (var index = 0; index < 10; index ++){
            Console.WriteLine(index);
           }

            Console.ReadKey();
            Menu.Show();
        }
    }
}