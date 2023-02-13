using System;

namespace MeuApp
{
    public static class PadraodeFormatacao
    {
        public static void Show(){
            
            Console.Clear();

            var data = DateTime.Now;

            var format = String.Format("{0}", data);

            //t = Short Time, d = short date, T = Long time, D = long date, f = combina data e hora, g = combina data e hr em short
            //r = data com um padrão em especifico
            //s = padrão estranho
            //u = padrão universal
            //var format = String.Format("{0:t}"/*o dois pontos passa o formato que vc quer exibir a sua data*/, data);
            //var format = String.Format("{0:M}", data);
            Console.WriteLine(format);

            Console.ReadKey();
            Menu.Show();
        }
    }
}