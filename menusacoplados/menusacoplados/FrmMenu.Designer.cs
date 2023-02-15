namespace menusacoplados
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplicacionnesXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conPilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conLinQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conSeñalizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEnlazadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listasToolStripMenuItem,
            this.aplicacionnesXMLToolStripMenuItem,
            this.arbolesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aplicacionnesXMLToolStripMenuItem
            // 
            this.aplicacionnesXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conPilasToolStripMenuItem,
            this.conLinQToolStripMenuItem,
            this.conSeñalizerToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.aplicacionnesXMLToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aplicacionnesXMLToolStripMenuItem.Name = "aplicacionnesXMLToolStripMenuItem";
            this.aplicacionnesXMLToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.aplicacionnesXMLToolStripMenuItem.Text = "Colas y Pilas";
            this.aplicacionnesXMLToolStripMenuItem.Click += new System.EventHandler(this.aplicacionnesXMLToolStripMenuItem_Click);
            // 
            // conPilasToolStripMenuItem
            // 
            this.conPilasToolStripMenuItem.BackColor = System.Drawing.Color.FloralWhite;
            this.conPilasToolStripMenuItem.Image = global::menusacoplados.Properties.Resources.Mi_proyecto;
            this.conPilasToolStripMenuItem.Name = "conPilasToolStripMenuItem";
            this.conPilasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.conPilasToolStripMenuItem.Text = "Plila";
            this.conPilasToolStripMenuItem.Click += new System.EventHandler(this.conPilasToolStripMenuItem_Click);
            // 
            // conLinQToolStripMenuItem
            // 
            this.conLinQToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("conLinQToolStripMenuItem.Image")));
            this.conLinQToolStripMenuItem.Name = "conLinQToolStripMenuItem";
            this.conLinQToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.conLinQToolStripMenuItem.Text = "Cola 1";
            this.conLinQToolStripMenuItem.Click += new System.EventHandler(this.conHilosToolStripMenuItem_Click);
            // 
            // conSeñalizerToolStripMenuItem
            // 
            this.conSeñalizerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("conSeñalizerToolStripMenuItem.Image")));
            this.conSeñalizerToolStripMenuItem.Name = "conSeñalizerToolStripMenuItem";
            this.conSeñalizerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.conSeñalizerToolStripMenuItem.Text = "Cola 2";
            this.conSeñalizerToolStripMenuItem.Click += new System.EventHandler(this.conSeñalizerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaSimpleToolStripMenuItem,
            this.listaEnlazadaToolStripMenuItem,
            this.arrayListToolStripMenuItem});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.listasToolStripMenuItem.Text = "Listas";
            // 
            // listaSimpleToolStripMenuItem
            // 
            this.listaSimpleToolStripMenuItem.Name = "listaSimpleToolStripMenuItem";
            this.listaSimpleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listaSimpleToolStripMenuItem.Text = "Lista Simple";
            this.listaSimpleToolStripMenuItem.Click += new System.EventHandler(this.listaSimpleToolStripMenuItem_Click);
            // 
            // listaEnlazadaToolStripMenuItem
            // 
            this.listaEnlazadaToolStripMenuItem.Name = "listaEnlazadaToolStripMenuItem";
            this.listaEnlazadaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listaEnlazadaToolStripMenuItem.Text = "Lista Circular";
            this.listaEnlazadaToolStripMenuItem.Click += new System.EventHandler(this.listaEnlazadaToolStripMenuItem_Click);
            // 
            // arrayListToolStripMenuItem
            // 
            this.arrayListToolStripMenuItem.Name = "arrayListToolStripMenuItem";
            this.arrayListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.arrayListToolStripMenuItem.Text = "ArrayList";
            this.arrayListToolStripMenuItem.Click += new System.EventHandler(this.arrayListToolStripMenuItem_Click);
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.p1ToolStripMenuItem,
            this.p2ToolStripMenuItem,
            this.p3ToolStripMenuItem});
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            // 
            // p1ToolStripMenuItem
            // 
            this.p1ToolStripMenuItem.Name = "p1ToolStripMenuItem";
            this.p1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.p1ToolStripMenuItem.Text = "P1";
            // 
            // p2ToolStripMenuItem
            // 
            this.p2ToolStripMenuItem.Name = "p2ToolStripMenuItem";
            this.p2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.p2ToolStripMenuItem.Text = "P2";
            // 
            // p3ToolStripMenuItem
            // 
            this.p3ToolStripMenuItem.Name = "p3ToolStripMenuItem";
            this.p3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.p3ToolStripMenuItem.Text = "P3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(872, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Autores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplicacionnesXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conPilasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conLinQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conSeñalizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem listaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEnlazadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrayListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem p1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem p2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem p3ToolStripMenuItem;
    }
}

