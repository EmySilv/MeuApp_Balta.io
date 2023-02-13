using System.Globalization;

namespace MeuApp
{
    public static class CultureInfro
    {
        public static void Show()
        {
            Console.Clear();


            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("D", pt));
            Console.WriteLine(DateTime.Now.ToString("D", br));
            Console.WriteLine(DateTime.Now.ToString("D", en));
            Console.WriteLine(DateTime.Now.ToString("D", de));
            Console.WriteLine(DateTime.Now.ToString("D", atual));
            //formatando a porra da data e cultura
            //Console.WriteLine(String.Format("{0:D}", DateTime.Now));

            Console.ReadKey();
            Menu.Show();

        }
    }
}