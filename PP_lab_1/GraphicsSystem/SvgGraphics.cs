using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsSystem.GraphicsObjects;
using Svg;

namespace GraphicsSystem {
	/// <summary>
	/// Класс svg контекста
	/// </summary>
	public class SvgGraphics : AGraphicContext<SvgDocument> {
		public SvgGraphics(SvgDocument document) : base(document) { }
		public override void Draw() {
			foreach(var i in this) {
				i.Draw.Draw(context);
			}
		}
	}
}
