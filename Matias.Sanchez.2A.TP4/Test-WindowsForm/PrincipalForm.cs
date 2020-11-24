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
    public partial class PrincipalForm : Form
    {
        public DelegadoCargarDatosNegocio DelegadoCargarNegocio;
        public DelegadoCargarPersona DelegadoCargarPersona;
        public PrincipalForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void PrincipalForm_MouseClick(object sender, MouseEventArgs e)
        {
            if(this.listNegocios.SelectedIndex >= 0)
            {
                this.listNegocios.ClearSelected();
                this.listNegocios.SelectedIndex = -1;
            }
        }
        private void listNegocios_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.textBoxInfo.Text = this.listNegocios.SelectedItem.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void BtnCrearNegocio_Click(object sender, EventArgs e)
        {
            this.DelegadoCargarNegocio = new DelegadoCargarDatosNegocio(AgregarNegocio);

            CrearNegocioForm crearNegocioFrm = new CrearNegocioForm();

            crearNegocioFrm.StartPosition = FormStartPosition.CenterScreen;

            crearNegocioFrm.Show(this);
        }
        /// <summary>
        /// Agrego un negocio a listBox de negocios, al crearlo se selecciona  
        /// automaticamente
        /// </summary>
        /// <param name="negocio">Un negocio a agregar</param>
        /// <param name="e"></param>
        private void AgregarNegocio(Negocio negocio, EventArgs e)
        {
            this.listNegocios.Items.Add(negocio);
            int index = this.listNegocios.Items.Count - 1;
            this.listNegocios.SelectedIndex = index;
        }
        private void BtnCrearCliente_Click(object sender, EventArgs e)
        {
            if(this.listNegocios.SelectedItem != null)
            {
                this.DelegadoCargarPersona = new DelegadoCargarPersona(AgregarPersona);

                CrearClienteForm crearClienteForm = new CrearClienteForm();

                crearClienteForm.StartPosition = FormStartPosition.CenterScreen;

                crearClienteForm.Show(this);
            }
            else
            {
                MessageBox.Show("Error, Seleccione un negocio antes de agregar!");
            }
        }

        private void BtnCrearEmpleado_Click(object sender, EventArgs e)
        {
            if (this.listNegocios.SelectedItem != null)
            {
                this.DelegadoCargarPersona = new DelegadoCargarPersona(AgregarPersona);
                
                CrearEmpleadoForm crearEmpleadoForm = new CrearEmpleadoForm();

                crearEmpleadoForm.StartPosition = FormStartPosition.CenterScreen;

                crearEmpleadoForm.Show(this);
            }
            else
            {
                MessageBox.Show("Error, Seleccione un negocio antes de agregar!");
            }
        }
        public void AgregarPersona(Persona p)
        {
            Type tipo = p.GetType();

            Negocio auxNegocio = (Negocio)this.listNegocios.SelectedItem;

            if (tipo.Equals(typeof(Cliente)))
            {
                auxNegocio += ((Cliente)p);
            }
            else
            {
               auxNegocio += ((Empleado)p);
            }

            int index = this.listNegocios.SelectedIndex;

            this.listNegocios.Items.RemoveAt(index);

            this.listNegocios.Items.Insert(index, auxNegocio);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result;

            if (this.listNegocios.SelectedItem != null)
            {
                result = MessageBox.Show(this, $"ELIMINAR EL NEGOCIO: '{((Negocio)this.listNegocios.SelectedItem).Nombre}' ?", 
                    "Eliminar Negocio", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    this.listNegocios.Items.Remove(listNegocios.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Para eliminar : Seleccione un negocio.");
            }
        }
    }
}
