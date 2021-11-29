using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GraphicsSystem.GraphicsObjects;

namespace GraphicsSystem {
	/// <summary>
	/// Класс контекста windosForm
	/// </summary>
	public class WinFormGraphics : AGraphicContext<Graphics> {
		public WinFormGraphics(Graphics graphics) : base(graphics) { }
		public override void Draw() {
			foreach(var i in this) {
				i.Draw.Draw(context);
			}
		}
	}
}
