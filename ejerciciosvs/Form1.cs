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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        private void btnEdan_Click(object sender, EventArgs e)
        {
            int Edad = int.Parse(txtEdad.Text);
            //ESTRUCTURA DE COMTROL ...
            //IF condicional. si cumple se ejecuta el bloque de codigo. 
            if (Edad >= 18)
            {
                MessageBox.Show("Bienvenido eres responsable de tus acciones.");
            }
        }
    }
}
