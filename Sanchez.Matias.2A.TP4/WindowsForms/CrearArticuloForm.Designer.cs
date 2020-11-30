namespace WindowsForms
{
    partial class CrearArticuloForm
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
            this.selectEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnVender = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.costo = new System.Windows.Forms.TextBox();
            this.marca = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.selectArt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.anios = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectEstado
            // 
            this.selectEstado.BackColor = System.Drawing.Color.Gainsboro;
            this.selectEstado.FormattingEnabled = true;
            this.selectEstado.Items.AddRange(new object[] {
            "Usado",
            "Nuevo"});
            this.selectEstado.Location = new System.Drawing.Point(167, 265);
            this.selectEstado.Name = "selectEstado";
            this.selectEstado.Size = new System.Drawing.Size(192, 21);
            this.selectEstado.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(102, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "Estado:";
            // 
            // BtnVender
            // 
            this.BtnVender.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnVender.Location = new System.Drawing.Point(113, 394);
            this.BtnVender.Name = "BtnVender";
            this.BtnVender.Size = new System.Drawing.Size(169, 37);
            this.BtnVender.TabIndex = 59;
            this.BtnVender.Text = "Comprar";
            this.BtnVender.UseVisualStyleBackColor = false;
            this.BtnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.Gainsboro;
            this.id.Location = new System.Drawing.Point(167, 138);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(192, 20);
            this.id.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(19, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "ID cliente comprador:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(94, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Costo($):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(103, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Marca: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "Articulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(26, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nombre del articulo:";
            // 
            // costo
            // 
            this.costo.BackColor = System.Drawing.Color.Gainsboro;
            this.costo.Location = new System.Drawing.Point(166, 222);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(193, 20);
            this.costo.TabIndex = 52;
            // 
            // marca
            // 
            this.marca.BackColor = System.Drawing.Color.Gainsboro;
            this.marca.Location = new System.Drawing.Point(167, 183);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(192, 20);
            this.marca.TabIndex = 51;
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.Color.Gainsboro;
            this.nombre.Location = new System.Drawing.Point(167, 97);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(192, 20);
            this.nombre.TabIndex = 50;
            // 
            // selectArt
            // 
            this.selectArt.BackColor = System.Drawing.Color.Gainsboro;
            this.selectArt.FormattingEnabled = true;
            this.selectArt.Items.AddRange(new object[] {
            "Radio",
            "TV"});
            this.selectArt.Location = new System.Drawing.Point(168, 57);
            this.selectArt.Name = "selectArt";
            this.selectArt.Size = new System.Drawing.Size(192, 21);
            this.selectArt.TabIndex = 63;
            this.selectArt.SelectedIndexChanged += new System.EventHandler(this.selectArt_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(63, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Elegir articulo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(86, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Peso(Kg):";
            // 
            // peso
            // 
            this.peso.BackColor = System.Drawing.Color.Gainsboro;
            this.peso.Location = new System.Drawing.Point(166, 307);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(193, 20);
            this.peso.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(14, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 17);
            this.label9.TabIndex = 67;
            this.label9.Text = "Años de antiguedad:";
            // 
            // anios
            // 
            this.anios.BackColor = System.Drawing.Color.Gainsboro;
            this.anios.Location = new System.Drawing.Point(166, 349);
            this.anios.Name = "anios";
            this.anios.Size = new System.Drawing.Size(193, 20);
            this.anios.TabIndex = 66;
            // 
            // CrearArticuloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(386, 457);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.anios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.selectArt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnVender);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costo);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.nombre);
            this.Name = "CrearArticuloForm";
            this.Text = "CrearArticuloForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnVender;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costo;
        private System.Windows.Forms.TextBox marca;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.ComboBox selectArt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox peso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox anios;
    }
}