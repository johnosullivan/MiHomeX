using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Globalization;

namespace MiHome
{
    public class BooleanInverter : IValueConverter
    {
        #region IValueConverter implementation
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }
        #endregion

    }
    public class MenuListData : List<MenuItem>
    {
        public MenuListData(string str)
        {
            if (str == "coach")
            {
                Add(new MenuItem() { Title = "Dashboard", Des = "Home", TargetType = typeof(Dashboard) });

            }
            else if (str == "athlete")
            {
            }
        }
    }
}