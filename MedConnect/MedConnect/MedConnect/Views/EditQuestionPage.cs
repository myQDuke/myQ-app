using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms; 
using MedConnect.Models;
using MedConnect.ViewModels; 

namespace MedConnect.Views
{
    public class EditQuestionPage : ViewPage
    {
        public EditQuestionPage(Question question, User user, MainViewModel mvm) : base(user, mvm)
        {
            var rateQuestionLabel = new Label
            {
                Text = "Rate question"
            };

            var removeQuestionButton = new Button
            {
                Text = "Remove question"
            };

            removeQuestionButton.Clicked += (sender, args) =>
            {
                _user.Questions.Remove(question);
                Navigation.PopModalAsync();
            };

            this.Content = new StackLayout
            {
                Children = { rateQuestionLabel, removeQuestionButton }
            };
        }
    }
}
