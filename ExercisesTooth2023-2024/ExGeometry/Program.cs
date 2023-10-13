namespace ExGeometry
{
    internal class Program
    {
        class Rettangolo
        {
            private double x;
            private double y;
            private double length;
            private double height;
            public Rettangolo(double x, double y, double larghezzaX2, double altezzaX1, bool HeightLength)
            {
                if (!HeightLength)
                {
                    this.x = x;
                    this.y = y;
                    this.height = altezzaX1;
                    this.length = larghezzaX2;
                }
                else
                {
                    this.x = x;
                    this.y = y;
                    height = y - altezzaX1;
                    length = x - larghezzaX2;
                }
            }
            public Rettangolo()
            {
                this.x = 0;
                this.y = 0;
                this.height = 0;
                this.length = 0;
            }
            public Rettangolo(Point p0, Point p1) // punti agli estremi
            {
                x = p0.X;
                y = p0.Y;
                height = y - p1.Y;
                length = x - p1.X;
            }
            public double X { get { return this.x; } set { this.x = value; } }
            public double Y { get { return this.y; } set { this.y = value; } }
            public double Length
            {
                get { return this.length; }
                set
                {
                    if (value < 0)
                    {
                        x -= value;
                        this.length = Math.Abs(value);
                    }
                    else
                        this.length = value;
                }
            } //non può essere negativa
            public double Height
            {
                get { return this.height; }
                set
                {
                    if (value < 0)
                    {
                        this.y -= value;
                        this.height = Math.Abs(value);
                    }
                    else
                        this.height = value;
                }
            } //non può essere negativa
            public bool Contains(Point p)
            {
                if (x <= p.X && p.X <= x + length && y <= p.Y && p.Y <= y + height)
                    return true;
                return false;
            }
            public bool Contains(Rettangolo r)
            {
                if (x <= r.x && r.x <= x + length && y <= r.y && r.y <= y + height && x <= r.x + r.Length && r.x + r.Length <= x + length && y <= r.y + r.Height && r.y + r.Height <= y + height )
                        return true;
                return false;
            }
            public void Sposta(Vectorial v)
            {
                x += v.Dx; y += v.Dy;
            }
            public bool Sovrapposto(Rettangolo r)
            {
                if (x < r.x && r.x < x + length && y < r.y && r.y < y + height && x < r.x + r.Length && r.x + r.Length < x + length && y < r.y + r.Height && r.y + r.Height < y + height)
                    return false;
                return true;
            }
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
                x += v.Dx; y += v.Dy;
            }
            public Vectorial Sottrazione(Point p)
            {
                return new Vectorial (this.x - p.X, y - p.Y) ;
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
            public double Length { get { return Math.Sqrt( Math.Pow(this.dx, 2) * Math.Pow(this.dx, 2)); }}
            public Vectorial Somma(Vectorial v)
            {
                return new Vectorial(dx + v.dx, dy + v.dy);
            }

        }
        static void Main(string[] args)
        {
            Rettangolo A = new Rettangolo(10.0, 10.0, 5.0, 6.0, false);
            Rettangolo B = new Rettangolo(10.1, 10.1, 4.0, 5.0, false);
            if (A.Contains(B))
                Console.WriteLine("A contiene B");
            if (!B.Contains(A))
                Console.WriteLine("B non contiene A");
            if (A.Sovrapposto(B)) Console.WriteLine("B è sovrapposto ad A");
            B.X = 9.8; B.Y = 9.8;
            if (A.Sovrapposto(B)) Console.WriteLine("B è sovrapposto ad A");
            Console.ReadLine();
        }
    }
}