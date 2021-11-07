using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double _numero1;
        double resultado;
        char operador;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
            AdicionaNumero(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
            AdicionaNumero(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
            AdicionaNumero(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
            AdicionaNumero(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
            AdicionaNumero(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
            AdicionaNumero(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
            AdicionaNumero(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
            AdicionaNumero(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
            AdicionaNumero(9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            lblCalculo.Text = resultado.ToString();
            lblCalculo.Visible = true;
            _numero1 = 0;
            txtResultado.Clear();
        }
        #region Operadores basicos
        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "-";
            operador = '-';
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "+";
            operador = '+';
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "X";
            operador = 'X';
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "/";
            operador = '/';
        }
        #endregion

        private void btnApaga_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != string.Empty)
            {
                txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);
            }
            if (lblCalculo.Text.Length > 0)
            {
                lblCalculo.Text = lblCalculo.Text.Remove(lblCalculo.Text.Length - 1);
            }           
        }

        private void AdicionaNumero(int numero1)
        {
            if(_numero1 == 0)
            {
                _numero1 = numero1;
            }
            else
            {
                if (Calcula(numero1))
                {
                    _numero1 = resultado;
                }
            }
        }

        private bool Calcula(double numero)
        {
            try
            {
                switch (operador)
                {
                    case '+':
                        resultado = _numero1 + numero;
                        break;
                    case '-':
                        resultado = _numero1 - numero;
                        break;
                    case 'X':
                        resultado = _numero1 * numero;
                        break;
                    case '/':
                        resultado = _numero1 / numero;
                        break;
                    default:
                        resultado = double.Parse(_numero1.ToString() + numero.ToString());
                        break;
                }
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }
    }
}
