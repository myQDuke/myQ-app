
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
	[Activity (Label = "CancerQuest", MainLauncher = true, Icon = "@drawable/icon")]		
	public class LoginActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Login);

			Button button = FindViewById<Button> (Resource.Id.LoginButton);
			EditText username = FindViewById<EditText> (Resource.Id.UsernameInput);
			EditText password = FindViewById<EditText> (Resource.Id.PasswordInput); 

			button.Click += (sender, e) => {
				if (!String.IsNullOrWhiteSpace(username.Text) || !String.IsNullOrWhiteSpace(password.Text))
				{
					var appIntent = new Intent(this, typeof(MainActivity));
					StartActivity(appIntent); 
				}
			};
		}
	}
}

