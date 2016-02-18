using System;
		
using UIKit;
using CoreAnimation;
using CoreGraphics;

namespace XamarinDemo.iOS
{
	public class RadialGradient: CALayer
	{
		public RadialGradient()
		{
			this.SetNeedsDisplay();
		}

		public override void DrawInContext(CGContext ctx)
		{
			base.DrawInContext(ctx);
			var colorSpace = CGColorSpace.CreateDeviceRGB();

			if (colorSpace == null)
			{
				throw new InvalidOperationException();
			}

			var gradient = new CGGradient(colorSpace, 
				new nfloat[] { 1f, 1f, 1f, 1f, 0.86f, 0.86f, 0.86f, 1f },
				               new nfloat[] { 0.2f, 0.95f });
			var center = new CGPoint(this.Bounds.Width / 2, this.Bounds.Height / 2);
			var radius = new nfloat(Math.Min(this.Bounds.Width, this.Bounds.Height));

			ctx.DrawRadialGradient(gradient, center, 0, center, radius, CGGradientDrawingOptions.DrawsAfterEndLocation);
		}
	}
	
}