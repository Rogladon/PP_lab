using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	public interface IStrategitaly {
		float GetAlgoritm(float coeff, float step, Algoritm.IStrategyGetLenght strategy);
	}
}
