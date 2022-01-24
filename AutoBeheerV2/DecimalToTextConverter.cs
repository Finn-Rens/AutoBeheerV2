using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace AutoBeheerV2
{
    public class DecimalToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Van decimal naar string
            //return string.Format("#######.00", value);
            //return value.ToString();

            return ((decimal)value).ToString("#.00");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //string naar decimal
            if (decimal.TryParse(value.ToString(), out decimal resultValue))
            {
                return resultValue;
            }

            return null;
        }
    }
}
