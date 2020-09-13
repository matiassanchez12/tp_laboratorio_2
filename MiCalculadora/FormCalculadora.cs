using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            this.CenterToScreen();
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string number1 = txtNumero1.Text;
            string number2 = txtNumero2.Text;
            
            lblResultado.Text = Operar(number1, number2, cmbOperador.Text).ToString();
            btnConvertirADecimal.Enabled = false;
            btnConvertirABinario.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
            Numero num = new Numero();
            lblResultado.Text = num.DecimalBinario(lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
            Numero num = new Numero();
            lblResultado.Text = num.BinarioDecimal(lblResultado.Text);
        }
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
            lblResultado.Text = "";
        }

        private static double Operar (string numero1, string numero2, string operador)
        {
            Calculadora calcu = new Calculadora();
            Numero number1 = new Numero(numero1);
            Numero number2 = new Numero(numero2);

            return calcu.Operar(number1, number2, operador);
        }
    }
}
