namespace menusacoplados
{
    partial class FrmPilas
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
            this.btn_excel = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_despilar = new System.Windows.Forms.Button();
            this.btn_enpilar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(264, 388);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(150, 39);
            this.btn_excel.TabIndex = 20;
            this.btn_excel.Text = "mostrar en excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(384, 66);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(206, 228);
            this.listBox2.TabIndex = 19;
            // 
            // btn_despilar
            // 
            this.btn_despilar.Location = new System.Drawing.Point(435, 323);
            this.btn_despilar.Name = "btn_despilar";
            this.btn_despilar.Size = new System.Drawing.Size(121, 23);
            this.btn_despilar.TabIndex = 18;
            this.btn_despilar.Text = "sacar de la pila";
            this.btn_despilar.UseVisualStyleBackColor = true;
            this.btn_despilar.Click += new System.EventHandler(this.btn_despilar_Click);
            // 
            // btn_enpilar
            // 
            this.btn_enpilar.Location = new System.Drawing.Point(127, 323);
            this.btn_enpilar.Name = "btn_enpilar";
            this.btn_enpilar.Size = new System.Drawing.Size(112, 23);
            this.btn_enpilar.TabIndex = 17;
            this.btn_enpilar.Text = "meter a la pila";
            this.btn_enpilar.UseVisualStyleBackColor = true;
            this.btn_enpilar.Click += new System.EventHandler(this.btn_enpilar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(73, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 228);
            this.listBox1.TabIndex = 16;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(83, 15);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombres";
            // 
            // FrmPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btn_despilar);
            this.Controls.Add(this.btn_enpilar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPilas";
            this.Text = "Pilas";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_despilar;
        private System.Windows.Forms.Button btn_enpilar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
    }
}