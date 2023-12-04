namespace ExpressionEvaluator
{
    enum TokenTypes
    {
        ConstValue,
        LBra,       // (
        RBra,       // )
        OpPlus,     // +
        OpMinus,    // -
        OpMult,     // *
        OpDiv,      // /
        OpMod       // %
    }
    class Token
    {
        public TokenTypes Type { get; private set; }
        public double Value { get; private set; }   // valido se .Type == ConstValue
        public Token(TokenTypes type, double value)
        {
            Type = type;
            Value = value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {


        }
    }
}