using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	/// <summary>
	/// Класс кривой Безье
	/// </summary>
	public class Bezier : ACurve {
		#region Fields
		protected IPoint c;
		protected IPoint d;
		#endregion

		#region Properties
		/// <summary>
		/// Аргумент начала Безье (Не помню как он точно называется)
		/// </summary>
		public IPoint C => c;
		/// <summary>
		/// Аргумент конца Безье (Не помню как он точно называется)
		/// </summary>
		public IPoint D => d;
		#endregion

		#region Constructors
		public Bezier(IPoint a, IPoint c, IPoint d, IPoint b) : base(a, b) {
			this.c = c;
			this.d = d;
		}
		#endregion

		#region ACurve realisation
		public override IPoint GetPoint(double t) {
			return a.Multiple(Math.Pow(1 - t, 3))
				.Plus(c.Multiple(3 * t * Math.Pow(1 - t, 2)))
				.Plus(d.Multiple(3 * Math.Pow(t, 2) * (1 - t)))
				.Plus(b.Multiple(Math.Pow(t, 3)));
		}
		#endregion
	}
}
