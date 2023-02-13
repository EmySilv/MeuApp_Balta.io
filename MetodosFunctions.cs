using System;

namespace MeuApp
{
    public static class MetodosFunctions
    {
        public static void Show()
        {
            Console.Clear();
            MetodosFunctions.MeuMetodo("C#");

            string nome = ReturnName("Emilly", "Vitória");
            Console.WriteLine(nome);

            Console.ReadKey();
            Menu.Show();
        }
        public static string ReturnName(string name,
            string middleName, //parametro obrigatorio
            int age = 18 //parametro opcional, sempre por ultimo.
         )
        {
            return name + " " + middleName + " tem " + age.ToString();
        }

        public static void MeuMetodo(string parametro)
        {
            Console.WriteLine(parametro);
        }
        // static void MeuMetodo()
        // {
        //     Console.WriteLine("C#");
        // }

    }
}



