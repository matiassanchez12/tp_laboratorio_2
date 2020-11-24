namespace Test_WindowsForm
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCrearEmpleado = new System.Windows.Forms.Button();
            this.BtnCrearNegocio = new System.Windows.Forms.Button();
            this.BtnCrearCliente = new System.Windows.Forms.Button();
            this.textBoxInfo = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.listNegocios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCrearEmpleado
            // 
            this.BtnCrearEmpleado.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnCrearEmpleado.Location = new System.Drawing.Point(39, 204);
            this.BtnCrearEmpleado.Name = "BtnCrearEmpleado";
            this.BtnCrearEmpleado.Size = new System.Drawing.Size(136, 56);
            this.BtnCrearEmpleado.TabIndex = 0;
            this.BtnCrearEmpleado.Text = "Crear Empleado";
            this.BtnCrearEmpleado.UseVisualStyleBackColor = true;
            this.BtnCrearEmpleado.Click += new System.EventHandler(this.BtnCrearEmpleado_Click);
            // 
            // BtnCrearNegocio
            // 
            this.BtnCrearNegocio.Location = new System.Drawing.Point(39, 131);
            this.BtnCrearNegocio.Name = "BtnCrearNegocio";
            this.BtnCrearNegocio.Size = new System.Drawing.Size(136, 47);
            this.BtnCrearNegocio.TabIndex = 1;
            this.BtnCrearNegocio.Text = "Crear Negocio";
            this.BtnCrearNegocio.UseVisualStyleBackColor = true;
            this.BtnCrearNegocio.Click += new System.EventHandler(this.BtnCrearNegocio_Click);
            // 
            // BtnCrearCliente
            // 
            this.BtnCrearCliente.Location = new System.Drawing.Point(39, 285);
            this.BtnCrearCliente.Name = "BtnCrearCliente";
            this.BtnCrearCliente.Size = new System.Drawing.Size(136, 54);
            this.BtnCrearCliente.TabIndex = 2;
            this.BtnCrearCliente.Text = "Crear Cliente";
            this.BtnCrearCliente.UseVisualStyleBackColor = true;
            this.BtnCrearCliente.Click += new System.EventHandler(this.BtnCrearCliente_Click);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxInfo.Location = new System.Drawing.Point(215, 131);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(479, 377);
            this.textBoxInfo.TabIndex = 3;
            this.textBoxInfo.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(739, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 47);
            this.button4.TabIndex = 4;
            this.button4.Text = "Cargar Data Tipo Txt";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(739, 184);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 47);
            this.button5.TabIndex = 5;
            this.button5.Text = "Guardar Data Tipo Txt";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(739, 267);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 47);
            this.button6.TabIndex = 6;
            this.button6.Text = "Cargar Data Tipo Xml";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(739, 320);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 47);
            this.button7.TabIndex = 7;
            this.button7.Text = "Guardar data Tipo Xml";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(739, 408);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 47);
            this.button8.TabIndex = 8;
            this.button8.Text = "Cargar data Tipo Sql";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(739, 461);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(136, 47);
            this.button9.TabIndex = 9;
            this.button9.Text = "Guardar data Tipo Sql";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // listNegocios
            // 
            this.listNegocios.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listNegocios.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listNegocios.FormattingEnabled = true;
            this.listNegocios.Location = new System.Drawing.Point(215, 37);
            this.listNegocios.Name = "listNegocios";
            this.listNegocios.Size = new System.Drawing.Size(479, 56);
            this.listNegocios.TabIndex = 11;
            this.listNegocios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listNegocios_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Informacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Negocios";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEliminar.Location = new System.Drawing.Point(709, 37);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(82, 47);
            this.BtnEliminar.TabIndex = 14;
            this.BtnEliminar.Text = "Eliminar negocio";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 550);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listNegocios);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.BtnCrearCliente);
            this.Controls.Add(this.BtnCrearNegocio);
            this.Controls.Add(this.BtnCrearEmpleado);
            this.Name = "PrincipalForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PrincipalForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCrearEmpleado;
        private System.Windows.Forms.Button BtnCrearNegocio;
        private System.Windows.Forms.Button BtnCrearCliente;
        private System.Windows.Forms.RichTextBox textBoxInfo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ListBox listNegocios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEliminar;
    }
}

