using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gimnasio.Socios
{
    public partial class FrmMembresia : Form
    {
        public int id = 0;
        clsSocio oSocio = new clsSocio();
        Membresias.clsMembresia oMembresia = new Membresias.clsMembresia();
        clsSocioMembresia oSocioMembresia = new clsSocioMembresia();
        public FrmMembresia()
        {
            InitializeComponent();
        }

        private void FrmMembresia_Load(object sender, EventArgs e)
        {
            if (oSocio.getDatos(id))
            {
                lblNombre.Text = oSocio.datos.Nombre + " " + oSocio.datos.Paterno + " " + oSocio.datos.Materno;
                lblTelefono.Text = oSocio.datos.Telefono;
                txtObservaciones.Text = oSocio.datos.Observaciones;

                if (oSocio.datos.foto != null)
                {
                    System.IO.MemoryStream stream = new System.IO.MemoryStream(oSocio.datos.foto);
                    Bitmap image = new Bitmap(stream);
                    pbFoto.Image = image;
                }
            }
            else
            {
                MessageBox.Show(this, oSocio.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //llenado de combo
            Membresias.clsMembresia.getCboMembresias(cboMembresia);
            if (cboMembresia.Items.Count <= 0)
            {
                MessageBox.Show(this,"No existen tipos de membresias agregadas al sistema, por favor ve al modulo de membresias y agregar una para poder ser asignada a los socios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            

            refrescaLista();
            interfaz();
        }

        private void interfaz()
        {
            try
            {
                dgvLista.Columns[0].Visible = false;
                dgvLista.Columns[dgvLista.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                Utilidades.OperacionesFormulario.quitaOrdenamientoGridView(dgvLista);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error de sistema " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void cboMembresia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboMembresia.Items.Count > 0)
                {
                    id = int.Parse(cboMembresia.SelectedValue.ToString());

                    if (oMembresia.getDatos(id))
                    {
                        lblPrecio.Text = oMembresia.datos.Precio.ToString();
                        lblMeses.Text = oMembresia.datos.meses.ToString();
                        lblHoraInicial.Text = oMembresia.datos.horaInicio.ToString();
                        lblHoraFinal.Text = oMembresia.datos.horaFinal.ToString();
                    }
                }
                //con esto evito la falla al abrir el formulario
            }catch{}

        }

        private void refrescaLista()
        {
            if (!oSocioMembresia.getDatos(dgvLista, oSocio.datos.idSocio))
            {
                MessageBox.Show(this, oSocioMembresia.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvLista.Columns[5].HeaderText = "Fecha de creación";

                if (dgvLista.Rows.Count > 0)
                {
                 //   dtpFechaInicio.Enabled = false;
                    dtpFechaInicio.MinDate = DateTime.Parse(Utilidades.OperacionesFormulario.getValorCelda(dgvLista, 2, 0));
                    dtpFechaInicio.Value = DateTime.Parse(Utilidades.OperacionesFormulario.getValorCelda(dgvLista, 2, 0));
                }
                else
                {
                   // dtpFechaInicio.Enabled = true;
                    dtpFechaInicio.MinDate = DateTime.Parse("01/01/1753");
                    dtpFechaInicio.Value = DateTime.Now;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oSocioMembresia.idMembresia = oMembresia.datos.idMembresia;
            oSocioMembresia.idSocio = oSocio.datos.idSocio;
            oSocioMembresia.Precio = oMembresia.datos.Precio;
            oSocioMembresia.fechaInicioMembresia = dtpFechaInicio.Value;
            oSocioMembresia.idUsuarioLog = Utilidades.clsUsuario.idUsuario;

            if (oSocioMembresia.add())
            {
                refrescaLista();
            }
            else
            {
                MessageBox.Show(this, oSocioMembresia.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count > 0)
            {
                int id = int.Parse(Utilidades.OperacionesFormulario.getValorCelda(dgvLista, 0, 0));
                if (id > 0)
                {
                    if (MessageBox.Show(this,"Estas seguro de eliminar el ultimo registro agregado de membresia", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (oSocioMembresia.changeState(3, id))
                        {
                            refrescaLista();
                        }
                        else
                        {
                            MessageBox.Show(this, "Ocurrió un error " + oSocioMembresia.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show(this, "Debe existir una fila seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(this, "No existen membresias para ser eliminadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvLista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dgvLista.Rows)
            {
                DateTime Fechavencimiento = DateTime.Parse(Myrow.Cells[2].Value.ToString());

                if (DateTime.Compare(Fechavencimiento, DateTime.Now) < 0)
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }
    }
}
