using Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svg;
using GraphicsSystem;
using GraphicsSystem.GraphicsObjects;

namespace Visual {
	public class DrawScheme2 : IDrawScheme {
		private IGraphicContext context;
		public DrawScheme2(IGraphicContext context) {
			this.context = context;
		}
		public void DrawEnd(IPoint point, IPoint direction) {
			List<IGraphicObject> graphicObjects = new List<IGraphicObject>();
			graphicObjects.Add(new GraphicsSystem.GraphicsObjects.Rectangle(point, Color.Black, 2, new Geometry.Point(10,10)));
			context.AddRange(graphicObjects);
			context.Draw();
		}

		public void DrawLines(IPoint[] point) {
			List<IGraphicObject> graphicObjects = new List<IGraphicObject>();
			for (int i = 1; i < point.Length; i++) {
				if (i % 3 == 0) continue;
				graphicObjects.Add(new GraphicsSystem.GraphicsObjects.Line(point[i], Color.Black, 2, point[i-1], point[i]));
			}

			context.AddRange(graphicObjects);
			context.Draw();
		}

		public void DrawStart(IPoint point, IPoint direction) {
			List<IGraphicObject> graphicObjects = new List<IGraphicObject>();
			graphicObjects.Add(new GraphicsSystem.GraphicsObjects.Rectangle(point, Color.Black, 2, new Geometry.Point(10, 10)));
			context.AddRange(graphicObjects);
			context.Draw();
		}
		public void SetGraphicContext(IGraphicContext context) {
			this.context = context;
		}
	}
}
