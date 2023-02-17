namespace menusacoplados
{
    partial class FrmCola
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCola = new System.Windows.Forms.TextBox();
            this.btnDesencolar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVerCola = new System.Windows.Forms.Button();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 48);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estructura de Datos - Colas (Queue)";
            // 
            // txtCola
            // 
            this.txtCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCola.Location = new System.Drawing.Point(136, 187);
            this.txtCola.Name = "txtCola";
            this.txtCola.Size = new System.Drawing.Size(442, 29);
            this.txtCola.TabIndex = 30;
            // 
            // btnDesencolar
            // 
            this.btnDesencolar.Location = new System.Drawing.Point(136, 145);
            this.btnDesencolar.Name = "btnDesencolar";
            this.btnDesencolar.Size = new System.Drawing.Size(108, 30);
            this.btnDesencolar.TabIndex = 23;
            this.btnDesencolar.Text = "Desencolar";
            this.btnDesencolar.UseVisualStyleBackColor = true;
            this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 258);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 30);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 222);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 186);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVerCola
            // 
            this.btnVerCola.Location = new System.Drawing.Point(12, 150);
            this.btnVerCola.Name = "btnVerCola";
            this.btnVerCola.Size = new System.Drawing.Size(100, 30);
            this.btnVerCola.TabIndex = 28;
            this.btnVerCola.Text = "Ver cola";
            this.btnVerCola.UseVisualStyleBackColor = true;
            this.btnVerCola.Click += new System.EventHandler(this.btnVerCola_Click);
            // 
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(12, 114);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(100, 30);
            this.btnEncolar.TabIndex = 29;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(12, 294);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.Size = new System.Drawing.Size(100, 20);
            this.txtNuevo.TabIndex = 21;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(12, 84);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 20);
            this.txtDato.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Elemento:";
            // 
            // FrmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(602, 334);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCola);
            this.Controls.Add(this.btnDesencolar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVerCola);
            this.Controls.Add(this.btnEncolar);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.label2);
            this.Name = "FrmCola";
            this.Text = "Cola";
            this.Activated += new System.EventHandler(this.Form3_Activated);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCola;
        private System.Windows.Forms.Button btnDesencolar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVerCola;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.TextBox txtNuevo;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label2;
    }
}