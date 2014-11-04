using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms; 

namespace MedConnect.NewViews
{
    public class BrowsePage : ContentPage 
    {
        MasterPage _masterPage; 

        public BrowsePage(MasterPage masterPage)
        {
            _masterPage = masterPage;
            var header = new HeaderElement("Browse");
            var tabs = new TabsHeader(_masterPage);

            var mostPopularEntry = new LandingCell("Most Popular", "Find new questions", "icon_heart.png", "#9ee4e7");
            var mostHelpfulEntry = new LandingCell("Most Helpful", "Save questions to your library", "icon_brightness.png", "#9ee4e7");
            var recentlyAddedEntry = new LandingCell("Recently Added", "Organize your saved questions", "icon_upload.png", "#9ee4e7");

            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { header, tabs, mostPopularEntry, mostHelpfulEntry, recentlyAddedEntry },
                Spacing = 20,
                Padding = new Thickness(20, 20, 20, 20),
                BackgroundColor = Color.FromHex("#FFFFFF")
            };
        }
    }
}
