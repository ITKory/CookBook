using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace CookBook.Services.Convertors
{
    internal class HtmlTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return Regex.Replace(value.ToString(), @"<[^>]*>", String.Empty);

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
