using System;

namespace MeuApp
{
    public static class Indices
    {
        public static void Show()
        {
            var texto = "Este texto é um teste";

            //IndexOf sempre vai pedir um objeto o mesmo tipo que vc tá comparando;
            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.IndexOf("um"));//pega a posição do objeto
            Console.WriteLine(texto.LastIndexOf("s"));// pega a posição da ultima letra que ele encontra

            Console.ReadKey();
            Menu.Show();
        }
    }
}