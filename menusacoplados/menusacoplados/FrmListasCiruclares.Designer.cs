﻿namespace menusacoplados
{
    partial class FrmListasCiruclares
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtNuevoDato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modifcar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Verlista = new System.Windows.Forms.Button();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btnCrearLista = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 89);
            this.panel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listas Circulares - Lista de Contactos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Nuevo Dato:";
            // 
            // txtNuevoDato
            // 
            this.txtNuevoDato.Location = new System.Drawing.Point(149, 241);
            this.txtNuevoDato.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuevoDato.Name = "txtNuevoDato";
            this.txtNuevoDato.Size = new System.Drawing.Size(132, 22);
            this.txtNuevoDato.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Dato:";
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(162, 295);
            this.txtLista.Margin = new System.Windows.Forms.Padding(4);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(520, 75);
            this.txtLista.TabIndex = 42;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(100, 182);
            this.txtDato.Margin = new System.Windows.Forms.Padding(4);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(181, 22);
            this.txtDato.TabIndex = 41;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(450, 209);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(144, 33);
            this.btn_Eliminar.TabIndex = 40;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modifcar
            // 
            this.btn_Modifcar.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modifcar.Location = new System.Drawing.Point(617, 209);
            this.btn_Modifcar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Modifcar.Name = "btn_Modifcar";
            this.btn_Modifcar.Size = new System.Drawing.Size(144, 33);
            this.btn_Modifcar.TabIndex = 39;
            this.btn_Modifcar.Text = "Modificar";
            this.btn_Modifcar.UseVisualStyleBackColor = true;
            this.btn_Modifcar.Click += new System.EventHandler(this.btn_Modifcar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(692, 148);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(144, 33);
            this.btn_Buscar.TabIndex = 38;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Verlista
            // 
            this.btn_Verlista.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verlista.Location = new System.Drawing.Point(525, 148);
            this.btn_Verlista.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Verlista.Name = "btn_Verlista";
            this.btn_Verlista.Size = new System.Drawing.Size(159, 33);
            this.btn_Verlista.TabIndex = 37;
            this.btn_Verlista.Text = "VerLista";
            this.btn_Verlista.UseVisualStyleBackColor = true;
            this.btn_Verlista.Click += new System.EventHandler(this.btn_Verlista_Click);
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insertar.Location = new System.Drawing.Point(350, 148);
            this.btn_Insertar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(167, 33);
            this.btn_Insertar.TabIndex = 36;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // btnCrearLista
            // 
            this.btnCrearLista.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearLista.Location = new System.Drawing.Point(52, 121);
            this.btnCrearLista.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearLista.Name = "btnCrearLista";
            this.btnCrearLista.Size = new System.Drawing.Size(144, 33);
            this.btnCrearLista.TabIndex = 35;
            this.btnCrearLista.Text = "Crear Lista";
            this.btnCrearLista.UseVisualStyleBackColor = true;
            this.btnCrearLista.Click += new System.EventHandler(this.btnCrearLista_Click);
            // 
            // FrmListasCiruclares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNuevoDato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modifcar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Verlista);
            this.Controls.Add(this.btn_Insertar);
            this.Controls.Add(this.btnCrearLista);
            this.Name = "FrmListasCiruclares";
            this.Text = "ListaCirculares";
            this.Activated += new System.EventHandler(this.FrmListasCiruclares_Activated);
            this.Load += new System.EventHandler(this.ListaEnlazada_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNuevoDato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modifcar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Verlista;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Button btnCrearLista;
    }
}