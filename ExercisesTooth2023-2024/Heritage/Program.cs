namespace Heritage
{
    internal class Program
    {
        class A
        {
            int a;
            public int defineA { get { return a; } set { a = value; } }
            public A(int a) 
            {
                this.a = a; 
            }
            public void Stampa() { Console.WriteLine($"Sono A e a = {a}"); }
        }
        class B : A
        {
            int b;
            public int defineB { get { return b; } set { b = value; } }
            public B(int b ,int a) : base(a)
            {
                this.b = b;
            }
            public void Stampa() { Console.WriteLine($"Sono B e b = {b}"); } // overload funzionerà solamente per l'istanza creata
        }
        class E : B 
        {
            int e;
            public int defineE { get { return e; } set { e = value; } }
            public E(int e, int b, int a) : base(b, a)
            {
                this.e = e;
            }
        }
        class F : B
        {
            public int f;
            public int defineF { get { return f; } set { f = value; } }
            public F(int f, int b, int a) : base(b, a)
            {
                this.f = f;
            }
        }
        class C : A
        {
            public int c;
            public int defineC { get { return c; } set { c = value; } }
            public C(int c, int a) : base(a)
            {
                this.c = c;
            }
        }
        class D : A
        {
            int d;
            public int defineD { get { return d; } set { d = value; } }
            public D(int d, int a) : base(a)
            {
                this.d = d;
            }
        }
        class G : D
        {
            int g;
            public int defineG { get { return g; } set { g = value; } }
            public G(int g,int d, int a) : base(d, a)
            {
                this.g = g;
            }
        }
        class H : D
        {
            int h;
            public int defineH { get { return h; } set { h = value; } }
            public H(int h, int d, int a) : base(d, a)
            {
                this.h = h;
            }
        }
        class I : G
        { 
            int i;
            public int defineI { get { return i; } set { i = value; } }
            public I(int i, int g, int d, int a) : base(g, d, a)
            {
                this.i = i;
            }
        }
        class L : G
        {
            public int l;
            public int defineL { get { return l; } set { l = value; } }
            public L(int l, int g, int d, int a) : base(g, d, a)
            {
                this.l = l;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}