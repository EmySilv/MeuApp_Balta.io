using System;

namespace MeuApp
{
    public static class ComparandoDatas
    {
        public static void Show()
        {

            Console.Clear();

            //DateTime? data = null;//DateTime.Now;

            var data = DateTime.Now;

            //num funfa, pq n são exataente iguais, agr funfa com o Date
            if (data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual");
            }

            Console.WriteLine(data);

            Console.ReadKey();
            Menu.Show();

        }
    }
}