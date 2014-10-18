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
    public class SubmitQuestionPage : ViewPage
    {

        public SubmitQuestionPage (User user, MainViewModel mvm) : base(user, mvm)
        {
            var questionLabel = new Label
            {
                Text = "Question"
            };

            var questionText = new Entry
            {
                Placeholder = "Your Question Here"
            };

            var submitButton = new Button
            {
                Text = "Submit"
            };

            var cancelButton = new Button
            {
                Text = "Cancel"
            };

            this.Content = new StackLayout
            {
                Children = { questionLabel, questionText, submitButton, cancelButton }
            };

            submitButton.Clicked += (sender, args) =>
            {
                var question = new Question();
                question.Text = questionText.Text; 
                _user.Questions.Add(question);
                Navigation.PopModalAsync();
            };

            cancelButton.Clicked += (sender, args) =>
            {
                Navigation.PopModalAsync(); 
            };
        }
    }
}
