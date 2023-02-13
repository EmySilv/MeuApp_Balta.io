using System.Globalization;

namespace MeuApp
{
    public static class Timezone
    {
        public static void Show()
        {
            Console.Clear();
            var utcDate = DateTime.UtcNow;

            Console.WriteLine(utcDate);
            Console.WriteLine(DateTime.Now);
            
            Console.WriteLine(utcDate.ToLocalTime());

            var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            //convertendo as datas para o horário da Austrália

            Console.WriteLine(timeZoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timeZoneAustralia);
            //pegando data utc e colocando timezone

            var timezones= TimeZoneInfo.GetSystemTimeZones();
            foreach(var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("------------------");

            }
            
            Console.ReadKey();
            Menu.Show();

        }
    }
}