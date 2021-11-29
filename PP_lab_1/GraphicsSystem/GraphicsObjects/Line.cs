using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svg;

namespace GraphicsSystem.GraphicsObjects {
	/// <summary>
	/// Прямая линия от a до b
	/// </summary>
	public class Line : IGraphicObject {
		#region Properties
		public IPoint Position { get; set; }
		public System.Drawing.Color Color { get; set; }
		public float WidthPen { get; set; }
		public IPoint StartPoint { get; set; }
		public IPoint EndPoint { get; set; }
		public IDraw Draw { get; private set; }
		#endregion

		public Line() {
			Initialize(new Point(0, 0), System.Drawing.Color.Black, 1f, new Point(-1, -1), new Point(1, 1));
		}

		public Line(IPoint position, System.Drawing.Color color, float widthPen, IPoint start, IPoint end) {
			Initialize(position, color, widthPen, start, end);
		}
		private void Initialize(IPoint position, System.Drawing.Color color, float widthPen, IPoint start, IPoint end) {
			Position = position;
			Color = color;
			WidthPen = widthPen;
			StartPoint = start;
			EndPoint = end;
			Draw = new DrawLine(this);
		}
	}
	public partial class DrawLine : IDraw {
		private Line line;
		public DrawLine(Line line) {
			this.line = line;
		}
		public void Draw(System.Drawing.Graphics g) {
			System.Drawing.Pen pen = new System.Drawing.Pen(line.Color, line.WidthPen);
			g.DrawLine(pen, PointConverter.GeometryToWinDraw(line.StartPoint), PointConverter.GeometryToWinDraw(line.EndPoint));
		}
		public void Draw(Svg.SvgDocument doc) {
			SvgLine svg = new SvgLine();
			svg.StrokeWidth = line.WidthPen;
			svg.FillRule = SvgFillRule.EvenOdd;
			svg.Color = new SvgColourServer(line.Color);
			svg.StartX = new SvgUnit((float)line.StartPoint.X);
			svg.StartY = new SvgUnit((float)line.StartPoint.Y);
			svg.EndX = new SvgUnit((float)line.EndPoint.X);
			svg.EndY = new SvgUnit((float)line.EndPoint.Y);
			svg.Stroke = new SvgColourServer(line.Color);
			doc.Children.Add(svg);
		}
	}
}