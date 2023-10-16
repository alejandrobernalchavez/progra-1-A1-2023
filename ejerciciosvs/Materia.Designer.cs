
namespace ejerciciosvs
{
    partial class Materia
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
            this.components = new System.ComponentModel.Container();
            this.grdDatosMaterias = new System.Windows.Forms.DataGridView();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDatosMateria = new System.Windows.Forms.GroupBox();
            this.txtUv = new System.Windows.Forms.TextBox();
            this.txtNombr = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbNavegacionMateria = new System.Windows.Forms.GroupBox();
            this.lblRegistroMateria = new System.Windows.Forms.Label();
            this.btnUltimaMateria = new System.Windows.Forms.Button();
            this.btnSiguienteMateria = new System.Windows.Forms.Button();
            this.btnAnteriorMateria = new System.Windows.Forms.Button();
            this.btnPrimeromateria = new System.Windows.Forms.Button();
            this.grbEdicionMateria = new System.Windows.Forms.GroupBox();
            this.btnEliminarMaterias = new System.Windows.Forms.Button();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.btnNuevoMateria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboOpcionBuscarMateria = new System.Windows.Forms.ComboBox();
            this.txtBuscarMaterias = new System.Windows.Forms.TextBox();
            this.erpMateria = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMaterias)).BeginInit();
            this.grbDatosMateria.SuspendLayout();
            this.grbNavegacionMateria.SuspendLayout();
            this.grbEdicionMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatosMaterias
            // 
            this.grdDatosMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMateria,
            this.codigo,
            this.nombre,
            this.uv});
            this.grdDatosMaterias.Location = new System.Drawing.Point(560, 82);
            this.grdDatosMaterias.Name = "grdDatosMaterias";
            this.grdDatosMaterias.Size = new System.Drawing.Size(387, 277);
            this.grdDatosMaterias.TabIndex = 0;
            this.grdDatosMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosMaterias_CellClick);
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
            // grbDatosMateria
            // 
            this.grbDatosMateria.Controls.Add(this.txtUv);
            this.grbDatosMateria.Controls.Add(this.txtNombr);
            this.grbDatosMateria.Controls.Add(this.txtCodigo);
            this.grbDatosMateria.Controls.Add(this.label4);
            this.grbDatosMateria.Controls.Add(this.label3);
            this.grbDatosMateria.Controls.Add(this.label1);
            this.grbDatosMateria.ForeColor = System.Drawing.Color.Black;
            this.grbDatosMateria.Location = new System.Drawing.Point(12, 12);
            this.grbDatosMateria.Name = "grbDatosMateria";
            this.grbDatosMateria.Size = new System.Drawing.Size(542, 220);
            this.grbDatosMateria.TabIndex = 1;
            this.grbDatosMateria.TabStop = false;
            this.grbDatosMateria.Text = "Datos Materias";
            // 
            // txtUv
            // 
            this.txtUv.Location = new System.Drawing.Point(40, 109);
            this.txtUv.Name = "txtUv";
            this.txtUv.ReadOnly = true;
            this.txtUv.Size = new System.Drawing.Size(193, 20);
            this.txtUv.TabIndex = 5;
            // 
            // txtNombr
            // 
            this.txtNombr.Location = new System.Drawing.Point(68, 65);
            this.txtNombr.Name = "txtNombr";
            this.txtNombr.ReadOnly = true;
            this.txtNombr.Size = new System.Drawing.Size(193, 20);
            this.txtNombr.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(68, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(193, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "uv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Materia:";
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
            // grbNavegacionMateria
            // 
            this.grbNavegacionMateria.Controls.Add(this.lblRegistroMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnUltimaMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnSiguienteMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnAnteriorMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnPrimeromateria);
            this.grbNavegacionMateria.ForeColor = System.Drawing.Color.Black;
            this.grbNavegacionMateria.Location = new System.Drawing.Point(28, 252);
            this.grbNavegacionMateria.Name = "grbNavegacionMateria";
            this.grbNavegacionMateria.Size = new System.Drawing.Size(219, 83);
            this.grbNavegacionMateria.TabIndex = 2;
            this.grbNavegacionMateria.TabStop = false;
            this.grbNavegacionMateria.Text = "Materia";
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
            // btnUltimaMateria
            // 
            this.btnUltimaMateria.Location = new System.Drawing.Point(129, 30);
            this.btnUltimaMateria.Name = "btnUltimaMateria";
            this.btnUltimaMateria.Size = new System.Drawing.Size(25, 27);
            this.btnUltimaMateria.TabIndex = 7;
            this.btnUltimaMateria.Text = ">|";
            this.btnUltimaMateria.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteMateria
            // 
            this.btnSiguienteMateria.Location = new System.Drawing.Point(108, 30);
            this.btnSiguienteMateria.Name = "btnSiguienteMateria";
            this.btnSiguienteMateria.Size = new System.Drawing.Size(25, 27);
            this.btnSiguienteMateria.TabIndex = 6;
            this.btnSiguienteMateria.Text = ">";
            this.btnSiguienteMateria.UseVisualStyleBackColor = true;
            this.btnSiguienteMateria.Click += new System.EventHandler(this.btnSiguienteMateria_Click);
            // 
            // btnAnteriorMateria
            // 
            this.btnAnteriorMateria.Location = new System.Drawing.Point(24, 30);
            this.btnAnteriorMateria.Name = "btnAnteriorMateria";
            this.btnAnteriorMateria.Size = new System.Drawing.Size(23, 31);
            this.btnAnteriorMateria.TabIndex = 5;
            this.btnAnteriorMateria.Text = "<";
            this.btnAnteriorMateria.UseVisualStyleBackColor = true;
            this.btnAnteriorMateria.Click += new System.EventHandler(this.btnAnteriorMateria_Click);
            // 
            // btnPrimeromateria
            // 
            this.btnPrimeromateria.Location = new System.Drawing.Point(6, 30);
            this.btnPrimeromateria.Name = "btnPrimeromateria";
            this.btnPrimeromateria.Size = new System.Drawing.Size(23, 31);
            this.btnPrimeromateria.TabIndex = 4;
            this.btnPrimeromateria.Text = "|<";
            this.btnPrimeromateria.UseVisualStyleBackColor = true;
            this.btnPrimeromateria.Click += new System.EventHandler(this.btnPrimeroMateria_Click);
            // 
            // grbEdicionMateria
            // 
            this.grbEdicionMateria.Controls.Add(this.btnEliminarMaterias);
            this.grbEdicionMateria.Controls.Add(this.btnModificarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnNuevoMateria);
            this.grbEdicionMateria.ForeColor = System.Drawing.Color.Black;
            this.grbEdicionMateria.Location = new System.Drawing.Point(253, 252);
            this.grbEdicionMateria.Name = "grbEdicionMateria";
            this.grbEdicionMateria.Size = new System.Drawing.Size(301, 97);
            this.grbEdicionMateria.TabIndex = 3;
            this.grbEdicionMateria.TabStop = false;
            this.grbEdicionMateria.Text = "Edicion";
            // 
            // btnEliminarMaterias
            // 
            this.btnEliminarMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMaterias.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarMaterias.Location = new System.Drawing.Point(216, 37);
            this.btnEliminarMaterias.Name = "btnEliminarMaterias";
            this.btnEliminarMaterias.Size = new System.Drawing.Size(85, 32);
            this.btnEliminarMaterias.TabIndex = 2;
            this.btnEliminarMaterias.Text = "Eliminar";
            this.btnEliminarMaterias.UseVisualStyleBackColor = true;
            this.btnEliminarMaterias.Click += new System.EventHandler(this.btnEliminarMateria_Click);
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMateria.Location = new System.Drawing.Point(117, 38);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(93, 31);
            this.btnModificarMateria.TabIndex = 1;
            this.btnModificarMateria.Text = "Modificar";
            this.btnModificarMateria.UseVisualStyleBackColor = true;
            this.btnModificarMateria.Click += new System.EventHandler(this.btnModificarMateria_Click);
            // 
            // btnNuevoMateria
            // 
            this.btnNuevoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoMateria.Location = new System.Drawing.Point(36, 37);
            this.btnNuevoMateria.Name = "btnNuevoMateria";
            this.btnNuevoMateria.Size = new System.Drawing.Size(75, 32);
            this.btnNuevoMateria.TabIndex = 0;
            this.btnNuevoMateria.Text = "Nuevo";
            this.btnNuevoMateria.UseVisualStyleBackColor = true;
            this.btnNuevoMateria.Click += new System.EventHandler(this.btnNuevoMateria_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(620, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar:";
            // 
            // cboOpcionBuscarMateria
            // 
            this.cboOpcionBuscarMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBuscarMateria.FormattingEnabled = true;
            this.cboOpcionBuscarMateria.Items.AddRange(new object[] {
            "Codigo",
            "Nombre"});
            this.cboOpcionBuscarMateria.Location = new System.Drawing.Point(669, 38);
            this.cboOpcionBuscarMateria.Name = "cboOpcionBuscarMateria";
            this.cboOpcionBuscarMateria.Size = new System.Drawing.Size(126, 21);
            this.cboOpcionBuscarMateria.TabIndex = 5;
            // 
            // txtBuscarMaterias
            // 
            this.txtBuscarMaterias.Location = new System.Drawing.Point(801, 38);
            this.txtBuscarMaterias.Name = "txtBuscarMaterias";
            this.txtBuscarMaterias.Size = new System.Drawing.Size(136, 20);
            this.txtBuscarMaterias.TabIndex = 6;
            this.txtBuscarMaterias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarMaterias_KeyUp);
            // 
            // erpMateria
            // 
            this.erpMateria.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(68, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(12, 8);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 371);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscarMaterias);
            this.Controls.Add(this.cboOpcionBuscarMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbEdicionMateria);
            this.Controls.Add(this.grbNavegacionMateria);
            this.Controls.Add(this.grbDatosMateria);
            this.Controls.Add(this.grdDatosMaterias);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Materia";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.Materia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMaterias)).EndInit();
            this.grbDatosMateria.ResumeLayout(false);
            this.grbDatosMateria.PerformLayout();
            this.grbNavegacionMateria.ResumeLayout(false);
            this.grbNavegacionMateria.PerformLayout();
            this.grbEdicionMateria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDatosMaterias;
        private System.Windows.Forms.GroupBox grbDatosMateria;
        private System.Windows.Forms.GroupBox grbNavegacionMateria;
        private System.Windows.Forms.GroupBox grbEdicionMateria;
        private System.Windows.Forms.Button btnPrimeromateria;
        private System.Windows.Forms.Label lblRegistroMateria;
        private System.Windows.Forms.Button btnUltimaMateria;
        private System.Windows.Forms.Button btnSiguienteMateria;
        private System.Windows.Forms.Button btnAnteriorMateria;
        private System.Windows.Forms.Button btnEliminarMaterias;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Button btnNuevoMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboOpcionBuscarMateria;
        private System.Windows.Forms.TextBox txtBuscarMaterias;
        private System.Windows.Forms.TextBox txtUv;
        private System.Windows.Forms.TextBox txtNombr;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn uv;
        private System.Windows.Forms.ErrorProvider erpMateria;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}