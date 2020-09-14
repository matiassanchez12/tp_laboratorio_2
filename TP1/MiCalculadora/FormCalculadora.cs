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
        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            string number1 = txtNumero1.Text;
            string number2 = txtNumero2.Text;
            
            lblResultado.Text = Operar(number1, number2, cmbOperador.Text).ToString();
            btnConvertirADecimal.Enabled = false;
            btnConvertirABinario.Enabled = true;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
            Numero num = new Numero();
            lblResultado.Text = num.DecimalBinario(lblResultado.Text);
        }

        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
            Numero num = new Numero();
            lblResultado.Text = num.BinarioDecimal(lblResultado.Text);
        }
        /// <summary>
        /// Borra el texto que hay en cada componente solicitado
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
            lblResultado.Text = "";
        }
        /// <summary>
        /// Recibe dos numeros y un operador y se encarga de realizar una operacion matematica con estos datos
        /// </summary>
        /// <param name="numero1">El primer numero</param>
        /// <param name="numero2">El segundo numero</param>
        /// <param name="operador">El operador</param>
        /// <returns>Resultado de la operacion realizada</returns>
        private static double Operar (string numero1, string numero2, string operador)
        {
            Calculadora calcu = new Calculadora();
            Numero number1 = new Numero(numero1);
            Numero number2 = new Numero(numero2);

            return calcu.Operar(number1, number2, operador);
        }

    }
}
