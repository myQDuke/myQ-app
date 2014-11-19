using MedConnect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms; 

namespace MedConnect.NewViews
{
    public class EditQuestionPage : ContentPage 
    {
        MasterPage _masterPage;
        int _questionID;

        public EditQuestionPage(MasterPage masterPage, int questionID)
        {
            _masterPage = masterPage;
            _questionID = questionID;

            var rateQuestionLabel = new Label
            {
                Text = "Was this question helpful?",
                Font = Font.SystemFontOfSize(NamedSize.Medium)
            };

            var helpfulButton = new Button
            {
                Text = "Yes",
                Font = Font.SystemFontOfSize(NamedSize.Medium),
            };

            var notHelpfulButton = new Button
            {
                Text = "No",
                Font = Font.SystemFontOfSize(NamedSize.Medium),
            };

            var yesNoLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = { helpfulButton, notHelpfulButton }
            };

            var removeQuestionButton = new Button
            {
                Text = "Remove question"
            };

            var cancelButton = new Button
            {
                Text = "Cancel"
            };
			_masterPage.MainView.getVisits();
            this.BindingContext = _masterPage.MainView._visitsViewModel;

            var listView = new ListView();
            listView.HasUnevenRows = true;
            listView.SetBinding(ListView.ItemsSourceProperty, new Binding("Visits"));
            //listView.ItemsSource = Questions;
            listView.ItemTemplate = new DataTemplate(typeof(VisitCell));

            listView.ItemTapped += async (sender, args) =>
            {
                var visit = args.Item as Visit;
                if (visit == null) return;

                //var answer = await DisplayAlert("Add question to visit", "Are you sure you want to proceed?", "Yes", "No");
                HandleAddVisitQuestion(visit.id);
                listView.SelectedItem = null;
            };

            removeQuestionButton.Clicked += (sender, args) =>
            {
                System.Diagnostics.Debug.WriteLine("Question removed");
                _masterPage.MainView.removeLibraryQuestion(_questionID);
                Navigation.PopModalAsync();
            };

            cancelButton.Clicked += (sender, args) =>
            {
                //_masterPage.Master = _masterPage.getMasterContentPage();
                //_masterPage.Detail = new LibraryPage(_masterPage);
                Navigation.PopModalAsync();
            };

            helpfulButton.Clicked += (sender, args) =>
            {
                System.Diagnostics.Debug.WriteLine("User voted question helpful");
                _masterPage.MainView.rateQuestion(_questionID,"Helpful");
                Navigation.PopModalAsync();
            };

            notHelpfulButton.Clicked += (sender, args) =>
            {
                _masterPage.MainView.rateQuestion(_questionID, "Unhelpful");
                Navigation.PopModalAsync();
                System.Diagnostics.Debug.WriteLine("User voted question unhelpful");
            };

            var mainLayout = new StackLayout
            {
                Padding = new Thickness(50, 50, 50, 50),
                BackgroundColor = Color.FromRgba(1, 1, 1, 0.5),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children = { rateQuestionLabel, yesNoLayout, removeQuestionButton, listView, cancelButton }
            };

            Content = mainLayout;

           /*
            var tapRecognizer = new TapGestureRecognizer();
            tapRecognizer.Tapped += (s, e) =>
            {
                Navigation.PopModalAsync();
            };
            mainLayout.GestureRecognizers.Add(tapRecognizer);
            */
        }

        public async void HandleAddVisitQuestion(int visitID)
        {
            //use _questionID;
            
			int userID = _masterPage.MainView.User.id;
			System.Diagnostics.Debug.WriteLine(userID + " qid: " + _questionID + " visitID: " + visitID);
			_masterPage.MainView.postVisitQuestion (userID, _questionID, visitID);
			await DisplayAlert("Question Added", "Question added to your visit!", "OK");
        }

    }
}
