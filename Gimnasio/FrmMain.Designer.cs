namespace Gimnasio
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.adminMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membresiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            this.adminMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.btnCerrarSesión);
            this.pnlMain.Controls.Add(this.btnAdmin);
            this.pnlMain.Controls.Add(this.btnRegistro);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMain.Location = new System.Drawing.Point(0, 650);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1362, 70);
            this.pnlMain.TabIndex = 1;
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesión.Image = global::Gimnasio.Properties.Resources.iconfinder_18_Close_106227;
            this.btnCerrarSesión.Location = new System.Drawing.Point(1239, 4);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(110, 61);
            this.btnCerrarSesión.TabIndex = 29;
            this.btnCerrarSesión.Text = "Cerrar Sesión";
            this.btnCerrarSesión.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarSesión.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrarSesión.UseVisualStyleBackColor = true;
            this.btnCerrarSesión.Click += new System.EventHandler(this.btnCerrarSesión_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Image = global::Gimnasio.Properties.Resources.iconfinder_54_Settings_106187;
            this.btnAdmin.Location = new System.Drawing.Point(1113, 4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(120, 61);
            this.btnAdmin.TabIndex = 28;
            this.btnAdmin.Text = "Administración";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Image = global::Gimnasio.Properties.Resources.iconfinder_45_Menu_106200;
            this.btnRegistro.Location = new System.Drawing.Point(11, 4);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(120, 61);
            this.btnRegistro.TabIndex = 27;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // adminMenu
            // 
            this.adminMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.sociosToolStripMenuItem,
            this.membresiasToolStripMenuItem,
            this.toolStripMenuItem3,
            this.productosToolStripMenuItem,
            this.entradasToolStripMenuItem,
            this.salidasToolStripMenuItem,
            this.toolStripMenuItem2,
            this.reportesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.configuraciónToolStripMenuItem});
            this.adminMenu.Name = "adminMenu";
            this.adminMenu.Size = new System.Drawing.Size(151, 198);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::Gimnasio.Properties.Resources.iconfinder_user_male3_172627;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.Image = global::Gimnasio.Properties.Resources.iconfinder_group_172474;
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.sociosToolStripMenuItem.Text = "Socios";
            this.sociosToolStripMenuItem.Click += new System.EventHandler(this.sociosToolStripMenuItem_Click);
            // 
            // membresiasToolStripMenuItem
            // 
            this.membresiasToolStripMenuItem.Image = global::Gimnasio.Properties.Resources.iconfinder_news_172514;
            this.membresiasToolStripMenuItem.Name = "membresiasToolStripMenuItem";
            this.membresiasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.membresiasToolStripMenuItem.Text = "Membresias";
            this.membresiasToolStripMenuItem.Click += new System.EventHandler(this.membresiasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(147, 6);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = global::Gimnasio.Properties.Resources.iconfinder_shopping_cart_loaded_172553;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Image = global::Gimnasio.Properties.Resources.iconfinder_put_in_172531;
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.entradasToolStripMenuItem.Text = "Entradas";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
            // 
            // salidasToolStripMenuItem
            // 
            this.salidasToolStripMenuItem.Image = global::Gimnasio.Properties.Resources.iconfinder_put_out_172532;
            this.salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            this.salidasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salidasToolStripMenuItem.Text = "Salidas";
            this.salidasToolStripMenuItem.Click += new System.EventHandler(this.salidasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 6);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Image = global::Gimnasio.Properties.Resources.iconfinder_copy_172587;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 6);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónGeneralToolStripMenuItem,
            this.respaldosToolStripMenuItem1});
            this.configuraciónToolStripMenuItem.Image = global::Gimnasio.Properties.Resources.iconfinder_settings_172548;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // configuraciónGeneralToolStripMenuItem
            // 
            this.configuraciónGeneralToolStripMenuItem.Image = global::Gimnasio.Properties.Resources.iconfinder_settings2_172549;
            this.configuraciónGeneralToolStripMenuItem.Name = "configuraciónGeneralToolStripMenuItem";
            this.configuraciónGeneralToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.configuraciónGeneralToolStripMenuItem.Text = "Configuración General";
            this.configuraciónGeneralToolStripMenuItem.Click += new System.EventHandler(this.configuraciónGeneralToolStripMenuItem_Click);
            // 
            // respaldosToolStripMenuItem1
            // 
            this.respaldosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem1,
            this.restaurarToolStripMenuItem1});
            this.respaldosToolStripMenuItem1.Image = global::Gimnasio.Properties.Resources.iconfinder_money_172506;
            this.respaldosToolStripMenuItem1.Name = "respaldosToolStripMenuItem1";
            this.respaldosToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.respaldosToolStripMenuItem1.Text = "Respaldos";
            // 
            // crearToolStripMenuItem1
            // 
            this.crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            this.crearToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.crearToolStripMenuItem1.Text = "Crear";
            this.crearToolStripMenuItem1.Click += new System.EventHandler(this.crearToolStripMenuItem1_Click);
            // 
            // restaurarToolStripMenuItem1
            // 
            this.restaurarToolStripMenuItem1.Name = "restaurarToolStripMenuItem1";
            this.restaurarToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.restaurarToolStripMenuItem1.Text = "Restaurar";
            this.restaurarToolStripMenuItem1.Click += new System.EventHandler(this.restaurarToolStripMenuItem1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 720);
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.pnlMain.ResumeLayout(false);
            this.adminMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ContextMenuStrip adminMenu;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membresiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respaldosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem1;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}

