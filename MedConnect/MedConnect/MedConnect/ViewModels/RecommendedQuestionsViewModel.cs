using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortableRest; 
using MedConnect.Models;
using MedConnect.Utilies; 

namespace MedConnect.ViewModels
{
    public class RecommendedQuestionsViewModel
    {
		private ObservableCollection<Question> _recommendedQuestions;
		//hacky solution; need to figure out a better design for this
		private WebService _webservice;

        public RecommendedQuestionsViewModel()
        {
			_recommendedQuestions = new ObservableCollection<Question>();

            _recommendedQuestions.Add(new Question
            {
                Text = "What type of cancer do I have?"
            });
            _recommendedQuestions.Add(new Question
            {
                Text = "Will certain activities make my symptoms worse?"
            });
            _recommendedQuestions.Add(new Question
            {
                Text = "What diagnostic tests or procedures will I need and how often?"
            });
            _recommendedQuestions.Add(new Question
            {
                Text = "How can I manage my symptoms?"
            });
			_webservice = new WebService ();
			
        }

		public async Task<ObservableCollection<Question>> getRecQuestions()
		{
			_recommendedQuestions = await _webservice.testRest ();
            //should this be linked to the main view model? 
            return _recommendedQuestions;
        }
    }
}
