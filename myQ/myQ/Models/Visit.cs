﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedConnect.Models
{
    //should this be a child of basket? and it only stores 
	public class Visit
	{
		public ObservableCollection<Question> Questions { get; set; }
        public string name { get; set; }
        public int id { get; set; }

        //add recordings here

	}
}

