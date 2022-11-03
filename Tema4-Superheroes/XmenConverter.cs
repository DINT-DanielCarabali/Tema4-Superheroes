using System;
using System.Globalization;
using System.Windows.Data;

namespace Tema4_Superheroes
{
    public class XmenConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                if ((bool)value)
                    return new Uri("./assets/xmen.png", UriKind.Relative);
                else
                    return value;
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}