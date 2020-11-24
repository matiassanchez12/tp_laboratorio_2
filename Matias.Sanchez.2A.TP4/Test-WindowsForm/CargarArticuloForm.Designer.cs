namespace Test_WindowsForm
{
    partial class CargarArticuloForm
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
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.nroRetiro = new System.Windows.Forms.TextBox();
            this.labelnroRetiro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.accesorios = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxAccesorios = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxComentarios = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "TV",
            "Radio",
            "Acondicionador de Aire",
            "Heladera",
            "Otro"});
            this.comboBoxTipo.Location = new System.Drawing.Point(159, 189);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(134, 21);
            this.comboBoxTipo.TabIndex = 49;
            // 
            // BtnCrear
            // 
            this.BtnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.BtnCrear.Location = new System.Drawing.Point(89, 396);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(169, 37);
            this.BtnCrear.TabIndex = 47;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // nroRetiro
            // 
            this.nroRetiro.Location = new System.Drawing.Point(159, 150);
            this.nroRetiro.Name = "nroRetiro";
            this.nroRetiro.Size = new System.Drawing.Size(134, 20);
            this.nroRetiro.TabIndex = 46;
            // 
            // labelnroRetiro
            // 
            this.labelnroRetiro.AutoSize = true;
            this.labelnroRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelnroRetiro.Location = new System.Drawing.Point(50, 150);
            this.labelnroRetiro.Name = "labelnroRetiro";
            this.labelnroRetiro.Size = new System.Drawing.Size(92, 17);
            this.labelnroRetiro.TabIndex = 45;
            this.labelnroRetiro.Text = "Nro de retiro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(35, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Comentarios:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(35, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tipo de Equipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Articulo nuevo";
            // 
            // accesorios
            // 
            this.accesorios.AutoSize = true;
            this.accesorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.accesorios.Location = new System.Drawing.Point(61, 109);
            this.accesorios.Name = "accesorios";
            this.accesorios.Size = new System.Drawing.Size(81, 17);
            this.accesorios.TabIndex = 40;
            this.accesorios.Text = "Accesorios:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelNombre.Location = new System.Drawing.Point(80, 69);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(62, 17);
            this.labelNombre.TabIndex = 39;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxAccesorios
            // 
            this.textBoxAccesorios.Location = new System.Drawing.Point(159, 109);
            this.textBoxAccesorios.Name = "textBoxAccesorios";
            this.textBoxAccesorios.Size = new System.Drawing.Size(134, 20);
            this.textBoxAccesorios.TabIndex = 36;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(159, 69);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(134, 20);
            this.textBoxNombre.TabIndex = 35;
            // 
            // textBoxComentarios
            // 
            this.textBoxComentarios.Location = new System.Drawing.Point(132, 237);
            this.textBoxComentarios.Name = "textBoxComentarios";
            this.textBoxComentarios.Size = new System.Drawing.Size(177, 142);
            this.textBoxComentarios.TabIndex = 50;
            this.textBoxComentarios.Text = "";
            // 
            // CargarArticuloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.textBoxComentarios);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.nroRetiro);
            this.Controls.Add(this.labelnroRetiro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accesorios);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxAccesorios);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "CargarArticuloForm";
            this.Text = "CargarArticuloForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.TextBox nroRetiro;
        private System.Windows.Forms.Label labelnroRetiro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label accesorios;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxAccesorios;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.RichTextBox textBoxComentarios;
    }
}