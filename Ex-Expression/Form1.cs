namespace Ex_Expression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNombres_Click(object sender, EventArgs e)
        {
            Button btnClick = (Button)sender;
            string result = btnClick.Text;
            txtBoxDisplay.Text += result;
            if (txtBoxDisplay.Text.ToCharArray()[-1] == '+' || 
                txtBoxDisplay.Text.ToCharArray()[-1] == '-')
            {

            }
        }

        private void Calcul_Click(object sender, EventArgs e)
        {
            string result = txtBoxDisplay.Text;
            string[] operateur = result.Split();
            string[] nbr = result.Split(new Char[] {'+', '-'}, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}