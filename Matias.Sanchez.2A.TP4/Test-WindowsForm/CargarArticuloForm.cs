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
    public partial class CargarArticuloForm : Form
    {
        public CargarArticuloForm()
        {
            InitializeComponent();
            comboBoxTipo.Items.Insert(0, "Elegir tipo...");
            comboBoxTipo.SelectedIndex = 0;
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            CrearClienteForm auxFormCrearCliente = (CrearClienteForm)this.Owner;

            Articulo.Tipo tipoDeArticulo = this.BuscarTipo(this.comboBoxTipo.Text);
            
            try
            {
                Articulo auxArticulo = new Articulo(this.textBoxNombre.Text, Int32.Parse(this.nroRetiro.Text),
                                                tipoDeArticulo, this.textBoxAccesorios.Text, this.textBoxComentarios.Text);  
                
                auxFormCrearCliente.DelegadoCargarUnArticulo(auxArticulo);

                MessageBox.Show("Articulo creado!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Articulo.Tipo BuscarTipo(string tipo)
        {
            Articulo.Tipo auxTipo = Articulo.Tipo.Otro;
            switch (tipo)
            {
                case "TV":
                    auxTipo = Articulo.Tipo.TV;
                    break;
                case "Radio":
                    auxTipo = Articulo.Tipo.Radio;
                    break;
                case "Acondicionador de Aire":
                    auxTipo = Articulo.Tipo.AcondicionadorDeAire;
                    break;
                case "Heladera":
                    auxTipo = Articulo.Tipo.Heladera;
                    break;
            }
            return auxTipo;
        }
    }
}
