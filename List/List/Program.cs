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
		static void Read(List<Product> productsShop)
		{
            string[] linea = Console.ReadLine().Split("|");
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
		static void ProductWrite(List<Product> productsShop)
		{
			Console.WriteLine("Inserire un produttore");
			string producer = Console.ReadLine();
			int producerProductCount = 0;
			for(int i = 0; i < productsShop.Count; i++)
			{
				if (productsShop[i].producer == producer)
					producerProductCount++;
			}
			Console.WriteLine($"Il numero dei prodotti che {producer} ha sono {producerProductCount}");
		}
		static void NameWrite()
		{

		}
		static void CodeWrite()
		{

		}
		static void TypeWrite()
		{

		}
		static void WriteInFile()
		{

		}
		static void ReadFromFile() 
		{
			
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