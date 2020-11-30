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
using System.Threading;

namespace WindowsForms
{
    /// <summary>
    /// Delegado para cambiar el estado de una compra
    /// </summary>
    /// <param name="auxBtn">instancia de radio button</param>
    /// <param name="isChecked">valor de chequeado del radio button</param>
    /// <param name="auxLbl">instancia de label</param>
    /// <param name="colorLbl">color del label</param>
    public delegate void DelegadoCambiarEstados(RadioButton auxBtn, bool isChecked, Label auxLbl, Color colorLbl);
    public partial class PrincipalFrm : Form
    {
        /// <summary>
        /// Instancias de delegados
        /// </summary>
        public DelegadoCargarCliente DelegadoCargarCliente;
        public DelegadoCambiarEstados DelegadoCambiarEstado;
        public DelegadoCargarArticulo DelegadoCargarArticulo;

        private bool comprando;
        private Thread thread;
        private Negocio nuevoNegocio;
        private Cliente cliente;
        private Articulo ultimoArticulo;

        /// <summary>
        /// Constructor de form principal, asegura mediante un cuadro de dialogo (utilizando el metodo
        /// InputBox) al comienzo del programa que se introduzca un nombre para un negocio y creando una instancia 
        /// de negocio, luego genera un form para introducir los datos del cliente y crear una nueva
        /// instancia y por ultimo inicia el form principal que es donde se podran agregar los articulos
        /// </summary>
        public PrincipalFrm()
        {
            InitializeComponent();

            string nombreNegocio;

            try
            {
                if (Input.InputBox("Creando un nuevo negocio..", "Ingresar nombre del negocio: ", out nombreNegocio) == DialogResult.OK)
                {
                    nuevoNegocio = new Negocio(nombreNegocio);

                    this.CrearFormCargarCliente();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message,
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }

        }
        /// <summary>
        /// Al cargar el form les doy estilo y configuro algunos controles
        /// de este form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrincipalFrm_Load(object sender, EventArgs e)
        {
            if(!(cliente is null))
            {
                this.Text = "Cliente: " + cliente.Nombre;

                this.StartPosition = FormStartPosition.CenterScreen;

                this.lblTotal.Text = "Total de compras: 0";

                //configuro un radioButton
                this.btn1.Checked = true;
                this.btn1.Enabled = false;
                //configuro un radioButton
                this.btn2.Enabled = false;
                //configuro un radioButton
                this.btn3.Enabled = false;

                this.lbl1.ForeColor = Color.Blue;
            }
            else
            {
                this.Close();
            }
        }
        /// <summary>
        /// Crea y muestra un nuevo formulario que sirve para ingresar los datos 
        /// que seran usados para crear una nueva instancia de un articulo.
        /// El delegadoCargarArticulo, recibe la direccion de memoria del
        /// metodo agregarArticulo, para ser utilizado dentro de este nuevo form
        /// creado y efectivamente crear el nuevo articulo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(comprando == false)
            {
                try
                {
                    this.DelegadoCargarArticulo = new DelegadoCargarArticulo(AgregarArticulo);

                    CrearArticuloForm crearArticulo = new CrearArticuloForm(cliente.Id);

                    crearArticulo.StartPosition = FormStartPosition.CenterScreen;

                    crearArticulo.ShowDialog(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(this,"Esperar a que termine el proceso de compra, antes de comprar denuevo", 
                    "Error, solo una compra a la vez", MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
            }
        }
        /// <summary>
        /// Crea y muestra un nuevo formulario que sirve para ingresar los datos
        /// de un nuevo cliente y generar una nueva instancia con ellos.
        /// Otorga una direccion de memoria al delegadoCargarCliente 
        /// donde se encuentra el metodo agregarCliente, que servira 
        /// para agregar la instancia de cliente al negocio
        /// </summary>
        private void CrearFormCargarCliente() 
        {
            try
            {
                this.DelegadoCargarCliente = new DelegadoCargarCliente(AgregarCliente);

                CrearClienteForm crearClienteForm = new CrearClienteForm();

                crearClienteForm.StartPosition = FormStartPosition.CenterScreen;

                crearClienteForm.ShowDialog(this);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message,
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }
        }
        /// <summary>
        /// Agrega un cliente al negocio, verificando si este es null y utilizando una
        /// excepcion si lo es. Modifica texBoxCliente con los datos
        /// del cliente.
        /// Utilizo Excepciones
        /// </summary>
        /// <param name="auxCliente">El cliente a agregar</param>
        public void AgregarCliente(Cliente auxCliente)
        {
            if(!(auxCliente is null))
            {
                cliente = auxCliente;

                nuevoNegocio += cliente;

                this.textBoxCliente.Text = cliente.ToString();
            }
            else
            {
                throw new DelegadoNullException();
            }
        }
        /// <summary>
        /// Agrega un articulo a la lista de articulos del negocio
        /// y tambien setea el valor de ultimoArticulo por el del nuevo articulo.
        /// Reemplaza los datos de richtextbox con los del nuevo articulo y 
        /// genera un nuevo hilo con la direccion de memoria del metodo
        /// cambiarEstadoProducto.
        /// Utilizo Hilos
        /// </summary>
        /// <param name="auxArticulo">un articulo a agregar</param>
        public void AgregarArticulo(Articulo auxArticulo)
        {
            if (!(auxArticulo is null))
            {
                ultimoArticulo = auxArticulo;

                richTextDatos.Text = auxArticulo.ToString();

                thread = new Thread(CambiarEstadoDeProducto);

                if (this.thread.ThreadState == ThreadState.Unstarted)
                {
                    this.thread.Start();

                    comprando = true;
                }
            }
            else
            {
                throw new DelegadoNullException();
            }
        }
        /// <summary>
        /// Este metodo es utilizado cuando comienza el hilo secundario
        /// y su funcion es cambiar los colores y el estado de tres labels
        /// y tres radioButtons. Funciona de una forma muy parecida 
        /// a la de un semaforo.
        /// </summary>
        public void CambiarEstadoDeProducto()
        {
            try
            {
                //Comienza el proceso, el hilo espera 2s
                Thread.Sleep(2000);
                //Altero el lbl1 y el btn1
                this.AlterarEstado(btn1, false, lbl1, Color.White);
                //Altero el lbl2 y el btn2
                this.AlterarEstado(btn2, true, lbl2, Color.DarkOrange);
                //Paro el proceso por 4s
                Thread.Sleep(4000);
                //Altero el lbl2 y el btn2
                this.AlterarEstado(btn2, false, lbl2, Color.White);
                //Altero el lbl3 y el btn3
                this.AlterarEstado(btn3, true, lbl3, Color.Green);
                //Paro el proceso por 1s
                Thread.Sleep(1000);

                //Altero el lbl3 y el btn3
                this.AlterarEstado(btn3, false, lbl3, Color.White);
                //Altero el lbl1 y el btn1
                this.AlterarEstado(btn1, true, lbl1, Color.Blue);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message,
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }

            comprando = false;
        }
        /// <summary>
        /// Metodo que se encarga de invocar un control en el hilo actual
        /// para que no ocurra un error en tiempo de ejecucion. Ademas su funcion
        /// es setear valores para auxBtn y auxLbl, y en el caso indicado
        /// mostrar un menssagebox, agregar el ultimo articulo al negocio y 
        /// actualizar el valor de lbltotal.
        /// </summary>
        /// <param name="auxBtn">una instancia de tipo radioButton</param>
        /// <param name="isChecked">el valor bolean que va a tener checked del radiobutton</param>
        /// <param name="auxLbl">una instancia de tipo label</param>
        /// <param name="colorLbl">el color que va a tener el label</param>
        public void AlterarEstado(RadioButton auxBtn, bool isChecked, Label auxLbl, Color colorLbl)
        {
            if (auxBtn.InvokeRequired && auxLbl.InvokeRequired)
            {
                DelegadoCambiarEstado = new DelegadoCambiarEstados(AlterarEstado);
                Object[] obj = new Object[] { auxBtn, isChecked, auxLbl, colorLbl};
                this.Invoke(DelegadoCambiarEstado, obj);
            }
            else
            {
                auxBtn.Checked = isChecked;
                auxLbl.ForeColor = colorLbl;

                if(auxLbl == lbl3 && isChecked == true)
                {
                    MessageBox.Show(this, "Compra realizada. Ticket generado con exito", "Info compra", 
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    nuevoNegocio += ultimoArticulo;

                    lblTotal.Text = $"Total de compras: {nuevoNegocio.Articulos.Count}";
                }
            }
        }
        /// <summary>
        /// Para evitar prosibles errores al cerrar el form mientras se esta ejecutando un hilo
        /// confirmo si ese hilo esta activo o si es null y lo aborto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrincipalFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(this.thread is null) && this.thread.IsAlive)
            {
                this.thread.Abort();
            }
        }
    }

}
