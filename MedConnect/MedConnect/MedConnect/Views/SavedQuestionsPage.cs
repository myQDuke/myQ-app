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

            this.Content = new StackLayout
            {
                Children = { menuButton, list }
            };

            list.ItemsSource = user.Questions;

            var cell = new DataTemplate(typeof(TextCell));
            cell.SetBinding(TextCell.TextProperty, "Text");

            list.ItemTemplate = cell; 
           
        }
    }
}
