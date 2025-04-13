using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
	public class Swap<T>
	{
		private T temp; 
		public Swap(ref T x, ref T y)
		{
			temp = x;
			x = y;
			y = temp;
		}
	}
}
