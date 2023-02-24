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
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEnlazadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicacionnesXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conPilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conLinQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conSeñalizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Arbol1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Arbol2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grafosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafoDijkstra1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasCircularesYDoblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listasToolStripMenuItem,
            this.aplicacionnesXMLToolStripMenuItem,
            this.arbolesToolStripMenuItem,
            this.informaciónToolStripMenuItem,
            this.grafosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(981, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaSimpleToolStripMenuItem,
            this.listaEnlazadaToolStripMenuItem,
            this.arrayListToolStripMenuItem,
            this.listasCircularesYDoblesToolStripMenuItem});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.listasToolStripMenuItem.Text = "Listas";
            // 
            // listaSimpleToolStripMenuItem
            // 
            this.listaSimpleToolStripMenuItem.Name = "listaSimpleToolStripMenuItem";
            this.listaSimpleToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.listaSimpleToolStripMenuItem.Text = "Lista Enlazada Simple 1";
            this.listaSimpleToolStripMenuItem.Click += new System.EventHandler(this.listaSimpleToolStripMenuItem_Click);
            // 
            // listaEnlazadaToolStripMenuItem
            // 
            this.listaEnlazadaToolStripMenuItem.Name = "listaEnlazadaToolStripMenuItem";
            this.listaEnlazadaToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.listaEnlazadaToolStripMenuItem.Text = "Lista Enlazada Simple 2";
            this.listaEnlazadaToolStripMenuItem.Click += new System.EventHandler(this.listaEnlazadaToolStripMenuItem_Click);
            // 
            // arrayListToolStripMenuItem
            // 
            this.arrayListToolStripMenuItem.Name = "arrayListToolStripMenuItem";
            this.arrayListToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.arrayListToolStripMenuItem.Text = "ArrayList";
            this.arrayListToolStripMenuItem.Click += new System.EventHandler(this.arrayListToolStripMenuItem_Click);
            // 
            // aplicacionnesXMLToolStripMenuItem
            // 
            this.aplicacionnesXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conPilasToolStripMenuItem,
            this.conLinQToolStripMenuItem,
            this.conSeñalizerToolStripMenuItem,
            this.toolStripSeparator1});
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
            this.conPilasToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.conPilasToolStripMenuItem.Text = "Plila";
            this.conPilasToolStripMenuItem.Click += new System.EventHandler(this.conPilasToolStripMenuItem_Click);
            // 
            // conLinQToolStripMenuItem
            // 
            this.conLinQToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("conLinQToolStripMenuItem.Image")));
            this.conLinQToolStripMenuItem.Name = "conLinQToolStripMenuItem";
            this.conLinQToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.conLinQToolStripMenuItem.Text = "Cola";
            this.conLinQToolStripMenuItem.Click += new System.EventHandler(this.conHilosToolStripMenuItem_Click);
            // 
            // conSeñalizerToolStripMenuItem
            // 
            this.conSeñalizerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("conSeñalizerToolStripMenuItem.Image")));
            this.conSeñalizerToolStripMenuItem.Name = "conSeñalizerToolStripMenuItem";
            this.conSeñalizerToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.conSeñalizerToolStripMenuItem.Text = "Bicola";
            this.conSeñalizerToolStripMenuItem.Click += new System.EventHandler(this.conSeñalizerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Arbol1ToolStripMenuItem,
            this.Arbol2ToolStripMenuItem,
            this.p3ToolStripMenuItem});
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            // 
            // Arbol1ToolStripMenuItem
            // 
            this.Arbol1ToolStripMenuItem.Name = "Arbol1ToolStripMenuItem";
            this.Arbol1ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.Arbol1ToolStripMenuItem.Text = "Arbol";
            this.Arbol1ToolStripMenuItem.Click += new System.EventHandler(this.Arbol1ToolStripMenuItem_Click);
            // 
            // Arbol2ToolStripMenuItem
            // 
            this.Arbol2ToolStripMenuItem.Name = "Arbol2ToolStripMenuItem";
            this.Arbol2ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.Arbol2ToolStripMenuItem.Text = "Arbol Binario de busqueda";
            this.Arbol2ToolStripMenuItem.Click += new System.EventHandler(this.Arbol2ToolStripMenuItem_Click);
            // 
            // p3ToolStripMenuItem
            // 
            this.p3ToolStripMenuItem.Name = "p3ToolStripMenuItem";
            this.p3ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.p3ToolStripMenuItem.Text = "XmlLinq";
            this.p3ToolStripMenuItem.Click += new System.EventHandler(this.p3ToolStripMenuItem_Click);
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoresToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.informaciónToolStripMenuItem.Text = "Información";
            this.informaciónToolStripMenuItem.Click += new System.EventHandler(this.informaciónToolStripMenuItem_Click);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.autoresToolStripMenuItem.Text = "Autores";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(143, 26);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // grafosToolStripMenuItem
            // 
            this.grafosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafoDijkstra1ToolStripMenuItem,
            this.grafoToolStripMenuItem});
            this.grafosToolStripMenuItem.Name = "grafosToolStripMenuItem";
            this.grafosToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.grafosToolStripMenuItem.Text = "Grafos";
            // 
            // grafoDijkstra1ToolStripMenuItem
            // 
            this.grafoDijkstra1ToolStripMenuItem.Name = "grafoDijkstra1ToolStripMenuItem";
            this.grafoDijkstra1ToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.grafoDijkstra1ToolStripMenuItem.Text = "Grafo Dijkstra 1";
            this.grafoDijkstra1ToolStripMenuItem.Click += new System.EventHandler(this.grafoDijkstra1ToolStripMenuItem_Click);
            // 
            // grafoToolStripMenuItem
            // 
            this.grafoToolStripMenuItem.Name = "grafoToolStripMenuItem";
            this.grafoToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.grafoToolStripMenuItem.Text = "Grafo";
            this.grafoToolStripMenuItem.Click += new System.EventHandler(this.grafoToolStripMenuItem_Click);
            // 
            // listasCircularesYDoblesToolStripMenuItem
            // 
            this.listasCircularesYDoblesToolStripMenuItem.Name = "listasCircularesYDoblesToolStripMenuItem";
            this.listasCircularesYDoblesToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.listasCircularesYDoblesToolStripMenuItem.Text = "Listas Circulares y Dobles";
            this.listasCircularesYDoblesToolStripMenuItem.Click += new System.EventHandler(this.listasCircularesYDoblesToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(981, 453);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEnlazadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrayListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Arbol1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Arbol2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem p3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem grafosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafoDijkstra1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasCircularesYDoblesToolStripMenuItem;
    }
}

