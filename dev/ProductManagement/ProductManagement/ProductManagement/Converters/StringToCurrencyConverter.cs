using System;
using System.Globalization;
using System.Windows.Data;

namespace ProductManagement.Converters
{
    public class StringToCurrencyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            culture = new CultureInfo("en-US");
            if (value != null)
            {
                double number = double.Parse(value.ToString());
                return number.ToString("C",culture);
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
