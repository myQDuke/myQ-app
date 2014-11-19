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

            ObservableCollection<Question> Questions = new ObservableCollection<Question>();
            Question q1 = new Question
            {
              Text = "This is a sample question",
              Text2 = "More text",
              Text3 = "I love Xamarin"
            };
            Question q2 = new Question
            {
                Text = "This is a sample question",
                Text2 = "More text",
                Text3 = "I love Xamarin"
            };
            Question q3 = new Question
            {
                Text = "Another sample question",
                Text2 = "More text yay",
                Text3 = "So beautiful"
            };
            Questions.Add(q1);
            Questions.Add(q2);
            Questions.Add(q3);

            var listView = new ListView();
            listView.HasUnevenRows = true;
            listView.ItemsSource = Questions;
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
