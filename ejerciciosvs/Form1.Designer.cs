
namespace ejerciciosvs
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
            this.lblTituloImouesto = new System.Windows.Forms.Label();
            this.lblCantidadImpuesto = new System.Windows.Forms.Label();
            this.btnCalcularImpuesto = new System.Windows.Forms.Button();
            this.txtCantidadImpuesto = new System.Windows.Forms.TextBox();
            this.lblValorAPagarImpuesto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloImouesto
            // 
            this.lblTituloImouesto.AutoSize = true;
            this.lblTituloImouesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloImouesto.Location = new System.Drawing.Point(123, 9);
            this.lblTituloImouesto.Name = "lblTituloImouesto";
            this.lblTituloImouesto.Size = new System.Drawing.Size(442, 20);
            this.lblTituloImouesto.TabIndex = 0;
            this.lblTituloImouesto.Text = "Cálculo de impuestaos  a las Actividades Económicas ";
            // 
            // lblCantidadImpuesto
            // 
            this.lblCantidadImpuesto.AutoSize = true;
            this.lblCantidadImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadImpuesto.Location = new System.Drawing.Point(160, 84);
            this.lblCantidadImpuesto.Name = "lblCantidadImpuesto";
            this.lblCantidadImpuesto.Size = new System.Drawing.Size(86, 20);
            this.lblCantidadImpuesto.TabIndex = 1;
            this.lblCantidadImpuesto.Text = "Cantidad:";
            // 
            // btnCalcularImpuesto
            // 
            this.btnCalcularImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularImpuesto.Location = new System.Drawing.Point(381, 76);
            this.btnCalcularImpuesto.Name = "btnCalcularImpuesto";
            this.btnCalcularImpuesto.Size = new System.Drawing.Size(95, 31);
            this.btnCalcularImpuesto.TabIndex = 2;
            this.btnCalcularImpuesto.Text = "Calcular";
            this.btnCalcularImpuesto.UseVisualStyleBackColor = true;
            this.btnCalcularImpuesto.Click += new System.EventHandler(this.btnCalcularImpuesto_Click);
            // 
            // txtCantidadImpuesto
            // 
            this.txtCantidadImpuesto.Location = new System.Drawing.Point(252, 83);
            this.txtCantidadImpuesto.Name = "txtCantidadImpuesto";
            this.txtCantidadImpuesto.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadImpuesto.TabIndex = 3;
            // 
            // lblValorAPagarImpuesto
            // 
            this.lblValorAPagarImpuesto.AutoSize = true;
            this.lblValorAPagarImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAPagarImpuesto.Location = new System.Drawing.Point(163, 145);
            this.lblValorAPagarImpuesto.Name = "lblValorAPagarImpuesto";
            this.lblValorAPagarImpuesto.Size = new System.Drawing.Size(163, 20);
            this.lblValorAPagarImpuesto.TabIndex = 4;
            this.lblValorAPagarImpuesto.Text = "El valor a pagar es:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 402);
            this.Controls.Add(this.lblValorAPagarImpuesto);
            this.Controls.Add(this.txtCantidadImpuesto);
            this.Controls.Add(this.btnCalcularImpuesto);
            this.Controls.Add(this.lblCantidadImpuesto);
            this.Controls.Add(this.lblTituloImouesto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloImouesto;
        private System.Windows.Forms.Label lblCantidadImpuesto;
        private System.Windows.Forms.Button btnCalcularImpuesto;
        private System.Windows.Forms.TextBox txtCantidadImpuesto;
        private System.Windows.Forms.Label lblValorAPagarImpuesto;
    }
}

