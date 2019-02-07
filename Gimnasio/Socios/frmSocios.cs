using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gimnasio.Socios
{
    public partial class frmSocios : Gimnasio.Utilidades.frmPadre
    {
        clsSocio oSocio = new clsSocio();

        public frmSocios()
        {
            InitializeComponent();
        }

        private void frmSocios_Load(object sender, EventArgs e)
        {
            addEventos();
            refrescaLista();
            interfaz();
        }

        #region FUNCIONES COMUNES
        private void interfaz()
        {
            try
            {
                lblTitle.Text = "Socios";
                
                dgvLista.Columns[dgvLista.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(this,"Error de sistema " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void addEventos()
        {
            cmdNuevo.Click += new EventHandler(nuevo);
            cmdModificar.Click += new EventHandler(modificar);
            cmdDesabilitar.Click += new EventHandler(desabilita);
            cmdAbilitar.Click += new EventHandler(abilita);
            cmdEliminar.Click += new EventHandler(elimina);
            button1.Click+=new EventHandler(membresia);
        }

        private void refrescaLista()
        {
            if (!oSocio.getDatos(dgvLista))
            {
                MessageBox.Show(this, oSocio.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                dgvLista.Columns[2].HeaderText = "Primer apellido";
                dgvLista.Columns[3].HeaderText = "Segundo apellido";
                dgvLista.Columns[4].HeaderText = "Teléfono";
                dgvLista.Columns[5].HeaderText = "Fecha de creación";
            }
            
        }
        #endregion

        #region EVENTOS DE BOTONES

        private void nuevo(object sender, EventArgs e)
        {
            frmSocio frmUs = new frmSocio();
            frmUs.ShowDialog();
            refrescaLista();
        }

        private void modificar(object sender, EventArgs e)
        {
            int id = Utilidades.OperacionesFormulario.getId(dgvLista);
            if (id > 0)
            {

                frmSocio frm = new frmSocio();
                frm.id = id;
                frm.ShowDialog();
                refrescaLista();
            }
            else
            {
                MessageBox.Show(this, "Debe existir una fila seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void desabilita(object sender, EventArgs e)
        {
            int id = Utilidades.OperacionesFormulario.getId(dgvLista);
            if (id > 0)
            {
                if (oSocio.changeState(2, id))
                {
                    refrescaLista();
                }
                else
                {
                    MessageBox.Show(this, "Ocurrió un error " + oSocio.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(this, "Debe existir una fila seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void abilita(object sender, EventArgs e)
        {
            int id = Utilidades.OperacionesFormulario.getId(dgvLista);
            if (id > 0)
            {
                if (oSocio.changeState(1, id))
                {
                    refrescaLista();
                }
                else
                {
                    MessageBox.Show(this, "Ocurrió un error " + oSocio.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(this, "Debe existir una fila seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void elimina(object sender, EventArgs e)
        {
            int id = Utilidades.OperacionesFormulario.getId(dgvLista);
            if (id > 0)
            {
                if (MessageBox.Show(this,"Estas seguro de eliminar el registro seleccionado", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (oSocio.changeState(3, id))
                    {
                        refrescaLista();
                    }
                    else
                    {
                        MessageBox.Show(this, "Ocurrió un error " + oSocio.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show(this, "Debe existir una fila seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// abre formulario de membresias de socios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void membresia(object sender, EventArgs e)
        {
            int id = Utilidades.OperacionesFormulario.getId(dgvLista);
            if (id > 0)
            {
                FrmMembresia frmM = new FrmMembresia();
                frmM.id = id;
                frmM.ShowDialog();
                refrescaLista();
            }
            else
            {
                MessageBox.Show(this, "Debe existir una fila seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #endregion
    }
}
