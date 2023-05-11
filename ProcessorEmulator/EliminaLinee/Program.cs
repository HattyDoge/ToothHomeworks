namespace EliminaLinee
{
	internal class Program
	{
		static void Main(string[] args)
		{
			using (StreamReader sr = new StreamReader(@"..\..\..\file.txt"))
			{
				while (!sr.EndOfStream) 
				{ 
					string linea = sr.ReadLine();
					bool lineaNo = false;
					try
					{
						if (int.Parse(linea) > 256)
							lineaNo = true;
					}
					catch (Exception e) { }
					if (!lineaNo) 
					{
						Console.Write(linea+ " ");
					}
				}
			}
		}
	}
}