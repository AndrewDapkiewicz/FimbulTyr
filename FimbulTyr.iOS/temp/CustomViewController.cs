using System;
using MonoTouch.UIKit;


namespace FimbulTyr.iOS {

	public class CustomViewController : UIViewController {

		UITextField usernameField;
		UITextField passwordField;
		UIButton submitButton;
		UIImageView imageView;

		CircleController circleController;


		public override void ViewDidLoad() {
			base.ViewDidLoad();

			View.BackgroundColor = UIColor.Gray;

			float h = 31.0f;
			float w = View.Bounds.Width;

			usernameField = new UITextField {
				Placeholder = "Enter your username",
				BorderStyle = UITextBorderStyle.RoundedRect,
				// iOS origin: upper-left
				Frame = new System.Drawing.RectangleF( 10, 10, w - 20, h )
			};

			passwordField = new UITextField {
				Placeholder = "Enter your password",
				BorderStyle = UITextBorderStyle.RoundedRect,
				Frame = new System.Drawing.RectangleF( 10, 45, w - 20, h ),
				SecureTextEntry = true
			};

			submitButton = UIButton.FromType( UIButtonType.RoundedRect );
			submitButton.Frame = new System.Drawing.RectangleF( 10, 90, w - 20, 44 );
			submitButton.SetTitle( "Submit", UIControlState.Normal );
			submitButton.BackgroundColor = UIColor.White;
			submitButton.Layer.CornerRadius = 5;
			submitButton.TouchUpInside += delegate(object sender, EventArgs e ) {
				Console.WriteLine( "Submit button clicked" );

				circleController = new CircleController();
				PresentViewController( circleController, true, null );
			};

			imageView = new UIImageView( new System.Drawing.RectangleF( 10, 160, 56, 56 ) );
			imageView.Image = UIImage.FromFile( "SimCityEDU Icon.png" );

			View.AddSubview( usernameField );
			View.AddSubview( passwordField );
			View.AddSubview( submitButton );
			View.AddSubview( imageView );
		}
	}
}