using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortableRest; 
using MedConnect.Models; 

namespace MedConnect.ViewModels
{
    public class RecommendedQuestionsViewModel
    {
        private ObservableCollection<Question> _recommendedQuestions;
        private const string _baseAddress = "http://cancerquest.azurewebsites.net/";

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
        }

        public ObservableCollection<Question> getRecQuestions()
        {
            //should this be linked to the main view model? 
            return _recommendedQuestions;
        }
    }
}
