using Geometry.Algoritm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	public class MoveTo : ICurve {
		private ICurve curve;
		private IPoint moveVector;
		public MoveTo(ICurve curve, IPoint p) {
			this.curve = curve;
			this.moveVector = p.Minus(curve.GetPoint(0));
		}
		public float GetAlgoritm(float coeff, float step, IStrategyGetLenght strategy) {
			return strategy.Operation(this, coeff, step);
		}

		public IPoint GetPoint(double t) {
			return curve.GetPoint(t).Plus(moveVector);
		}
	}
}
