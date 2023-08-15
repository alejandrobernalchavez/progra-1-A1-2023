
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
            this.btnConvertirConversores = new System.Windows.Forms.Button();
            this.lbldeconversores = new System.Windows.Forms.Label();
            this.cboConversores = new System.Windows.Forms.ComboBox();
            this.cboCantidad = new System.Windows.Forms.ComboBox();
            this.lblaconversores = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.lblCantidadConversores = new System.Windows.Forms.Label();
            this.txtCantidadConversores = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConvertirConversores
            // 
            this.btnConvertirConversores.Location = new System.Drawing.Point(134, 244);
            this.btnConvertirConversores.Name = "btnConvertirConversores";
            this.btnConvertirConversores.Size = new System.Drawing.Size(236, 103);
            this.btnConvertirConversores.TabIndex = 0;
            this.btnConvertirConversores.Text = "CONVERTIR";
            this.btnConvertirConversores.UseVisualStyleBackColor = true;
            this.btnConvertirConversores.Click += new System.EventHandler(this.bTNCONVERTIRCONVESORES_Click);
            // 
            // lbldeconversores
            // 
            this.lbldeconversores.AutoSize = true;
            this.lbldeconversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeconversores.Location = new System.Drawing.Point(80, 71);
            this.lbldeconversores.Name = "lbldeconversores";
            this.lbldeconversores.Size = new System.Drawing.Size(36, 18);
            this.lbldeconversores.TabIndex = 1;
            this.lbldeconversores.Text = "DE:";
            // 
            // cboConversores
            // 
            this.cboConversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConversores.FormattingEnabled = true;
            this.cboConversores.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Quetzalez",
            "Lempiras",
            "Colones sv",
            "Cordoba",
            "Pesos CR",
            "Yen",
            "Libras esterlinas",
            "Rupia india"});
            this.cboConversores.Location = new System.Drawing.Point(166, 68);
            this.cboConversores.Name = "cboConversores";
            this.cboConversores.Size = new System.Drawing.Size(190, 21);
            this.cboConversores.TabIndex = 2;
            // 
            // cboCantidad
            // 
            this.cboCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCantidad.FormattingEnabled = true;
            this.cboCantidad.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Quetzalez",
            "Lempiras",
            "Colones sv",
            "Cordoba",
            "Pesos CR",
            "Yen",
            "Libras esterlinas",
            "Rupia india"});
            this.cboCantidad.Location = new System.Drawing.Point(166, 111);
            this.cboCantidad.Name = "cboCantidad";
            this.cboCantidad.Size = new System.Drawing.Size(190, 21);
            this.cboCantidad.TabIndex = 4;
            // 
            // lblaconversores
            // 
            this.lblaconversores.AutoSize = true;
            this.lblaconversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaconversores.Location = new System.Drawing.Point(80, 114);
            this.lblaconversores.Name = "lblaconversores";
            this.lblaconversores.Size = new System.Drawing.Size(23, 18);
            this.lblaconversores.TabIndex = 3;
            this.lblaconversores.Text = "A:";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(26, 207);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(121, 18);
            this.lblRespuesta.TabIndex = 5;
            this.lblRespuesta.Text = "RESPUESTA:?";
            // 
            // lblCantidadConversores
            // 
            this.lblCantidadConversores.AutoSize = true;
            this.lblCantidadConversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadConversores.Location = new System.Drawing.Point(42, 164);
            this.lblCantidadConversores.Name = "lblCantidadConversores";
            this.lblCantidadConversores.Size = new System.Drawing.Size(74, 18);
            this.lblCantidadConversores.TabIndex = 6;
            this.lblCantidadConversores.Text = "Cantidad";
            // 
            // txtCantidadConversores
            // 
            this.txtCantidadConversores.Location = new System.Drawing.Point(166, 162);
            this.txtCantidadConversores.Name = "txtCantidadConversores";
            this.txtCantidadConversores.Size = new System.Drawing.Size(190, 20);
            this.txtCantidadConversores.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 388);
            this.Controls.Add(this.txtCantidadConversores);
            this.Controls.Add(this.lblCantidadConversores);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.cboCantidad);
            this.Controls.Add(this.lblaconversores);
            this.Controls.Add(this.cboConversores);
            this.Controls.Add(this.lbldeconversores);
            this.Controls.Add(this.btnConvertirConversores);
            this.Name = "Form1";
            this.Text = "fom1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertirConversores;
        private System.Windows.Forms.Label lbldeconversores;
        private System.Windows.Forms.ComboBox cboConversores;
        private System.Windows.Forms.ComboBox cboCantidad;
        private System.Windows.Forms.Label lblaconversores;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Label lblCantidadConversores;
        private System.Windows.Forms.TextBox txtCantidadConversores;
    }
}

