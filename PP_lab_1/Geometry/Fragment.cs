using Geometry.Algoritm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	public class Fragment : ICurve {
		private ICurve curve;
		private float tStart;
		private float tFinish;
		public Fragment(ICurve curve, float tStart, float tFinish){
			this.tStart = tStart;
			this.tFinish = tFinish;
			this.curve = curve;
		}

		public float GetAlgoritm(float coeff, float step, IStrategyGetLenght strategy) {
			return strategy.Operation(this,coeff, step);
		}
		public IPoint GetPoint(double t) {
			return curve.GetPoint(t * Math.Abs(tFinish - tStart) + tStart);
		}
	}
}
