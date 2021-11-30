using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visual;
using Geometry;
using Svg;
using GraphicsSystem;
using System.IO;

namespace PP_lab_1 {
	public partial class Form1 : Form {
		IGraphicContext svgContext;
		IGraphicContext winContext1;
		IGraphicContext winContext2;
		Random rnd = new Random();

		#region Initialize
		public Form1() {
			InitializeComponent();
			
		}

		void InitCurve() {
			if (winContext1 == null) {
				Graphics g = pictureBox.CreateGraphics();
				winContext1 = new WinFormGraphics(g);
			}
			if(winContext2 == null) {
				Graphics g2 = pictureBox1.CreateGraphics();
				winContext2 = new WinFormGraphics(g2);
			}
			if (svgContext == null) {
				SvgDocument doc = new SvgDocument();
				svgContext = new SvgGraphics(doc);
			}
		}
		#endregion

		#region ButtonClick
		private void generate2_Click(object sender, EventArgs e) {
			if (winContext1 == null || winContext2 == null) InitCurve();
			var curve = GenerateCurve();
			curve.Draw();
			curve.SetDrawScheme(new DrawScheme2(winContext2));
			curve.Draw();
		}
		private void save1_Click(object sender, EventArgs e) {
			SaveSvg(winContext1);
		}

		private void save2_Click(object sender, EventArgs e) {
			SaveSvg(winContext2);
		}
		#endregion
		private VisualCurve GenerateCurve() {
			return new VisualCurve(new Bezier(RandomPoint, RandomPoint, RandomPoint, RandomPoint), new DrawScheme1(winContext1),100);
		}
		private void SaveSvg(IGraphicContext context) {
			if (svgContext == null) InitCurve();
			svgContext.AddRange(context);
			svgContext.Draw();
			var doc = (svgContext as SvgGraphics).Context;
			StreamWriter w = new StreamWriter("svg.svg");
			w.Write(doc.GetXML());
			w.Close();
		}
		private Geometry.Point RandomPoint => new Geometry.Point(
			rnd.Next(0, pictureBox.Width), 
			rnd.Next(0, pictureBox.Height));
		
	}
}
