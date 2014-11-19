using System;
using System.Globalization;
using MedConnect.Utilies;
using MedConnect.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MedConnect
{
	public class TagTranslator
	{
		private WebService _webService;
		private Dictionary<int,string> dicTags;
		private List<Tag> allTags;

		public TagTranslator (WebService webservice)
		{
			_webService = webservice;
			dicTags = new Dictionary<int, string> ();
			allTags = new List<Tag> ();
            getTags();
            initializeTagDict();

		}

		public string getTagName(int tagID)
		{
			//result = dicTags.get(tagID);
			//return result;
            return null;
		}

        public async void getTags()
        {
            //var temp = await _webService.getTags();
            //allTags = temp;

        }

        private void initializeTagDict()
        {
            foreach(Tag q in allTags)
            {
                dicTags.Add(q.id, q.Text);
            }
        }
		/*
		 * Get all tags
		 * foreach tag, create new entry in dictionary. map tag id to tag name. 
		 * each question will get tag
		 * 
		*


	    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	    {
	        
	    }

	    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	    {
	        
	    }
         */
	}
}

