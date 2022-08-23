namespace Ex_Expression.Class
{
    public abstract class Binaire : Expression
    {
        public Expression op2 { get; set; }

        public Expression op1 { get; set; }

        protected Binaire(Expression op2, Expression op1)
        {
            this.op2 = op2;
            this.op1 = op1;
        }

    }
}