namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; } //propriedades
        private enum Operacao
        { 
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao

        }
        public Form1()
        {
            InitializeComponent();
        }


        private void botao0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void botao5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void botao6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void botao7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void botao8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void botaoDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void botaoMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void botaoSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void botaoAdicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void botaoVirgula_Click(object sender, EventArgs e)
        {
            if(!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";   
        }

        private void botaoIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;

                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;

                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;

                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
            }
            txtResultado.Text = Convert.ToString(Resultado);
        }
    }
}
