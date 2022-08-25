using Ex_Expression.Class.Pattern.Composite;

namespace Ex_Expression
{
    public partial class Form1 : Form
    {
        private bool newCalcul = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNombres_Click(object sender, EventArgs e)
        {
            if (newCalcul)
            {
                txtBoxDisplay.Clear();
                newCalcul = false;
            }

            Button btnClick = (Button)sender;
            string result = btnClick.Text;
            if ((result == "+" || result == "-") && (txtBoxDisplay.Text.EndsWith('+') ||
                txtBoxDisplay.Text.EndsWith('-')))
            {
                char[] tmp = txtBoxDisplay.Text.ToCharArray();
                txtBoxDisplay.Text = txtBoxDisplay.Text.Replace(tmp[tmp.Length - 1],
                    Convert.ToChar(result));
            }
            else
            {
                txtBoxDisplay.Text += result;
            }
        }

        private void Calcul_Click(object sender, EventArgs e)
        {
            List<char> operatorList = new List<char>();
            List<Nombre> exps = new List<Nombre>();

            if (txtBoxDisplay.Text.EndsWith('+') ||
                txtBoxDisplay.Text.EndsWith('-'))
            {
                txtBoxDisplay.Text = txtBoxDisplay.Text.Substring(0, txtBoxDisplay.Text.Length - 1);
            }
            char[] exp = txtBoxDisplay.Text.ToCharArray();
            foreach (char item in exp)
            {
                if (item == '+' || item == '-')
                {
                    operatorList.Add(item);
                }
            }
            string[] nbr = txtBoxDisplay.Text.Split(new Char[] {'+', '-'}, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in nbr)
            {
                exps.Add(new Nombre(int.Parse(item)));
            }
            int result = exps[0].Evalue();

            for (int i = 0; i < operatorList.Count; ++i)
            {
                Nombre nb = new Nombre(result);
                result = GetOperationType(operatorList[i], nb, exps[i + 1]);
            }

            txtBoxDisplay.Text += '=' + result.ToString();
            newCalcul = true;
        }

        private int GetOperationType(char _op, Expression op1, Expression op2)
        {
            switch (_op)
            {
                case '+':
                    Addition addition = new Addition(op1, op2);
                    return addition.Evalue();
                case '-':
                    Soustraction soustraction = new Soustraction(op1, op2);
                    return soustraction.Evalue();
                default:
                    return 0;
            }
        }
    }
}