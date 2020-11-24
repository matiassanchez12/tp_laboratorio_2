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
    public partial class CrearEmpleadoForm : Form
    {
        
        public CrearEmpleadoForm()
        {
            InitializeComponent();
        }
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            PrincipalForm auxForm = (PrincipalForm)this.Owner;

            try
            {
                Empleado auxEmpleado = new Empleado(this.nombre.Text, this.apellido.Text, this.domicilio.Text,
                                                 this.telefono.Text, this.celular.Text, Int32.Parse(this.ID.Text));

                auxForm.DelegadoCargarPersona(auxEmpleado);

                MessageBox.Show("Empleado agregado!");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
