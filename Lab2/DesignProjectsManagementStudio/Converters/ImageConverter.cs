using System;
using System.Globalization;
using System.Windows.Data;
using Domain.Enums;

namespace DesignProjectsManagementStudio.Converters
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var type = (ProjectType)value;
            var path = $"C:\\Проекти\\Sharaga 3.1\\КПЗ\\Lab2\\DesignProjectsManagementStudio\\Images\\Projects\\{(int)type}.png";
            return path;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("Method not allowed!");
        }
    }
}
