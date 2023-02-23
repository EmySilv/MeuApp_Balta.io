using System;

namespace MeuApp
{
    public static class AlterandoValue
    {
        public static void Show()
        {
            Console.Clear();

            // var meuprimeiro = new int[5] { 1, 2, 3, 4, 5 };
            // meuArray[0] = 12;

            var primeiro = new int[4];
            var segundo = new int [4];
            
            primeiro[0] = primeiro[0];

            primeiro[0] = 23;
            Console.WriteLine(segundo[0]);

            Console.ReadKey();
            Menu.Show();
        }

        public struct Funcionario
        {
            public int Id
            {
                get; set;
            }
             public String Nome
            {
                get; set;
            }
        }
    }
}