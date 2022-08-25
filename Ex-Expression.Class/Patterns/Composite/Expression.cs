namespace Ex_Expression.Class.Pattern.Composite
{
    public abstract class Expression
    {
        public static int Result { get; set; }

        public abstract int Evalue();

        public abstract string Formate();
    }
}