using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gimnasio.Productos
{
    public partial class frmProductos : Gimnasio.Utilidades.frmPadre
    {
        clsProducto oProducto = new clsProducto();

        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
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
                lblTitle.Text = "Productos";
                dgvLista.Columns[0].Visible = false;
                dgvLista.Columns[dgvLista.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(this,"Error de sistema " + ex.Message,"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!oProducto.getDatos(dgvLista))
            {
                MessageBox.Show(this, oProducto.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvLista.Columns[2].HeaderText = "Descripción";
                dgvLista.Columns[5].HeaderText = "Fecha de creación";
            }


        }
        #endregion

        #region EVENTOS DE BOTONES

        private void nuevo(object sender, EventArgs e)
        {
            frmProducto frmUs = new frmProducto();
            frmUs.ShowDialog();
            refrescaLista();
        }

        private void modificar(object sender, EventArgs e)
        {
            int id = Utilidades.OperacionesFormulario.getId(dgvLista);
            if (id > 0)
            {

                frmProducto frm = new frmProducto();
                frm.id = id;
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
                if (oProducto.changeState(2, id))
                {
                    refrescaLista();
                }
                else
                {
                    MessageBox.Show(this, "Ocurrió un error " + oProducto.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (oProducto.changeState(1, id))
                {
                    refrescaLista();
                }
                else
                {
                    MessageBox.Show(this, "Ocurrió un error " + oProducto.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (MessageBox.Show(this,"Estas seguro de eliminar el registro seleccionado", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (oProducto.changeState(3, id))
                    {
                        refrescaLista();
                    }
                    else
                    {
                        MessageBox.Show(this, "Ocurrió un error " + oProducto.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
