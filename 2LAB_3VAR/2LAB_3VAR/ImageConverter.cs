using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media.Imaging;

namespace _2LAB_3VAR
{
    class ImageConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch(value as String)
            {
                case "Воин":
                    {
                        return Sven.UriSource = new Uri("sven.jpg", UriKind.RelativeOrAbsolute);
                    }
                case "Маг":
                    {
                        return Sven.UriSource = new Uri("wizard.jpg", UriKind.RelativeOrAbsolute);
                    }
                case "Разбойник":
                    {
                        return Sven.UriSource = new Uri("thief.jpeg", UriKind.RelativeOrAbsolute);
                    }
                case "Жрец":
                    {
                        return Sven.UriSource = new Uri("priest.jpg", UriKind.RelativeOrAbsolute);
                    }
                case "Палладин":
                    {
                        return Sven.UriSource = new Uri("palladin.jpg", UriKind.RelativeOrAbsolute);
                    }
                case "Лучник":
                    {
                        return Sven.UriSource = new Uri("archer.jpg", UriKind.RelativeOrAbsolute);
                    }
                default:
                    {
                        return Sven.UriSource = new Uri("All.jpg", UriKind.RelativeOrAbsolute);
                    }
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        BitmapImage Sven = new BitmapImage();
        
   
       
    }
}
