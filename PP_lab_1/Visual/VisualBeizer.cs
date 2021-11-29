using Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual {
	public class VisualBezier : VisualCurve {
		#region Fields
		private int quality = 100;
		#endregion

		#region Properties
		/// <summary>
		/// Насколько отрезков поделится линия Безье при рисовании
		/// </summary>
		public int Quality => quality;
		#endregion

		#region Constructors
		public VisualBezier(Bezier curve) : base(curve) { }
		#endregion

		#region Builders
		/// <summary>
		/// Устанавливает качество рисуемой линии
		/// </summary>
		/// <param name="quality">Насколько отрезков поделится линия Безье</param>
		/// <returns></returns>
		public VisualCurve SetQuality(int quality) {
			this.quality = quality;
			return this;
		}
		#endregion

		#region VisualCurve realization
		public override void Draw(Graphics g) {
			PointF[] points = Enumerable.Range(0, quality+1)
				.Select(p => (double)p / quality)
				.Select(p => GetPoint(p))
				.Select(p => new PointF((float)p.X, (float)p.Y)).ToArray();
			g.DrawLines(new Pen(color, width), points);
		}
		#endregion
	}
}
