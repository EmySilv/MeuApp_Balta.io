using System;

namespace MeuApp
{
    public static class StartEnd
    {
        public static void Show()
        {
            Console.Clear();
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.StartsWith("texto"));
            Console.WriteLine(texto.StartsWith("este"));
            Console.WriteLine(texto.StartsWith("Este")); //StartsWith = começa com, retornando true or false

            Console.WriteLine(texto.EndsWith("Este"));
            Console.WriteLine(texto.EndsWith("texto"));
            Console.WriteLine(texto.EndsWith("este")); //EndsWith = termina com, tb retorna true or false

            Console.ReadKey();
            Menu.Show();
        }
    }
}