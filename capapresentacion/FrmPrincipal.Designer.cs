
namespace capapresentacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.widgetBoton = new System.Windows.Forms.Button();
            this.Tiempos = new FontAwesome.Sharp.IconButton();
            this.Tareas = new FontAwesome.Sharp.IconButton();
            this.Proyectos = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.reloj_image = new System.Windows.Forms.PictureBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.txtnombreusuario = new System.Windows.Forms.Label();
            this.miminizar = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.iconoFormularioActual = new FontAwesome.Sharp.IconPictureBox();
            this.textoInicio = new System.Windows.Forms.Label();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reloj_image)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoFormularioActual)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkOrange;
            this.panelMenu.Controls.Add(this.widgetBoton);
            this.panelMenu.Controls.Add(this.Tiempos);
            this.panelMenu.Controls.Add(this.Tareas);
            this.panelMenu.Controls.Add(this.Proyectos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 567);
            this.panelMenu.TabIndex = 0;
            // 
            // widgetBoton
            // 
            this.widgetBoton.BackColor = System.Drawing.Color.Transparent;
            this.widgetBoton.BackgroundImage = global::capapresentacion.Properties.Resources.flechas;
            this.widgetBoton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.widgetBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.widgetBoton.FlatAppearance.BorderSize = 0;
            this.widgetBoton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.widgetBoton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.widgetBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.widgetBoton.ForeColor = System.Drawing.Color.Transparent;
            this.widgetBoton.Location = new System.Drawing.Point(67, 474);
            this.widgetBoton.Name = "widgetBoton";
            this.widgetBoton.Size = new System.Drawing.Size(49, 43);
            this.widgetBoton.TabIndex = 6;
            this.widgetBoton.UseVisualStyleBackColor = false;
            this.widgetBoton.Click += new System.EventHandler(this.widgetBoton_Click);
            // 
            // Tiempos
            // 
            this.Tiempos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tiempos.FlatAppearance.BorderSize = 0;
            this.Tiempos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tiempos.ForeColor = System.Drawing.SystemColors.Control;
            this.Tiempos.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.Tiempos.IconColor = System.Drawing.Color.White;
            this.Tiempos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Tiempos.IconSize = 32;
            this.Tiempos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tiempos.Location = new System.Drawing.Point(0, 260);
            this.Tiempos.Name = "Tiempos";
            this.Tiempos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Tiempos.Size = new System.Drawing.Size(200, 60);
            this.Tiempos.TabIndex = 5;
            this.Tiempos.Text = "Tiempos";
            this.Tiempos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tiempos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Tiempos.UseVisualStyleBackColor = true;
            this.Tiempos.Click += new System.EventHandler(this.Tiempos_Click);
            // 
            // Tareas
            // 
            this.Tareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tareas.FlatAppearance.BorderSize = 0;
            this.Tareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tareas.ForeColor = System.Drawing.SystemColors.Control;
            this.Tareas.IconChar = FontAwesome.Sharp.IconChar.List;
            this.Tareas.IconColor = System.Drawing.Color.White;
            this.Tareas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Tareas.IconSize = 32;
            this.Tareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tareas.Location = new System.Drawing.Point(0, 200);
            this.Tareas.Name = "Tareas";
            this.Tareas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Tareas.Size = new System.Drawing.Size(200, 60);
            this.Tareas.TabIndex = 2;
            this.Tareas.Text = "Tareas";
            this.Tareas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tareas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Tareas.UseVisualStyleBackColor = true;
            this.Tareas.Click += new System.EventHandler(this.Tareas_Click);
            // 
            // Proyectos
            // 
            this.Proyectos.BackColor = System.Drawing.Color.DarkOrange;
            this.Proyectos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Proyectos.FlatAppearance.BorderSize = 0;
            this.Proyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Proyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proyectos.ForeColor = System.Drawing.SystemColors.Control;
            this.Proyectos.IconChar = FontAwesome.Sharp.IconChar.Yelp;
            this.Proyectos.IconColor = System.Drawing.Color.White;
            this.Proyectos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Proyectos.IconSize = 32;
            this.Proyectos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Proyectos.Location = new System.Drawing.Point(0, 140);
            this.Proyectos.Name = "Proyectos";
            this.Proyectos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Proyectos.Size = new System.Drawing.Size(200, 60);
            this.Proyectos.TabIndex = 1;
            this.Proyectos.Text = "Proyectos";
            this.Proyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Proyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Proyectos.UseVisualStyleBackColor = false;
            this.Proyectos.Click += new System.EventHandler(this.Proyectos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.reloj_image);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // reloj_image
            // 
            this.reloj_image.BackgroundImage = global::capapresentacion.Properties.Resources.reloj;
            this.reloj_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reloj_image.Image = global::capapresentacion.Properties.Resources.reloj1;
            this.reloj_image.Location = new System.Drawing.Point(6, 2);
            this.reloj_image.Name = "reloj_image";
            this.reloj_image.Size = new System.Drawing.Size(188, 137);
            this.reloj_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reloj_image.TabIndex = 0;
            this.reloj_image.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Chocolate;
            this.panelTitulo.Controls.Add(this.txtnombreusuario);
            this.panelTitulo.Controls.Add(this.miminizar);
            this.panelTitulo.Controls.Add(this.cerrar);
            this.panelTitulo.Controls.Add(this.iconoFormularioActual);
            this.panelTitulo.Controls.Add(this.textoInicio);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(200, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(729, 50);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitulo_Paint);
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPrincipal_MouseDown);
            // 
            // txtnombreusuario
            // 
            this.txtnombreusuario.AutoSize = true;
            this.txtnombreusuario.Location = new System.Drawing.Point(456, 17);
            this.txtnombreusuario.Name = "txtnombreusuario";
            this.txtnombreusuario.Size = new System.Drawing.Size(35, 13);
            this.txtnombreusuario.TabIndex = 27;
            this.txtnombreusuario.Text = "label1";
            // 
            // miminizar
            // 
            this.miminizar.FlatAppearance.BorderSize = 0;
            this.miminizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miminizar.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miminizar.ForeColor = System.Drawing.SystemColors.Control;
            this.miminizar.Location = new System.Drawing.Point(672, 3);
            this.miminizar.Name = "miminizar";
            this.miminizar.Size = new System.Drawing.Size(24, 27);
            this.miminizar.TabIndex = 26;
            this.miminizar.Text = "-";
            this.miminizar.UseVisualStyleBackColor = true;
            this.miminizar.Click += new System.EventHandler(this.miminizar_Click);
            // 
            // cerrar
            // 
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Font = new System.Drawing.Font("Arial Black", 9F);
            this.cerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.cerrar.Location = new System.Drawing.Point(702, 3);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(24, 27);
            this.cerrar.TabIndex = 25;
            this.cerrar.Text = "x";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // iconoFormularioActual
            // 
            this.iconoFormularioActual.BackColor = System.Drawing.Color.Chocolate;
            this.iconoFormularioActual.ForeColor = System.Drawing.Color.Snow;
            this.iconoFormularioActual.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconoFormularioActual.IconColor = System.Drawing.Color.Snow;
            this.iconoFormularioActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoFormularioActual.Location = new System.Drawing.Point(16, 15);
            this.iconoFormularioActual.Name = "iconoFormularioActual";
            this.iconoFormularioActual.Size = new System.Drawing.Size(32, 32);
            this.iconoFormularioActual.TabIndex = 2;
            this.iconoFormularioActual.TabStop = false;
            // 
            // textoInicio
            // 
            this.textoInicio.AutoSize = true;
            this.textoInicio.ForeColor = System.Drawing.Color.White;
            this.textoInicio.Location = new System.Drawing.Point(54, 22);
            this.textoInicio.Name = "textoInicio";
            this.textoInicio.Size = new System.Drawing.Size(0, 13);
            this.textoInicio.TabIndex = 1;
            // 
            // panelFormulario
            // 
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormulario.Location = new System.Drawing.Point(200, 50);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(729, 517);
            this.panelFormulario.TabIndex = 2;
            this.panelFormulario.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 567);
            this.ControlBox = false;
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WPTimeTracking";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPrincipal_MouseDown);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reloj_image)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoFormularioActual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton Tiempos;
        private FontAwesome.Sharp.IconButton Tareas;
        private FontAwesome.Sharp.IconButton Proyectos;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.PictureBox reloj_image;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label textoInicio;
        private System.Windows.Forms.Panel panelFormulario;
        private FontAwesome.Sharp.IconPictureBox iconoFormularioActual;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button miminizar;
        private System.Windows.Forms.Button widgetBoton;
        private System.Windows.Forms.Label txtnombreusuario;
    }
}