using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;
using System.Drawing;
using GraphicsSystem.GraphicsObjects;

namespace VisualBridge {
	/// <summary>
	/// Схема отрисовки
	/// </summary>
	public interface IDrawScheme {
		/// <summary>
		/// Отрисовка точки начала
		/// </summary>
		/// <param name="point">точка начала кривой</param>
		/// <param name="direction">направление в котором будет продолжаться кривая</param>
		/// <returns></returns>
		void DrawStart(IPoint point, IPoint direction);
		/// <summary>
		/// Отрисовка кривой
		/// </summary>
		/// <param name="point">Массив точек кривой</param>
		/// <returns></returns>
		void DrawLines(IPoint[] point);
		/// <summary>
		/// Отрисовка точки конца кривой
		/// </summary>
		/// <param name="point">точка конца кривой</param>
		/// <param name="direction">направление к прошлой точке кривой</param>
		/// <returns></returns>
		void DrawEnd(IPoint point, IPoint direction);
		void SetGraphicContext(GraphicsSystem.IGraphicContext context);
	}
}
