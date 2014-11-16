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
		private ObservableCollection<Question> _libraryQuestions;

		public ObservableCollection<Question> LibraryQuestions
		{
			get
			{
				return _libraryQuestions;
			}
			set
			{
				_libraryQuestions = value;
				OnPropertyChanged ("LibraryQuestions");
			}
		}
		private ObservableCollection<Visit> _visits;

		public ObservableCollection<Visit> Visits
		{
			get{
				return _visits;
			}
			set{
				_visits = value;
				OnPropertyChanged ("Visits");
			}
		}

        //should we have instances of every view so that we can cache them? or is that stupid and should we make new ones everytime... 

		public MainViewModel () {
            _webService = new WebService();
            _recommendedQuestions = new ObservableCollection<Question>();
			_libraryQuestions = new ObservableCollection<Question>();

			//test createUser
			//createUser ("Kevin", "Test", "jon@jo.com");

		}

		public async Task<User> authenticate(string username, string password)
        {
			var responseUser = await _webService.login (username, password);
			//System.Diagnostics.Debug.WriteLine (_currentUser);
			User = responseUser;
			if (User != null) {
				_libraryQuestions = User.Questions; 
			}
			return User;
        }

        public async void getRecQuestions()
        {
            RecommendedQuestions.Clear();
            var tempQ = await _webService.getRecQuestions();
            foreach (var q in tempQ) {
                //RecommendedQuestions.Add (q);
                System.Diagnostics.Debug.WriteLine(q.Text);
            }
            RecommendedQuestions = tempQ;
        }

		public async void getLibraryQuestions()
		{
			LibraryQuestions.Clear();
			var tempQ = await _webService.getLibraryQuestions(_currentUser.id);
			LibraryQuestions = tempQ;

			System.Diagnostics.Debug.WriteLine(_currentUser.Questions);
		}
		public async Task<Question> postQuestion(String s)
        {
            var response = await _webService.postQuestion(s);
			return response;
        }
		public async void getVisits()
		{
			Visits.Clear();
			var tempQ = await _webService.getVisits(_currentUser.id);
			LibraryQuestions = tempQ;

			System.Diagnostics.Debug.WriteLine(_currentUser.Questions);
		}

		public async void postLibrary(int questionID)
		{
			var response = await _webService.postLibrary(questionID, _currentUser.id);
		}
		public async Task<User> createUser(string username, string password, string email)
		{
			var responseUser = await _webService.createUser (username, password, email);
			//System.Diagnostics.Debug.WriteLine (_currentUser);
			User = responseUser;
			return User;
		}
        public void removeLibraryQuestion(int questionID)
        {
            _webService.removeLibraryQuestion(questionID, _currentUser.id);
        }
	}
}

