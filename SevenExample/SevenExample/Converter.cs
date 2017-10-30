using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenExample
{
    public class Converter : IMultiValueConverter
    {
        public DateTime ConvertedDate
        { get; set; }

        public int Day
        { get; set; }

        public int Month
        { get; set; }

        public int Year
        { get; set; }

        public void _Convert(string day, string month, string year)
        {
            int _day = 6, _month = 6, _year = 2001;
            if (!string.IsNullOrEmpty(day) && !string.IsNullOrEmpty(month) && !string.IsNullOrEmpty(year))
            {

                Day = Convert.ToInt32(day);
                Month = Convert.ToInt32(month);
                Year = Convert.ToInt32(year);
                if (Day > 31 || Day < 0)
                {
                    Day = _day;
                }
                else if(Month > 12 || Month < 0)
                {
                    Month = _month;
                }
                else if (Year > 3000 || Month <1700)
                {
                    Year = _year;
                }
                ConvertedDate = new DateTime(Year, Month, Day);
            }
            else
            {
                Day = _day;
                Month = _month;
                Year = _year;
                ConvertedDate = new DateTime(Year, Month, Day);
            }
        }

        public void _ConvertBack()
        {
            Day = ConvertedDate.Day;
            Month = ConvertedDate.Month;
            Year = ConvertedDate.Year;
        }
    }
}
