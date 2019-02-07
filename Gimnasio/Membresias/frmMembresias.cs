using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gimnasio.Membresias
{
    public partial class frmMembresias : Gimnasio.Utilidades.frmPadre
    {
        clsMembresia oMembresia = new clsMembresia();

        public frmMembresias()
        {
            InitializeComponent();
        }

        private void frmMembresias_Load(object sender, EventArgs e)
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
                lblTitle.Text = "Membresias";
                dgvLista.Columns[0].Visible = false;
                dgvLista.Columns[dgvLista.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
            }catch(Exception ex){
                MessageBox.Show(this,"Error de sistema "+ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void addEventos()
        {
            cmdNuevo.Click += new EventHandler(nuevo);
            cmdModificar.Click += new EventHandler(modificar);
            cmdDesabilitar.Click += new EventHandler(desabilita);
            cmdAbilitar.Click += new EventHandler(abilita);
            cmdEliminar.Click += new EventHandler(elimina);
        }

        private void refrescaLista()
        {
            if (!oMembresia.getDatos(dgvLista))
            {
                MessageBox.Show(this, oMembresia.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                dgvLista.Columns[3].HeaderText = "Meses";
                dgvLista.Columns[4].HeaderText = "Hora de inicio";
                dgvLista.Columns[5].HeaderText = "Hora final";
                dgvLista.Columns[6].HeaderText = "Fecha de creación";
            }


        }
        #endregion

        #region EVENTOS DE BOTONES

        private void nuevo(object sender, EventArgs e)
        {
            frmMembresia frmUs = new frmMembresia();
            frmUs.ShowDialog();
            refrescaLista();
        }

        private void modificar(object sender, EventArgs e)
        {
            int id = Utilidades.OperacionesFormulario.getId(dgvLista);
            if (id > 0)
            {

                frmMembresia frm = new frmMembresia();
                frm.idMembresia = id;
                frm.ShowDialog();
                refrescaLista();
            }
            else
            {
                MessageBox.Show(this, "Debe existir una fila seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void desabilita(object sender, EventArgs e)
        {
            int id = Utilidades.OperacionesFormulario.getId(dgvLista);
            if (id > 0)
            {
                if (id == 1)
                {
                    MessageBox.Show(this, "No puedes realizar esta acción en la membresia visita", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (oMembresia.changeState(2, id))
                {
                    refrescaLista();
                }
                else
                {
                    MessageBox.Show(this, "Ocurrió un error " + oMembresia.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(this, "Debe existir una fila seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void abilita(object sender, EventArgs e)
        {
            int id = Utilidades.OperacionesFormulario.getId(dgvLista);
            if (id > 0)
            {
                if (id == 1)
                {
                    MessageBox.Show(this, "No puedes realizar esta acción en la membresia visita", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (oMembresia.changeState(1, id))
                {
                    refrescaLista();
                }
                else
                {
                    MessageBox.Show(this, "Ocurrió un error " + oMembresia.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(this, "Debe existir una fila seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void elimina(object sender, EventArgs e)
        {
            int id = Utilidades.OperacionesFormulario.getId(dgvLista);
            if (id > 0)
            {
                if (id == 1)
                {
                    MessageBox.Show(this, "No puedes eliminar la membresia visita", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show(this,"Estas seguro de eliminar el registro seleccionado", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (oMembresia.changeState(3, id))
                    {
                        refrescaLista();
                    }
                    else
                    {
                        MessageBox.Show(this, "Ocurrió un error " + oMembresia.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show(this, "Debe existir una fila seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        #endregion
    }
}
