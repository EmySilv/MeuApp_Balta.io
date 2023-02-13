using System;

namespace MeuApp
{
    public static class While
    {
        public static void Show()
        {

            /*AULA DE DO*/

            var valor = 0;
            // do
            // {
            //     Console.WriteLine("teste");
            //     valor++;
            // } while (valor < 5);
            while (true)
            {
                valor++;
                Console.WriteLine(valor);

                Console.ReadKey();
                Menu.Show();
            }

        }
    }
}