namespace menusacoplados
{
    partial class FrmDijkstra1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.RichTextBox();
            this.txtRutaCorta = new System.Windows.Forms.TextBox();
            this.btnRutaCorta = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtAdyacencia = new System.Windows.Forms.RichTextBox();
            this.btnMostrarAdyacencia = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFinDistancia = new System.Windows.Forms.TextBox();
            this.txtIniDistancia = new System.Windows.Forms.TextBox();
            this.btnVerDistancia = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddArista = new System.Windows.Forms.Button();
            this.txtPesoNodo = new System.Windows.Forms.TextBox();
            this.txtFinNodo = new System.Windows.Forms.TextBox();
            this.txtIniNodo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(219, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = " Algoritmo de Dijkstra";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistancia.Location = new System.Drawing.Point(753, 230);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtDistancia.Size = new System.Drawing.Size(275, 211);
            this.txtDistancia.TabIndex = 17;
            this.txtDistancia.Text = "";
            // 
            // txtRutaCorta
            // 
            this.txtRutaCorta.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaCorta.Location = new System.Drawing.Point(541, 459);
            this.txtRutaCorta.Name = "txtRutaCorta";
            this.txtRutaCorta.Size = new System.Drawing.Size(290, 38);
            this.txtRutaCorta.TabIndex = 16;
            // 
            // btnRutaCorta
            // 
            this.btnRutaCorta.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutaCorta.Location = new System.Drawing.Point(260, 455);
            this.btnRutaCorta.Name = "btnRutaCorta";
            this.btnRutaCorta.Size = new System.Drawing.Size(275, 45);
            this.btnRutaCorta.TabIndex = 15;
            this.btnRutaCorta.Text = "Ruta más corta - Dijkstra";
            this.btnRutaCorta.UseVisualStyleBackColor = true;
            this.btnRutaCorta.Click += new System.EventHandler(this.btnRutaCorta_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 36;
            this.listBox1.Location = new System.Drawing.Point(12, 255);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 292);
            this.listBox1.TabIndex = 14;
            // 
            // txtAdyacencia
            // 
            this.txtAdyacencia.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdyacencia.Location = new System.Drawing.Point(226, 138);
            this.txtAdyacencia.Name = "txtAdyacencia";
            this.txtAdyacencia.Size = new System.Drawing.Size(448, 278);
            this.txtAdyacencia.TabIndex = 13;
            this.txtAdyacencia.Text = "";
            // 
            // btnMostrarAdyacencia
            // 
            this.btnMostrarAdyacencia.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarAdyacencia.Location = new System.Drawing.Point(242, 79);
            this.btnMostrarAdyacencia.Name = "btnMostrarAdyacencia";
            this.btnMostrarAdyacencia.Size = new System.Drawing.Size(392, 52);
            this.btnMostrarAdyacencia.TabIndex = 12;
            this.btnMostrarAdyacencia.Text = "Mostrar Adyacencia";
            this.btnMostrarAdyacencia.UseVisualStyleBackColor = true;
            this.btnMostrarAdyacencia.Click += new System.EventHandler(this.btnMostrarAdyacencia_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFinDistancia);
            this.groupBox2.Controls.Add(this.txtIniDistancia);
            this.groupBox2.Controls.Add(this.btnVerDistancia);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(680, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 143);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Distancia - Nodos:";
            // 
            // txtFinDistancia
            // 
            this.txtFinDistancia.Location = new System.Drawing.Point(304, 32);
            this.txtFinDistancia.Name = "txtFinDistancia";
            this.txtFinDistancia.Size = new System.Drawing.Size(57, 44);
            this.txtFinDistancia.TabIndex = 3;
            // 
            // txtIniDistancia
            // 
            this.txtIniDistancia.Location = new System.Drawing.Point(124, 36);
            this.txtIniDistancia.Name = "txtIniDistancia";
            this.txtIniDistancia.Size = new System.Drawing.Size(57, 44);
            this.txtIniDistancia.TabIndex = 2;
            // 
            // btnVerDistancia
            // 
            this.btnVerDistancia.Location = new System.Drawing.Point(110, 86);
            this.btnVerDistancia.Name = "btnVerDistancia";
            this.btnVerDistancia.Size = new System.Drawing.Size(202, 49);
            this.btnVerDistancia.TabIndex = 1;
            this.btnVerDistancia.Text = "Ver Distancias";
            this.btnVerDistancia.UseVisualStyleBackColor = true;
            this.btnVerDistancia.Click += new System.EventHandler(this.btnVerDistancia_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Inicio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddArista);
            this.groupBox1.Controls.Add(this.txtPesoNodo);
            this.groupBox1.Controls.Add(this.txtFinNodo);
            this.groupBox1.Controls.Add(this.txtIniNodo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 179);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nodos";
            // 
            // btnAddArista
            // 
            this.btnAddArista.Location = new System.Drawing.Point(33, 136);
            this.btnAddArista.Name = "btnAddArista";
            this.btnAddArista.Size = new System.Drawing.Size(102, 37);
            this.btnAddArista.TabIndex = 4;
            this.btnAddArista.Text = "Añadir";
            this.btnAddArista.UseVisualStyleBackColor = true;
            this.btnAddArista.Click += new System.EventHandler(this.btnAddArista_Click);
            // 
            // txtPesoNodo
            // 
            this.txtPesoNodo.Location = new System.Drawing.Point(77, 100);
            this.txtPesoNodo.Name = "txtPesoNodo";
            this.txtPesoNodo.Size = new System.Drawing.Size(75, 30);
            this.txtPesoNodo.TabIndex = 3;
            // 
            // txtFinNodo
            // 
            this.txtFinNodo.Location = new System.Drawing.Point(78, 65);
            this.txtFinNodo.Name = "txtFinNodo";
            this.txtFinNodo.Size = new System.Drawing.Size(75, 30);
            this.txtFinNodo.TabIndex = 2;
            // 
            // txtIniNodo
            // 
            this.txtIniNodo.Location = new System.Drawing.Point(77, 31);
            this.txtIniNodo.Name = "txtIniNodo";
            this.txtIniNodo.Size = new System.Drawing.Size(75, 30);
            this.txtIniNodo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Peso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inicio:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(850, 459);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(105, 42);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 590);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtRutaCorta);
            this.Controls.Add(this.btnRutaCorta);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtAdyacencia);
            this.Controls.Add(this.btnMostrarAdyacencia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDistancia;
        private System.Windows.Forms.TextBox txtRutaCorta;
        private System.Windows.Forms.Button btnRutaCorta;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox txtAdyacencia;
        private System.Windows.Forms.Button btnMostrarAdyacencia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFinDistancia;
        private System.Windows.Forms.TextBox txtIniDistancia;
        private System.Windows.Forms.Button btnVerDistancia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddArista;
        private System.Windows.Forms.TextBox txtPesoNodo;
        private System.Windows.Forms.TextBox txtFinNodo;
        private System.Windows.Forms.TextBox txtIniNodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrar;
    }
}

