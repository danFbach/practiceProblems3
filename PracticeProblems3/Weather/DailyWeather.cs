using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3
{
    public class DailyWeather
    {
        Enum day;
        Enum weather;
        public DailyWeather(Enum day, Enum weather)
        {
            this.day = day;
            this.weather = weather;
        }
        public override string ToString()
        {
            return (String.Format("Day of Week: {0} || Todays Weather: {1}", day, weather));
        }
    }
}
