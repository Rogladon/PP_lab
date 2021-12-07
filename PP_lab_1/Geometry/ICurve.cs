using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	public interface ICurve {
		/// <summary>
		/// Выдает точку лежащую на кривой
		/// </summary>
		/// <param name="t">От 0(начало кривой) до 1(конец кривой)</param>
		/// <returns></returns>
		IPoint GetPoint(double t);
		float GetAlgoritm(float coeff, float step, Algoritm.IStrategyGetLenght strategy);
	}
}
