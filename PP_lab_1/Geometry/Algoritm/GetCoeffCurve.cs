using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Algoritm {
	public class GetCoeffCurve : IStrategyGetLenght {
		public float Operation(ICurve curve, float l, float step) {
			float lenght = 0;
			float i = step;
			for(i = step; lenght <= l; i += step) {
				lenght += curve.GetPoint(i - step).Distance(curve.GetPoint(i));
			}
			return i;
		}
	}
}
