using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerciciosvs
{
    public partial class Materia : Form
    {
        Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();
        public int posicion = 0;
        String accion = "nuevo";
        public Materia()
        {
            InitializeComponent();
        }

        private void Materia_Load(object sender, EventArgs e)
        {
            actualizarDsMaterias();
            cboOpcionBuscarMateria.SelectedIndex = 1;
        }
        private void actualizarDsMaterias()
        {
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            miTabla = miDs.Tables["Materia"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idMateria"] };
            mostrarMaterias();
            mostrarDatosMateria();
        }
        private void mostrarMaterias()
        {

            grdDatosMaterias.DataSource = miTabla.DefaultView;
        }
        private void filtrarMaterias(String valor, int opcion)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = grdDatosMaterias.DataSource;
                bs.Filter = opcion == 0 ? "codigo=" + valor : "materia like '%" + valor + "%'";
                grdDatosMaterias.DataSource = bs;
                erpMateria.SetError(txtBuscarMaterias, "");
            }
            catch (Exception e)
            {
                erpMateria.SetError(txtBuscarMaterias, "Por favor ingrese un codigo o materia a buscr");
            }
        }
        private void mostrarDatosMateria()
        {
            if (miTabla.Rows.Count > 0)
            {
                txtCodigo.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtNombr.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtUv.Text = miTabla.Rows[posicion].ItemArray[3].ToString();

                lblRegistroMateria.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
            }
            else
            {
                limpiarCajas();
            }
        }

        private void btnSiguienteMateria_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosMateria();
            }
            else
            {
                MessageBox.Show("Ultimo Registro", "Registro de Materias");
            }
        }

        private void btnUltimaMateria_ClickbtnUltimoMateria_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosMateria();
        }

        private void btnAnteriorMateria_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosMateria();
            }
            else
            {
                MessageBox.Show("Primer regisro", "Registro de Materias");
            }
        }

        private void btnPrimeroMateria_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosMateria();
        }

        private void btnNuevoMateria_Click(object sender, EventArgs e)
        {
            if (btnNuevoMateria.Text == "Nuevo")
            {
                btnNuevoMateria.Text = "Guardar";
                btnModificarMateria.Text = "Cancelar";
                estadoControles(false);
                limpiarCajas();
                accion = "nuevo";
            }
            else
            {//Guardar
                String[] materias = new string[] {
                    accion,txtCodigo.Text, txtNombr.Text, txtUv.Text,
                    miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String msg = objConexion.mantenimientoMaterias(materias);
                if (msg != "1")
                {
                    MessageBox.Show("Error en el registro de materias: " + msg, "Registro de Materias.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    actualizarDsMaterias();
                    estadoControles(true);
                    btnNuevoMateria.Text = "Nuevo";
                    btnModificarMateria.Text = "Modificar";
                }
            }
        }

        private void btnModificarMateria_Click(object sender, EventArgs e)
        {
            if (btnModificarMateria.Text == "Modificar")
            {
                btnNuevoMateria.Text = "Guardar";
                btnModificarMateria.Text = "Cancelar";
                estadoControles(false);
                accion = "modificar";
            }
            else
            {

                estadoControles(true);
                mostrarDatosMateria();
                btnNuevoMateria.Text = "Nuevo";
                btnModificarMateria.Text = "Modificar";
            }
        }
        private void estadoControles(Boolean estado)
        {
            txtCodigo.ReadOnly = estado;
            txtNombr.ReadOnly = estado;
            txtUv.ReadOnly = estado;

            grbNavegacionMateria.Enabled = estado;
            btnEliminarMaterias.Enabled = estado;
            txtBuscarMaterias.ReadOnly = !estado;
        }
        private void limpiarCajas()
        {
            txtCodigo.Text = "";
            txtNombr.Text = "";
            txtUv.Text = "";
        }

        private void txtBuscarMaterias_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarMaterias(txtBuscarMaterias.Text, cboOpcionBuscarMateria.SelectedIndex);
            if (e.KeyValue == 13)
            {//tecla enter
                seleccionarMateria();
            }
        }
        private void seleccionarMateria()
        {
            posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosMaterias.CurrentRow.Cells["idMateria"].Value.ToString()));
            mostrarDatosMateria();
        }

        private void grdDatosMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarMateria();
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombr.Text, "Eliminado Materias",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] materias = new string[] {
                    "eliminar",txtCodigo.Text, txtNombr.Text, txtUv.Text,
                    miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String msg = objConexion.mantenimientoMaterias(materias);
                if (msg != "1")
                {
                    MessageBox.Show("Error en la eliminacion de materias: " + msg, "Registro de Materias.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDsMaterias();
                }
            }
        }

        
        

        
    }
}
