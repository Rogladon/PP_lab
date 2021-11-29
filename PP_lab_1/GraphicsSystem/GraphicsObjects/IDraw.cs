using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsSystem.GraphicsObjects {
	/// <summary>
	/// Способ отрисовки объекта в каждом из контекстов
	/// </summary>
	public partial interface IDraw {
		/// <summary>
		/// Отрисовка в контексте winForm
		/// </summary>
		/// <param name="g"></param>
		void Draw(System.Drawing.Graphics g);
		/// <summary>
		/// Отрисовка в контексте svg
		/// </summary>
		/// <param name="doc"></param>
		void Draw(Svg.SvgDocument doc);
	}
}
