namespace Operators
{
    class Rational : Object
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
            if (this.denominator < 0)   //  Normalizzazione
            {
                this.numerator = -numerator;
                this.denominator = -denominator;
            }
        }
        public Rational(int numerator) : this(numerator, 1) { }
        public Rational() : this(0, 1) { }
        
     /* static public Rational Sum(Rational r1, Rational r2) //vecchio metodo
        {
            return new Rational(r1.numerator * r1.denominator + r2.numerator * r2.denominator, r1.denominator * r2.denominator);
        } */
        public static Rational operator + (Rational r1, Rational r2) // Operator è molto intuitivo
        {
            return new Rational(r1.numerator * r1.denominator + r2.numerator * r2.denominator, r1.denominator * r2.denominator);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rational A = new Rational(2, 4);
            Rational B = new Rational(2, 5);
      //    Rational sum = Rational.Sum(A, B);
      //    Console.WriteLine(sum);
            Rational sum = A + B;
            Console.WriteLine(sum);
        }
    }
}