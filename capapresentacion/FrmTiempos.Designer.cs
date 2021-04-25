
namespace capapresentacion
{
    partial class FrmTiempos
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
            this.label_añadir = new System.Windows.Forms.Label();
            this.panelRecuadro = new System.Windows.Forms.Panel();
            this.dataListTiempos = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.btnEliminarTiempo = new System.Windows.Forms.Button();
            this.txtBuscarTiempo = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelRecuadro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListTiempos)).BeginInit();
            this.SuspendLayout();
            // 
            // label_añadir
            // 
            this.label_añadir.AutoSize = true;
            this.label_añadir.Location = new System.Drawing.Point(172, 144);
            this.label_añadir.Name = "label_añadir";
            this.label_añadir.Size = new System.Drawing.Size(37, 13);
            this.label_añadir.TabIndex = 27;
            this.label_añadir.Text = "Añadir";
            // 
            // panelRecuadro
            // 
            this.panelRecuadro.BackColor = System.Drawing.Color.Gold;
            this.panelRecuadro.Controls.Add(this.dataListTiempos);
            this.panelRecuadro.Location = new System.Drawing.Point(38, 174);
            this.panelRecuadro.Name = "panelRecuadro";
            this.panelRecuadro.Size = new System.Drawing.Size(663, 282);
            this.panelRecuadro.TabIndex = 26;
            // 
            // dataListTiempos
            // 
            this.dataListTiempos.AllowUserToAddRows = false;
            this.dataListTiempos.AllowUserToDeleteRows = false;
            this.dataListTiempos.AllowUserToOrderColumns = true;
            this.dataListTiempos.BackgroundColor = System.Drawing.Color.White;
            this.dataListTiempos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListTiempos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListTiempos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListTiempos.Location = new System.Drawing.Point(0, 0);
            this.dataListTiempos.Name = "dataListTiempos";
            this.dataListTiempos.ReadOnly = true;
            this.dataListTiempos.RowHeadersWidth = 51;
            this.dataListTiempos.Size = new System.Drawing.Size(663, 282);
            this.dataListTiempos.TabIndex = 4;
            this.dataListTiempos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListTiempos_CellContentClick);
            this.dataListTiempos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListTiempos_CellDoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 2;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::capapresentacion.Properties.Resources.addNew;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(224, 136);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(26, 28);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cbEliminar
            // 
            this.cbEliminar.Location = new System.Drawing.Point(38, 139);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(63, 24);
            this.cbEliminar.TabIndex = 55;
            this.cbEliminar.Text = "Eliminar";
            this.cbEliminar.UseVisualStyleBackColor = true;
            this.cbEliminar.CheckedChanged += new System.EventHandler(this.cbEliminar_CheckedChanged);
            // 
            // btnEliminarTiempo
            // 
            this.btnEliminarTiempo.BackColor = System.Drawing.Color.White;
            this.btnEliminarTiempo.BackgroundImage = global::capapresentacion.Properties.Resources.DeleteButton;
            this.btnEliminarTiempo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarTiempo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarTiempo.FlatAppearance.BorderSize = 0;
            this.btnEliminarTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTiempo.Location = new System.Drawing.Point(104, 135);
            this.btnEliminarTiempo.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarTiempo.Name = "btnEliminarTiempo";
            this.btnEliminarTiempo.Size = new System.Drawing.Size(32, 28);
            this.btnEliminarTiempo.TabIndex = 56;
            this.btnEliminarTiempo.UseVisualStyleBackColor = false;
            this.btnEliminarTiempo.Click += new System.EventHandler(this.btnEliminarTiempo_Click);
            // 
            // txtBuscarTiempo
            // 
            this.txtBuscarTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarTiempo.Location = new System.Drawing.Point(38, 52);
            this.txtBuscarTiempo.Name = "txtBuscarTiempo";
            this.txtBuscarTiempo.Size = new System.Drawing.Size(663, 20);
            this.txtBuscarTiempo.TabIndex = 57;
            this.txtBuscarTiempo.TextChanged += new System.EventHandler(this.txtBuscarTiempo_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(592, 139);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(104, 13);
            this.lblTotal.TabIndex = 58;
            this.lblTotal.Text = "Número de registros:";
            // 
            // FrmTiempos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(796, 517);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtBuscarTiempo);
            this.Controls.Add(this.btnEliminarTiempo);
            this.Controls.Add(this.cbEliminar);
            this.Controls.Add(this.label_añadir);
            this.Controls.Add(this.panelRecuadro);
            this.Controls.Add(this.btnNuevo);
            this.Name = "FrmTiempos";
            this.Text = "FrmTiempos";
            this.Load += new System.EventHandler(this.FrmTiempos_Load);
            this.panelRecuadro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListTiempos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_añadir;
        private System.Windows.Forms.Panel panelRecuadro;
        private System.Windows.Forms.DataGridView dataListTiempos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.CheckBox cbEliminar;
        private System.Windows.Forms.Button btnEliminarTiempo;
        private System.Windows.Forms.TextBox txtBuscarTiempo;
        private System.Windows.Forms.Label lblTotal;
    }
}