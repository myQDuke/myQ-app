using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MedConnect.ViewModels; 

namespace MedConnect.Views 
{
    public class RecommendedQuestionsPage : ContentPage
    {
        public RecommendedQuestionsPage()
        {
            Title = "Recommended Questions";

            var list = new ListView();
            Content = list;

            var viewModel = new RecommendedQuestionsViewModel();
            list.ItemsSource = viewModel.RecommendedQuestions;

            var cell = new DataTemplate(typeof(TextCell));
            cell.SetBinding(TextCell.TextProperty, "Text");

            list.ItemTemplate = cell;

            this.Padding = new Thickness(50);
        }
    }
}
