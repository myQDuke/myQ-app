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
    public class RecommendedQuestionsPage : ContentPage
    {
        private User User;
        private MainViewModel mvm;

        public RecommendedQuestionsPage(User user, MainViewModel main)
        {
            User = user;
            mvm = main;

            Title = "Recommended Questions";

            var list = new ListView();
            Content = list;

            var viewModel = new RecommendedQuestionsViewModel();
            list.ItemsSource = viewModel.getRecQuestions();

            var cell = new DataTemplate(typeof(TextCell));
            cell.SetBinding(TextCell.TextProperty, "Text");

            list.ItemTemplate = cell;

            this.Padding = new Thickness(50);

            list.ItemTapped += (sender, args) =>
            {
                var question = args.Item as Question;
                if (question == null) return;
                user.Questions.Add(question);
                System.Diagnostics.Debug.WriteLine("Question successfully added to user bucket");
                mvm.viewBasket(this);
                list.SelectedItem = null;
            };
        }
    }
}
