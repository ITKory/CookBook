using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace CookBook.Services.Converters
{
    internal class HtmlTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value == null)
                return "";
            return Regex.Replace(value as string, @"<[^>]*>", String.Empty);

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "";
        }
    }
}
