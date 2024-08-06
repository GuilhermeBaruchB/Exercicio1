using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Entrada de Dados
            double renda = double.Parse(txtRenda.Text);

            double energia = double.Parse(txtEnergia.Text);
            double agua = double.Parse(txtAgua.Text);
            double tv = double.Parse(txtTV.Text);
            double alimentacao = double.Parse(txtAlimentacao.Text);
            double outros = double.Parse(txtOutros.Text);

            //Processamento
            double gastos = energia + agua + tv + alimentacao + outros;
            double saldo = renda - gastos;

            //Saída de dados
            lblGastos.Text = gastos.ToString("C");
            lblSaldo.Text = saldo.ToString("C");
 
        }
    }
}
