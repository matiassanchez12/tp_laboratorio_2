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

namespace Test_WindowsForm
{
    public partial class CrearClienteForm : Form
    {
        public DelegadoCargarArticulo DelegadoCargarUnArticulo;
        public Artefactos artefactos;
        public CrearClienteForm()
        {
            InitializeComponent();
            comboBoxTipo.Items.Insert(0, "Elegir tipo...");
            comboBoxTipo.SelectedIndex = 0;
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.artefactos = new Artefactos();
        }
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            PrincipalForm auxForm = (PrincipalForm)this.Owner;

            Cliente.TipoCliente tipo = Cliente.TipoCliente.Desconocido;
            
            if(this.comboBoxTipo.Text == "Conocido")
            {
                tipo = Cliente.TipoCliente.Conocido;
            }
            
            try
            {
                Cliente auxCliente = new Cliente(artefactos, this.nombre.Text, this.apellido.Text, this.domicilio.Text,
                    this.telefono.Text, this.celular.Text, Int32.Parse(this.idEmpleado.Text), tipo);

                auxForm.DelegadoCargarPersona(auxCliente);

                MessageBox.Show("Cliente agregado!");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLoadArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                CargarArticuloForm cargarArticuloForm = new CargarArticuloForm();

                this.DelegadoCargarUnArticulo = new DelegadoCargarArticulo(CargarUnArticulo);

                cargarArticuloForm.StartPosition = FormStartPosition.CenterScreen;

                cargarArticuloForm.Show(this);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarUnArticulo(Articulo art)
        {
            try
            {
                artefactos += art;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
