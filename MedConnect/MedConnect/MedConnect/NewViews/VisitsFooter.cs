using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms; 

namespace MedConnect.NewViews
{
    public class VisitsFooter : StackLayout
    {
        public VisitsFooter()
        {
            var deleteLabel = new Label
            {
                Text = "Delete",
                TextColor = Color.FromHex("#FFFFFF"),
                BackgroundColor = Color.FromHex("#C65B5B")
            };

            var deleteTab = new StackLayout
            {
                Padding = new Thickness(10, 10, 10, 10),
                BackgroundColor = Color.FromHex("#C65B5B"),
                Children = { deleteLabel }
            };

            var deleteTapRecognizer = new TapGestureRecognizer();
            deleteTapRecognizer.Tapped += (s, e) =>
            {

            };
            deleteTab.GestureRecognizers.Add(deleteTapRecognizer);

            var renameLabel = new Label
            {
                Text = "Rename",
                TextColor = Color.FromHex("#FFFFFF"),
                BackgroundColor = Color.FromHex("#006166"),
            };

            var renameTab = new StackLayout
            {
                Padding = new Thickness(10, 10, 10, 10),
                BackgroundColor = Color.FromHex("#006166"),
                Children = { renameLabel }
            };

            var renameTapRecognizer = new TapGestureRecognizer();
            renameTapRecognizer.Tapped += (s, e) =>
            {

            };
            renameTab.GestureRecognizers.Add(renameTapRecognizer);

            Orientation = StackOrientation.Horizontal;
            HorizontalOptions = LayoutOptions.StartAndExpand;
            Children.Add(renameTab);
            Children.Add(deleteTab);
        }
    }
}
