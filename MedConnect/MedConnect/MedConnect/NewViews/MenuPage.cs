using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms; 

namespace MedConnect.NewViews
{

    public class MenuPage : ContentPage
    {
        MasterDetailPage _master;

        public MenuPage(MasterDetailPage master)
        {
            _master = master;

            var label = new Label
            {
                Text = "Test"
            }; 

            Content = new StackLayout
            {
                BackgroundColor = Color.Gray,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { label }
            };
        }
    }
}
