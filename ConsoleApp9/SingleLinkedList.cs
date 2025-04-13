using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
	internal class SingleLinkedList<T> //я робив тут поміточкі але то для себе щоб розібратися як все працює бо я заплутався спочатку (виглядає ніби це на екзамен проект хпхп) 
	{
		private class Node
		{
			public T Data; //це теперішнє значення нашого списку
			public Node Next; //це посилання на наступний елемент списку

			public Node(T data) 
			{
				Data = data;
				Next = null; //це тому що спочатку наступного вузла не існує
			}
		}

		private Node _head; //це початок списку

		public void Add(T item)
		{
			Node node = new Node(item); //тута створюється нова нода яка зберігає нове значення ітем

			if (_head == null) //якщо список порожній (перший елемент нулл) то нода стає першим елементом
			{
				_head = node;
			}
			else
			{
				Node current = _head; //створюємо штучку яка перебирає список з самого початку 
				while(current.Next != null) //перебираємо список поки наступний елемент не буде нулл тобто список закінчився
				{
					current = current.Next; //ну й тут ми робимо з теперішнього елементу наступний і у наступному рядку присвоюємо значення нове новому елементу
				}
				current.Next = node;
			}
		}

		public bool Remove(T item)
		{
			if (_head == null) //якщо список порожній то одразу фолс 
				return false;

			//я намагався робити тут по іншому спочатку, але "==" недоступний для шаблонів тому інакше ніяк тут було тобто якщо має значення елемент перший то...
			if (_head.Data.Equals(item)) //тут якщо ми хочемо видалити перший елемент то просто зрізаємо його (присвоюємо йому значення наступного) і ретьорн тру
			{
				_head = _head.Next;
				return true;
			}

			Node current = _head; //інакше ми знову створюємо систему пошуку та фігачімося по списку поки не знайдемо
			while(current.Next != null && !current.Next.Data.Equals(item)) //тут ми саме шукаємо некст тому й в умові у нас некст 
				current = current.Next;

			if (current.Next == null) //якщо некст нуолл то всьо
				return false; 

			current.Next = current.Next.Next; //тут воно працює так, шо якщо у нас є "1" "2" "3" і нам потрібно видалити 2, то ми просто переносимо "1" на адресу "3" і 2 зникає
			return true; 


		}

		public override string ToString() //тутонькі ми просто як сігми проходимось знов по списку та кожне значення фігачімо у стрінг який потім повертаємо
		{
			Node current = _head;
			string result = "";
			while (current != null) //ось умова на закінчення списку :3
			{
				result += current.Data + " -> ";
				current = current.Next;
			}
			return result;
		}


	}
}
