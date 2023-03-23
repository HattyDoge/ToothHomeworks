using System.Runtime.CompilerServices;

namespace List
{
	internal class Program
	{
		struct Product
		{
			public int code;
			public string name;
			public string producer;
			public string type;
			public double price;
		}
		static void Main(string[] args)
		{
			string fileName = "..\\..\\Datafile";
			List<Product> productsShop = new List<Product>();
			using (StreamReader sr = new StreamReader(fileName))
			{
				while (!sr.EndOfStream)
				{
					string[] linea = sr.ReadLine().Split("|");
					for (int i = 0; i < linea.Length; i++)
					{
						Product p = new Product();
						p.code = int.Parse(linea[i]);
						p.name = linea[i];
						p.producer = linea[i];
						p.type = linea[i];
						p.price = double.Parse(linea[i]);
						
						productsShop.Add(p);
					}
				}
				sr.Close();
			}

		}
	}
}