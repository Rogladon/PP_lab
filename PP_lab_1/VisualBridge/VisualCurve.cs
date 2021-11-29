using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace VisualBridge {
	/// <summary>
	/// Класс кривой с визуализацией
	/// </summary>
	public class VisualCurve : ICurve, IDrawable {
		#region Fields
		private ICurve curve;
		private IDrawScheme drawScheme;
		#endregion

		#region Properties
		public IDrawScheme DrawScheme => drawScheme;
		public ICurve Curve => curve;
		#endregion

		#region Constructs

		public VisualCurve(ICurve curve, IDrawScheme d) {
			this.curve = curve;
			this.drawScheme = d;
		}
		#endregion

		#region Realization IDrawable
		public void Draw(GraphicsSystem.IGraphicContext g, int n) {
			var points = Enumerable.Range(0, n)
				.Select(p => GetPoint((double)p / n)).ToArray();
			g.AddRange(DrawScheme.DrawStart(points[0], points[1].Minus(points[0])));
			g.AddRange(DrawScheme.DrawLines(points));
			g.AddRange(DrawScheme.DrawEnd(points[n-1], points[n-2].Minus(points[n-1])));
			g.Draw();
		}
		public void SetDrawScheme(IDrawScheme drawScheme) {
			this.drawScheme = drawScheme;
		}
		#endregion

		#region Realization ICurve
		public void GetPoint(double t, out IPoint p) {
			curve.GetPoint(t, out p);
		}

		public IPoint GetPoint(double t) {
			return curve.GetPoint(t);
		}
		#endregion
		
	}
}
