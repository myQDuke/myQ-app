using System;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedConnect.Models; 
using Xamarin.Forms; 

namespace MedConnect.NewViews
{
    public class LibraryPage : ContentPage
    {
        MasterPage _masterPage; 

        public LibraryPage(MasterPage masterPage)
        {
            _masterPage = masterPage; 
            BackgroundColor = Color.FromHex("#C1C1C1");
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
            listView.ItemTapped += (sender, args) =>
            {
                var modalPage = new EditQuestionPage();
                Navigation.PushModalAsync(modalPage);
                listView.SelectedItem = null;
            };
            var header = new HeaderElement("My Library");

            var addQuestionButton = new Button
            {
                Text = "Add Question"
            };

            addQuestionButton.Clicked += (sender, args) =>
            {
                var modalPage = new AddQuestionPage(_masterPage.getMainViewModel());
                Navigation.PushModalAsync(modalPage);
                listView.SelectedItem = null;
            };

            Content = new StackLayout
            {
                Padding = new Thickness(20, 20, 20, 20),
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { header, listView, addQuestionButton }
            };
        }
    }
}
