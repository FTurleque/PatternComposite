namespace Ex_Expression.Class.Pattern.Composite
{
    public abstract class Binaire : Expression
    {
        public Expression op2 { get; set; }

        public Expression op1 { get; set; }

/*        public int Result { get; set; }
*/
        protected Binaire(Expression op1, Expression op2)
        {
            this.op2 = op2;
            this.op1 = op1;
        }

    }
}