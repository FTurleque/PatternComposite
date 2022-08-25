using System.Text;

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
            return Operation() + "=" + Evalue();
        }

        public override string Operation()
        {
            StringBuilder op = new StringBuilder();

            if (op1 is Binaire)
            {
                op.Append("(");
                op.Append(op1.Operation());
                op.Append(")");
            }
            else
            {
                op.Append(op1.Operation());
            }

            op.Append('-');

            if (op2 is Binaire)
            {
                op.Append("(");
                op.Append(op2.Operation());
                op.Append(")");
            }
            else
            {
                op.Append(op2.Operation());
            }

            return op.ToString();
        }

        public override string Formate2()
        {
            StringBuilder op = new StringBuilder();

            int resultOp1 = op1.Evalue();
            int numberDigit = resultOp1.ToString().Length;

            if (numberDigit == op1.Formate2().Length)
            {
                op.Append(op1.Operation());
            }
            else
            {
                op.Append(op1.Operation().Substring(0, op1.Operation().Length - numberDigit - 1));
            }
            op.Append('-');
            if (numberDigit == op2.Formate2().Length)
            {
                op.Append(op2.Operation());
            }
            else
            {
                op.Append(op2.Operation().Substring(0, op2.Operation().Length - numberDigit - 1));
            }

            op.Append('=');
            op.Append(Evalue());

            return op.ToString();
        }
    }
}

