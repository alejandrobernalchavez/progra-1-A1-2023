
namespace ejerciciosvs
{
    partial class Alumnos
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
            this.txtBuscarAlumnos = new System.Windows.Forms.TextBox();
            this.cboOpcionBuscarAlumnos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbEdicioAlumnos = new System.Windows.Forms.GroupBox();
            this.btnEliminarAlumnos = new System.Windows.Forms.Button();
            this.btnModificarAlumnos = new System.Windows.Forms.Button();
            this.btnNuevoAlumnos = new System.Windows.Forms.Button();
            this.grbNavegacionAlumnos = new System.Windows.Forms.GroupBox();
            this.lblRegistroMateria = new System.Windows.Forms.Label();
            this.btnUltimaAlumnos = new System.Windows.Forms.Button();
            this.btnSiguienteAlumnos = new System.Windows.Forms.Button();
            this.btnAnteriorAlumnos = new System.Windows.Forms.Button();
            this.btnPrimeroAumnos = new System.Windows.Forms.Button();
            this.grbDatosAlumnos = new System.Windows.Forms.GroupBox();
            this.txtDireccionAlumnos = new System.Windows.Forms.TextBox();
            this.txtNombreAlumnos = new System.Windows.Forms.TextBox();
            this.txtCodigoAlumnos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdDatosAlumnos = new System.Windows.Forms.DataGridView();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTelefonoAlumnos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grbEdicioAlumnos.SuspendLayout();
            this.grbNavegacionAlumnos.SuspendLayout();
            this.grbDatosAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarAlumnos
            // 
            this.txtBuscarAlumnos.Location = new System.Drawing.Point(798, 78);
            this.txtBuscarAlumnos.Name = "txtBuscarAlumnos";
            this.txtBuscarAlumnos.Size = new System.Drawing.Size(136, 20);
            this.txtBuscarAlumnos.TabIndex = 20;
            // 
            // cboOpcionBuscarAlumnos
            // 
            this.cboOpcionBuscarAlumnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBuscarAlumnos.FormattingEnabled = true;
            this.cboOpcionBuscarAlumnos.Items.AddRange(new object[] {
            "Codigo",
            "Nombre"});
            this.cboOpcionBuscarAlumnos.Location = new System.Drawing.Point(666, 78);
            this.cboOpcionBuscarAlumnos.Name = "cboOpcionBuscarAlumnos";
            this.cboOpcionBuscarAlumnos.Size = new System.Drawing.Size(126, 21);
            this.cboOpcionBuscarAlumnos.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Buscar:";
            // 
            // grbEdicioAlumnos
            // 
            this.grbEdicioAlumnos.Controls.Add(this.btnEliminarAlumnos);
            this.grbEdicioAlumnos.Controls.Add(this.btnModificarAlumnos);
            this.grbEdicioAlumnos.Controls.Add(this.btnNuevoAlumnos);
            this.grbEdicioAlumnos.Location = new System.Drawing.Point(250, 292);
            this.grbEdicioAlumnos.Name = "grbEdicioAlumnos";
            this.grbEdicioAlumnos.Size = new System.Drawing.Size(301, 97);
            this.grbEdicioAlumnos.TabIndex = 17;
            this.grbEdicioAlumnos.TabStop = false;
            this.grbEdicioAlumnos.Text = "Edicion";
            // 
            // btnEliminarAlumnos
            // 
            this.btnEliminarAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumnos.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarAlumnos.Location = new System.Drawing.Point(216, 37);
            this.btnEliminarAlumnos.Name = "btnEliminarAlumnos";
            this.btnEliminarAlumnos.Size = new System.Drawing.Size(85, 32);
            this.btnEliminarAlumnos.TabIndex = 2;
            this.btnEliminarAlumnos.Text = "Eliminar";
            this.btnEliminarAlumnos.UseVisualStyleBackColor = true;
            // 
            // btnModificarAlumnos
            // 
            this.btnModificarAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumnos.Location = new System.Drawing.Point(117, 38);
            this.btnModificarAlumnos.Name = "btnModificarAlumnos";
            this.btnModificarAlumnos.Size = new System.Drawing.Size(93, 31);
            this.btnModificarAlumnos.TabIndex = 1;
            this.btnModificarAlumnos.Text = "Modificar";
            this.btnModificarAlumnos.UseVisualStyleBackColor = true;
            // 
            // btnNuevoAlumnos
            // 
            this.btnNuevoAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAlumnos.Location = new System.Drawing.Point(36, 37);
            this.btnNuevoAlumnos.Name = "btnNuevoAlumnos";
            this.btnNuevoAlumnos.Size = new System.Drawing.Size(75, 32);
            this.btnNuevoAlumnos.TabIndex = 0;
            this.btnNuevoAlumnos.Text = "Nuevo";
            this.btnNuevoAlumnos.UseVisualStyleBackColor = true;
            // 
            // grbNavegacionAlumnos
            // 
            this.grbNavegacionAlumnos.Controls.Add(this.lblRegistroMateria);
            this.grbNavegacionAlumnos.Controls.Add(this.btnUltimaAlumnos);
            this.grbNavegacionAlumnos.Controls.Add(this.btnSiguienteAlumnos);
            this.grbNavegacionAlumnos.Controls.Add(this.btnAnteriorAlumnos);
            this.grbNavegacionAlumnos.Controls.Add(this.btnPrimeroAumnos);
            this.grbNavegacionAlumnos.Location = new System.Drawing.Point(25, 292);
            this.grbNavegacionAlumnos.Name = "grbNavegacionAlumnos";
            this.grbNavegacionAlumnos.Size = new System.Drawing.Size(219, 83);
            this.grbNavegacionAlumnos.TabIndex = 16;
            this.grbNavegacionAlumnos.TabStop = false;
            this.grbNavegacionAlumnos.Text = "Alumnos";
            // 
            // lblRegistroMateria
            // 
            this.lblRegistroMateria.AutoSize = true;
            this.lblRegistroMateria.Location = new System.Drawing.Point(69, 39);
            this.lblRegistroMateria.Name = "lblRegistroMateria";
            this.lblRegistroMateria.Size = new System.Drawing.Size(33, 13);
            this.lblRegistroMateria.TabIndex = 0;
            this.lblRegistroMateria.Text = "XD N";
            // 
            // btnUltimaAlumnos
            // 
            this.btnUltimaAlumnos.Location = new System.Drawing.Point(129, 30);
            this.btnUltimaAlumnos.Name = "btnUltimaAlumnos";
            this.btnUltimaAlumnos.Size = new System.Drawing.Size(25, 27);
            this.btnUltimaAlumnos.TabIndex = 7;
            this.btnUltimaAlumnos.Text = ">|";
            this.btnUltimaAlumnos.UseVisualStyleBackColor = true;
            this.btnUltimaAlumnos.Click += new System.EventHandler(this.btnUltimaAlumnos_Click);
            // 
            // btnSiguienteAlumnos
            // 
            this.btnSiguienteAlumnos.Location = new System.Drawing.Point(108, 30);
            this.btnSiguienteAlumnos.Name = "btnSiguienteAlumnos";
            this.btnSiguienteAlumnos.Size = new System.Drawing.Size(25, 27);
            this.btnSiguienteAlumnos.TabIndex = 6;
            this.btnSiguienteAlumnos.Text = ">";
            this.btnSiguienteAlumnos.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorAlumnos
            // 
            this.btnAnteriorAlumnos.Location = new System.Drawing.Point(24, 30);
            this.btnAnteriorAlumnos.Name = "btnAnteriorAlumnos";
            this.btnAnteriorAlumnos.Size = new System.Drawing.Size(23, 31);
            this.btnAnteriorAlumnos.TabIndex = 5;
            this.btnAnteriorAlumnos.Text = "<";
            this.btnAnteriorAlumnos.UseVisualStyleBackColor = true;
            // 
            // btnPrimeroAumnos
            // 
            this.btnPrimeroAumnos.Location = new System.Drawing.Point(6, 30);
            this.btnPrimeroAumnos.Name = "btnPrimeroAumnos";
            this.btnPrimeroAumnos.Size = new System.Drawing.Size(23, 31);
            this.btnPrimeroAumnos.TabIndex = 4;
            this.btnPrimeroAumnos.Text = "|<";
            this.btnPrimeroAumnos.UseVisualStyleBackColor = true;
            // 
            // grbDatosAlumnos
            // 
            this.grbDatosAlumnos.Controls.Add(this.txtTelefonoAlumnos);
            this.grbDatosAlumnos.Controls.Add(this.label5);
            this.grbDatosAlumnos.Controls.Add(this.txtDireccionAlumnos);
            this.grbDatosAlumnos.Controls.Add(this.txtNombreAlumnos);
            this.grbDatosAlumnos.Controls.Add(this.txtCodigoAlumnos);
            this.grbDatosAlumnos.Controls.Add(this.label4);
            this.grbDatosAlumnos.Controls.Add(this.label3);
            this.grbDatosAlumnos.Controls.Add(this.label1);
            this.grbDatosAlumnos.Location = new System.Drawing.Point(9, 52);
            this.grbDatosAlumnos.Name = "grbDatosAlumnos";
            this.grbDatosAlumnos.Size = new System.Drawing.Size(542, 220);
            this.grbDatosAlumnos.TabIndex = 15;
            this.grbDatosAlumnos.TabStop = false;
            this.grbDatosAlumnos.Text = "Datos Alumnos";
            this.grbDatosAlumnos.Enter += new System.EventHandler(this.grbDatosAlumno_Enter);
            // 
            // txtDireccionAlumnos
            // 
            this.txtDireccionAlumnos.Location = new System.Drawing.Point(77, 106);
            this.txtDireccionAlumnos.Name = "txtDireccionAlumnos";
            this.txtDireccionAlumnos.ReadOnly = true;
            this.txtDireccionAlumnos.Size = new System.Drawing.Size(193, 20);
            this.txtDireccionAlumnos.TabIndex = 5;
            // 
            // txtNombreAlumnos
            // 
            this.txtNombreAlumnos.Location = new System.Drawing.Point(77, 62);
            this.txtNombreAlumnos.Name = "txtNombreAlumnos";
            this.txtNombreAlumnos.ReadOnly = true;
            this.txtNombreAlumnos.Size = new System.Drawing.Size(193, 20);
            this.txtNombreAlumnos.TabIndex = 4;
            // 
            // txtCodigoAlumnos
            // 
            this.txtCodigoAlumnos.Location = new System.Drawing.Point(77, 26);
            this.txtCodigoAlumnos.Name = "txtCodigoAlumnos";
            this.txtCodigoAlumnos.ReadOnly = true;
            this.txtCodigoAlumnos.Size = new System.Drawing.Size(193, 20);
            this.txtCodigoAlumnos.TabIndex = 3;
            this.txtCodigoAlumnos.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // grdDatosAlumnos
            // 
            this.grdDatosAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMateria,
            this.codigo,
            this.nombre,
            this.uv});
            this.grdDatosAlumnos.Location = new System.Drawing.Point(557, 122);
            this.grdDatosAlumnos.Name = "grdDatosAlumnos";
            this.grdDatosAlumnos.Size = new System.Drawing.Size(387, 277);
            this.grdDatosAlumnos.TabIndex = 14;
            // 
            // idMateria
            // 
            this.idMateria.DataPropertyName = "idMateria";
            this.idMateria.HeaderText = "ID";
            this.idMateria.Name = "idMateria";
            this.idMateria.ReadOnly = true;
            this.idMateria.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "materia";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // uv
            // 
            this.uv.DataPropertyName = "uv";
            this.uv.HeaderText = "UV";
            this.uv.Name = "uv";
            this.uv.ReadOnly = true;
            // 
            // txtTelefonoAlumnos
            // 
            this.txtTelefonoAlumnos.Location = new System.Drawing.Point(77, 152);
            this.txtTelefonoAlumnos.Name = "txtTelefonoAlumnos";
            this.txtTelefonoAlumnos.ReadOnly = true;
            this.txtTelefonoAlumnos.Size = new System.Drawing.Size(193, 20);
            this.txtTelefonoAlumnos.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefono";
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.txtBuscarAlumnos);
            this.Controls.Add(this.cboOpcionBuscarAlumnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbEdicioAlumnos);
            this.Controls.Add(this.grbNavegacionAlumnos);
            this.Controls.Add(this.grbDatosAlumnos);
            this.Controls.Add(this.grdDatosAlumnos);
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.grbEdicioAlumnos.ResumeLayout(false);
            this.grbNavegacionAlumnos.ResumeLayout(false);
            this.grbNavegacionAlumnos.PerformLayout();
            this.grbDatosAlumnos.ResumeLayout(false);
            this.grbDatosAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarAlumnos;
        private System.Windows.Forms.ComboBox cboOpcionBuscarAlumnos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbEdicioAlumnos;
        private System.Windows.Forms.Button btnEliminarAlumnos;
        private System.Windows.Forms.Button btnModificarAlumnos;
        private System.Windows.Forms.Button btnNuevoAlumnos;
        private System.Windows.Forms.GroupBox grbNavegacionAlumnos;
        private System.Windows.Forms.Label lblRegistroMateria;
        private System.Windows.Forms.Button btnUltimaAlumnos;
        private System.Windows.Forms.Button btnSiguienteAlumnos;
        private System.Windows.Forms.Button btnAnteriorAlumnos;
        private System.Windows.Forms.Button btnPrimeroAumnos;
        private System.Windows.Forms.GroupBox grbDatosAlumnos;
        private System.Windows.Forms.TextBox txtDireccionAlumnos;
        private System.Windows.Forms.TextBox txtNombreAlumnos;
        private System.Windows.Forms.TextBox txtCodigoAlumnos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdDatosAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn uv;
        private System.Windows.Forms.TextBox txtTelefonoAlumnos;
        private System.Windows.Forms.Label label5;
    }
}