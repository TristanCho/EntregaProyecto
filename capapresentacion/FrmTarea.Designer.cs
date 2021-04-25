
namespace capapresentacion
{
    partial class FrmTarea
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
            this.dataListTareas = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBuscarTarea = new System.Windows.Forms.TextBox();
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.btnEliminarProyecto = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cboBuscarTareas = new System.Windows.Forms.ComboBox();
            this.panelRecuadro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // label_añadir
            // 
            this.label_añadir.AutoSize = true;
            this.label_añadir.Location = new System.Drawing.Point(150, 146);
            this.label_añadir.Name = "label_añadir";
            this.label_añadir.Size = new System.Drawing.Size(37, 13);
            this.label_añadir.TabIndex = 21;
            this.label_añadir.Text = "Añadir";
            this.label_añadir.Click += new System.EventHandler(this.label_añadir_Click);
            // 
            // panelRecuadro
            // 
            this.panelRecuadro.BackColor = System.Drawing.Color.Gold;
            this.panelRecuadro.Controls.Add(this.dataListTareas);
            this.panelRecuadro.Location = new System.Drawing.Point(39, 180);
            this.panelRecuadro.Name = "panelRecuadro";
            this.panelRecuadro.Size = new System.Drawing.Size(663, 282);
            this.panelRecuadro.TabIndex = 20;
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
            this.dataListTareas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListTareas_CellContentClick);
            this.dataListTareas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListTareas_CellDoubleClick);
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
            // txtBuscarTarea
            // 
            this.txtBuscarTarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarTarea.Location = new System.Drawing.Point(215, 54);
            this.txtBuscarTarea.Name = "txtBuscarTarea";
            this.txtBuscarTarea.Size = new System.Drawing.Size(487, 20);
            this.txtBuscarTarea.TabIndex = 14;
            this.txtBuscarTarea.TextChanged += new System.EventHandler(this.txtBuscarProyecto_TextChanged);
            // 
            // cbEliminar
            // 
            this.cbEliminar.AutoSize = true;
            this.cbEliminar.Location = new System.Drawing.Point(39, 146);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(62, 17);
            this.cbEliminar.TabIndex = 22;
            this.cbEliminar.Text = "Eliminar";
            this.cbEliminar.UseVisualStyleBackColor = true;
            this.cbEliminar.CheckedChanged += new System.EventHandler(this.cbEliminar_CheckedChanged);
            // 
            // btnEliminarProyecto
            // 
            this.btnEliminarProyecto.BackColor = System.Drawing.Color.White;
            this.btnEliminarProyecto.BackgroundImage = global::capapresentacion.Properties.Resources.DeleteButton;
            this.btnEliminarProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarProyecto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProyecto.Location = new System.Drawing.Point(104, 138);
            this.btnEliminarProyecto.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarProyecto.Name = "btnEliminarProyecto";
            this.btnEliminarProyecto.Size = new System.Drawing.Size(32, 28);
            this.btnEliminarProyecto.TabIndex = 23;
            this.btnEliminarProyecto.UseVisualStyleBackColor = false;
            this.btnEliminarProyecto.Click += new System.EventHandler(this.btnEliminarProyecto_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::capapresentacion.Properties.Resources.addNew;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(190, 138);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(26, 28);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cboBuscarTareas
            // 
            this.cboBuscarTareas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarTareas.FormattingEnabled = true;
            this.cboBuscarTareas.Items.AddRange(new object[] {
            "Tarea",
            "Descripción",
            "Estados",
            "Fecha creación",
            "Observación",
            "Proyecto",
            "Tecnico"});
            this.cboBuscarTareas.Location = new System.Drawing.Point(39, 54);
            this.cboBuscarTareas.Name = "cboBuscarTareas";
            this.cboBuscarTareas.Size = new System.Drawing.Size(153, 21);
            this.cboBuscarTareas.TabIndex = 13;
            this.cboBuscarTareas.SelectedIndexChanged += new System.EventHandler(this.cboBuscarTareas_SelectedIndexChanged);
            // 
            // FrmTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.ControlBox = false;
            this.Controls.Add(this.btnEliminarProyecto);
            this.Controls.Add(this.cbEliminar);
            this.Controls.Add(this.label_añadir);
            this.Controls.Add(this.panelRecuadro);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtBuscarTarea);
            this.Controls.Add(this.cboBuscarTareas);
            this.Name = "FrmTarea";
            this.Text = "FrmTarea";
            this.Load += new System.EventHandler(this.FrmTarea_Load);
            this.panelRecuadro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_añadir;
        private System.Windows.Forms.Panel panelRecuadro;
        private System.Windows.Forms.DataGridView dataListTareas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtBuscarTarea;
        private System.Windows.Forms.Button btnEliminarProyecto;
        private System.Windows.Forms.CheckBox cbEliminar;
        private System.Windows.Forms.ComboBox cboBuscarTareas;
    }
}