namespace GeneretorFunctions
{
    internal class Program
    {
        interface IComeTiVoglioVedere
        {
            void CompitoImportantissimo();
        }

        class Base_A : IComeTiVoglioVedere
        {
            void IComeTiVoglioVedere.CompitoImportantissimo() { }
        }
        class Derivata_A : Base_A
        {

        }
        class Base_B : IComparable<Base_B>
        {
            int IComparable<Base_B>.CompareTo(Base_B? obj)
            {
                return 0;
            }
        }
        class Derivata_B : Base_B
        { 
        }
        static void Main(string[] args)
        {

        }
    }
}