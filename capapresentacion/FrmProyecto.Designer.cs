
namespace capapresentacion
{
    partial class FrmProyecto
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
            this.dataListProyectos = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminarProyecto = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.txtBuscarProyecto = new System.Windows.Forms.TextBox();
            this.panelRecuadro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListProyectos)).BeginInit();
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
            // 
            // panelRecuadro
            // 
            this.panelRecuadro.BackColor = System.Drawing.Color.Gold;
            this.panelRecuadro.Controls.Add(this.dataListProyectos);
            this.panelRecuadro.Location = new System.Drawing.Point(39, 180);
            this.panelRecuadro.Name = "panelRecuadro";
            this.panelRecuadro.Size = new System.Drawing.Size(663, 282);
            this.panelRecuadro.TabIndex = 20;
            // 
            // dataListProyectos
            // 
            this.dataListProyectos.AllowUserToAddRows = false;
            this.dataListProyectos.AllowUserToDeleteRows = false;
            this.dataListProyectos.AllowUserToOrderColumns = true;
            this.dataListProyectos.BackgroundColor = System.Drawing.Color.White;
            this.dataListProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListProyectos.Location = new System.Drawing.Point(0, 0);
            this.dataListProyectos.Name = "dataListProyectos";
            this.dataListProyectos.ReadOnly = true;
            this.dataListProyectos.RowHeadersWidth = 51;
            this.dataListProyectos.Size = new System.Drawing.Size(663, 282);
            this.dataListProyectos.TabIndex = 4;
            this.dataListProyectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListProyectos_CellContentClick_1);
            this.dataListProyectos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListProyectos_CellDoubleClick);
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
            this.btnNuevo.Location = new System.Drawing.Point(190, 138);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(26, 28);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.btnEliminarProyecto.TabIndex = 18;
            this.btnEliminarProyecto.UseVisualStyleBackColor = false;
            this.btnEliminarProyecto.Click += new System.EventHandler(this.btnEliminarProyecto_Click_1);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(567, 146);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(111, 13);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Número de proyectos:";
            // 
            // cbEliminar
            // 
            this.cbEliminar.AutoSize = true;
            this.cbEliminar.Location = new System.Drawing.Point(39, 146);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(62, 17);
            this.cbEliminar.TabIndex = 16;
            this.cbEliminar.Text = "Eliminar";
            this.cbEliminar.UseVisualStyleBackColor = true;
            this.cbEliminar.CheckedChanged += new System.EventHandler(this.cbEliminar_CheckedChanged_1);
            // 
            // txtBuscarProyecto
            // 
            this.txtBuscarProyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarProyecto.Location = new System.Drawing.Point(39, 54);
            this.txtBuscarProyecto.Name = "txtBuscarProyecto";
            this.txtBuscarProyecto.Size = new System.Drawing.Size(663, 20);
            this.txtBuscarProyecto.TabIndex = 14;
            this.txtBuscarProyecto.TextChanged += new System.EventHandler(this.txtBuscarProyecto_TextChanged);
            // 
            // FrmProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(799, 488);
            this.Controls.Add(this.label_añadir);
            this.Controls.Add(this.panelRecuadro);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminarProyecto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cbEliminar);
            this.Controls.Add(this.txtBuscarProyecto);
            this.Name = "FrmProyecto";
            this.Text = "FrmProyecto";
            this.panelRecuadro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListProyectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_añadir;
        private System.Windows.Forms.Panel panelRecuadro;
        private System.Windows.Forms.DataGridView dataListProyectos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminarProyecto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox cbEliminar;
        private System.Windows.Forms.TextBox txtBuscarProyecto;
    }
}