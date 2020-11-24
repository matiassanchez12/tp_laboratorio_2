namespace Test_WindowsForm
{
    partial class CrearClienteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCrear = new System.Windows.Forms.Button();
            this.idEmpleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.domicilio = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.celular = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnLoadArticulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCrear
            // 
            this.BtnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.BtnCrear.Location = new System.Drawing.Point(80, 394);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(169, 37);
            this.BtnCrear.TabIndex = 27;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // idEmpleado
            // 
            this.idEmpleado.Location = new System.Drawing.Point(150, 148);
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.Size = new System.Drawing.Size(134, 20);
            this.idEmpleado.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(19, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "ID del empleado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(77, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(71, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(71, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Domicilio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Crear Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(71, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(71, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre:";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(150, 225);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(134, 20);
            this.telefono.TabIndex = 18;
            // 
            // domicilio
            // 
            this.domicilio.Location = new System.Drawing.Point(150, 183);
            this.domicilio.Name = "domicilio";
            this.domicilio.Size = new System.Drawing.Size(134, 20);
            this.domicilio.TabIndex = 17;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(150, 107);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(134, 20);
            this.apellido.TabIndex = 16;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(150, 67);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(134, 20);
            this.nombre.TabIndex = 15;
            // 
            // celular
            // 
            this.celular.Location = new System.Drawing.Point(150, 266);
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(134, 20);
            this.celular.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(93, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tipo:";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Conocido",
            "Desconocido"});
            this.comboBoxTipo.Location = new System.Drawing.Point(150, 300);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(134, 21);
            this.comboBoxTipo.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(26, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Cargar Articulos:";
            // 
            // BtnLoadArticulo
            // 
            this.BtnLoadArticulo.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnLoadArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadArticulo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnLoadArticulo.Location = new System.Drawing.Point(150, 341);
            this.BtnLoadArticulo.Name = "BtnLoadArticulo";
            this.BtnLoadArticulo.Size = new System.Drawing.Size(50, 23);
            this.BtnLoadArticulo.TabIndex = 33;
            this.BtnLoadArticulo.Text = "+";
            this.BtnLoadArticulo.UseVisualStyleBackColor = false;
            this.BtnLoadArticulo.Click += new System.EventHandler(this.BtnLoadArticulo_Click);
            // 
            // CrearClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 443);
            this.Controls.Add(this.BtnLoadArticulo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.idEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.domicilio);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.celular);
            this.Name = "CrearClienteForm";
            this.Text = "CrearClienteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.TextBox idEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox domicilio;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox celular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnLoadArticulo;
    }
}