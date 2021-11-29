using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	public class Line : ACurve {
		#region Constructors
		public Line(IPoint a, IPoint b) : base(a, b) { }
		#endregion

		#region ACurve realisation
		public override IPoint GetPoint(double t) {
			return a.Multiple(1 - t).Plus(b.Multiple(t));
		}
		#endregion
	}
}
