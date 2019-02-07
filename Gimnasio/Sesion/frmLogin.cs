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
    public partial class frmLogin : Form
    {
        Boolean session = false;

        public frmLogin()
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
                session = true;
                this.Close();
            }
            else
            {
                MessageBox.Show(this,Utilidades.clsUsuario.error,"Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !this.session;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();
            //VALIDACIONES
            if (usuario.Equals("") || password.Equals(""))
            {
                MessageBox.Show(this, "Usuario y contraseña son obligatorios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //PROCESO
            if (Utilidades.clsUsuario.login(usuario, password))
            {
                if (MessageBox.Show(this, "Cerrar sistema", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Environment.Exit(1);
                }                
            }
            else
            {
                MessageBox.Show(this, Utilidades.clsUsuario.error, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
