using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsSystem.GraphicsObjects;

namespace GraphicsSystem {
	/// <summary>
	/// Графический контекст
	/// </summary>
	/// <typeparam name="T"></typeparam>
	abstract public class AGraphicContext<T> : IGraphicContext {
		#region Fields
		protected T context;
		private List<IGraphicObject> graphicObjects = new List<IGraphicObject>();
		#endregion

		#region Prperties

		public IGraphicObject this[int index] {
			get {
				return graphicObjects[index];
			}
			set {
				graphicObjects[index] = value;
			}
		}

		public T Context => context;
		#endregion

		#region Constructs
		public AGraphicContext(T context) {
			this.context = context;
		}
		#endregion

		#region IGraphicsContext Realization
		abstract public void Draw();
		public void Add(IGraphicObject graphicObject) {
			graphicObjects.Add(graphicObject);
		}

		public void AddRange(IEnumerable<IGraphicObject> graphicObjects) {
			this.graphicObjects.AddRange(graphicObjects);
		}

		public void Remove(IGraphicObject graphicObject) {
			graphicObjects.Remove(graphicObject);
		}

		public void RemoveAt(int index) {
			graphicObjects.RemoveAt(index);
		}
		public IEnumerator<IGraphicObject> GetEnumerator() {
			return ((IEnumerable<IGraphicObject>)graphicObjects).GetEnumerator();
		}
		IEnumerator IEnumerable.GetEnumerator() {
			return ((IEnumerable)graphicObjects).GetEnumerator();
		}
		#endregion
	}
}
