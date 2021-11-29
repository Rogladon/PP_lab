using Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual {
	public class VisualLine : VisualCurve {
		#region Constructors
		public VisualLine(Line curve) : base(curve) { }
		#endregion

		#region VisualCurve realization
		public override void Draw(Graphics g) {
			IPoint a = curve.GetPoint(0);
			IPoint b = curve.GetPoint(1);
			g.DrawLine(new Pen(color, width), (float)a.X, (float)a.Y, (float)b.X, (float)b.Y);
		}
		#endregion
	}
}
