using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace CookBook.Services.Convertors
{
    public class ImageConvertor : IValueConverter
    {


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            BitmapImage bitmapImage = new();
            bitmapImage.BeginInit();
            if (value != null)
                bitmapImage.UriSource = new Uri(value.ToString());
            else
                bitmapImage.UriSource = new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQAksU7SgymVsQeNobvXuFccjnQ-4-SrqtnAQ&usqp=CAU");

            bitmapImage.EndInit();

            return bitmapImage;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return new BitmapImage();    
        }
    }
}
