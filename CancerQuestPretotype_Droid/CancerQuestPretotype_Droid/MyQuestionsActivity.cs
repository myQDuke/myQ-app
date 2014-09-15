
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CancerQuestPretotype_Droid
{
	[Activity (Label = "MyQuestionsActivity")]			
	public class MyQuestionsActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.MyQuestions);
		}
	}
}

