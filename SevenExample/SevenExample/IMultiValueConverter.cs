using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenExample
{
    public interface IMultiValueConverter
    {
        int Day { get; set; }
        int Month { get; set; }
        int Year { get; set; }
        DateTime ConvertedDate { get; set; }

        void _Convert(string day, string month, string year);
        void _ConvertBack();
    }
}
