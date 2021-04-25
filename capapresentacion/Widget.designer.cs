
namespace capapresentacion
{
    partial class Widget
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Widget));
            this.listaTareasPersonales = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modoAplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarCronometroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pararCronometroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miminizar = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.tCronometro = new System.Windows.Forms.TextBox();
            this.botonStart = new System.Windows.Forms.Button();
            this.botonApagar = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaTareasPersonales
            // 
            this.listaTareasPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaTareasPersonales.FormattingEnabled = true;
            this.listaTareasPersonales.Location = new System.Drawing.Point(29, 34);
            this.listaTareasPersonales.Name = "listaTareasPersonales";
            this.listaTareasPersonales.Size = new System.Drawing.Size(256, 21);
            this.listaTareasPersonales.TabIndex = 2;
            this.listaTareasPersonales.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(26, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tareas Personales";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "WPTimeTracking";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoAplicacionToolStripMenuItem,
            this.iniciarCronometroToolStripMenuItem,
            this.pararCronometroToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 70);
            // 
            // modoAplicacionToolStripMenuItem
            // 
            this.modoAplicacionToolStripMenuItem.Name = "modoAplicacionToolStripMenuItem";
            this.modoAplicacionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.modoAplicacionToolStripMenuItem.Text = "Modo aplicacion";
            this.modoAplicacionToolStripMenuItem.Click += new System.EventHandler(this.modoAplicacionToolStripMenuItem_Click);
            // 
            // iniciarCronometroToolStripMenuItem
            // 
            this.iniciarCronometroToolStripMenuItem.Name = "iniciarCronometroToolStripMenuItem";
            this.iniciarCronometroToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.iniciarCronometroToolStripMenuItem.Text = "Iniciar cronometro";
            this.iniciarCronometroToolStripMenuItem.Click += new System.EventHandler(this.iniciarCronometroToolStripMenuItem_Click);
            // 
            // pararCronometroToolStripMenuItem
            // 
            this.pararCronometroToolStripMenuItem.Name = "pararCronometroToolStripMenuItem";
            this.pararCronometroToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.pararCronometroToolStripMenuItem.Text = "Parar cronometro";
            this.pararCronometroToolStripMenuItem.Click += new System.EventHandler(this.pararCronometroToolStripMenuItem_Click);
            // 
            // miminizar
            // 
            this.miminizar.FlatAppearance.BorderSize = 0;
            this.miminizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miminizar.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miminizar.ForeColor = System.Drawing.SystemColors.Control;
            this.miminizar.Location = new System.Drawing.Point(311, 12);
            this.miminizar.Name = "miminizar";
            this.miminizar.Size = new System.Drawing.Size(24, 27);
            this.miminizar.TabIndex = 23;
            this.miminizar.Text = "-";
            this.miminizar.UseVisualStyleBackColor = true;
            this.miminizar.Click += new System.EventHandler(this.miminizar_Click);
            // 
            // cerrar
            // 
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Font = new System.Drawing.Font("Arial Black", 9F);
            this.cerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cerrar.Location = new System.Drawing.Point(369, 12);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(24, 27);
            this.cerrar.TabIndex = 24;
            this.cerrar.Text = "x";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // maximizar
            // 
            this.maximizar.FlatAppearance.BorderSize = 0;
            this.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizar.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.maximizar.Location = new System.Drawing.Point(341, 11);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(24, 27);
            this.maximizar.TabIndex = 31;
            this.maximizar.Text = "□";
            this.maximizar.UseVisualStyleBackColor = true;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // tCronometro
            // 
            this.tCronometro.Location = new System.Drawing.Point(29, 100);
            this.tCronometro.Name = "tCronometro";
            this.tCronometro.ReadOnly = true;
            this.tCronometro.Size = new System.Drawing.Size(85, 20);
            this.tCronometro.TabIndex = 32;
            this.tCronometro.Text = "00:00:00";
            this.tCronometro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tCronometro.TextChanged += new System.EventHandler(this.tCronometro_TextChanged);
            // 
            // botonStart
            // 
            this.botonStart.BackColor = System.Drawing.Color.Transparent;
            this.botonStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonStart.BackgroundImage")));
            this.botonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonStart.FlatAppearance.BorderSize = 0;
            this.botonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonStart.Location = new System.Drawing.Point(301, 93);
            this.botonStart.Name = "botonStart";
            this.botonStart.Size = new System.Drawing.Size(34, 32);
            this.botonStart.TabIndex = 27;
            this.botonStart.UseVisualStyleBackColor = false;
            this.botonStart.Click += new System.EventHandler(this.botonStart_Click);
            // 
            // botonApagar
            // 
            this.botonApagar.BackColor = System.Drawing.Color.Transparent;
            this.botonApagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonApagar.BackgroundImage")));
            this.botonApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonApagar.FlatAppearance.BorderSize = 0;
            this.botonApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonApagar.Location = new System.Drawing.Point(352, 93);
            this.botonApagar.Name = "botonApagar";
            this.botonApagar.Size = new System.Drawing.Size(41, 32);
            this.botonApagar.TabIndex = 25;
            this.botonApagar.UseVisualStyleBackColor = false;
            this.botonApagar.Click += new System.EventHandler(this.botonApagar_Click);
            // 
            // Widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(398, 137);
            this.ControlBox = false;
            this.Controls.Add(this.tCronometro);
            this.Controls.Add(this.maximizar);
            this.Controls.Add(this.botonStart);
            this.Controls.Add(this.botonApagar);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.miminizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaTareasPersonales);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Widget";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox listaTareasPersonales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button miminizar;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button botonApagar;
        private System.Windows.Forms.Button botonStart;
        private System.Windows.Forms.Button maximizar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modoAplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarCronometroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pararCronometroToolStripMenuItem;
        private System.Windows.Forms.TextBox tCronometro;
    }
}

