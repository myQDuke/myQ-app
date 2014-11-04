using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms; 

namespace MedConnect.NewViews
{
    public class LibraryCell : ViewCell
    {
        public LibraryCell()
        {
            var textLabel = new Label
            {
                TextColor = Color.FromHex("#636363"),
                Font = Font.SystemFontOfSize(20, FontAttributes.Bold)
            };
            textLabel.SetBinding(Label.TextProperty, "Text");

            var ratingLabel = new Label
            {
                TextColor = Color.FromHex("#636363"),
                Font = Font.SystemFontOfSize(NamedSize.Small)
            };
            //ratingLabel.SetBinding(Label.TextProperty, "Text2");

            var tagsLabel = new Label
            {
                TextColor = Color.FromHex("#636363"),
                Font = Font.SystemFontOfSize(NamedSize.Small)
            };
            //tagsLabel.SetBinding(Label.TextProperty, "Text3");

            var textLayout = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Start,
                BackgroundColor = Color.FromHex("#FFFFFF"),
                Children = { textLabel, ratingLabel, tagsLabel }
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
