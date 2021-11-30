using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	public class Point : IPoint {
		#region Fields
		private double x;
		private double y;
		#endregion

		#region Properties
		public double X => x;
		public double Y => y;
		#endregion

		#region Static Properties
		public static Point Zero => new Point(0, 0);
		public static Point One => new Point(1, 1);
		#endregion

		#region Constructors
		public Point(double x, double y) {
			this.x = x;
			this.y = y;
		}
		#endregion

		#region Public Methods
		public void SetX(double x) {
			this.x = x;
		}

		public void SetY(double y) {
			this.y = y;
		}

		public IPoint Plus(IPoint p) {
			return new Point(X + p.X, Y + p.Y);
		}
		public IPoint Minus(IPoint p) {
			return new Point(X - p.X, Y - p.Y);
		}
		public IPoint Multiple(double d) {
			return new Point(X * d, Y * d);
		}
		public IPoint Normalize() {
			double lenght = Math.Sqrt(x * x + y * y);
			return new Point(x / lenght, y / lenght);
		}

		public float Distance(IPoint p) {
			return (float)Math.Sqrt(Math.Pow((p.X - X), 2) + Math.Pow((p.Y - Y), 2));
		}
		#endregion

	}
}
