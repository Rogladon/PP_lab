using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svg;

namespace GraphicsSystem.GraphicsObjects {
	/// <summary>
	/// Путь по точкам, состоит из линий от точки до точки
	/// </summary>
	public class Patch : IGraphicObject {
		#region Properties
		public IPoint Position { get; set; }
		public System.Drawing.Color Color { get; set; }
		public float WidthPen { get; set; }
		public List<IPoint> Pathc { get; set; }
		public IDraw Draw { get; private set; }
		#endregion
		public Patch() {
			Initialize(new Point(0, 0), System.Drawing.Color.Black, 1f, new List<IPoint>());
		}

		public Patch(IPoint position, System.Drawing.Color color, float widthPen, List<IPoint> patch) {
			Initialize(position, color, widthPen, patch);
		}
		private void Initialize(IPoint position, System.Drawing.Color color, float widthPen, List<IPoint> patch) {
			Position = position;
			Color = color;
			WidthPen = widthPen;
			Pathc = patch;
			Draw = new DrawPatch(this);
		}
	}
	public partial class DrawPatch : IDraw {
		private Patch patch;
		public DrawPatch(Patch circle) {
			this.patch = circle;
		}
		public void Draw(System.Drawing.Graphics g) {
			System.Drawing.Pen brush = new System.Drawing.Pen(patch.Color, patch.WidthPen);
			g.DrawLines(brush, patch.Pathc.Select(p => new System.Drawing.PointF((float)p.X, (float)p.Y)).ToArray());
		}
		public void Draw(Svg.SvgDocument doc) {
			for(int i = 1; i< patch.Pathc.Count; i++) {
				Line l = new Line(patch.Position, patch.Color, patch.WidthPen, patch.Pathc[i - 1], patch.Pathc[i]);
				l.Draw.Draw(doc);
			}
		}
	}
}
