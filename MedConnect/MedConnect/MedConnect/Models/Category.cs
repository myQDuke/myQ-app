using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedConnect.Models
{
    public class Category
    {
        public int id;
        public string text;
        public ObservableCollection<Tag> Tag;


    }
}
