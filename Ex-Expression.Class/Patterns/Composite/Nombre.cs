namespace Ex_Expression.Class.Pattern.Composite
{
    public class Nombre : Expression
    {
        private int valeur;

        public Nombre(int valeur)
        {
            this.valeur = valeur;
        }

        public override int Evalue()
        {
            return this.valeur;
        }

        public string ToString()
        {
            return Evalue().ToString();
        }

        public override string Formate()
        {
            return Operation();
        }

        public override string Operation()
        {
            return ToString();
        }

        public override string Formate2()
        {
            return Operation();
        }
    }
}