namespace menusacoplados
{
    partial class FrmWarshall
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMatriz2 = new System.Windows.Forms.RichTextBox();
            this.txtMatriz1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "CERRAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "INICIAR ALGORITMO DE RUTA MAS CORTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMatriz2
            // 
            this.txtMatriz2.Location = new System.Drawing.Point(353, 239);
            this.txtMatriz2.Name = "txtMatriz2";
            this.txtMatriz2.Size = new System.Drawing.Size(411, 189);
            this.txtMatriz2.TabIndex = 11;
            this.txtMatriz2.Text = "";
            // 
            // txtMatriz1
            // 
            this.txtMatriz1.Location = new System.Drawing.Point(353, 23);
            this.txtMatriz1.Name = "txtMatriz1";
            this.txtMatriz1.Size = new System.Drawing.Size(411, 189);
            this.txtMatriz1.TabIndex = 10;
            this.txtMatriz1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::menusacoplados.Properties.Resources.Captura_de_pantalla_20230219_203744;
            this.pictureBox1.Location = new System.Drawing.Point(50, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FrmWarshall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMatriz2);
            this.Controls.Add(this.txtMatriz1);
            this.Name = "FrmWarshall";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox txtMatriz2;
        private System.Windows.Forms.RichTextBox txtMatriz1;
    }
}