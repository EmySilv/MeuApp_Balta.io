using System;
using System.Globalization;

namespace MeuApp
{
    public static class MyMath
    {
        public static void Show()
        {
            Console.Clear();
            
             
            decimal valor = 10536.25m;  

            Console.WriteLine(Math.Floor(valor));//arredonda pra baixo
            Console.WriteLine(Math.Ceiling(valor));//arredonda pra cima
            Console.WriteLine(Math.Round(valor, 2));//arredonda
            
            Console.ReadKey();
            Menu.Show();
        }
    }
}