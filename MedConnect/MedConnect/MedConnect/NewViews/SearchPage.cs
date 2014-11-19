using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedConnect.Models;
using Xamarin.Forms;

namespace MedConnect.NewViews
{
    public class SearchPage : ContentPage
    {
        MasterPage _masterPage; 

        public SearchPage(MasterPage masterPage)
        {
            _masterPage = masterPage; 

            BackgroundColor = Color.FromHex("#C1C1C1");
            var header = new HeaderElement("Search");
            
            SearchBar searchBar = new SearchBar
            {
                Placeholder = "Search for questions",
            };
            searchBar.SearchButtonPressed += (sender, args) =>
            {
                string searchQuery = searchBar.Text;
                System.Diagnostics.Debug.WriteLine(searchQuery);
            };
            

            var listView = new ListView();
            listView.HasUnevenRows = true;
            listView.ItemTemplate = new DataTemplate(typeof(QuestionCell));

            Content = new StackLayout
            {
                Padding = new Thickness(20, 20, 20, 20),
                Children = { header, new TabsHeader(_masterPage), searchBar, 
                    new ScrollView
                    {
                        Content = listView,
                    }
                }
            };
        }
    }
}
