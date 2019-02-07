using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Gimnasio.Socios
{
    public partial class frmSocio : Form
    {
        public int id = 0;
        clsSocio oSocio = new clsSocio();

        public frmSocio()
        {
            InitializeComponent();
        }

        private void frmSocio_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                cargaDatos();
            }

        }

        private void cargaDatos()
        {
            if (oSocio.getDatos(id))
            {

                txtNombre.Text = oSocio.datos.Nombre;
                txtPaterno.Text = oSocio.datos.Paterno;
                txtMaterno.Text = oSocio.datos.Materno;
                txtTelefono.Text = oSocio.datos.Telefono;
                txtObservaciones.Text = oSocio.datos.Observaciones;

                if(oSocio.datos.foto!=null)
                {
                    MemoryStream stream = new MemoryStream(oSocio.datos.foto);
                    Bitmap image = new Bitmap(stream);
                    pbFoto.Image = image;
                }

            }
            else
            {
                MessageBox.Show(this,"Ocurrió un problema al cargar los datos " + oSocio.getError(),"Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        /// <summary>
        /// aqui abrimos la captura de imagen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbFoto_Click(object sender, EventArgs e)
        {
            frmFoto frmF = new frmFoto();
            frmF.pbFotoSocio = pbFoto;
            frmF.Show();
            frmF.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id <= 0)
            {
                agrega();
            }
            else
            {
                modifica();
            }
        }

        private void agrega()
        {
            try
            {
                //validaciones
                if (txtNombre.Text.Trim().Equals("") || txtPaterno.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this,"Nombre y Primer apellido son obligatorios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
              

                //asignacion de datos
                oSocio.Nombre = txtNombre.Text.Trim();
                oSocio.Paterno = txtPaterno.Text.Trim();
                oSocio.Materno = txtMaterno.Text.Trim();
                oSocio.Telefono = txtTelefono.Text.Trim();
                oSocio.Observaciones = txtObservaciones.Text.Trim();
                if(pbFoto.Image!=null)
                oSocio.foto = Utilidades.OperacionesFormulario.conviertePicBoxImageToByte(pbFoto);
                oSocio.idUsuarioLog = Utilidades.clsUsuario.idUsuario;
                if (oSocio.add())
                {
                    MessageBox.Show(this, "Registro agregado con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(this, oSocio.getError(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception EX)
            {
                MessageBox.Show(this, "Ocurrió un error de sistema " + EX.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modifica()
        {

            try
            {
                //validaciones
                if (txtNombre.Text.Trim().Equals("") || txtPaterno.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this, "Nombre y Primer apellido son obligatorios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //asignacion de datos
                oSocio.Nombre = txtNombre.Text.Trim();
                oSocio.Paterno = txtPaterno.Text.Trim();
                oSocio.Materno = txtMaterno.Text.Trim();
                oSocio.Telefono = txtTelefono.Text.Trim();
                oSocio.Observaciones = txtObservaciones.Text.Trim();
                if (pbFoto.Image != null)
                    oSocio.foto = Utilidades.OperacionesFormulario.conviertePicBoxImageToByte(pbFoto);

                oSocio.idUsuarioLog = Utilidades.clsUsuario.idUsuario;
                if (oSocio.edit(id))
                {
                    MessageBox.Show(this, "Registro modificado con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(this, oSocio.getError(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception EX)
            {
                MessageBox.Show(this, "Ocurrió un error de sistema " + EX.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean cancel = false;
        private void button2_Click(object sender, EventArgs e)
        {
            this.cancel = true;
            this.Close();
        }

        private void frmSocio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.cancel)
            {
                if (MessageBox.Show(this, "Estás seguro de cancelar", "Confirma cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

    }
}
