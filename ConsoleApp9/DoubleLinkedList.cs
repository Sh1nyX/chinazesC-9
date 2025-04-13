using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
	internal class DoubleLinkedList<T>
	{
		private class Node 
		{
			public T Data;
			public Node Next;
			public Node Prev; //тут додалося посилання на попередній елемент ОГОООО

			public Node(T data)
			{
				Data = data;
				Next = null;
				Prev = null;
			}
		}

		private Node _head;
		private Node _tail; //останній елемент списку карочє

		public void Add(T item)
		{
			Node node = new Node(item);

			if (_head == null) //тут по класікє якщо список порожній то просто оновлюємо всьо на нього
			{
				_head = node;
				_tail = node;
			}
			else 
			{
				_tail.Next = node; //інакше ми прив'язуємо ноду до кінця списку
				node.Prev = _tail; //останній елемент прив'язуємо до попереднього (я заплутався івардлівадр )
				_tail = node; //оновлюємо посилання на кінець списочку
			}
		}

		//тут може виникнути питання чому current.Next.Prev замість current але я зрозумів чому так всі писали і так варто писати і я ВІДІБ'Ю СВОЇ ПРАВА 
		//написано саме так тому шо як виявилося, якщо я взаємодію саме з каррентом то я взаємодію з тимчасовою змінною
		//а коли я взаємодію з current.Next.Prev то я взаємодію зі структурою списку, отож (я умній) 
		public bool Remove(T item)
		{
			if (_head == null) //класіка
				return false; 

			if(_head.Data.Equals(item)) //якщо перший елемент містисть значення то........................(>~<)
			{
				if (_head.Next != null)
					_head.Next.Prev = null; //звучить гарно але "оновлюємо попередній елемент наступного елементу" 
				_head = _head.Next; //переміщаємо хеад на наступний елемент (зрізаємо хехехехе) і вуаля ретьорн тру
				return true;
			}

			Node current = _head; //ой зараз шукати будемо
			while(current != null)
			{
				if(current.Data.Equals(item))
				{
					if (current.Next != null)
						current.Next.Prev = current.Prev; //тут оновлюється попередній елемент наступного
					if (current.Prev != null)
						current.Prev.Next = current.Next; //тут оновлюється наступний елемент попереднього
					if (current == _tail)
						_tail = current.Prev; //ну а якщо це був останній елемент то просто оновлюємо тейл
					return true;
				}
				current = current.Next;
			}
			return false;

		}
		public override string ToString() // 0 відмінностей від тустрінга в однозв'язному списочку
		{
			Node current = _head;
			string result = "";
			while (current != null) 
			{
				result += current.Data + " -> ";
				current = current.Next;
			}
			return result;
		}
	}


}
