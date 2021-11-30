using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Algoritm {
	public interface IStrategyGetLenght {
		float Operation(ICurve curve, float k, float step);
	}
}
