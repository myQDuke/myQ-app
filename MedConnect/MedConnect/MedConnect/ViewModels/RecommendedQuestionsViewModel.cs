using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortableRest; 
using MedConnect.Models;
using MedConnect.Utilies;
using System.ComponentModel; 

namespace MedConnect.ViewModels
{
	public class RecommendedQuestionsViewModel : ViewModel
    {
		public ObservableCollection<Question> _recommendedQuestions;

		public ObservableCollection<Question> RecommendedQuestions {
			get {
				return _recommendedQuestions;
			}
			set {
				_recommendedQuestions = value;
				OnPropertyChanged ("RecommendedQuestions");
			}
		}

		//hacky solution; need to figure out a better design for this
		private WebService _webservice;

        public RecommendedQuestionsViewModel()
        {
			RecommendedQuestions = new ObservableCollection<Question>();

			RecommendedQuestions.Add(new Question
            {
                Text = "What type of cancer do I have?"
            });
			RecommendedQuestions.Add(new Question
            {
                Text = "Will certain activities make my symptoms worse?"
            });
			RecommendedQuestions.Add(new Question
            {
                Text = "What diagnostic tests or procedures will I need and how often?"
            });
			RecommendedQuestions.Add(new Question
            {
                Text = "How can I manage my symptoms?"
            });
			_webservice = new WebService ();

			getRecQuestions ();
			
        }

		public async void getRecQuestions()
		{
			RecommendedQuestions.Clear ();
			var tempQ = await _webservice.testRest ();
			/*

			foreach (var q in tempQ) {
				RecommendedQuestions.Add (q);
			}*/
			RecommendedQuestions = tempQ;
			
        }
    }
}
