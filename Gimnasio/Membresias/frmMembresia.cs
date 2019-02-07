using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gimnasio.Membresias
{
    public partial class frmMembresia : Form
    {
        public int idMembresia = 0;
        clsMembresia oMembresia = new clsMembresia();
        public frmMembresia()
        {
            InitializeComponent();
        }

        private void frmMembresia_Load(object sender, EventArgs e)
        {
            cboMeses.SelectedIndex = 0;

            if (idMembresia > 0)
            {
                cargaDatos();
            }
        }

        private void cargaDatos()
        {
            if (oMembresia.getDatos(idMembresia))
            {

                txtNombre.Text = oMembresia.datos.Nombre;
                txtPrecio.Text = oMembresia.datos.Precio.ToString();
                cboMeses.Text = oMembresia.datos.meses.ToString();
                dpInicio.Text = oMembresia.datos.horaInicio.ToString();
                dpFinal.Text = oMembresia.datos.horaFinal.ToString();
            }
            else
            {
                MessageBox.Show(this,"Ocurrió un problema al cargar los datos " + oMembresia.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idMembresia <= 0)
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
             try
            {
                //validaciones
                if (txtNombre.Text.Trim().Equals("") || txtPrecio.Text.Trim().Equals("") || cboMeses.Text.Equals(""))
                {
                    MessageBox.Show(this, "Nombre, Precio y Meses son obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!ExpresionesRegulares.RegEX.isDecimal(txtPrecio.Text.Trim()))
                {
                    MessageBox.Show(this, "El precio debe ser un número valido, no se permiten letras ni caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //asignacion de datos
                oMembresia.Nombre = txtNombre.Text.Trim();
                oMembresia.Precio = decimal.Parse(txtPrecio.Text.Trim());
                oMembresia.meses = int.Parse(cboMeses.Text.Trim());
                oMembresia.horaInicio = dpInicio.Value.TimeOfDay;
                oMembresia.horaFinal = dpFinal.Value.TimeOfDay;
                oMembresia.idUsuarioLog = Utilidades.clsUsuario.idUsuario;
                if (oMembresia.add())
                {
                    MessageBox.Show(this, "Registro agregado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(this, oMembresia.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

             }
              catch (Exception EX)
              {
                  MessageBox.Show(this, "Ocurrió un error de sistema " + EX.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
        }

        private void modifica()
        {

            try
            {
                //validaciones
                if (txtNombre.Text.Trim().Equals("") || txtPrecio.Text.Trim().Equals("") || cboMeses.Text.Equals(""))
                {
                    MessageBox.Show(this, "Nombre, Precio y Meses son obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!ExpresionesRegulares.RegEX.isDecimal(txtPrecio.Text.Trim()))
                {
                    MessageBox.Show(this, "El precio debe ser un número valido, no se permiten letras ni caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //asignacion de datos
                oMembresia.Nombre = txtNombre.Text.Trim();
                oMembresia.Precio = decimal.Parse(txtPrecio.Text.Trim());
                oMembresia.meses = int.Parse(cboMeses.Text.Trim());
                oMembresia.horaInicio= dpInicio.Value.TimeOfDay;
                oMembresia.horaFinal = dpFinal.Value.TimeOfDay;
                oMembresia.idUsuarioLog = Utilidades.clsUsuario.idUsuario;
                if (oMembresia.edit(idMembresia))
                {
                    MessageBox.Show(this, "Registro modificado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(this, oMembresia.getError(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception EX)
            {
                MessageBox.Show(this, "Ocurrió un error de sistema " + EX.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean cancel = false;
        private void button2_Click(object sender, EventArgs e)
        {
            this.cancel = true;
            this.Close();
        }

        private void frmMembresia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.cancel)
            {
                if (MessageBox.Show(this, "Estás seguro de cancelar", "Confirma cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
