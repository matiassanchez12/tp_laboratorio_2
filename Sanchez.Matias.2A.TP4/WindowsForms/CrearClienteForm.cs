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

namespace WindowsForms
{
    public partial class CrearClienteForm : Form
    {
        /// <summary>
        /// Constructor por defecto, iniciliaza el nombre del form,
        /// y ademas configura el comboBox del form
        /// </summary>
        public CrearClienteForm()
        {
            InitializeComponent();

            this.Text = "Creando cliente..";

            formaPago.Items.Insert(0, "Elegir tipo...");
            formaPago.SelectedIndex = 0;
            formaPago.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        /// <summary>
        /// Captura el evento click del boton, para
        /// crear un nuevo cliente y luego pasar este cliente
        /// al delegadoCargarCliente del formulario principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCrear_Click_1(object sender, EventArgs e)
        {
            PrincipalFrm auxForm = (PrincipalFrm)this.Owner;

            try
            {
                Cliente auxCliente = new Cliente(int.Parse(this.id.Text),this.nombre.Text, this.dni.Text,
                                                ConexionBD.BuscarMedioDePago(this.formaPago.Text),
                                                char.Parse(this.sexo.Text));

                auxForm.DelegadoCargarCliente(auxCliente);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message,
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }
        }

    }
}
