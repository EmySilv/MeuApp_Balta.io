using System;

namespace MeuApp
{
    public static class Finally
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
            catch (ArgumentNullException ex)//especifico
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Falha ao cadastrar");
            }
            catch (MinhaException ex)//especifico
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("Excessão customizada");
            }
            catch (Exception ex)//generico
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Não foi dessa vez");
            }
            finally
            {
                //verificar se o arquivo tá aberto ou fechado
                //exception para a aplicação se tiver algum erro
                //aqui colocaria uma instrução para fechar o programa seja dando certo ou errado a execução dele
                Console.WriteLine("Chegou ao fim");
            }

            Console.ReadKey();
            Menu.Show();
        }

        private static void Cadastrar(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                //throw new Exception("O texto não pode ser nulo ou vazio");
                //throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
                throw new MinhaException(DateTime.Now);
            }
        }

        //exception própria 
        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu { get; set; }
        }
    }
}