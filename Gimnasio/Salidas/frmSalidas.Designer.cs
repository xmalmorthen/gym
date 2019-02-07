namespace Gimnasio.Salidas
{
    partial class frmSalidas
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
            ((System.ComponentModel.ISupportInitialize)(this.spContenedor)).BeginInit();
            this.spContenedor.Panel1.SuspendLayout();
            this.spContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // spContenedor
            // 
            // 
            // cmdAbilitar
            // 
            this.cmdAbilitar.Location = new System.Drawing.Point(396, 3);
            this.cmdAbilitar.Visible = false;
            // 
            // cmdDesabilitar
            // 
            this.cmdDesabilitar.Location = new System.Drawing.Point(283, 3);
            this.cmdDesabilitar.Visible = false;
            // 
            // cmdModificar
            // 
            this.cmdModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdModificar.Image = global::Gimnasio.Properties.Resources.iconfinder_visible_172630;
            this.cmdModificar.Location = new System.Drawing.Point(2, 3);
            this.cmdModificar.Size = new System.Drawing.Size(96, 48);
            this.cmdModificar.Text = "Mostrar";
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Location = new System.Drawing.Point(556, 3);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 3);
            // 
            // frmSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "frmSalidas";
            this.Text = "Salidas";
            this.Load += new System.EventHandler(this.frmSalidas_Load);
            this.spContenedor.Panel1.ResumeLayout(false);
            this.spContenedor.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContenedor)).EndInit();
            this.spContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
