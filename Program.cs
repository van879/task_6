using System;

namespace task_6
{
	class Program
	{
		static void Main(string[] args)
		{
			int pictures = 52;
			int picturesInRow = 3;
			int rowsOfPictures = pictures / picturesInRow;
			int remainsOfPictures = pictures % picturesInRow;

			Console.WriteLine($"полных рядов - {rowsOfPictures}; останется картинок - {remainsOfPictures}");
		}
	}
}
