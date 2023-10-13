namespace ExGeometry
{
    internal class Program
    {
        class Rettangolo
        {
            double x;
            double y;
            double larghezza;
            double altezza;
            public Rettangolo(double x, double y, double larghezzaX2, double altezzaX1, bool HeightLength)
            {
                if (HeightLength)
                {
                    this.x = x;
                    this.y = y;
                    this.altezza = altezzaX1;
                    this.larghezza = larghezzaX2;
                }
                else
                {
                    this.x = x;
                    this.y = y;
                    altezza = y - altezzaX1;
                    larghezza = x - larghezzaX2;
                }
            }
            public Rettangolo()
            {
                this.x = 0;
                this.y = 0;
                this.altezza = 0;
                this.larghezza = 0;
            }
            public Rettangolo(Point p0, Point p1) // punti agli estremi
            {
                x = p0.X;
                y = p0.Y;
                altezza = y - p1.Y;
                larghezza = x - p1.X;
            }
            public double X { get { return this.x; } set { this.x = value; } }
            public double Y { get { return this.y; } set { this.y = value; } }
            public double Length
            {
                get { return this.larghezza; }
                set
                {
                    if (value < 0)
                    {
                        x -= value;
                        this.larghezza = Math.Abs(value);
                    }
                    else
                        this.larghezza = value;
                }
            } //non può essere negativa
            public double Height
            {
                get { return this.altezza; }
                set
                {
                    if (value < 0)
                    {
                        this.y -= value;
                        this.altezza = Math.Abs(value);
                    }
                    else
                        this.altezza = value;
                }
            } //non può essere negativa

        }
        class Point
        {
            double x;
            double y;
            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public Point()
            {
                this.x = 0;
                this.y = 0;
            }
            public double X { get { return this.x; } set { this.x = value; } }
            public double Y { get { return this.y; } set { this.y = value; } }
            public void Sposta(Vectorial v)
            {

            }
            public Vectorial Sottrazione(Point p)
            {
                return null;
            }
        }
        class Vectorial //Un punto è l'origine perchè i vettori sono liberi di muoversi in un grafico
        {
            double dx;
            double dy;
            public Vectorial(double dx, double dy)
            {
                this.dx = dx;
                this.dy = dy;
            }
            public Vectorial()
            {
                this.dx = 0;
                this.dy = 0;
            }
            public Vectorial(Point p0, Point p1)
            {
                this.dx = p1.X - p0.X;
                this.dy = p1.Y - p0.Y;
            }
            public double Dx { get { return this.dx; } set { this.dx = value; } }
            public double Dy { get { return this.dy; } set { this.dy = value; } }

            public Vectorial Somma()
            {
                return null; 
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}