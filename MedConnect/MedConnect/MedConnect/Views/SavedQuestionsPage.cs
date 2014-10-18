using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms; 
using MedConnect.Models;
using MedConnect.ViewModels; 

namespace MedConnect.Views
{
    public class SavedQuestionsPage : ViewPage
    {
        private ObservableCollection<Question> _savedQuestions { get; set; }

        public SavedQuestionsPage(User user, MainViewModel mvm) : base(user, mvm)
        {
            Title = "Saved Questions";

            var list = new ListView();
            var menuButton = getMenu();

            var titleLabel = new Label
            {
                Text = "My Saved Questions"
            };

            var submitQuestionButton = new Button
            {
                Text = "Add Question"
            };

            this.Content = new StackLayout
            {
                Children = { menuButton, titleLabel, list, submitQuestionButton }
            };

            list.ItemsSource = user.Questions;

            var cell = new DataTemplate(typeof(TextCell));
            cell.SetBinding(TextCell.TextProperty, "Text");

            list.ItemTemplate = cell;

            list.ItemTapped += (sender, args) =>
            {
                var question = args.Item as Question;
                //try catch here? some unhandled exception here...
                if (question == null) return;
                var modalPage = new EditQuestionPage(question, _user, _mainViewModel);
                Navigation.PushModalAsync(modalPage);
                list.SelectedItem = null;
            };

            submitQuestionButton.Clicked += (sender, args) =>
            {
                var modalPage = new SubmitQuestionPage(_user, _mainViewModel);
                Navigation.PushModalAsync(modalPage);
                System.Diagnostics.Debug.WriteLine("The modal page is now on screen");       
            };
           
        }
    }
}
