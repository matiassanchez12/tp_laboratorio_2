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
    public partial class CrearNegocioForm : Form
    {
        private string nombre;
        public CrearNegocioForm()
        {
            InitializeComponent();
        }
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            PrincipalForm auxForm = (PrincipalForm)this.Owner;
            Empleado e1 = new Empleado("juan", "perez", "asd", "1231", "1231", 2);
            Artefactos art = new Artefactos();
            Cliente c1 = new Cliente(art, "ppe", "Juarez", "qweqwe", "123123", "123123", 2, Cliente.TipoCliente.Conocido);
            nombre = textBoxNombre.Text;
            
            try
            {
                Negocio auxNegocio = new Negocio(nombre);

                auxNegocio += e1;
                auxNegocio += c1;

                auxForm.DelegadoCargarNegocio(auxNegocio, e);

                MessageBox.Show("Creado con exito!");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
