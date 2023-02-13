using System;

namespace MeuApp
{
    public static class Comparacao
    {
        public static void Show()
        {
            Console.Clear();
            Console.Write("Seja Bem-Vindo!!");
            
            var texto = "este texto é um teste";

            Console.WriteLine(texto.Contains("Teste"));//é pra saber se existe uma palavra dentro do texto; retorna true or false
            Console.WriteLine(texto.Contains("teste"));
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));//ignora o case sensitivy
            //Console.WriteLine(texto.Contains(null));//vai dar erro pq ele precisa de um objeto válido

            Console.WriteLine(texto.CompareTo("Testando"));//compara se strings totalmente iguais; retorna numeros 
            Console.WriteLine(texto.CompareTo("testando"));

            Console.ReadKey();
            Menu.Show();

        }
    }
}