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
                Text = "Rate question: Was this question helpful?"
            };

            var helpfulButton = new Button
            {
                Text = "Yes"
            };

            var notHelpfulButton = new Button
            {
                Text = "No"
            };

            var removeQuestionButton = new Button
            {
                Text = "Remove question"
            };

            removeQuestionButton.Clicked += (sender, args) =>
            {
                _user.Questions.Remove(question);
                System.Diagnostics.Debug.WriteLine("Question removed");
                Navigation.PopModalAsync();
            };

            helpfulButton.Clicked += (sender, args) =>
            {
                question.helpfulVotes++;
                question.totalVotes++;
                System.Diagnostics.Debug.WriteLine("User voted question helpful");
            };

            notHelpfulButton.Clicked += (sender, args) =>
            {
                question.notHelpfulVotes++;
                question.totalVotes++;
                System.Diagnostics.Debug.WriteLine("User voted question unhelpful");
            };

            this.Content = new StackLayout
            {
                Children = { rateQuestionLabel, helpfulButton, notHelpfulButton, removeQuestionButton }
            };
        }
    }
}
