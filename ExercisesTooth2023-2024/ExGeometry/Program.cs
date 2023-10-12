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
            public Rettangolo(Punto p0, Punto p1) // punti agli estremi
            {
                x = p0.X;
                y = p0.Y;
                altezza = y - p1.Y;
                larghezza = x - p1.X;
            }
            public double X { get { return this.x; } set { this.x = value; } }
            public double Y { get { return this.y; } set { this.y = value; } }
            public double Length { get { return this.larghezza; } 
                set 
                { 
                    if(value < 0)
                    {

                    }
                    else
                        this.larghezza = value; 
                } 
            } //non può essere negativa
            public double Height { get { return this.altezza; }
                set
                {
                    if (value < 0)
                    {

                    }
                    else
                        this.altezza = value;
                }
            } //non può essere negativa
            class Punto
            {
                double x;
                double y;
                public Punto(double x, double y)
                {
                    this.x = x;
                    this.y = y;
                }
                public Punto()
                {
                    this.x = 0;
                    this.y = 0;
                }
                public double X { get { return this.x; } set { this.x = value; } }
                public double Y { get { return this.y; } set { this.y = value; } }

                public void Sposta(Vettore v)
                {

                }
                public Vettore Sottrazione()
                {

                }
            }
        class Vettore //Un punto è l'origine perchè i vettori sono liberi di muoversi in un grafico
        {
            double dx;
            double dy;
            public Vettore (double dx, double dy)
            {
                this.dx = dx;
                this.dy = dy;
            }
            public Vettore ()
            {
                this.dx = 0;
                this.dy = 0;
            }
            public Vettore(Punto p0, Punto p1)
            { 

            }
            public double Dx { get { return this.dx; } set { this.dx = value; } }
            public double Dy { get { return this.dy; } set { this.dy = value; } }

            public Vettore Somma()
            {

            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}