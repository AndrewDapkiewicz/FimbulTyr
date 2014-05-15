using System;
using MonoTouch.UIKit;


namespace FimbulTyr.iOS {

	public class CircleController : UIViewController {

		CircleView view;

		public override void LoadView() {
			base.LoadView();

			view = new CircleView();
			View = view;
		}
	}
}