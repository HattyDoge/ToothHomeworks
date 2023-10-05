namespace EquazioniSecondoGrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = 2;
            double c = -3;
            double delta = b * b - 4.0 * a * c;
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"x1 = {x1}; x2 = {x2}");

            double Q;       // metodo precisio
            if (b >= 0 ) 
                Q = (b + Math.Sqrt(delta)) / 2;
            else
                Q = (b - Math.Sqrt(delta)) / 2;
            x1 = Q / a;     // metodo precisio
            x2 = c / Q;     // metodo precisio
            Console.WriteLine($"x1 = {x1}; x2 = {x2}");
        }
    }
}