using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gimnasio.Usuarios
{
    public partial class frmUsuario : Form
    {
        Boolean cancel = false;
        public int idUsuario = 0;
        clsUsuario oUsuario = new clsUsuario();

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            
            if (idUsuario > 0)
            {
                cargaDatos();
            }
        }

        private void cargaDatos()
        {
            if (oUsuario.getDatos(idUsuario))
            {
                txtUsuario.Text = oUsuario.datos.Usuario;
                txtNombre.Text = oUsuario.datos.Nombre;
            }
            else
            {
                MessageBox.Show(this, "Ocurrió un problema al cargar los datos " + oUsuario.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idUsuario <= 0)
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
            
            oUsuario.Usuario = txtUsuario.Text.Trim();
            oUsuario.Nombre = txtNombre.Text.Trim();
            oUsuario.Password = txtPassword.Text.Trim();            

            if (oUsuario.Usuario.Equals("") || oUsuario.Password.Equals(""))
            {
                MessageBox.Show(this, "Usuario y contraseña son obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (oUsuario.Password != txtPasswordConfirm.Text) {
                MessageBox.Show(this,"La contraseña y la confirmación de contraseña no coinciden","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (oUsuario.add())
            {
                MessageBox.Show(this, "Registro agregado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show(this, oUsuario.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
        }

        private void modifica()
        {
            oUsuario.Usuario = txtUsuario.Text.Trim();
            oUsuario.Nombre = txtNombre.Text.Trim();
            oUsuario.Password = txtPassword.Text.Trim();

            if (oUsuario.Usuario.Equals("") || oUsuario.Password.Equals(""))
            {
                MessageBox.Show(this, "Usuario y contraseña son obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (oUsuario.Password != txtPasswordConfirm.Text)
            {
                MessageBox.Show(this, "La contraseña y la confirmación de contraseña no coinciden", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (oUsuario.edit(idUsuario))
            {
                MessageBox.Show(this, "Registro modificado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show(this, oUsuario.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.cancel)
            {
                if (MessageBox.Show(this, "Estás seguro de cancelar", "Confirma cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.cancel = true;
            this.Close();
        }

    }
}
