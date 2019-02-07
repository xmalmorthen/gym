using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gimnasio.Entradas
{
    public partial class frmViewEntrada : Form
    {
        public int id = 0;
        clsEntrada oEntrada = new clsEntrada();
        public frmViewEntrada()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmViewEntrada_Load(object sender, EventArgs e)
        {
            cargaDatos();
            refrescaLista();
            interfaz();
        }

        #region FUNCIONES COMUNES
        private void interfaz()
        {
            try
            {
                dgvLista.Columns[0].Visible = false;
                dgvLista.Columns[dgvLista.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(this,"Error de sistema " + ex.Message,"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
     

        private void refrescaLista()
        {
            if (!oEntrada.getDatosDetalle(dgvLista))
            {
                MessageBox.Show(this, oEntrada.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                dgvLista.Columns[1].HeaderText = "Cantidad";
                dgvLista.Columns[3].HeaderText = "Costo unitario";
                dgvLista.Columns[4].HeaderText = "Total";
            }


        }

        private void cargaDatos()
        {
            if (oEntrada.getDatos(id))
            {
                lblTotal.Text = string.Format("$ {0}",oEntrada.datos.Total.ToString());
                lblFecha.Text = oEntrada.datos.fechaCreacion.ToShortDateString();
              
            }
            else
            {
                MessageBox.Show(this, "Ocurrió un problema al cargar los datos " + oEntrada.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion

    }
}
