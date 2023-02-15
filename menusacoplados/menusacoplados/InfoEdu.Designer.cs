namespace menusacoplados
{
    partial class InfoEdu
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Se busca por:",
            "",
            "Genocidio",
            "Desaparición forzada",
            "Tortura",
            "Discriminación",
            "Manipulación Genética",
            "Rebelión",
            "Sedición",
            "Falsificación de documentos en general",
            "Falsificación de sellos, timbres, y marcas oficiales",
            "Delitos de peligro común",
            "Delitos contra los medios de transporte, comunicación y otros servicios públicos",
            "Delitos contra la salud pública",
            "Delitos contra el orden migratorio",
            "Delitos financieros",
            "Delitos monetarios",
            "Abuso del poder económico",
            "Acaparamiento, especulación, adulteración",
            "Venta ilícita de mercaderías",
            "Delitos contra los derechos de autor y conexos",
            "Delitos contra la propiedad industrial",
            "Atentados contra el sistema crediticio",
            "Usura",
            "Libramiento y cobro indebido"});
            this.listBox1.Location = new System.Drawing.Point(4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(484, 404);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InfoEdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "InfoEdu";
            this.Load += new System.EventHandler(this.InfoEdu_Load);
            this.Click += new System.EventHandler(this.button1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}
