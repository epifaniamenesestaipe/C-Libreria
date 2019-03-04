using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatosYNegocio;

namespace CapaPresentacion
{
    public partial class frmPersonal_Insertar : Form
    {
        public frmPersonal_Insertar()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsPersonal nuevo;
            nuevo = new clsPersonal(22,txtDNIPersonal.Text, txtNombres.Text, txtApPaterno.Text, txtApMaterno.Text, txtDireccionPers.Text,Convert.ToBoolean(rbMasculino.Checked), txtIniSesionPer.Text, txtContraseniaPers.Text, Convert.ToString(cmbCargo.SelectedItem), System.DateTime.Now);
            nuevo.Telefono = txtTelefonoPers.Text;
            nuevo.Insertar();
            MessageBox.Show("personal insertada yupiiii");
        }
    }
}
