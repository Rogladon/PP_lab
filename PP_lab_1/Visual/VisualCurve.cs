using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace Visual {
	public abstract class VisualCurve : ICurve, IDrawable {
		#region Fields
		protected Color color;
		protected float width = 1;
		protected ICurve curve;
		#endregion

		#region Properties
		/// <summary>
		/// Цвет кривой
		/// </summary>
		public Color Color => color;
		/// <summary>
		/// Толщина линии кривой
		/// </summary>
		public float Width => width;
		/// <summary>
		/// Объект кривой
		/// </summary>
		public ICurve Curve => curve;
		#endregion

		#region Constructors
		public VisualCurve(ICurve curve) {
			this.curve = curve;
		}
		#endregion

		#region Builder
		/// <summary>
		/// Устанавливает цвет кривой
		/// </summary>
		/// <param name="color"></param>
		/// <returns></returns>
		public VisualCurve SetColor(Color color) {
			this.color = color;
			return this;
		}
		/// <summary>
		/// Устанавливает толщину линии кривой
		/// </summary>
		/// <param name="width"></param>
		/// <returns></returns>
		public VisualCurve SetWidth(float width) {
			this.width = width;
			return this;
		}

		#endregion

		#region IDrawable realization
		/// <summary>
		/// Отрисовывает Кривую
		/// </summary>
		/// <param name="g">Графический контекст</param>
		public abstract void Draw(Graphics g);
		#endregion

		#region ICurve realizetion
		public void GetPoint(double t, out IPoint p) {
			p = curve.GetPoint(t);
		}
		public IPoint GetPoint(double t) {
			return curve.GetPoint(t);
		}
		#endregion
	}
}
