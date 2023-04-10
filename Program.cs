using System;

namespace task_6
{
	class Program
	{
		static void Main(string[] args)
		{
			int pictures = 52;
			int picturesInRow = 3;
			int rows = pictures / picturesInRow;
			int remains = pictures % picturesInRow;
			Console.WriteLine($"полных рядов - {rows}; останется картинок - {remains}");
		}
	}
}
