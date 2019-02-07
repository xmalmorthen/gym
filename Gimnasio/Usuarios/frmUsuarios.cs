using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gimnasio.Usuarios
{
    public partial class frmUsuarios : Gimnasio.Utilidades.frmPadre
    {
        clsUsuario oUsuario = new clsUsuario();

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            
            addEventos();
            refrescaLista();
            interfaz();
        }

        #region FUNCIONES COMUNES
        private void interfaz()
        {
            lblTitle.Text = "Registro de usuarios del sistema";

            dgvLista.Columns[0].Visible = false;
    
            if (dgvLista.Rows.Count > 0)
            {
                dgvLista.Columns[dgvLista.Columns.Count-1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void addEventos()
        {
            cmdNuevo.Click += new EventHandler(nuevo);
            cmdModificar.Click += new EventHandler(modificar);
            cmdDesabilitar.Click += new EventHandler(desabilita);
            cmdAbilitar.Click += new EventHandler(abilita);
            cmdEliminar.Click+=new EventHandler(elimina);
        }

        private void refrescaLista()
        {
            if (!oUsuario.getDatos(dgvLista))
            {
                MessageBox.Show(oUsuario.getError());
            }
           
     
        }
        #endregion

        #region EVENTOS DE BOTONES

        private void nuevo(object sender, EventArgs e)
        {
            frmUsuario frmUs = new frmUsuario();
            frmUs.ShowDialog();
            refrescaLista();
        }

        private void modificar(object sender, EventArgs e)
        {
            int id = Utilidades.OperacionesFormulario.getId(dgvLista);
            if (id > 0)
            {

                frmUsuario frmUs = new frmUsuario();
                frmUs.idUsuario = id;
                frmUs.ShowDialog();
                refrescaLista();
            }
            else
            {
                MessageBox.Show(this,"Debe seleccionar una fila","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void desabilita(object sender, EventArgs e)
        {
            int id = Utilidades.OperacionesFormulario.getId(dgvLista);
            if (id > 0)
            {
                if (oUsuario.changeState(2, id))
                {
                    refrescaLista();
                }
                else
                {
                    MessageBox.Show(this,"Ocurrió un error "+oUsuario.getError(),"Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show(this, "Debe seleccionar una fila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void abilita(object sender, EventArgs e)
        {
            int id = Utilidades.OperacionesFormulario.getId(dgvLista);
            if (id > 0)
            {
                if (oUsuario.changeState(1, id))
                {
                    refrescaLista();
                }
                else
                {
                    MessageBox.Show(this, "Ocurrió un error " + oUsuario.getError(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(this, "Debe seleccionar una fila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void elimina(object sender, EventArgs e)
        {
            int id = Utilidades.OperacionesFormulario.getId(dgvLista);
            if (id > 0)
            {
                if (MessageBox.Show(this,"Estas seguro de eliminar el registro seleccionado", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (oUsuario.changeState(3, id))
                    {
                        refrescaLista();
                    }
                    else
                    {
                        MessageBox.Show(this, "Ocurrió un error " + oUsuario.getError(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show(this, "Debe seleccionar una fila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        #endregion

      

       
    }
}
