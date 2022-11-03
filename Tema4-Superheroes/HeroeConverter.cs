using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Tema4_Superheroes
{
    public class HeroeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                if ((bool)value)
                    return Brushes.PaleGreen;
                else
                    return Brushes.IndianRed;
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}