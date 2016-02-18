using System;
using UIKit;
using CoreAnimation;
using CoreGraphics;

namespace XamarinDemo.iOS
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			this.JoinButton.Layer.CornerRadius = 5.0f;
			this.HandleTextField.Layer.CornerRadius = 5.0f;

			var gradient = new RadialGradient();
			gradient.Frame = this.View.Bounds;
			this.View.Layer.InsertSublayer(gradient, 0);
		}

		partial void JoinButton_TouchUpInside(UIButton sender)
		{
			var clientId = this.HandleTextField.Text;
			var alertView = new UIAlertView(this.View.Bounds);
			alertView.Message = clientId;
			alertView.Show();
		}
	}
}