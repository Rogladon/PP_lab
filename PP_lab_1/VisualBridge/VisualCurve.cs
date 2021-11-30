using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace Visual {
	/// <summary>
	/// Класс кривой с визуализацией
	/// </summary>
	public class VisualCurve : ICurve, IDrawable {
		#region Fields
		private ICurve curve;
		private IDrawScheme drawScheme;
		private int detail;
		#endregion

		#region Properties
		public IDrawScheme DrawScheme => drawScheme;
		public ICurve Curve => curve;
		#endregion

		#region Constructs

		public VisualCurve(ICurve curve, IDrawScheme d, int detail) {
			this.curve = curve;
			this.drawScheme = d;
			this.detail = detail;
		}
		#endregion

		#region Realization IDrawable
		public void Draw() {
			var points = Enumerable.Range(0, detail)
				.Select(p => GetPoint((double)p / detail)).ToArray();
			DrawScheme.DrawStart(points[0], points[1].Minus(points[0]));
			DrawScheme.DrawLines(points);
			DrawScheme.DrawEnd(points[detail - 1], points[detail - 2].Minus(points[detail-1]));
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
