using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsSystem.GraphicsObjects;

namespace GraphicsSystem {
	/// <summary>
	/// Графический контекст. Хранит массив объектов и отрисовывает на контексте движка
	/// </summary>
	public interface IGraphicContext : IEnumerable<IGraphicObject> {
		/// <summary>
		/// Графический объект в контексте
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		IGraphicObject this[int index] { get; }

		/// <summary>
		/// Отрисовка всех объектов на контексте движка
		/// </summary>
		void Draw();
		/// <summary>
		/// Добавление объекта
		/// </summary>
		/// <param name="graphicObject"></param>
		void Add(IGraphicObject graphicObject);
		/// <summary>
		/// Добавления коллекции объектов
		/// </summary>
		/// <param name="graphicObjects"></param>
		void AddRange(IEnumerable<IGraphicObject> graphicObjects);
		/// <summary>
		/// Удаление объекта по ссылке
		/// </summary>
		/// <param name="graphicObject"></param>
		void Remove(IGraphicObject graphicObject);
		/// <summary>
		/// Удаление объекта по индексу
		/// </summary>
		/// <param name="index"></param>
		void RemoveAt(int index);
	}
}
