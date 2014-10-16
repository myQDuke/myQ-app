using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedConnect.Models
{
    public class Question
    {
        public string Text { get; set; }
        public int Rating { get; set; }
        public List<string> Tags { get; set; }

        public Question()
        {
            Tags = new List<string>();
        }
        public void addTag(string toAdd)
        {
            Tags.Add(toAdd);
        }
    }
}
