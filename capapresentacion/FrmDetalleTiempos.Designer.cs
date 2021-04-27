
namespace capapresentacion
{
    partial class FrmDetalleTiempos
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescripciones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdTiempo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iconoerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.mensajetool = new System.Windows.Forms.ToolTip(this.components);
            this.comboboxTarea = new System.Windows.Forms.ComboBox();
            this.btnEliminarTiempo = new System.Windows.Forms.Button();
            this.lEdicion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconoerror)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(694, 459);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(93, 459);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(613, 459);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(12, 459);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 39;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaInicio.Location = new System.Drawing.Point(131, 85);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(146, 20);
            this.dtFechaInicio.TabIndex = 38;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones.Location = new System.Drawing.Point(12, 154);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(757, 299);
            this.txtObservaciones.TabIndex = 34;
            this.txtObservaciones.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tarea:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescripciones
            // 
            this.lblDescripciones.AutoSize = true;
            this.lblDescripciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripciones.Location = new System.Drawing.Point(12, 123);
            this.lblDescripciones.Name = "lblDescripciones";
            this.lblDescripciones.Size = new System.Drawing.Size(134, 18);
            this.lblDescripciones.TabIndex = 32;
            this.lblDescripciones.Text = "Observaciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Fecha Inicio:";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaFin.Location = new System.Drawing.Point(381, 87);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(146, 20);
            this.dtFechaFin.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Fecha Fin:";
            // 
            // txtIdTiempo
            // 
            this.txtIdTiempo.Location = new System.Drawing.Point(105, 46);
            this.txtIdTiempo.Name = "txtIdTiempo";
            this.txtIdTiempo.Size = new System.Drawing.Size(117, 20);
            this.txtIdTiempo.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "Tiempo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iconoerror
            // 
            this.iconoerror.ContainerControl = this;
            // 
            // comboboxTarea
            // 
            this.comboboxTarea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboboxTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxTarea.FormattingEnabled = true;
            this.comboboxTarea.Location = new System.Drawing.Point(302, 46);
            this.comboboxTarea.Name = "comboboxTarea";
            this.comboboxTarea.Size = new System.Drawing.Size(467, 21);
            this.comboboxTarea.TabIndex = 55;
            // 
            // btnEliminarTiempo
            // 
            this.btnEliminarTiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarTiempo.BackColor = System.Drawing.Color.White;
            this.btnEliminarTiempo.BackgroundImage = global::capapresentacion.Properties.Resources.DeleteButton;
            this.btnEliminarTiempo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarTiempo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarTiempo.FlatAppearance.BorderSize = 0;
            this.btnEliminarTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTiempo.Location = new System.Drawing.Point(740, 119);
            this.btnEliminarTiempo.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarTiempo.Name = "btnEliminarTiempo";
            this.btnEliminarTiempo.Size = new System.Drawing.Size(32, 28);
            this.btnEliminarTiempo.TabIndex = 56;
            this.btnEliminarTiempo.UseVisualStyleBackColor = false;
            this.btnEliminarTiempo.Click += new System.EventHandler(this.btnEliminarTiempo_Click);
            // 
            // lEdicion
            // 
            this.lEdicion.AutoSize = true;
            this.lEdicion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEdicion.Location = new System.Drawing.Point(24, 9);
            this.lEdicion.Name = "lEdicion";
            this.lEdicion.Size = new System.Drawing.Size(101, 14);
            this.lEdicion.TabIndex = 57;
            this.lEdicion.Text = "[MODO LECTURA]";
            // 
            // FrmDetalleTiempos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(781, 494);
            this.ControlBox = false;
            this.Controls.Add(this.lEdicion);
            this.Controls.Add(this.btnEliminarTiempo);
            this.Controls.Add(this.comboboxTarea);
            this.Controls.Add(this.txtIdTiempo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFechaFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDescripciones);
            this.Controls.Add(this.label1);
            this.Name = "FrmDetalleTiempos";
            this.Text = "FrmDetalleTiempos";
            this.Load += new System.EventHandler(this.FrmDetalleTiempos_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.iconoerror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.RichTextBox txtObservaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescripciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdTiempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider iconoerror;
        private System.Windows.Forms.ToolTip mensajetool;
        private System.Windows.Forms.ComboBox comboboxTarea;
        private System.Windows.Forms.Button btnEliminarTiempo;
        private System.Windows.Forms.Label lEdicion;
    }
}