﻿
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
            this.txtEdad = new System.Windows.Forms.MaskedTextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.btnEdan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(149, 69);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 0;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(66, 69);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 1;
            this.lblEdad.Text = "Edad";
            this.lblEdad.Click += new System.EventHandler(this.lblEdad_Click);
            // 
            // btnEdan
            // 
            this.btnEdan.Location = new System.Drawing.Point(149, 121);
            this.btnEdan.Name = "btnEdan";
            this.btnEdan.Size = new System.Drawing.Size(115, 32);
            this.btnEdan.TabIndex = 2;
            this.btnEdan.Text = "Comprobar";
            this.btnEdan.UseVisualStyleBackColor = true;
            this.btnEdan.Click += new System.EventHandler(this.btnEdan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 402);
            this.Controls.Add(this.btnEdan);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtEdad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Button btnEdan;
    }
}

