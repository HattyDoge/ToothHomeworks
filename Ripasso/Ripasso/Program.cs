using System.IO;

namespace Ripasso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\TempInput";
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.CreateNew)))
            {
                sw.WriteLine("This");
                sw.WriteLine("is some text");
                sw.WriteLine("to test");
                sw.WriteLine("reading");
            }

            using (StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open)))
            {
                while (sr.Peek() >= 0)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
    }
}