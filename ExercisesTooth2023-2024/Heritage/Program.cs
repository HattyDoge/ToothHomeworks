namespace Heritage
{
    internal class Program
    {
        class A
        {
            int a;
            public A(int a) 
            {
                this.a = a; 
            }
        }
        class B : A
        {
            int b;
            public B(int b ,int a) : base(a)
            {
                this.b = b;
            }
        }
        class E : B 
        {
            int e;
            public E(int e, int b, int a) : base(b, a)
            {
                this.e = e;
            }
        }
        class F : B
        {
            public int f;
            public F(int f, int b, int a) : base(b, a)
            {
                this.f = f;
            }
        }
        class C : A
        {
            public int c;
            public C(int c, int a) : base(a)
            {
                this.c = c;
            }
        }
        class D : A
        {
            int d;
            public D(int d, int a) : base(a)
            {
                this.d = d;
            }
        }
        class G : D
        {
            int g;
            public G(int g,int d, int a) : base(d, a)
            {
                this.g = g;
            }
        }
        class I : G
        { 
            int i;
            public I(int i, int g, int d, int a) : base(g, d, a)
            {
                this.i = i;
            }
        }
        class L : G
        {
            public int l;
            public L(int l, int g, int d, int a) : base(g, d, a)
            {
                this.l = l;
            }
        }
        class H : D
        {
            int h;
            public H(int h, int d, int a) : base(d, a)
            {
                this.h = h;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}