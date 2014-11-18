﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MedConnect.Models; 

namespace MedConnect.NewViews
{
    public class VisitQuestionsPage : ContentPage 
    {
        private MasterPage _masterPage; 

        public VisitQuestionsPage(MasterPage masterPage)
        {
            this.Appearing += LibraryPage_Appearing;

            _masterPage = masterPage;
            BackgroundColor = Color.FromHex("#C1C1C1");

            this.BindingContext = _masterPage.MainView;

            var listView = new ListView();
            listView.HasUnevenRows = true;
            listView.SetBinding(ListView.ItemsSourceProperty, new Binding("LibraryQuestions"));
            listView.ItemTemplate = new DataTemplate(typeof(QuestionCell));
            listView.ItemTapped += (sender, args) =>
            {
                var question = args.Item as Question;
                if (question == null) return;

                var modalPage = new EditQuestionPage(_masterPage, question.id);
                Navigation.PushModalAsync(modalPage);
                listView.SelectedItem = null;
            };
            var header = new HeaderElement("My Library");

            var addQuestionButton = new Button
            {
                Text = "Add Question"
            };

            var footer = new VisitsFooter(); 

            addQuestionButton.Clicked += (sender, args) =>
            {
                var modalPage = new AddQuestionPage(_masterPage.MainView);
                Navigation.PushModalAsync(modalPage);
                listView.SelectedItem = null;
            };

            Content = new StackLayout
            {
                Padding = new Thickness(20, 20, 20, 20),
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { header, listView, addQuestionButton, footer }
            };
        }

        void LibraryPage_Appearing(object sender, EventArgs e)
        {
            _masterPage.MainView.getLibraryQuestions();
        }

    }
}
