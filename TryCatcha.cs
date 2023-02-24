using System;

namespace MeuApp
{
    public static class TryCathca
    {
        public static void Show()
        {
            Console.Clear();

            try
            {
                for (var index = 0; index < 10; index++)
                {
                    Console.WriteLine(index);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Não foi dessa vez");
            }

            Console.ReadKey();
            Menu.Show();
        }
    }
}