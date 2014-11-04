using System;
using MedConnect.Models;
using MedConnect.Utilies;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.ComponentModel;
using PortableRest;

namespace MedConnect.ViewModels
{
	public class MainViewModel : ViewModel
	{
		private ObservableCollection<Question> _recommendedQuestions;

        public ObservableCollection<Question> RecommendedQuestions
        {
            get
            {
                return _recommendedQuestions;
            }
            set
            {
                _recommendedQuestions = value;
				OnPropertyChanged("RecommendedQuestions");
            }
        } 

        private WebService _webService;
		private static User _currentUser;

		public User User
		{
			get
			{
				return _currentUser;
			}
			set
			{
				_currentUser = value;
				OnPropertyChanged("User");
			}
		}
        //should we have instances of every view so that we can cache them? or is that stupid and should we make new ones everytime... 

		public MainViewModel () {
            _webService = new WebService();
            _recommendedQuestions = new ObservableCollection<Question>();

			//testing connection
			//testConnection ();
            //getRecQuestions();
			//_webService.testLogin("Jonno", "Test", _currentUser);
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
		public async Task<User> authenticate(string username, string password)
        {

			var lol = await _webService.testLogin (username, password);
			//System.Diagnostics.Debug.WriteLine (_currentUser);
			User = lol;
			return User;

			/*
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
            */
        }

        public async void getRecQuestions()
        {
            RecommendedQuestions.Clear();
            var tempQ = await _webService.testRest();
            foreach (var q in tempQ) {
                //RecommendedQuestions.Add (q);
                System.Diagnostics.Debug.WriteLine(q.Text);
            }
            RecommendedQuestions = tempQ;

        }

        public void viewBasket(ContentPage currentPage)
        {
            //currentPage.Navigation.PushAsync(new SavedQuestionsPage(_currentUser, this));
        }

        public void viewRecommendedQuestions(ContentPage currentPage)
        {
            //currentPage.Navigation.PushAsync(new RecommendedQuestionsPage(_currentUser, this)); 
        }

        public async void postQuestion(String s)
        {
            var response = await _webService.postQuestion(s);
        }
        
	}
}

