using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Algoritm {
	public class GetLenghtCurve : IStrategyGetLenght {
		public float Operation(ICurve curve, float t, float step) {
			float lenght = 0;
			for(float i = step; i < t; i += step) {
				lenght += curve.GetPoint(i - step).Distance(curve.GetPoint(i));
			}
			return lenght;
		}
	}
}
