using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MedConnect.ViewModels;
using MedConnect.Models; 

namespace MedConnect.Views 
{
    public class RecommendedQuestionsPage : ViewPage
    {
        public RecommendedQuestionsPage (User user, MainViewModel main) : base(user, main)
        {
            var menuButton = getMenu();
            var titleLabel = new Label
            {
                Text = "Recommended Questions"
            };

            Title = "Recommended Questions";

            var list = new ListView();

            this.Content = new StackLayout
            {
                Children = {titleLabel, menuButton, list }
            };

            var viewModel = new RecommendedQuestionsViewModel();
            list.ItemsSource = viewModel.getRecQuestions();

            var cell = new DataTemplate(typeof(TextCell));
            cell.SetBinding(TextCell.TextProperty, "Text");

            list.ItemTemplate = cell;

            this.Padding = new Thickness(50);

            list.ItemTapped += (sender, args) =>
            {
                var question = args.Item as Question;
				//try catch here? some unhandled exception here...
                if (question == null) return;
                user.Questions.Add(question);
                System.Diagnostics.Debug.WriteLine("Question successfully added to user bucket");
                _mainViewModel.viewBasket(this);
                list.SelectedItem = null;
            };
        }
    }
}
