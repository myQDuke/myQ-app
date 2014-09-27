using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedConnect.Models; 

namespace MedConnect.ModelViews
{
    public class SuggestedQuestionsViewModel
    {
        public ObservableCollection<Question> SuggestedQuestions { get; set; }

        public SuggestedQuestionsViewModel() 
        {
            SuggestedQuestions = new ObservableCollection<Question>();
        }
    }
}
