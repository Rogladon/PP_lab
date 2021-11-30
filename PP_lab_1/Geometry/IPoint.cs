using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	public interface IPoint {
		double X { get; }
		double Y { get; }
		void SetX(double x);
		void SetY(double y);

		IPoint Plus(IPoint p);
		IPoint Minus(IPoint p);
		IPoint Multiple(double d);
		IPoint Normalize();
		float Distance(IPoint p);
	}
}
