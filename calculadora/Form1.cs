using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        private double acumulador = 0;
        private char ultimaOperacao;

        public Form1()
        {
            InitializeComponent();
        }

        private void botaoCE_Pressed(object sender, EventArgs e)
        {
            Display.Text = "";
        }


        private void operador_Pressed(object sender, EventArgs e)
        {
            char operacao = (sender as Button).Text[0];
            double operacaoAtual = double.Parse(Display.Text);
            switch (ultimaOperacao)
            {
                case '+': 
                    acumulador += operacaoAtual; 
                    break;
                case '-':
                    acumulador -= operacaoAtual; 
                    break;
                case '×':
                    acumulador *= operacaoAtual; 
                    break;
                case '÷':
                    acumulador /= operacaoAtual; 
                    break;
                default:
                    acumulador = operacaoAtual; 
                    break;
            }

            ultimaOperacao = operacao;
            Display.Text = operacao == '=' ? acumulador.ToString() : "";
        }

        private void valor_Pressed(object sender, EventArgs e)
        {
            string valor = (sender as Button).Text;
            Display.Text = Display.Text == "0" ? valor : Display.Text + valor;
        }
    }
}
