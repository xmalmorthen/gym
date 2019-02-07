namespace Gimnasio.Registro
{
    partial class frmRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tmTime = new System.Windows.Forms.Timer(this.components);
            this.tmHideData = new System.Windows.Forms.Timer(this.components);
            this.tmNoMember = new System.Windows.Forms.Timer(this.components);
            this.pnlNotFound = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.pnlRestanteMembresia = new System.Windows.Forms.Panel();
            this.lblRestanteMembresia = new System.Windows.Forms.Label();
            this.panelMiembro = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlNotFound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.pnlRestanteMembresia.SuspendLayout();
            this.panelMiembro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHora.Location = new System.Drawing.Point(907, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(517, 46);
            this.lblHora.TabIndex = 41;
            this.lblHora.Text = "{00:00:00}";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFecha.Location = new System.Drawing.Point(12, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(164, 46);
            this.lblFecha.TabIndex = 40;
            this.lblFecha.Text = "{Fecha}";
            // 
            // tmTime
            // 
            this.tmTime.Enabled = true;
            this.tmTime.Interval = 1000;
            this.tmTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmHideData
            // 
            this.tmHideData.Interval = 8000;
            this.tmHideData.Tick += new System.EventHandler(this.tmHideData_Tick);
            // 
            // tmNoMember
            // 
            this.tmNoMember.Interval = 3000;
            this.tmNoMember.Tick += new System.EventHandler(this.tmNoMember_Tick);
            // 
            // pnlNotFound
            // 
            this.pnlNotFound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNotFound.BackColor = System.Drawing.Color.Transparent;
            this.pnlNotFound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotFound.Controls.Add(this.label2);
            this.pnlNotFound.Location = new System.Drawing.Point(165, 206);
            this.pnlNotFound.Name = "pnlNotFound";
            this.pnlNotFound.Size = new System.Drawing.Size(1132, 250);
            this.pnlNotFound.TabIndex = 44;
            this.pnlNotFound.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1114, 243);
            this.label2.TabIndex = 44;
            this.label2.Text = "No existe un socio con esa clave";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(238, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(1164, 208);
            this.lblName.TabIndex = 27;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.Location = new System.Drawing.Point(256, 365);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(0, 29);
            this.lblVencimiento.TabIndex = 39;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(6, 5);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(393, 76);
            this.lblBienvenido.TabIndex = 40;
            this.lblBienvenido.Text = "Bienvenid@";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(8, 352);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(1394, 92);
            this.lblPeriodo.TabIndex = 38;
            this.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 46);
            this.label4.TabIndex = 42;
            this.label4.Text = "Periodo de membresía";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(902, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 46);
            this.label1.TabIndex = 43;
            this.label1.Text = "Clave de Socio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtClave
            // 
            this.txtClave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.Color.Red;
            this.txtClave.Location = new System.Drawing.Point(1202, 8);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(201, 68);
            this.txtClave.TabIndex = 0;
            this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClave_KeyDown);
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // pbFoto
            // 
            this.pbFoto.BackgroundImage = global::Gimnasio.Properties.Resources.iconfinder_user_male_172625;
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.InitialImage = null;
            this.pbFoto.Location = new System.Drawing.Point(12, 88);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(210, 210);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 37;
            this.pbFoto.TabStop = false;
            // 
            // pnlRestanteMembresia
            // 
            this.pnlRestanteMembresia.BackColor = System.Drawing.Color.Transparent;
            this.pnlRestanteMembresia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRestanteMembresia.Controls.Add(this.lblRestanteMembresia);
            this.pnlRestanteMembresia.Location = new System.Drawing.Point(424, 243);
            this.pnlRestanteMembresia.Name = "pnlRestanteMembresia";
            this.pnlRestanteMembresia.Size = new System.Drawing.Size(582, 100);
            this.pnlRestanteMembresia.TabIndex = 43;
            this.pnlRestanteMembresia.Visible = false;
            // 
            // lblRestanteMembresia
            // 
            this.lblRestanteMembresia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRestanteMembresia.BackColor = System.Drawing.Color.Transparent;
            this.lblRestanteMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestanteMembresia.ForeColor = System.Drawing.Color.Red;
            this.lblRestanteMembresia.Location = new System.Drawing.Point(6, 5);
            this.lblRestanteMembresia.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblRestanteMembresia.Name = "lblRestanteMembresia";
            this.lblRestanteMembresia.Size = new System.Drawing.Size(566, 88);
            this.lblRestanteMembresia.TabIndex = 44;
            this.lblRestanteMembresia.Text = "{RestanteMembresia}";
            this.lblRestanteMembresia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMiembro
            // 
            this.panelMiembro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMiembro.BackColor = System.Drawing.Color.Transparent;
            this.panelMiembro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMiembro.Controls.Add(this.pnlRestanteMembresia);
            this.panelMiembro.Controls.Add(this.pbFoto);
            this.panelMiembro.Controls.Add(this.txtClave);
            this.panelMiembro.Controls.Add(this.label1);
            this.panelMiembro.Controls.Add(this.label4);
            this.panelMiembro.Controls.Add(this.lblPeriodo);
            this.panelMiembro.Controls.Add(this.lblBienvenido);
            this.panelMiembro.Controls.Add(this.lblVencimiento);
            this.panelMiembro.Controls.Add(this.lblName);
            this.panelMiembro.Controls.Add(this.shapeContainer1);
            this.panelMiembro.Location = new System.Drawing.Point(12, 69);
            this.panelMiembro.Margin = new System.Windows.Forms.Padding(5);
            this.panelMiembro.Name = "panelMiembro";
            this.panelMiembro.Padding = new System.Windows.Forms.Padding(5);
            this.panelMiembro.Size = new System.Drawing.Size(1412, 446);
            this.panelMiembro.TabIndex = 41;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(5, 5);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1400, 434);
            this.shapeContainer1.TabIndex = 41;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 7;
            this.lineShape2.X2 = 723;
            this.lineShape2.Y1 = 342;
            this.lineShape2.Y2 = 342;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 7;
            this.lineShape1.X2 = 723;
            this.lineShape1.Y1 = 78;
            this.lineShape1.Y2 = 78;
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(1414, 517);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(10, 357);
            this.axWindowsMediaPlayer2.TabIndex = 45;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 517);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 357);
            this.axWindowsMediaPlayer1.TabIndex = 46;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Gimnasio.Properties.Resources.backgroundAlpha15percent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1436, 874);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.pnlNotFound);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.panelMiembro);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimizeBox = false;
            this.Name = "frmRegistro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Control de Ingreso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistro_FormClosing);
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.SizeChanged += new System.EventHandler(this.frmRegistro_SizeChanged);
            this.pnlNotFound.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.pnlRestanteMembresia.ResumeLayout(false);
            this.panelMiembro.ResumeLayout(false);
            this.panelMiembro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmTime;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmHideData;
        private System.Windows.Forms.Timer tmNoMember;
        private System.Windows.Forms.Panel pnlNotFound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Panel pnlRestanteMembresia;
        private System.Windows.Forms.Label lblRestanteMembresia;
        private System.Windows.Forms.Panel panelMiembro;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}