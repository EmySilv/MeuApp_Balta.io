using System.Globalization;

namespace MeuApp
{
    public static class ValueDatas
    {
        public static void Show()
        {
            Console.Clear();
            var data = new DateTime(2022, 03, 09);
            Console.WriteLine(data.DayOfYear);//explorar os métodos
            // Console.ForegroundColor = ConsoleColor.Red;
            // Console.WriteLine("EU TE AMO, MAGAGO <3");

            Console.ReadKey();
            Menu.Show();
        }
    }
}