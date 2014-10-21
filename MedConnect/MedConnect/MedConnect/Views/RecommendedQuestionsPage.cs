using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MedConnect.ViewModels;
using MedConnect.Models;
using System.Collections.ObjectModel; 

namespace MedConnect.Views 
{
    public class RecommendedQuestionsPage : ViewPage
    {

		private RecommendedQuestionsViewModel viewModel;

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

            viewModel = new RecommendedQuestionsViewModel();

			this.BindingContext = viewModel;

			list.SetBinding (ListView.ItemsSourceProperty, new Binding ("RecommendedQuestions"));

            var cell = new DataTemplate(typeof(TextCell));
            cell.SetBinding(TextCell.TextProperty, "Text");

            list.ItemTemplate = cell;

            list.HasUnevenRows = true;

            this.Padding = new Thickness(0);

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
		/*
		public async Task<ObservableCollection<Question>> getData(RecommendedQuestionsViewModel vm)
		{
			//return null;
			//return await vm.getRecQuestions ();
		}
		*/
    }
}
