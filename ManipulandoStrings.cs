using System;

namespace MeuApp
{
    public static class ManipulandoStrings
    {
        public static void Show()
        {
            var texto = " Este texto é um teste ";

            Console.WriteLine(texto.Replace("Este", "isto"));//troca os caracteres especificados
            Console.WriteLine(texto.Replace("e", "X"));//troca os caracteres especificados

            var divisao = texto.Split(" ");//divião do texto por espaço, resultando uma lista de string

            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);

            // var resultado = texto.Substring(5, 5);
            var resultado = texto.Substring(5, texto.LastIndexOf("o"));
            Console.WriteLine(resultado);

            Console.WriteLine(texto.Trim());//remove os espaços no inicio e no final do texto

            Console.ReadKey();
            Menu.Show();
        }

    }
}