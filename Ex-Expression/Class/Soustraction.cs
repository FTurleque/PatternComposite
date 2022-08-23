namespace Ex_Expression.Class
{
    public class Soustraction : Binaire
    {
        private int result;

        public Soustraction(Expression op2, Expression op1) : base(op2, op1)
        {
        }

        public override int Evalue()
        {
            result = op1.Evalue() > op2.Evalue() ? 
                op1.Evalue() - op2.Evalue() : 
                op2.Evalue() - op1.Evalue();
            return result;
        }

        public string ToString()
        {
            return this.result.ToString();
        }
    }
}
