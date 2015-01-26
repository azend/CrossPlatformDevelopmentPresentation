using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Magic8BallShared;

namespace Magic8BallAndroid
{
	[Activity (Label = "Magic8BallAndroid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		private Magic8Ball magic8Ball = new Magic8Ball();

		private TextView textViewPhrase = null;
		private Button buttonRoll = null;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			SetupUIHandles ();
			SetupEventListeners ();
		}

		private void SetupUIHandles() {
			textViewPhrase = (TextView)FindViewById (Resource.Id.textViewPhrase);
			buttonRoll = (Button)FindViewById (Resource.Id.buttonRoll);
		}

		private void SetupEventListeners() {
			buttonRoll.Click += OnRoll;
		}

		private void OnRoll (object o, EventArgs e) {
			textViewPhrase.Text = magic8Ball.Shake();
		}
	}
}


