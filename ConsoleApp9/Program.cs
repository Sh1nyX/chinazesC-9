namespace ConsoleApp9
{
	internal class Program
	{
		
		
		static void Main(string[] args)
		{
			//Task 1
			int x = 10, y = 20;
			Swap<int> swap = new Swap<int>(ref x, ref y);
			Console.WriteLine($"X = {x} Y = {y}");

			Console.WriteLine();

			//Task 4
			SingleLinkedList<int> singleList = new SingleLinkedList<int>();
			singleList.Add(1);
			singleList.Add(2);
			singleList.Add(3);
			Console.WriteLine($"Після додавання:  \n{singleList}");
			singleList.Remove(2);
			Console.WriteLine($"Після видалення 2:  \n{singleList}");

			Console.WriteLine();

			//Task 5
			DoubleLinkedList<int> doubleList = new DoubleLinkedList<int>();
			doubleList.Add(1);
			doubleList.Add(2);
			doubleList.Add(3);
			Console.WriteLine($"Після додавання: \n{doubleList}");
			doubleList.Remove(2);
			Console.WriteLine($"Після видалення 2:\n {doubleList}");

		}
	}
}
