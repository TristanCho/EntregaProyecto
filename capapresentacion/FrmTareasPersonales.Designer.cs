
namespace capapresentacion
{
    partial class FrmTareasPersonales
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
            this.txtBuscarTareasPersonales = new System.Windows.Forms.TextBox();
            this.cboBuscarTareasPersonales = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscarTareasPersonales = new System.Windows.Forms.Button();
            this.btnEliminarAplicacion = new System.Windows.Forms.Button();
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.panelRecuadro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListTiempos)).BeginInit();
            this.SuspendLayout();
            // 
            // label_añadir
            // 
            this.label_añadir.AutoSize = true;
            this.label_añadir.Location = new System.Drawing.Point(167, 140);
            this.label_añadir.Name = "label_añadir";
            this.label_añadir.Size = new System.Drawing.Size(37, 13);
            this.label_añadir.TabIndex = 27;
            this.label_añadir.Text = "Añadir";
            // 
            // panelRecuadro
            // 
            this.panelRecuadro.BackColor = System.Drawing.Color.Gold;
            this.panelRecuadro.Controls.Add(this.dataListTiempos);
            this.panelRecuadro.Location = new System.Drawing.Point(35, 175);
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
            // txtBuscarTareasPersonales
            // 
            this.txtBuscarTareasPersonales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarTareasPersonales.Location = new System.Drawing.Point(219, 54);
            this.txtBuscarTareasPersonales.Name = "txtBuscarTareasPersonales";
            this.txtBuscarTareasPersonales.Size = new System.Drawing.Size(452, 20);
            this.txtBuscarTareasPersonales.TabIndex = 23;
            // 
            // cboBuscarTareasPersonales
            // 
            this.cboBuscarTareasPersonales.FormattingEnabled = true;
            this.cboBuscarTareasPersonales.Items.AddRange(new object[] {
            "titulo",
            "observaciones",
            "codigo_proyecto"});
            this.cboBuscarTareasPersonales.Location = new System.Drawing.Point(43, 53);
            this.cboBuscarTareasPersonales.Name = "cboBuscarTareasPersonales";
            this.cboBuscarTareasPersonales.Size = new System.Drawing.Size(153, 21);
            this.cboBuscarTareasPersonales.TabIndex = 22;
            this.cboBuscarTareasPersonales.Text = "titulo";
            this.cboBuscarTareasPersonales.SelectedIndexChanged += new System.EventHandler(this.cboBuscarTareasPersonales_SelectedIndexChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::capapresentacion.Properties.Resources.addNew;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(219, 132);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(26, 28);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscarTareasPersonales
            // 
            this.btnBuscarTareasPersonales.BackColor = System.Drawing.Color.White;
            this.btnBuscarTareasPersonales.BackgroundImage = global::capapresentacion.Properties.Resources.Lupa;
            this.btnBuscarTareasPersonales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarTareasPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTareasPersonales.Location = new System.Drawing.Point(674, 54);
            this.btnBuscarTareasPersonales.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarTareasPersonales.Name = "btnBuscarTareasPersonales";
            this.btnBuscarTareasPersonales.Size = new System.Drawing.Size(25, 21);
            this.btnBuscarTareasPersonales.TabIndex = 24;
            this.btnBuscarTareasPersonales.UseVisualStyleBackColor = false;
            // 
            // btnEliminarAplicacion
            // 
            this.btnEliminarAplicacion.BackColor = System.Drawing.Color.White;
            this.btnEliminarAplicacion.BackgroundImage = global::capapresentacion.Properties.Resources.DeleteButton;
            this.btnEliminarAplicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarAplicacion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarAplicacion.FlatAppearance.BorderSize = 0;
            this.btnEliminarAplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAplicacion.Location = new System.Drawing.Point(105, 132);
            this.btnEliminarAplicacion.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarAplicacion.Name = "btnEliminarAplicacion";
            this.btnEliminarAplicacion.Size = new System.Drawing.Size(32, 28);
            this.btnEliminarAplicacion.TabIndex = 33;
            this.btnEliminarAplicacion.UseVisualStyleBackColor = false;
            // 
            // cbEliminar
            // 
            this.cbEliminar.AutoSize = true;
            this.cbEliminar.Location = new System.Drawing.Point(37, 139);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(62, 17);
            this.cbEliminar.TabIndex = 32;
            this.cbEliminar.Text = "Eliminar";
            this.cbEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmTareasPersonales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.btnEliminarAplicacion);
            this.Controls.Add(this.cbEliminar);
            this.Controls.Add(this.label_añadir);
            this.Controls.Add(this.panelRecuadro);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscarTareasPersonales);
            this.Controls.Add(this.txtBuscarTareasPersonales);
            this.Controls.Add(this.cboBuscarTareasPersonales);
            this.Name = "FrmTareasPersonales";
            this.Text = "FrmTareasPersonales";
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
        private System.Windows.Forms.Button btnBuscarTareasPersonales;
        private System.Windows.Forms.TextBox txtBuscarTareasPersonales;
        private System.Windows.Forms.ComboBox cboBuscarTareasPersonales;
        private System.Windows.Forms.Button btnEliminarAplicacion;
        private System.Windows.Forms.CheckBox cbEliminar;
    }
}