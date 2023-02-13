using System;

namespace MeuApp
{
    public static class Equales
    {
        public static void Show()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Equals("Este"));
            Console.WriteLine(texto.Equals("este"));
            Console.WriteLine(texto.Equals("texto"));//Equals = é igual a, retorna true or false

            Console.ReadKey();
            Menu.Show();
        }
    }
}