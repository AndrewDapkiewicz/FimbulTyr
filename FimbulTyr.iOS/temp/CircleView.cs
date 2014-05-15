using System;
using System.Drawing;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;


namespace FimbulTyr.iOS {

	public class CircleView : UIView {

		public CircleView() {
			BackgroundColor = UIColor.White;
		}

		public override void Draw( RectangleF rect ) {
			base.Draw( rect );

			// Get graphics context
			using( CGContext g = UIGraphics.GetCurrentContext() ) {
				// Set up drawing attributes
				g.SetLineWidth( 10 );
				UIColor.Green.SetFill();
				UIColor.Blue.SetStroke();

				// Create geometry
				var path = new CGPath();
				path.AddArc( Bounds.GetMidX(), Bounds.GetMidY(), 50, 0, 2.0f * ( float )Math.PI, true );

				// Add geometry to graphics context and draw it
				g.AddPath( path );
				g.DrawPath( CGPathDrawingMode.FillStroke );
			}
		}
	}
}