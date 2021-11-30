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
	public class DrawScheme1 : IDrawScheme {
		private IGraphicContext context;
		public DrawScheme1(IGraphicContext graphic) {
			context = graphic;
		}
		public void DrawEnd(IPoint point, IPoint direction) {
			List<IGraphicObject> graphicObjects = new List<IGraphicObject>();
			direction = direction.Normalize().Multiple(10);
			IPoint a1 = new Geometry.Point(
				direction.X * Math.Cos(0.5) - direction.Y * Math.Sin(0.5),
				direction.X * Math.Sin(0.5) + direction.Y * Math.Cos(0.5)
				);
			IPoint a2 = new Geometry.Point(
				direction.X * Math.Cos(-0.5) - direction.Y * Math.Sin(-0.5),
				direction.X * Math.Sin(-0.5) + direction.Y * Math.Cos(-0.5)
				);
			graphicObjects.Add(new GraphicsSystem.GraphicsObjects.Line(point, Color.Red, 2, point,a1.Plus(point)));
			graphicObjects.Add(new GraphicsSystem.GraphicsObjects.Line(point, Color.Red, 2, point,a2.Plus(point)));
			context.AddRange(graphicObjects);
			context.Draw();
		}

		public void DrawLines(IPoint[] point) {
			List<IGraphicObject> graphicObjects = new List<IGraphicObject>();
			graphicObjects.Add(
					new GraphicsSystem.GraphicsObjects.Patch(
						point[0], Color.Green, 2, point.ToList()));
			context.AddRange(graphicObjects);
			context.Draw();
		}

		public void DrawStart(IPoint point, IPoint direction) {
			List<IGraphicObject> graphicObjects = new List<IGraphicObject>();
			graphicObjects.Add(new Circle(point, Color.Green, 1, 5));
			context.AddRange(graphicObjects);
			context.Draw();
		}

		public void SetGraphicContext(IGraphicContext context) {
			this.context = context;
		}
	}
}
