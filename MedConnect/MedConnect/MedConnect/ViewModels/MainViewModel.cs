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
			//test createUser
			createUser ("Kevin", "Test", "jon@jo.com");
		}

		public async Task<User> authenticate(string username, string password)
        {

			var responseUser = await _webService.login (username, password);
			//System.Diagnostics.Debug.WriteLine (_currentUser);
			User = responseUser;
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
        public async void postQuestion(String s)
        {
            var response = await _webService.postQuestion(s);
        }
		public async Task<User> createUser(string username, string password, string email)
		{
			var responseUser = await _webService.createUser (username, password, email);
			//System.Diagnostics.Debug.WriteLine (_currentUser);
			User = responseUser;
			return User;
		}
	}
}

