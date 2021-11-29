using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svg;

namespace GraphicsSystem.GraphicsObjects {
	/// <summary>
	/// Круг
	/// </summary>
	public class Circle : IGraphicObject {
		#region Properties
		public IPoint Position { get; set; }
		public System.Drawing.Color Color { get; set; }
		public float WidthPen { get; set; }
		/// <summary>
		/// Радиус
		/// </summary>
		public float Radius { get; set; }
		public IDraw Draw { get; private set; }
		#endregion

		public Circle() {
			Initialize(new Point(0, 0), System.Drawing.Color.Black, 1f, 1f);
		}

		public Circle(IPoint position, System.Drawing.Color color, float widthPen, float radius) {
			Initialize(position, color, widthPen, radius);
		}
		private void Initialize(IPoint position, System.Drawing.Color color, float widthPen, float radius) {
			Position = position;
			Color = color;
			WidthPen = widthPen;
			Radius = radius;
			Draw = new DrawCircle(this);
		}
	}
	public partial class DrawCircle : IDraw{
		private Circle circle;
		public DrawCircle(Circle circle) {
			this.circle = circle;
		}
		public void Draw(System.Drawing.Graphics g) {
			System.Drawing.Pen brush = new System.Drawing.Pen(circle.Color, circle.WidthPen);
			g.FillEllipse(brush.Brush, (float)circle.Position.X-circle.Radius, (float)circle.Position.Y- circle.Radius, circle.Radius * 2, circle.Radius * 2);
		}
		public void Draw(Svg.SvgDocument doc) {
			Svg.SvgCircle svg = new Svg.SvgCircle();
			svg.CenterX = new SvgUnit((float)circle.Position.X);
			svg.CenterY = new SvgUnit((float)circle.Position.Y);
			svg.Radius = circle.Radius;
			svg.Fill = new SvgColourServer(circle.Color);
			doc.Children.Add(svg);
		}
	}
}
