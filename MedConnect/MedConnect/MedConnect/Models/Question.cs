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
        public int rating { get; set; }
        public List<string> tags { get; set; }

        public Question()
        {
            tags = new List<string>();
        }
        public void addTag(string toAdd)
        {
            tags.Add(toAdd);
        }
    }
}
