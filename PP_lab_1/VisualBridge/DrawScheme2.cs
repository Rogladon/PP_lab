using Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svg;
using GraphicsSystem.GraphicsObjects;

namespace VisualBridge {
	public class DrawScheme2 : IDrawScheme {
		public IEnumerable<IGraphicObject> DrawEnd(IPoint point, IPoint direction) {
			List<IGraphicObject> graphicObjects = new List<IGraphicObject>();
			graphicObjects.Add(new GraphicsSystem.GraphicsObjects.Rectangle(point, Color.Black, 2, new Geometry.Point(10,10)));
			return graphicObjects;
		}

		public IEnumerable<IGraphicObject> DrawLines(IPoint[] point) {
			List<IGraphicObject> graphicObjects = new List<IGraphicObject>();
			for (int i = 1; i < point.Length; i++) {
				if (i % 3 == 0) continue;
				graphicObjects.Add(new GraphicsSystem.GraphicsObjects.Line(point[i], Color.Black, 2, point[i-1], point[i]));
			}

			return graphicObjects;
		}

		public IEnumerable<IGraphicObject> DrawStart(IPoint point, IPoint direction) {
			List<IGraphicObject> graphicObjects = new List<IGraphicObject>();
			graphicObjects.Add(new GraphicsSystem.GraphicsObjects.Rectangle(point, Color.Black, 2, new Geometry.Point(10, 10)));
			return graphicObjects;
		}
	}
}
