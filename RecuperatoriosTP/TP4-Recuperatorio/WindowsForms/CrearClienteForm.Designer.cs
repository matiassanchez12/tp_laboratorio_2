namespace WindowsForms
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
            this.formaPago = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.sexo = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // formaPago
            // 
            this.formaPago.BackColor = System.Drawing.Color.Gainsboro;
            this.formaPago.ForeColor = System.Drawing.SystemColors.WindowText;
            this.formaPago.FormattingEnabled = true;
            this.formaPago.Items.AddRange(new object[] {
            "SinDatos",
            "Efectivo",
            "Debito",
            "Credito",
            "MercadoPago",
            "Otro"});
            this.formaPago.Location = new System.Drawing.Point(119, 241);
            this.formaPago.Name = "formaPago";
            this.formaPago.Size = new System.Drawing.Size(192, 21);
            this.formaPago.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(12, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Forma de pago:";
            // 
            // BtnCrear
            // 
            this.BtnCrear.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCrear.Location = new System.Drawing.Point(99, 297);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(169, 37);
            this.BtnCrear.TabIndex = 47;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = false;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click_1);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.Gainsboro;
            this.id.ForeColor = System.Drawing.SystemColors.WindowText;
            this.id.Location = new System.Drawing.Point(119, 107);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(192, 20);
            this.id.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(87, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(77, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(28, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Sexo (F / M): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Crear Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(50, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nombre:";
            // 
            // dni
            // 
            this.dni.BackColor = System.Drawing.Color.Gainsboro;
            this.dni.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dni.Location = new System.Drawing.Point(118, 197);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(193, 20);
            this.dni.TabIndex = 38;
            // 
            // sexo
            // 
            this.sexo.BackColor = System.Drawing.Color.Gainsboro;
            this.sexo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sexo.Location = new System.Drawing.Point(120, 155);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(192, 20);
            this.sexo.TabIndex = 37;
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.Color.Gainsboro;
            this.nombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nombre.Location = new System.Drawing.Point(119, 72);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(192, 20);
            this.nombre.TabIndex = 35;
            // 
            // CrearClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(342, 356);
            this.Controls.Add(this.formaPago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.nombre);
            this.Name = "CrearClienteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox formaPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.TextBox sexo;
        private System.Windows.Forms.TextBox nombre;
    }
}