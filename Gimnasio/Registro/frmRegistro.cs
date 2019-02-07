using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Gimnasio.Sesion;
using Gimnasio.Socios;
namespace Gimnasio.Registro
{
    public partial class frmRegistro : Form
    {
        clsRegistro oRegistro;
        string basePath = AppDomain.CurrentDomain.BaseDirectory;

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {            
            cargaDatos();
        }

        private void cargaDatos()
        {
            Configuracion.clsConfiguracion.getDatos();

            //Configuracion.clsConfiguracion.datos.NombreGimnacio.ToUpper();
            //Configuracion.clsConfiguracion.datos.Domicilio;
            //Configuracion.clsConfiguracion.datos.Telefono;
            //Configuracion.clsConfiguracion.datos.RFC.ToUpper();
            //Configuracion.clsConfiguracion.datos.Mensaje;
            /*if (Configuracion.clsConfiguracion.datos.Logo != null)
            {

                MemoryStream stream = new MemoryStream(Configuracion.clsConfiguracion.datos.Logo);
                Bitmap image = new Bitmap(stream);
                pbLogo.Image = image;
            }*/

            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();

            string videoDirectoryPath = string.Format(@"{0}{1}", this.basePath, "videos");
            if (!Directory.Exists(videoDirectoryPath))
                Directory.CreateDirectory(videoDirectoryPath);

            

            string videoFilePath = string.Format(@"{0}\{1}", videoDirectoryPath, "v1.mp4");
            if (File.Exists(videoFilePath)) {
                axWindowsMediaPlayer1.URL = videoFilePath;
                axWindowsMediaPlayer1.settings.volume = 0;
                axWindowsMediaPlayer1.settings.mute = true;
                axWindowsMediaPlayer1.stretchToFit = true;                
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer1.Show();
                
                axWindowsMediaPlayer2.URL = videoFilePath;
                axWindowsMediaPlayer2.settings.volume = 0;
                axWindowsMediaPlayer2.settings.mute = true;
                axWindowsMediaPlayer2.stretchToFit = true;
                axWindowsMediaPlayer2.Ctlcontrols.play();
                axWindowsMediaPlayer2.Show();
            }
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.initForm(false);

                if (string.IsNullOrEmpty(txtClave.Text)) 
                    return;

                int clave = int.Parse(txtClave.Text.ToString());

                oRegistro = new clsRegistro(clave);
                if (oRegistro.buscaDatos())
                {
                    clsSocio socio = new clsSocio();

                    //cargar datos
                    String name = string.Format("{0} {1} {2}", oRegistro.datos.NombreSocio, oRegistro.datos.Paterno, oRegistro.datos.Materno);
                    lblName.Text = name;
                                        
                    //cargar foto
                    if (oRegistro.datos.foto != null)
                    {
                        MemoryStream stream = new MemoryStream(oRegistro.datos.foto);
                        Bitmap image = new Bitmap(stream);
                        pbFoto.Image = image;
                    }

                    txtClave.Text = "";
                    if (!oRegistro.datos.idSocio.Equals(1000))
                    {
                        String vencimiento = string.Format("Del {0} al {1}", oRegistro.datos.fechaInicioMembresia.ToLongDateString(), oRegistro.datos.Vencimiento.ToLongDateString());
                        lblPeriodo.Text = vencimiento;

                        clsSocio socioData = new clsSocio();
                        if (!socioData.socioActivo(oRegistro.datos.idSocio)){
                            this.BackColor = Color.Salmon;
                            lblVencimiento.ForeColor = Color.Red;
                            MessageBox.Show(this, "Usuario inactivo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tmHideData.Start();
                            return;
                        } else if (DateTime.Compare(oRegistro.datos.Vencimiento, DateTime.Now) < 0){
                            this.BackColor = Color.Salmon;
                            lblVencimiento.ForeColor = Color.Red;
                            MessageBox.Show(this, "Su membresía ha terminado, favor de renovarla", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tmHideData.Start();
                            return;
                        } else {
                            //si le quedanm pocos dias se le avisa de que ya mero se le acaba su membresia
                            Configuracion.clsConfiguracion.getDatos();
                            if (Configuracion.clsConfiguracion.datos.mensajeVencimiento > 0)//si tiene abilitado el mensaje
                                if (DateTime.Compare(oRegistro.datos.Vencimiento, DateTime.Now.AddDays(Configuracion.clsConfiguracion.datos.mensajeVencimiento)) < 0)//si ya mero se termina
                                {
                                    DateTime newDate = oRegistro.datos.Vencimiento;
                                    DateTime oldDate = DateTime.Now;
                                    TimeSpan ts = newDate - oldDate;
                                    int diasFaltantes = ts.Days;

                                    string msgDiasFaltantes = string.Format("Quedan {0} dias de vigencia a tu membresia", diasFaltantes);
                                    lblRestanteMembresia.Text = msgDiasFaltantes;
                                    pnlRestanteMembresia.Show();
                                }

                            lblVencimiento.ForeColor = Color.Black;
                        }
                    } else {
                        lblPeriodo.Hide();
                    }

                    if (!oRegistro.addVisita())
                    {
                        MessageBox.Show(this,oRegistro.error,"Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    tmHideData.Start();
                }
                else
                {
                    this.BackColor = Color.Red;
                    pnlNotFound.Show();
                    tmNoMember.Start();                    
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tmNoMember_Tick(object sender, EventArgs e)
        {
            tmNoMember.Stop();
            this.initForm(false);            
        }

        private void tmHideData_Tick(object sender, EventArgs e)
        {
            tmHideData.Stop();
            this.initForm(false);
        }

        private void initForm(Boolean clearTextContent = true) {
            tmHideData.Stop();
            tmNoMember.Stop();

            pnlNotFound.Hide();
            this.BackColor = Color.WhiteSmoke;
            pbFoto.Image = null;
            if (clearTextContent)
                txtClave.Text = string.Empty;
            lblName.Text = string.Empty;
            
            lblPeriodo.Show();
            lblPeriodo.Text = string.Empty;
            
            pnlRestanteMembresia.Hide();
        }

        private void frmRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
#if !DEBUG
            frmConfirm FrmConfirm = new frmConfirm();
            e.Cancel = FrmConfirm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK ? false : true;
            FrmConfirm.Dispose();
            FrmConfirm = null;
#endif
        }

        private void frmRegistro_SizeChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Size = new Size( this.Size.Width / 2, axWindowsMediaPlayer1.Height);
            axWindowsMediaPlayer2.Size = new Size( this.Size.Width / 2 - 12, axWindowsMediaPlayer2.Height);

            axWindowsMediaPlayer2.Location = new Point( this.Size.Width / 2, 517);
        }
    }
}
