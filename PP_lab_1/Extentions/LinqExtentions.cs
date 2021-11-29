using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Linq {
	public static class LinqExtentions {
		public static IEnumerable<T> ForEach<T>(this IEnumerable<T> en, Action<T> action) {
			foreach (var i in en) {
				action(i);
			}
			return en;
		}
	}
}