using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gimnasio.Salidas
{
    public partial class frmSalidas : Gimnasio.Utilidades.frmPadre
    {
        clsSalida oSalida = new clsSalida();
        public frmSalidas()
        {
            InitializeComponent();
        }

        private void frmSalidas_Load(object sender, EventArgs e)
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
                lblTitle.Text = "Salidas";
                dgvLista.Columns[0].Visible = false;
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
            cmdModificar.Click += new EventHandler(mostrar);
            cmdEliminar.Click += new EventHandler(elimina);
        }

        private void refrescaLista()
        {
            if (!oSalida.getDatos(dgvLista))
            {
                MessageBox.Show(this, oSalida.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvLista.Columns[1].HeaderText = "Total";
                dgvLista.Columns[2].HeaderText = "Fecha de creación";
            }


        }
        #endregion

        #region EVENTOS DE BOTONES

        private void nuevo(object sender, EventArgs e)
        {
            frmSalida frmUs = new frmSalida();
            frmUs.ShowDialog();
            refrescaLista();
        }


        private void elimina(object sender, EventArgs e)
        {
            int id = Utilidades.OperacionesFormulario.getId(dgvLista);
            if (id > 0)
            {
                if (MessageBox.Show(this,"Está seguro de eliminar el registro seleccionado", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (oSalida.remove(id))
                    {
                        refrescaLista();
                    }
                    else
                    {
                        MessageBox.Show(this, "Ocurrió un error " + oSalida.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show(this, "Debe existir una fila seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mostrar(object sender, EventArgs e)
        {
            int id = Utilidades.OperacionesFormulario.getId(dgvLista);
            if (id > 0)
            {
                frmViewSalida frmUs = new frmViewSalida();
                frmUs.id = id;
                frmUs.ShowDialog(this);
            }
            else
            {
                MessageBox.Show(this, "Debe existir una fila seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        #endregion

    
    }
}
