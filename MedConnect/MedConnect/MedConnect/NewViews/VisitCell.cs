using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MedConnect.Models; 

namespace MedConnect.NewViews
{
    public  class VisitCell : ViewCell
    {
        public VisitCell()
        {
            var textLabel = new Label
            {
                TextColor = Color.FromHex("#636363"),
                Font = Font.SystemFontOfSize(20, FontAttributes.Bold)
            };
            textLabel.SetBinding(Label.TextProperty, "name");

            var textLayout = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Start,
                BackgroundColor = Color.FromHex("#FFFFFF"),
                WidthRequest = 320,
                Children = { textLabel }
            };

            var viewLayout = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                BackgroundColor = Color.FromHex("#FFFFFF"),
                Padding = new Thickness(20, 20, 20, 20),
                Children = { textLayout }
            };

            var mainLayout = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Start,
                Padding = new Thickness(0, 0, 0, 10),
                BackgroundColor = Color.FromHex("#C1C1C1"),
                Children = { viewLayout }
            };
            View = mainLayout; 
        }
    }
}
