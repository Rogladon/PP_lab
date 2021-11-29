using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsSystem.GraphicsObjects {
	public class PointConverter {
		public static System.Drawing.PointF GeometryToWinDraw(Geometry.IPoint point) {
			return new System.Drawing.PointF((float)point.X, (float)point.Y);
		}
		public static Svg.SvgPoint GeometryToSvg(Geometry.IPoint point) {
			return new Svg.SvgPoint((float)point.X, (float)point.Y);
		}
	}
}
