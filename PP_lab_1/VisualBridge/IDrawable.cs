using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GraphicsSystem;

namespace Visual {
	/// <summary>
	/// Интерфейс для отрисовка линий
	/// </summary>
	public interface IDrawable {
		/// <summary>
		/// Мост схема отрисовки
		/// </summary>
		IDrawScheme DrawScheme { get; }
		/// <summary>
		/// Отрисовка 
		/// </summary>
		/// <param name="g">Графичексий контекст</param>
		/// <param name="n">Качество отрисовки линии</param>
		void Draw();
		/// <summary>
		/// Смена моста
		/// </summary>
		/// <param name="drawScheme"></param>
		void SetDrawScheme(IDrawScheme drawScheme);
	}
}
