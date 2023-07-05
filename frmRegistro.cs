using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaoIEFI3
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            Clase Pais = new Clase();
            Pais.CargarCombo(cmbPais);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtAgregaraPais.Text == "")
            {
                MessageBox.Show("Ingrese el Pais que quiere agregar");
                return;
            }
            else
            {
                Clase NuevoPais = new Clase();
                NuevoPais.CargarPais(txtAgregaraPais.Text);
                NuevoPais.CargarCombo(cmbPais);

                txtAgregaraPais.Text = "";
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string pais = cmbPais.Text;
            int edad = (int)numEdad.Value;
            bool esMasculino = rdbMasculino.Checked;
            decimal importe = decimal.Parse(txtImporte.Text);
            int puntaje = int.Parse(txtPuntaje.Text);

            
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbPais.SelectedIndex = -1;
            numEdad.Value = 0;
            rdbFemenino.Checked = false;
            rdbMasculino.Checked = false;
            txtImporte.Text = "";
            txtPuntaje.Text = "";

            if (numEdad.Value < 49 && puntaje > 130 && importe > 1000)
            {
                Clase Socio = new Clase();
                Socio.AgregarSocio(nombre, apellido, pais, edad, esMasculino, importe, puntaje);

                MessageBox.Show("Socio agregado con exito");
            }
            else
            {
                MessageBox.Show("Recuerde que la edad debe ser MENOR a 49, el importe MAYOR a 1000 y el puntaje MAYOR a 130");
                return;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text=="")
            {
                txtApellido.Enabled = false;
            }
            else
            {
                txtApellido.Enabled=true;
            }
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPais.SelectedIndex!=-1)
            {
                numEdad.Enabled = true;
            }
            else
            {
                numEdad.Enabled = false;
            }
        }

        private void numEdad_ValueChanged(object sender, EventArgs e)
        {
            if (numEdad.Value != 0)
            {
                cdrSexo.Enabled = true;
            }
            else
            {
                cdrSexo.Enabled=false;
            }
        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMasculino.Checked==true)
            {
                txtImporte.Enabled = true;
            }
            else
            {
                txtImporte.Enabled = false;
            }
        }

        private void txtImporte_TextChanged(object sender, EventArgs e)
        {
            if (txtImporte.Text!="")
            {
                txtPuntaje.Enabled = true;
            }
            else
            {
                txtPuntaje.Enabled = false;
            }
        }

        private void txtPuntaje_TextChanged(object sender, EventArgs e)
        {
            if (txtPuntaje.Text!="")
            {
                btnRegistrar.Enabled=true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }
    }
}
