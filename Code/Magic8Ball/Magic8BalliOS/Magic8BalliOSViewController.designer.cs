// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Magic8BalliOS
{
	[Register ("Magic8BalliOSViewController")]
	partial class Magic8BalliOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonRoll { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelPhrase { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (buttonRoll != null) {
				buttonRoll.Dispose ();
				buttonRoll = null;
			}
			if (labelPhrase != null) {
				labelPhrase.Dispose ();
				labelPhrase = null;
			}
		}
	}
}
