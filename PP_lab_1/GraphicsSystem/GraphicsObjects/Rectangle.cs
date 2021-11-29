using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svg;

namespace GraphicsSystem.GraphicsObjects {
	/// <summary>
	/// Прямоугольник
	/// </summary>
	public class Rectangle : IGraphicObject {
		#region Properties
		public IPoint Position { get; set; }
		public System.Drawing.Color Color { get; set; }
		public float WidthPen { get; set; }
		public IPoint Size { get; set; }
		public IDraw Draw { get; private set; }
		#endregion
		public Rectangle() {
			Position = new Point(0, 0);
			Color = System.Drawing.Color.Black;
			WidthPen = 1f;
			Size = new Point(1,1);
		}

		public Rectangle(IPoint position, System.Drawing.Color color, float widthPen, IPoint size) {
			Initialize(position, color, widthPen, size);
		}
		private void Initialize(IPoint position, System.Drawing.Color color, float widthPen, IPoint size) {
			Position = position;
			Color = color;
			WidthPen = widthPen;
			Size = size;
			Draw = new DrawRectangle(this);
		}
	}
	public partial class DrawRectangle : IDraw {
		private Rectangle rect;
		public DrawRectangle(Rectangle rect) {
			this.rect = rect;
		}
		public void Draw(System.Drawing.Graphics g) {
			System.Drawing.Pen pen = new System.Drawing.Pen(rect.Color, rect.WidthPen);
			g.FillRectangle(pen.Brush, (float)(rect.Position.X-rect.Size.X/2), (float)(rect.Position.Y-rect.Size.Y / 2), (float)rect.Size.X, (float)rect.Size.Y);
		}
		public void Draw(Svg.SvgDocument doc) {
			SvgRectangle svg = new SvgRectangle();
			svg.StrokeWidth = rect.WidthPen;
			svg.X = new SvgUnit((float)(rect.Position.X-rect.Size.X/2));
			svg.Y = new SvgUnit((float)(rect.Position.Y-rect.Size.Y/2));
			svg.Width = new SvgUnit((float)rect.Size.X);
			svg.Height = new SvgUnit((float)rect.Size.Y);
			svg.Fill = new SvgColourServer(rect.Color);
			doc.Children.Add(svg);
		}
	}
}
