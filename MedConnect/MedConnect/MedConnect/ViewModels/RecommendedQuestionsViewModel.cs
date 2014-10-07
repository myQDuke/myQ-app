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
        public ObservableCollection<Question> RecommendedQuestions { get; set; }
        private const string BaseAddress = "http://cancerquest.azurewebsites.net/";

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
        }
    }
}
