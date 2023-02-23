using System;

namespace MeuApp
{
    public static class ForEacha
    {
        public static void Show()
        {
            Console.Clear();

            // var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            // meuArray[0] = 12;

            var funcionarios = new Funcionario[5];

            funcionarios[0] = new Funcionario() { Id = 2579, Nome = "André" };

            //muito mais facil e clean que o item
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
            }

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