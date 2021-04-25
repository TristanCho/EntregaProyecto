
namespace capapresentacion
{
    partial class FrmAplicacion
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
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.label_añadir = new System.Windows.Forms.Label();
            this.panelRecuadro = new System.Windows.Forms.Panel();
            this.dataListTareas = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBuscarAplicacion = new System.Windows.Forms.TextBox();
            this.cboBuscarAplicaciones = new System.Windows.Forms.ComboBox();
            this.btnEliminarAplicacion = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscarTareas = new System.Windows.Forms.Button();
            this.panelRecuadro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEliminar
            // 
            this.cbEliminar.AutoSize = true;
            this.cbEliminar.Location = new System.Drawing.Point(42, 132);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(62, 17);
            this.cbEliminar.TabIndex = 30;
            this.cbEliminar.Text = "Eliminar";
            this.cbEliminar.UseVisualStyleBackColor = true;
            // 
            // label_añadir
            // 
            this.label_añadir.AutoSize = true;
            this.label_añadir.Location = new System.Drawing.Point(166, 133);
            this.label_añadir.Name = "label_añadir";
            this.label_añadir.Size = new System.Drawing.Size(37, 13);
            this.label_añadir.TabIndex = 29;
            this.label_añadir.Text = "Añadir";
            // 
            // panelRecuadro
            // 
            this.panelRecuadro.BackColor = System.Drawing.Color.Gold;
            this.panelRecuadro.Controls.Add(this.dataListTareas);
            this.panelRecuadro.Location = new System.Drawing.Point(34, 175);
            this.panelRecuadro.Name = "panelRecuadro";
            this.panelRecuadro.Size = new System.Drawing.Size(663, 282);
            this.panelRecuadro.TabIndex = 28;
            // 
            // dataListTareas
            // 
            this.dataListTareas.AllowUserToAddRows = false;
            this.dataListTareas.AllowUserToDeleteRows = false;
            this.dataListTareas.AllowUserToOrderColumns = true;
            this.dataListTareas.BackgroundColor = System.Drawing.Color.White;
            this.dataListTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListTareas.Location = new System.Drawing.Point(0, 0);
            this.dataListTareas.Name = "dataListTareas";
            this.dataListTareas.ReadOnly = true;
            this.dataListTareas.RowHeadersWidth = 51;
            this.dataListTareas.Size = new System.Drawing.Size(663, 282);
            this.dataListTareas.TabIndex = 4;
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
            // txtBuscarAplicacion
            // 
            this.txtBuscarAplicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarAplicacion.Location = new System.Drawing.Point(218, 54);
            this.txtBuscarAplicacion.Name = "txtBuscarAplicacion";
            this.txtBuscarAplicacion.Size = new System.Drawing.Size(452, 20);
            this.txtBuscarAplicacion.TabIndex = 25;
            // 
            // cboBuscarAplicaciones
            // 
            this.cboBuscarAplicaciones.FormattingEnabled = true;
            this.cboBuscarAplicaciones.Items.AddRange(new object[] {
            "titulo",
            "observaciones",
            "codigo_proyecto"});
            this.cboBuscarAplicaciones.Location = new System.Drawing.Point(42, 53);
            this.cboBuscarAplicaciones.Name = "cboBuscarAplicaciones";
            this.cboBuscarAplicaciones.Size = new System.Drawing.Size(153, 21);
            this.cboBuscarAplicaciones.TabIndex = 24;
            this.cboBuscarAplicaciones.Text = "titulo";
            // 
            // btnEliminarAplicacion
            // 
            this.btnEliminarAplicacion.BackColor = System.Drawing.Color.White;
            this.btnEliminarAplicacion.BackgroundImage = global::capapresentacion.Properties.Resources.DeleteButton;
            this.btnEliminarAplicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarAplicacion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarAplicacion.FlatAppearance.BorderSize = 0;
            this.btnEliminarAplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAplicacion.Location = new System.Drawing.Point(110, 125);
            this.btnEliminarAplicacion.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarAplicacion.Name = "btnEliminarAplicacion";
            this.btnEliminarAplicacion.Size = new System.Drawing.Size(32, 28);
            this.btnEliminarAplicacion.TabIndex = 31;
            this.btnEliminarAplicacion.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::capapresentacion.Properties.Resources.addNew;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(218, 125);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(26, 28);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscarTareas
            // 
            this.btnBuscarTareas.BackColor = System.Drawing.Color.White;
            this.btnBuscarTareas.BackgroundImage = global::capapresentacion.Properties.Resources.Lupa;
            this.btnBuscarTareas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTareas.Location = new System.Drawing.Point(673, 54);
            this.btnBuscarTareas.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarTareas.Name = "btnBuscarTareas";
            this.btnBuscarTareas.Size = new System.Drawing.Size(25, 21);
            this.btnBuscarTareas.TabIndex = 26;
            this.btnBuscarTareas.UseVisualStyleBackColor = false;
            // 
            // FrmAplicacion
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
            this.Controls.Add(this.btnBuscarTareas);
            this.Controls.Add(this.txtBuscarAplicacion);
            this.Controls.Add(this.cboBuscarAplicaciones);
            this.Name = "FrmAplicacion";
            this.Text = "FrmAplicacion";
            this.panelRecuadro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarAplicacion;
        private System.Windows.Forms.CheckBox cbEliminar;
        private System.Windows.Forms.Label label_añadir;
        private System.Windows.Forms.Panel panelRecuadro;
        private System.Windows.Forms.DataGridView dataListTareas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscarTareas;
        private System.Windows.Forms.TextBox txtBuscarAplicacion;
        private System.Windows.Forms.ComboBox cboBuscarAplicaciones;
    }
}