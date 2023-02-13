using System;

namespace MeuApp
{
    public static class MetodosAdicionais
    {
        public static void Show()
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.ToLower());//converte tudo em minusculo
            Console.WriteLine(texto.ToUpper());// convete todo em maiuscolo
            Console.WriteLine(texto.Insert(5, "AQUI "));//adiciona caracter, precisando colocar a posi
            Console.WriteLine(texto.Remove(5, 5));//adiciona caractere na posição que vc indicar, (por onde começa, até onde vai)
            Console.WriteLine(texto.Length);//conta os caracteres de uma string especifica          

            Console.ReadKey();
            Menu.Show();
        }
    }
}