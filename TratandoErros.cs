using System;

namespace MeuApp
{
    public static class TratandoErros
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
            }//fazer do mais especifico tipo de tratamento de erro, ao mais genérico
            catch (IndexOutOfRangeException ex)//especifico
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Não Encontrei o índice na lista");
            }
            catch (Exception ex)//generico
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