using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gimnasio.Productos
{
    public partial class frmProducto : Form
    {
        public int id = 0;
        clsProducto oProducto = new clsProducto();

        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                cargaDatos();
            }
        }

        private void cargaDatos()
        {
            if (oProducto.getDatos(id))
            {

                txtNombre.Text = oProducto.datos.Nombre;
                txtPrecio.Text = oProducto.datos.Precio.ToString();
                txtCosto.Text = oProducto.datos.Costo.ToString();
                txtDescripcion.Text = oProducto.datos.Descripcion.ToString();
                
            }
            else
            {
                MessageBox.Show(this,"Ocurrió un problema al cargar los datos " + oProducto.getError(),"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id <= 0)
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
                if (txtNombre.Text.Trim().Equals("") || txtPrecio.Text.Trim().Equals("") || txtCosto.Text.Equals(""))
                {
                    MessageBox.Show(this, "Nombre, Precio y Costo son obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!ExpresionesRegulares.RegEX.isDecimal(txtPrecio.Text.Trim()))
                {
                    MessageBox.Show(this, "El precio debe ser un número valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!ExpresionesRegulares.RegEX.isDecimal(txtCosto.Text.Trim()))
                {
                    MessageBox.Show(this, "El costo debe ser un número valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (decimal.Parse(txtPrecio.Text.ToString()) <= decimal.Parse(txtCosto.Text.ToString()))
                {
                    MessageBox.Show(this, "El costo debe ser menor que el precio al público", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //asignacion de datos
                oProducto.Nombre = txtNombre.Text.Trim();
                oProducto.Precio = decimal.Parse(txtPrecio.Text.Trim());
                oProducto.Costo = decimal.Parse(txtCosto.Text.Trim());
                oProducto.Descripcion = txtDescripcion.Text.Trim();
                oProducto.idUsuarioLog = Utilidades.clsUsuario.idUsuario;
                if (oProducto.add())
                {
                    MessageBox.Show(this, "Registro agregado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(oProducto.getError());

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
                if (txtNombre.Text.Trim().Equals("") || txtPrecio.Text.Trim().Equals("") || txtCosto.Text.Equals(""))
                {
                    MessageBox.Show(this, "Nombre, Precio y Costo son obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!ExpresionesRegulares.RegEX.isDecimal(txtPrecio.Text.Trim()))
                {
                    MessageBox.Show(this, "El precio debe ser un número valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!ExpresionesRegulares.RegEX.isDecimal(txtCosto.Text.Trim()))
                {
                    MessageBox.Show(this, "El costo debe ser un número valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (decimal.Parse(txtPrecio.Text.ToString()) <= decimal.Parse(txtCosto.Text.ToString()))
                {
                    MessageBox.Show(this, "El costo debe ser menor que el precio al público", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //asignacion de datos
                oProducto.Nombre = txtNombre.Text.Trim();
                oProducto.Precio = decimal.Parse(txtPrecio.Text.Trim());
                oProducto.Costo = decimal.Parse(txtCosto.Text.Trim());
                oProducto.Descripcion = txtDescripcion.Text.Trim();
                oProducto.idUsuarioLog = Utilidades.clsUsuario.idUsuario;
                if (oProducto.edit(id))
                {
                    MessageBox.Show(this, "Registro modificado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(oProducto.getError());

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

        private void frmProducto_FormClosing(object sender, FormClosingEventArgs e)
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
