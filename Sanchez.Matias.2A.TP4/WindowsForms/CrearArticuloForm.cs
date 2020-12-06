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
    public partial class CrearArticuloForm : Form
    {
        /// <summary>
        /// Constructor por defecto, configuro los dos combobox del form y fijo un valor 
        /// para el textbox id
        /// </summary>
        public CrearArticuloForm(int idCliente)
        {
            InitializeComponent();

            this.Text = "Creando articulo..";

            selectArt.Items.Insert(0, "Elegir tipo...");
            selectArt.SelectedIndex = 0;
            selectArt.DropDownStyle = ComboBoxStyle.DropDownList;

            selectEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            selectEstado.Items.Insert(0, "Elegir tipo...");
            selectEstado.SelectedIndex = 0;

            this.id.Enabled = false;
            this.id.Text = idCliente.ToString();
        }
        /// <summary>
        /// Cuando el combobox de "selectArticulo" cambia su valor,
        /// se activa o desactiva un textbox predeterminado para
        /// TV o Radio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectArt_SelectedIndexChanged(object sender, EventArgs e)
        {
            peso.Enabled = false;
            anios.Enabled = false;

            if (selectArt.Text == "Radio")
            {
                anios.Enabled = true;
                peso.Enabled = false;
            }
            if (selectArt.Text == "TV")
            {
                peso.Enabled = true;
                anios.Enabled = false;
            }
        }
        /// <summary>
        /// Capturo el evento click sobre el boton de vender
        /// y se trata de crear un articulo nuevo verificando
        /// si el articulo a crear es de tipo tv o radio. Por ultimo
        /// llama al delegadoCargarArticulo del form principal para
        /// pasar por parametro el articulo creado. Ademas agrega un articulo
        /// a la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnVender_Click(object sender, EventArgs e)
        {
            PrincipalFrm auxForm = (PrincipalFrm)this.Owner;

            Articulo auxArticulo;

            EEstado auxEstado = EEstado.Usado;

            if(selectEstado.Text == "Nuevo")
            {
                auxEstado = EEstado.Nuevo;
            }

            try
            {
                if(this.selectArt.Text == "Radio")
                {
                    auxArticulo = new Radio(int.Parse(id.Text), nombre.Text, marca.Text, auxEstado,
                                            double.Parse(costo.Text), int.Parse(anios.Text));
                    ConexionBD.InsertArticulo((Radio)auxArticulo);
                }
                else if(this.selectArt.Text == "TV")
                {
                    auxArticulo = new TV(int.Parse(id.Text), nombre.Text, marca.Text, auxEstado,
                                         double.Parse(peso.Text), double.Parse(costo.Text));
                    ConexionBD.InsertArticulo((TV)auxArticulo);
                }
                else
                {
                    throw new Exception("Error, debe seleccionarse un articulo");
                }

                auxForm.DelegadoCargarArticulo(auxArticulo);

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
