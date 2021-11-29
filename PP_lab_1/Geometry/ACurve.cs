using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	public abstract class ACurve : ICurve {
		#region Fields
		protected IPoint a;
		protected IPoint b;
		#endregion

		#region Properties
		/// <summary>
		/// Начало кривой
		/// </summary>
		public IPoint A => a;
		/// <summary>
		/// Конец кривой
		/// </summary>
		public IPoint B => b;
		#endregion

		#region Constructors
		public ACurve(IPoint a, IPoint b) {
			this.a = a;
			this.b = b;
		}
		#endregion

		#region ICurve realization
		public void GetPoint(double t, out IPoint p) {
			p = GetPoint(t);
		}
		public abstract IPoint GetPoint(double t);
		#endregion
	}
}
