using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3
{
    public class Weather
    {
        public Weather()
        {
            forecast();
        }
        enum days { Sun, Mon, Tue, Wed, Thr, Fri, Sat };
        enum weatherTypes { ThunderStorm, Rain, Cloudy, Sunny, Hot };
        List<DailyWeather> forecastWeek = new List<DailyWeather>();
        public void forecast()
        {
            forecastWeek.Add(new DailyWeather(days.Sun, weatherTypes.Rain));
            forecastWeek.Add(new DailyWeather(days.Mon, weatherTypes.Hot));
            forecastWeek.Add(new DailyWeather(days.Tue, weatherTypes.Sunny));
            forecastWeek.Add(new DailyWeather(days.Wed, weatherTypes.Sunny));
            forecastWeek.Add(new DailyWeather(days.Thr, weatherTypes.Cloudy));
            forecastWeek.Add(new DailyWeather(days.Fri, weatherTypes.Sunny));
            forecastWeek.Add(new DailyWeather(days.Sat, weatherTypes.ThunderStorm));
        }
        public void displayForecast()
        {
            foreach(DailyWeather day in forecastWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
//-    Problem 1: Create two enums to get the forecast for the next seven days. One enum will contain the days of the week. The second enum will contain the different types of forecasts. Make sure to print to the console the forecast of the next seven days.   