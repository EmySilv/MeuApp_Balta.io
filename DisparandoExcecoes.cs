using System;

namespace MeuApp
{
    public static class DisparandoExcecoes
    {
        public static void Show()
        {
            Console.Clear();

            try
            {
                // for (var index = 0; index < 10; index++)
                // {
                //     Console.WriteLine(index);
                // }

                Cadastrar("");
            }//fazer do mais especifico tipo de tratamento de erro, ao mais genérico
            catch (IndexOutOfRangeException ex)//especifico
            //{
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Não Encontrei o índice na lista");
            }
            catch (ArgumentNullException ex)//especifico
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Falha ao cadastrar");
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

        private static void Cadastrar(string text){
            if (string.IsNullOrEmpty(text))
            {
                //throw new Exception("O texto não pode ser nulo ou vazio");
                throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
            }
        }
    }
}