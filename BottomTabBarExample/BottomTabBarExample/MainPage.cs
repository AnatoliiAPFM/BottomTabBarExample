using BottomBar.XamarinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BottomTabBarExample
{
    public class MainPage : BottomBarPage
    {
        public MainPage()
        {
            Children.Add(new ContentPage()
            {
                Content =
                    new Label
                    {
                        Text = "Favorites Content",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                Icon = "ic_favorites",
                Title = "Favorites"
            });

            Children.Add(new ContentPage()
            {
                Content =
                    new Label
                    {
                        Text = "Friends Content",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                Icon = "ic_friends",
                Title = "Friends"
            });

            Children.Add(new ContentPage()
            {
                Content =
                    new Label
                    {
                        Text = "Nearby Content",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                Icon = "ic_nearby",
                Title = "Nearby"
            });
            NavigationPage.SetHasNavigationBar(this, true);
            ToolbarItems.Add(new ToolbarItem()
            {
                Text = "TopCmd"
            });
        }
    }
}
