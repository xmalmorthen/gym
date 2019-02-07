using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gimnasio.Sesion
{
    public partial class frmConfirm : Form
    {
        Boolean confirm = false;

        public frmConfirm()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();
            //VALIDACIONES
            if (usuario.Equals("") || password.Equals(""))
            {
                MessageBox.Show(this,"Usuario y contraseña son obligatorios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //PROCESO
            if (Utilidades.clsUsuario.login(usuario, password))
            {
                confirm = true;
                this.Close();
            }
            else
            {
                MessageBox.Show(this,Utilidades.clsUsuario.error,"Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = this.confirm ? System.Windows.Forms.DialogResult.OK : System.Windows.Forms.DialogResult.Cancel;            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
