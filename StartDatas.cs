using System;

namespace MeuApp
{
    public static class StartDatas
    {
        public static void Show()
        {
            // DateTime no .net é um struct, contendo vários métodos
            Console.Clear();
            //var data = new DateTime();//se não especifica nada ele trará uma data padrão
            var data = DateTime.Now;//pega a data atual
            Console.WriteLine(data);

            Console.ReadKey();
            Menu.Show();
        }
    }
}