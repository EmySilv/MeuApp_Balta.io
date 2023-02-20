using System.Globalization;

namespace MeuApp
{
    public static class FormatCoins
    {
        public static void Show()
        {
            Console.Clear();
            
             
            decimal valor = 10536.25m;

            //passando uma cultura especifica
            var culture = CultureInfo.CreateSpecificCulture("pt-BR");
            
            Console.WriteLine(valor.ToString("E04",  culture));
            //essas letrinhas é um conversor de moeda, coloca o simbolo dos ngc e pá
            //"G", formatador numerico, sempre tipo como um numero
            //"C", formatador de moeda, currence
            //"E04", formatador para
            //"F", formatador numerico tb, precisão maior
            //"N", formatador tipo o currence, mas sem a formatção de moeda
            //"P",formatador de porcentagem

            Console.ReadKey();
            Menu.Show();
        }
    }
}