namespace Ex_Expression.Class.Pattern.Composite
{
    public class Soustraction : Binaire
    {
        public Soustraction(Expression op1, Expression op2) : base(op1, op2)
        {
        }

        public override int Evalue()
        {
            return op1.Evalue() - op2.Evalue();
        }

        public string ToString()
        {
            return Evalue().ToString();
        }

        public override string Formate()
        {
            Result = Evalue();
            return op1.Formate() + "-" + op2.Formate();
        }
    }
}
