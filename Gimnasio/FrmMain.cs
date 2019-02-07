using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using Gimnasio.Sesion;

namespace Gimnasio
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            sinSesion();
        }

        #region METODOS PRIVADOS
        /// <summary>
        /// metodo que abre la ventana de login
        /// </summary>
        private void sinSesion()
        {
#if !DEBUG
            pnlMain.Enabled = false;
            cerrarFormuarios();
            Sesion.frmLogin frmL = new Sesion.frmLogin();
            frmL.ShowDialog();
            if(Utilidades.clsUsuario.existeSesion)
#else

            Utilidades.clsUsuario.login("admin","a");
#endif
            pnlMain.Enabled = true;
        }

        
        private bool detectarFormularioAbierto(string formulario)
        {
            bool abierto = false;

            if (Application.OpenForms[formulario] != null)
            {
                abierto = true;
                Application.OpenForms[formulario].Activate();
                Application.OpenForms[formulario].WindowState = FormWindowState.Maximized;
            }
            return abierto;
        }

        private void cerrarFormuarios()
        {
            if (this.MdiChildren.Length > 0)   
            {
                foreach (Form childForm in this.MdiChildren)
                    childForm.Close();

              
            }
        }

        #endregion

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            //SE ABRE REGISTRO CON F12
            if (e.KeyCode == Keys.F12)
            {
                if (!detectarFormularioAbierto("frmRegistro"))
                {
                    Registro.frmRegistro frmM = new Registro.frmRegistro();
                    frmM.Show();
                    frmM.WindowState = FormWindowState.Maximized;
                }
            }
        }
                
        private void creadoPorHéctorDeLeónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreador oFrm = new frmCreador();
            oFrm.ShowDialog();
                
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!detectarFormularioAbierto("frmUsuarios"))
            {
                Usuarios.frmUsuarios frmU = new Usuarios.frmUsuarios();
                frmU.MdiParent = this;
                frmU.Show();
                frmU.WindowState = FormWindowState.Maximized;
            }
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!detectarFormularioAbierto("frmSocios"))
            {
                Socios.frmSocios frmM = new Socios.frmSocios();
                frmM.MdiParent = this;
                frmM.Show();
                frmM.WindowState = FormWindowState.Maximized;
            }
        }

        private void membresiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!detectarFormularioAbierto("frmMembresias"))
            {
                Membresias.frmMembresias frmM = new Membresias.frmMembresias();
                frmM.MdiParent = this;
                frmM.Show();
                frmM.WindowState = FormWindowState.Maximized;
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!detectarFormularioAbierto("frmProductos"))
            {
                Productos.frmProductos frmM = new Productos.frmProductos();
                frmM.MdiParent = this;
                frmM.Show();
                frmM.WindowState = FormWindowState.Maximized;
            }
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!detectarFormularioAbierto("frmEntradas"))
            {
                Entradas.frmEntradas frmM = new Entradas.frmEntradas();
                frmM.MdiParent = this;
                frmM.Show();
                frmM.WindowState = FormWindowState.Maximized;
            }
        }

        private void salidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!detectarFormularioAbierto("frmSalidas"))
            {
                Salidas.frmSalidas frmM = new Salidas.frmSalidas();
                frmM.MdiParent = this;
                frmM.Show();
                frmM.WindowState = FormWindowState.Maximized;
            }
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!detectarFormularioAbierto("frmReportes"))
            {
                Reportes.frmReportes frmM = new Reportes.frmReportes();
                frmM.MdiParent = this;
                frmM.Show();
                frmM.WindowState = FormWindowState.Maximized;
            }
        }

        private void configuraciónGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!detectarFormularioAbierto("frmConfiguracion"))
            {
                Configuracion.frmConfiguracion frmM = new Configuracion.frmConfiguracion();
                frmM.MdiParent = this;
                frmM.Show();
                frmM.WindowState = FormWindowState.Maximized;
            }
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            SaveFileDialog sFileDialog1 = new SaveFileDialog();

            sFileDialog1.InitialDirectory = "c:\\";
            sFileDialog1.Filter = "Archivos de sql (*.sql)|*.sql";
            sFileDialog1.FilterIndex = 1;
            sFileDialog1.RestoreDirectory = true;

            if (sFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //se guarda el respaldo
                    try
                    {
                        string constr = "server=localhost;User Id=root;Persist Security Info=True;database=gym";
                        string file = sFileDialog1.FileName;
                        MySqlBackup mb = new MySqlBackup(constr);
                        mb.ExportInfo.FileName = file;
                        mb.ExportInfo.ExportViews = false;

                        if (System.IO.File.Exists(file))
                            System.IO.File.Delete(file);
                        mb.Export();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error " + ex.Message);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error del Sistema: " + ex.Message);
                }
            }

            MessageBox.Show("Información guardada con éxito");
        }

        private void restaurarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de abrir un archivo de respaldo? se remplazara toda la información en el sistema con lo que existe en el archivo de respaldo", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //se abre la ventana para seleccionar acrhivo

                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Archivos de sql (*.sql)|*.sql";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //se abre el respaldo
                        try
                        {
                            string constr = "server=localhost;User Id=root;Persist Security Info=True;database=gym";
                            string file = openFileDialog1.FileName;
                            MySqlBackup mb = new MySqlBackup(constr);
                            mb.ImportInfo.FileName = file;
                            mb.ImportInfo.SetTargetDatabase("gym", ImportInformations.CharSet.utf8);
                            mb.Import();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrió un error " + ex.Message);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error del Sistema: " + ex.Message);
                    }
                }

                MessageBox.Show("Información restaurada con éxito");

                //se cierran formularios
                cerrarFormuarios();
                //se cierra sesion
                if (Utilidades.clsUsuario.salir())
                {
                    sinSesion();
                }
                else
                {
                    MessageBox.Show(Utilidades.clsUsuario.error);
                }

            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (!detectarFormularioAbierto("frmRegistro"))
            {
                Registro.frmRegistro frmM = new Registro.frmRegistro();
                frmM.Show();
                frmM.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            adminMenu.Show(ptLowerLeft);
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
#if !DEBUG            
            if (Utilidades.clsUsuario.salir())
            {
                sinSesion();
            }
            else
            {
                MessageBox.Show(this,Utilidades.clsUsuario.error,"Atención");
            }
#else
            this.Close();
#endif
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
#if !DEBUG
            frmConfirm FrmConfirm = new frmConfirm();
            e.Cancel = FrmConfirm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK ? false : true;
            FrmConfirm.Dispose();
            FrmConfirm = null;
#endif
        }
    }
}
