namespace ListaColaStefaniaM
{
    partial class Form1
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
            this.lstCola = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombreNodo = new System.Windows.Forms.TextBox();
            this.txtNombreNodo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCola
            // 
            this.lstCola.HideSelection = false;
            this.lstCola.Location = new System.Drawing.Point(34, 42);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(170, 291);
            this.lstCola.TabIndex = 0;
            this.lstCola.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // textNombreNodo
            // 
            this.textNombreNodo.Location = new System.Drawing.Point(246, 99);
            this.textNombreNodo.Name = "textNombreNodo";
            this.textNombreNodo.Size = new System.Drawing.Size(286, 20);
            this.textNombreNodo.TabIndex = 2;
            // 
            // txtNombreNodo
            // 
            this.txtNombreNodo.Location = new System.Drawing.Point(246, 144);
            this.txtNombreNodo.Name = "txtNombreNodo";
            this.txtNombreNodo.Size = new System.Drawing.Size(103, 46);
            this.txtNombreNodo.TabIndex = 3;
            this.txtNombreNodo.Text = "Encolar";
            this.txtNombreNodo.UseVisualStyleBackColor = true;
            this.txtNombreNodo.Click += new System.EventHandler(this.bEncolar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Desencolsr";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNombreNodo);
            this.Controls.Add(this.textNombreNodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstCola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombreNodo;
        private System.Windows.Forms.Button txtNombreNodo;
        private System.Windows.Forms.Button button1;
    }
}

