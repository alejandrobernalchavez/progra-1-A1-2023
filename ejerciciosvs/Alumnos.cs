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
    public partial class Alumnos : Form
    {

        Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();
        public int posicion = 0;
        String accion = "nuevo";
        public Alumnos()
        {
            InitializeComponent();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            actualizarDsAlumnos();
            cboOpcionBuscarAlumnos.SelectedIndex = 1;
        }
        private void actualizarDsAlumnos()
        {
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            miTabla = miDs.Tables["Alumno"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idAlumno"] };
            mostrarAlumnos();
            mostrarDatosAlumno();
        }
        private void mostrarAlumnos()
        {

            grdDatosAlumnos.DataSource = miTabla.DefaultView;
        }
        private void filtrarAlumnos(String valor, int opcion)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = grdDatosAlumnos.DataSource;
                bs.Filter = opcion == 0 ? "codigo=" + valor : "Alumno like '%" + valor + "%'";
                grdDatosAlumnos.DataSource = bs;
                //erpAlumno.SetError(txtBuscarAlumnos, "");
            }
            catch (Exception e)
            {
                //erpAlumno.SetError(txtBuscarAlumnos, "Por favor ingrese un codigo o Alumno a buscr");
            }
        }
        private void mostrarDatosAlumno()
        {
            if (miTabla.Rows.Count > 0)
            {
                //cambia de un formulario a otro
                txtCodigoAlumnos.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtNombreAlumnos.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtDireccionAlumnos.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtTelefonoAlumnos.Text = miTabla.Rows[posicion].ItemArray[4].ToString();

                lblRegistroMateria.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
                
            }
            else
            {
                limpiarCajas();
            }
        }

        private void btnSiguienteAlumno_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosAlumno();
            }
            else
            {
                MessageBox.Show("Ultimo Registro", "Registro de Alumnos");
            }
        }

        private void btnUltimaAlumno_ClickbtnUltimoAlumno_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosAlumno();
        }

        private void btnAnteriorAlumno_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosAlumno();
            }
            else
            {
                MessageBox.Show("Primer regisro", "Registro de Alumnos");
            }
        }

        private void btnPrimeroAlumno_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosAlumno();
        }

        private void btnNuevoAlumno_Click(object sender, EventArgs e)
        {
            if (btnNuevoAlumnos.Text == "Nuevo")
            {
                btnNuevoAlumnos.Text = "Guardar";
                btnModificarAlumnos.Text = "Cancelar";
                estadoControles(false);
                limpiarCajas();
                accion = "nuevo";
            }
            else
            {//Guardar
                //cambia de un formulario a otro
                String[] Alumnos = new string[] {
                    accion,txtCodigoAlumnos.Text, txtNombreAlumnos.Text, txtDireccionAlumnos.Text,txtTelefonoAlumnos.Text,
                    miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String msg = objConexion.mantenimientoAlumnos(Alumnos);
                if (msg != "1")
                {
                    MessageBox.Show("Error en el registro de Alumnos: " + msg, "Registro de Alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    actualizarDsAlumnos();
                    estadoControles(true);
                    btnNuevoAlumnos.Text = "Nuevo";
                    btnModificarAlumnos.Text = "Modificar";
                }
            }
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            if (btnModificarAlumnos.Text == "Modificar")
            {
                btnNuevoAlumnos.Text = "Guardar";
                btnModificarAlumnos.Text = "Cancelar";
                estadoControles(false);
                accion = "modificar";
            }
            else
            {

                estadoControles(true);
                mostrarDatosAlumno();
                btnNuevoAlumnos.Text = "Nuevo";
                btnModificarAlumnos.Text = "Modificar";
            }
        }
        private void estadoControles(Boolean estado)
        {
            //cambia de un formulario a otro
            txtCodigoAlumnos.ReadOnly = estado;
            txtNombreAlumnos.ReadOnly = estado;
            txtDireccionAlumnos.ReadOnly = estado;
            txtTelefonoAlumnos.ReadOnly = estado;

            grbNavegacionAlumnos.Enabled = estado;
            btnEliminarAlumnos.Enabled = estado;
            txtBuscarAlumnos.ReadOnly = !estado;
        }
        private void limpiarCajas()
        {
            //cambia de un formulario a otro
            txtCodigoAlumnos.Text = "";
            txtNombreAlumnos.Text = "";
            txtDireccionAlumnos.Text = "";
            txtTelefonoAlumnos.Text = "";
        }

        private void txtBuscarAlumnos_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarAlumnos(txtBuscarAlumnos.Text, cboOpcionBuscarAlumnos.SelectedIndex);
            if (e.KeyValue == 13)
            {//tecla enter
                seleccionarAlumno();
            }
        }
        private void seleccionarAlumno()
        {
            posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosAlumnos.CurrentRow.Cells["idAlumno"].Value.ToString()));
            mostrarDatosAlumno();
        }

        private void grdDatosAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarAlumno();
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            //cambia de un formulario a otro
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreAlumnos.Text, "Eliminado Alumnos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] Alumnos = new string[] {
                    "eliminar",txtCodigoAlumnos.Text, txtNombreAlumnos.Text, txtDireccionAlumnos.Text,txtTelefonoAlumnos.Text,
                    miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String msg = objConexion.mantenimientoAlumnos(Alumnos);
                if (msg != "1")
                {
                    MessageBox.Show("Error en la eliminacion de Alumnos: " + msg, "Registro de Alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDsAlumnos();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
