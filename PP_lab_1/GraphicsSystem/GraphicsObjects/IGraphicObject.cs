using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;
using System.Drawing;

namespace GraphicsSystem.GraphicsObjects {
	/// <summary>
	/// Графический объект
	/// </summary>
	public interface IGraphicObject {
		/// <summary>
		/// Позиция 
		/// </summary>
		IPoint Position { get; set;}
		/// <summary>
		/// Цвет 
		/// </summary>
		Color Color { get; set; }
		/// <summary>
		/// Толщина обводки
		/// </summary>
		float WidthPen { get; set; }
		/// <summary>
		/// Интервфейс отрисовка в графическом контексте
		/// </summary>
		IDraw Draw { get; }
	}
}
