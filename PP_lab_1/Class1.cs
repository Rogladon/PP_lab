using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_lab_1 {
	public interface Figure {
		int GetAngle();
		void Add(Figure figure);
		void Remove(Figure figure);
		Figure GetElement(int index);
	}
	public class Square : Figure {
		public void Add(Figure figure) {
			throw new NotImplementedException();
		}
		public int GetAngle() {
			return 4;
		}
		public Figure GetElement(int index) {
			return null;
		}
		public void Remove(Figure figure) {
			throw new NotImplementedException();
		}
	}
	//треугольник
	public class Triangle: Figure {
		public void Add(Figure figure) {
			throw new NotImplementedException();
		}
		public int GetAngle() {
			return 3;
		}
		public void Remove(Figure figure) {
			throw new NotImplementedException();
		}
		Figure Figure.GetElement(int index) {
			return null;
		}
	}
	//круг
	public class Circle : Figure {
		public void Add(Figure figure) {
			throw new NotImplementedException();
		}
		public int GetAngle() {
			return 0;
		}
		public Figure GetElement(int index) {
			return null;
		}
		public void Remove(Figure figure) {
			throw new NotImplementedException();
		}
	}
	//многоугольник
	public class Poligon : Figure {
		private int countAngle;
		//в конструкторе задается кол-во углов
		public Poligon(int countAngle) {
			this.countAngle = countAngle;
		}
		public void Add(Figure figure) {
			throw new NotImplementedException();
		}
		public int GetAngle() {
			return countAngle;
		}
		public Figure GetElement(int index) {
			return null;
		}
		public void Remove(Figure figure) {
			throw new NotImplementedException();
		}
	}


	public class Picture : Figure, IIterateFigure {
		private List<Figure> figures = new List<Figure>();
		Figure current;
		int index = 0;
		public Picture(List<Figure> figures) {
			this.figures = figures;
		}
		public void Add(Figure figure) {
			figures.Add(figure);
		}
		public int GetAngle() {
			int angle = 0;
			foreach(var i in figures) {
				angle += i.GetAngle();
			}
			return angle;
		}
		public Figure GetElement(int index) {
			return figures[index];
		}
		public void Remove(Figure figure) {
			figures.Remove(figure);
		}
		public void Iterate(Action<Figure> action) {
			foreach (var i in figures) {//проходим по всем фигурам из листа
				if (i is IIterateFigure) {//проеряем фигура наследуется от интерфейса IIteratorFigure
					(i as IIterateFigure).Iterate(action);//Если наследуется то это получается не 
					//лстовой еще объект, не последний и меет в себе другие объекты (в нашем случае значит)
					//что это рисонк внутри рисунка, поэтому мы для этого объекта тоже выполняем Iterate
					//Чтоб он в свою очередь перебрал все свои обекты
				} else {
					action(i);//Иначе это просто фигура и мы выполняем для не1 действие
				}
			}
		}

		//public bool Next() {
		//	if(figures.Count <= index) {
		//		Reset();
		//		return false;
		//	}
		//	if (figures[index] is IIterator) {
		//		if((figures[index] as IIterator).Next()) {
		//			current = (figures[index] as IIterator).Currnet();
		//		} else {
		//			index++;
		//		}
		//	} else {
		//		current = figures[index];
		//		index++;
		//	}
		//	return true;
		//}
		//public Figure Currnet() {
		//	return current;
		//}
		//public void Reset() {
		//	index = 0;
		//	current = null;
		//}
	}
	//public interface IIterator {
	//	bool Next();
	//	Figure Currnet();
	//	void Reset();
	//}
	public interface IIterateFigure {
		void Iterate(Action<Figure> action);
	}

	class Programm {
		static void Main() {
			Figure pict1 = new Picture(new List<Figure>() {
				new Square(),new Circle(),new Poligon(5)
			});
			Figure pict2 = new Picture(new List<Figure>() {
				new Triangle(),new Square(),new Poligon(10)
			});
			Picture pict = new Picture(new List<Figure>() {
				pict1,pict2
			});
			Console.WriteLine(pict.GetAngle());

			int count = 0;
			int sumAngle = 0;
			pict.Iterate(f => {
				count++;
				sumAngle += f.GetAngle();
			});
			Console.WriteLine($"Общее число листовых объектов:{count}");
			Console.WriteLine($"Сумма углов листовых объектов:{sumAngle}");
		}
	}
}
