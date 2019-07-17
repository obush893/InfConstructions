﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace InfConstractions.Converters
{
    public class ViewTypeToBoolConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType == typeof(bool) && value is ViewType && parameter is ViewType)
                return (ViewType)value == (ViewType)parameter;
            return false;
        }
        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
                if (targetType == typeof(ViewType))
                {
                    return (bool)value ? ViewType.Gallery : ViewType.Map;
                }
            return null;
        }
    }
}
