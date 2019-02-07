namespace Gimnasio.Utilidades
{
    partial class frmPadre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.spContenedor = new System.Windows.Forms.SplitContainer();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdAbilitar = new System.Windows.Forms.Button();
            this.cmdDesabilitar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.spContenedor)).BeginInit();
            this.spContenedor.Panel1.SuspendLayout();
            this.spContenedor.Panel2.SuspendLayout();
            this.spContenedor.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // spContenedor
            // 
            this.spContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContenedor.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spContenedor.IsSplitterFixed = true;
            this.spContenedor.Location = new System.Drawing.Point(0, 0);
            this.spContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.spContenedor.Name = "spContenedor";
            this.spContenedor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spContenedor.Panel1
            // 
            this.spContenedor.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.spContenedor.Panel1.Controls.Add(this.panelBotones);
            this.spContenedor.Panel1.Controls.Add(this.lblTitle);
            this.spContenedor.Panel1.Controls.Add(this.shapeContainer1);
            this.spContenedor.Panel1MinSize = 100;
            // 
            // spContenedor.Panel2
            // 
            this.spContenedor.Panel2.Controls.Add(this.dgvLista);
            this.spContenedor.Panel2MinSize = 100;
            this.spContenedor.Size = new System.Drawing.Size(800, 600);
            this.spContenedor.SplitterDistance = 105;
            this.spContenedor.SplitterWidth = 5;
            this.spContenedor.TabIndex = 0;
            this.spContenedor.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.spContenedor_SplitterMoved);
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotones.Controls.Add(this.button1);
            this.panelBotones.Controls.Add(this.cmdEliminar);
            this.panelBotones.Controls.Add(this.cmdAbilitar);
            this.panelBotones.Controls.Add(this.cmdDesabilitar);
            this.panelBotones.Controls.Add(this.cmdModificar);
            this.panelBotones.Controls.Add(this.cmdNuevo);
            this.panelBotones.Location = new System.Drawing.Point(10, 46);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(779, 55);
            this.panelBotones.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Gimnasio.Properties.Resources.iconfinder_news_172514;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 48);
            this.button1.TabIndex = 12;
            this.button1.Text = "Membresía";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Image = global::Gimnasio.Properties.Resources.iconfinder_minus_172505;
            this.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdEliminar.Location = new System.Drawing.Point(669, 3);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(107, 48);
            this.cmdEliminar.TabIndex = 11;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            // 
            // cmdAbilitar
            // 
            this.cmdAbilitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAbilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdAbilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAbilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAbilitar.Image = global::Gimnasio.Properties.Resources.iconfinder_thumb_up_172598;
            this.cmdAbilitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdAbilitar.Location = new System.Drawing.Point(556, 3);
            this.cmdAbilitar.Name = "cmdAbilitar";
            this.cmdAbilitar.Size = new System.Drawing.Size(107, 48);
            this.cmdAbilitar.TabIndex = 10;
            this.cmdAbilitar.Text = "Habilitar";
            this.cmdAbilitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdAbilitar.UseVisualStyleBackColor = true;
            // 
            // cmdDesabilitar
            // 
            this.cmdDesabilitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDesabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdDesabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDesabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDesabilitar.Image = global::Gimnasio.Properties.Resources.iconfinder_thumb_down_172597;
            this.cmdDesabilitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdDesabilitar.Location = new System.Drawing.Point(443, 3);
            this.cmdDesabilitar.Name = "cmdDesabilitar";
            this.cmdDesabilitar.Size = new System.Drawing.Size(107, 48);
            this.cmdDesabilitar.TabIndex = 9;
            this.cmdDesabilitar.Text = "Deshabilitar";
            this.cmdDesabilitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdDesabilitar.UseVisualStyleBackColor = true;
            // 
            // cmdModificar
            // 
            this.cmdModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.Image = global::Gimnasio.Properties.Resources.iconfinder_edit_172462;
            this.cmdModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdModificar.Location = new System.Drawing.Point(330, 3);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(107, 48);
            this.cmdModificar.TabIndex = 8;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.Image = global::Gimnasio.Properties.Resources.iconfinder_plus_172525;
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdNuevo.Location = new System.Drawing.Point(217, 3);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(107, 48);
            this.cmdNuevo.TabIndex = 7;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 34);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Formulario";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 105);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 10;
            this.lineShape1.X2 = 571;
            this.lineShape1.Y1 = 43;
            this.lineShape1.Y2 = 43;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvLista.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLista.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLista.Location = new System.Drawing.Point(0, 0);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLista.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLista.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(800, 490);
            this.dgvLista.TabIndex = 0;
            // 
            // frmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.spContenedor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 639);
            this.Name = "frmPadre";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPadre";
            this.Load += new System.EventHandler(this.frmPadre_Load);
            this.spContenedor.Panel1.ResumeLayout(false);
            this.spContenedor.Panel1.PerformLayout();
            this.spContenedor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContenedor)).EndInit();
            this.spContenedor.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.SplitContainer spContenedor;
        public System.Windows.Forms.DataGridView dgvLista;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelBotones;
        public System.Windows.Forms.Button cmdEliminar;
        public System.Windows.Forms.Button cmdAbilitar;
        public System.Windows.Forms.Button cmdDesabilitar;
        public System.Windows.Forms.Button cmdModificar;
        public System.Windows.Forms.Button cmdNuevo;
        public System.Windows.Forms.Button button1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}