﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedConnect.Models; 
using Xamarin.Forms;

namespace MedConnect.NewViews
{
    public class VisitsPage : ContentPage
    {
		private MasterPage _masterPage;
		public VisitsPage(MasterPage masterPage)
        {
            this.Appearing += visitPage_Appearing;
			_masterPage = masterPage;

            BackgroundColor = Color.FromHex("#C1C1C1");
            ObservableCollection<Visit> Questions = new ObservableCollection<Visit>();
            Visit q1 = new Visit
            {
                name = "This is a sample question",

            };
			Visit q2 = new Visit
			{
				name = "This is a sample question",

			};
            
            Questions.Add(q1);
            Questions.Add(q2);

			

			this.BindingContext = _masterPage.MainView._visitsViewModel;

            var listView = new ListView();
            listView.HasUnevenRows = true;
			listView.SetBinding (ListView.ItemsSourceProperty, new Binding ("Visits"));
			//listView.ItemsSource = Questions;
            listView.ItemTemplate = new DataTemplate(typeof(VisitCell));

			listView.ItemTapped += (sender, args) =>
			{
				var visit = args.Item as Visit;
				if (visit == null) return;

				var modalPage = new VisitQuestionsPage(_masterPage, visit);
				Navigation.PushModalAsync(modalPage);
				listView.SelectedItem = null;
			};

            var header = new HeaderElement("My Visits");
            var addVisitsButton = new Button
            {
                Text = "Add New Visit"
            };

            addVisitsButton.Clicked += (sender, args) =>
            {
				HandleAddVisit();
                //Navigation.PopModalAsync();
            };

            Content = new StackLayout
            {
                Padding = new Thickness(20, 20, 20, 20),
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { header, listView, addVisitsButton}
            };
        }

		public async void HandleAddVisit()
		{
			int userID = _masterPage.MainView.User.id;
			_masterPage.MainView._visitsViewModel.createVisit (userID);
			await DisplayAlert("Visit Created", "New Visit created!", "OK");
            
		}
        private void visitPage_Appearing(object sender, EventArgs args)
        {
            _masterPage.MainView.getVisits();
        }
    }
}
