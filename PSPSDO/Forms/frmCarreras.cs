using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Segundo_Parcial_2.Clases;
using PSPSDO.Classes;

namespace PSPSDO.Forms
{
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            updateCarrera Opciones = new updateCarrera();
            Opciones.add(dgvCarreras,txtNombre.Text,txtClave.Text,txtDescripcion.Text);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            updateCarrera Opciones = new updateCarrera();
            Opciones.delete(dgvCarreras, dgvCarreras.CurrentCell.RowIndex);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            updateCarrera Opciones = new updateCarrera();
            Opciones.show(dgvCarreras);
        }
    }
}
