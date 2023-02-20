using System;
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

            Console.WriteLine(timeZoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc((System.DateTime)utcDate, timeZoneAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc((System.DateTime)utcDate, timezone));
                Console.WriteLine("------------------");
            }

            Console.ReadKey();
            Menu.Show();
        }
    }
}