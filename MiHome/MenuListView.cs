using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MiHome
{
    public class MenuListView : ListView
    {
        public MenuListView(string str)
        {
            List<MenuItem> data = new MenuListData(str);

            ItemsSource = data;
            VerticalOptions = LayoutOptions.FillAndExpand;
            BackgroundColor = Color.Transparent;
            SeparatorVisibility = SeparatorVisibility.None;


            var cell = new DataTemplate(typeof(MenuCell));
            cell.SetBinding(MenuCell.TextProperty, "Title");

            //cell.SetBinding (MenuCell.DetailProperty, "Des");
            cell.SetBinding(MenuCell.ImageSourceProperty, "IconSource");



            ItemTemplate = cell;
        }
    }
}