using System;
using MedConnect.Models;
using MedConnect.Utilies;
using MedConnect.Views;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace MedConnect.ViewModels
{
	public class MainViewModel
	{
        private WebService _webService;
        private static User _currentUser;
        //should we have instances of every view so that we can cache them? or is that stupid and should we make new ones everytime... 

		public MainViewModel () {
            _webService = new WebService();

			//testing connection
			testConnection ();
		}
		public async Task<ObservableCollection<Question>> testConnection()
		{
			ObservableCollection<Question> result = await _webService.testRest ();
			foreach(Question q in result) 
			{
				System.Diagnostics.Debug.WriteLine(q.Text);
			}

			return result;
		}

        //this is for logging in
        public void authenticate(string username, string password, ContentPage cur)
        {
			System.Diagnostics.Debug.WriteLine(username);
            if (_webService.authenticate(username, password))
            {
                _currentUser = new User();
                _currentUser.Name = username;
                _currentUser.Questions = _webService.getData();
                cur.Navigation.PushAsync(new RecommendedQuestionsPage(_currentUser, this));
            }
            else {
                cur.Navigation.PushAsync(new SignupPage());
            }
        }

        public void viewBasket(ContentPage currentPage)
        {
            currentPage.Navigation.PushAsync(new SavedQuestionsPage(_currentUser, this));
        }

        public void viewRecommendedQuestions(ContentPage currentPage)
        {
            currentPage.Navigation.PushAsync(new RecommendedQuestionsPage(_currentUser, this)); 
        }

        
	}
}

