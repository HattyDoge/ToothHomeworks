using System.Drawing;

namespace Operators
{
    class Rational : Object, IComparable<Rational>
    {
        public override string ToString()
        {
            if (denominator == 1)
                return numerator.ToString();
            if (numerator == 0)
                return "0";
            return $"{numerator}/{denominator}";
        }
        int numerator, denominator; // Sarà sempre ( denominator > 0 )
        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException();
            this.numerator = numerator;
            this.denominator = denominator;

            Normalize();
        }
        public Rational(int numerator) : this(numerator, 1) { }
        public Rational() : this(0, 1) { }
        
     /* static public Rational Sum(Rational r1, Rational r2) //vecchio metodo
        {
            return new Rational(r1.numerator * r1.denominator + r2.numerator * r2.denominator, r1.denominator * r2.denominator);
        } */
        public static Rational operator + (Rational r1, Rational r2) // Operator è molto intuitivo
        {
            return new Rational(r1.numerator * r2.denominator + r2.numerator * r1.denominator, r1.denominator * r2.denominator);
        }
        public static Rational operator - (Rational r1, Rational r2)
        {
            return new Rational(r1.numerator * r2.denominator - r2.numerator * r1.denominator, r1.denominator * r2.denominator);
        }
        public static Rational operator * (Rational r1, Rational r2)
        {
            return new Rational(r1.numerator * r2.numerator, r1.denominator * r2.denominator);
        }
        public static Rational operator / (Rational r1, Rational r2)
        {
            return new Rational(r1.numerator * r2.denominator, r1.denominator * r2.numerator);
        }
        public static explicit operator double (Rational r)
        {
            return (double)r.numerator / r.denominator;
        }
        public override bool Equals(Object? obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Rational)) // is as
                return false;
            return this == (Rational)obj;
        }
        public int CompareTo(Rational? other)
        {
            return numerator * other.numerator - numerator * other.denominator;
        }
        public static bool operator < (Rational r_sx, Rational r_dx) { return r_sx.CompareTo(r_dx) < 0; }
        public static bool operator <= (Rational r_sx, Rational r_dx) { return r_sx.CompareTo(r_dx) <= 0; }
        public static bool operator == (Rational r_sx, Rational r_dx) { return r_sx.CompareTo(r_dx) == 0; }
        public static bool operator != (Rational r_sx, Rational r_dx) { return r_sx.CompareTo(r_dx) != 0; }
        public static bool operator > (Rational r_sx, Rational r_dx) { return r_sx.CompareTo(r_dx) > 0; }
        public static bool operator >= (Rational r_sx, Rational r_dx) { return r_sx.CompareTo(r_dx) >= 0; }
        void Normalize()
        {
            if (this.denominator < 0)   //  Normalizzazione
            {
                this.numerator = -numerator;
                this.denominator = -denominator;
            }

            int mcd = Euclide(denominator, numerator);
            numerator /= mcd;
            denominator /= mcd;
        }
        int Euclide(int a, int b) // prototipo della funzione Euclide //
        {
            int r;
            while (b != 0) //ripetere finché non riduciamo a zero
            {
                r = a % b;
                a = b;
                b = r; //scambiamo il ruolo di a e b
            }
            return a; //... e quando b è (o è diventato) 0, il risultato è a
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rational A = new Rational(2, 4);
            Rational B = new Rational(2, 5);
            Console.WriteLine(A);
            //    Rational sum = Rational.Sum(A, B);
            //    Console.WriteLine(sum);
            Rational sum = A + B;
            Console.WriteLine(sum);
            Console.WriteLine((double)sum); // (double) <-- explicit ( lo può fare anche implicit )
            Console.WriteLine($"Il valore più piccolo fra {A} e {B} {(A < B ? A : B)}");  // ( in parentesi perchè sennò la interpreterebbe come un modo di trascrivere i valori)

            List<Rational> l = new List<Rational>();
            foreach (Rational r in l)
            {
                Console.Write($"{r}, ");
            }
            Console.WriteLine();
            l.Sort();
            foreach (Rational r in l)
            {
                Console.Write($"{r}, ");
            }
        }
    }
}