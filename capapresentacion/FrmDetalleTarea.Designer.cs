
namespace capapresentacion
{
    partial class FrmDetalleTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleTarea));
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dtFechaTarea = new System.Windows.Forms.DateTimePicker();
            this.txtTituloTarea = new System.Windows.Forms.TextBox();
            this.txtIdTarea = new System.Windows.Forms.TextBox();
            this.txtObservacionesTarea = new System.Windows.Forms.RichTextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloProyecto = new System.Windows.Forms.Label();
            this.lbl_idproyecto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcionTarea = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboboxProyecto = new System.Windows.Forms.ComboBox();
            this.comboboxEstado = new System.Windows.Forms.ComboBox();
            this.lEdicion = new System.Windows.Forms.Label();
            this.btnEliminarProyecto = new System.Windows.Forms.Button();
            this.ltec = new System.Windows.Forms.Label();
            this.lTecnico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(497, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Estado:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(679, 459);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(598, 459);
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
            // dtFechaTarea
            // 
            this.dtFechaTarea.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaTarea.Location = new System.Drawing.Point(376, 81);
            this.dtFechaTarea.Name = "dtFechaTarea";
            this.dtFechaTarea.Size = new System.Drawing.Size(99, 20);
            this.dtFechaTarea.TabIndex = 38;
            // 
            // txtTituloTarea
            // 
            this.txtTituloTarea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTituloTarea.Location = new System.Drawing.Point(376, 41);
            this.txtTituloTarea.Name = "txtTituloTarea";
            this.txtTituloTarea.ReadOnly = true;
            this.txtTituloTarea.Size = new System.Drawing.Size(378, 20);
            this.txtTituloTarea.TabIndex = 36;
            // 
            // txtIdTarea
            // 
            this.txtIdTarea.Location = new System.Drawing.Point(123, 41);
            this.txtIdTarea.Name = "txtIdTarea";
            this.txtIdTarea.ReadOnly = true;
            this.txtIdTarea.Size = new System.Drawing.Size(162, 20);
            this.txtIdTarea.TabIndex = 35;
            // 
            // txtObservacionesTarea
            // 
            this.txtObservacionesTarea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacionesTarea.Location = new System.Drawing.Point(12, 267);
            this.txtObservacionesTarea.Name = "txtObservacionesTarea";
            this.txtObservacionesTarea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtObservacionesTarea.Size = new System.Drawing.Size(742, 170);
            this.txtObservacionesTarea.TabIndex = 34;
            this.txtObservacionesTarea.Text = "";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(12, 246);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(134, 18);
            this.lblObservaciones.TabIndex = 32;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Fecha:";
            // 
            // lblTituloProyecto
            // 
            this.lblTituloProyecto.AutoSize = true;
            this.lblTituloProyecto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProyecto.Location = new System.Drawing.Point(308, 40);
            this.lblTituloProyecto.Name = "lblTituloProyecto";
            this.lblTituloProyecto.Size = new System.Drawing.Size(62, 18);
            this.lblTituloProyecto.TabIndex = 30;
            this.lblTituloProyecto.Text = "Título:";
            this.lblTituloProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_idproyecto
            // 
            this.lbl_idproyecto.AutoSize = true;
            this.lbl_idproyecto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idproyecto.Location = new System.Drawing.Point(58, 40);
            this.lbl_idproyecto.Name = "lbl_idproyecto";
            this.lbl_idproyecto.Size = new System.Drawing.Size(59, 18);
            this.lbl_idproyecto.TabIndex = 29;
            this.lbl_idproyecto.Text = "Tarea:";
            this.lbl_idproyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Proyecto:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescripcionTarea
            // 
            this.txtDescripcionTarea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcionTarea.Location = new System.Drawing.Point(12, 159);
            this.txtDescripcionTarea.Name = "txtDescripcionTarea";
            this.txtDescripcionTarea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDescripcionTarea.Size = new System.Drawing.Size(742, 72);
            this.txtDescripcionTarea.TabIndex = 50;
            this.txtDescripcionTarea.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "Descripción:";
            // 
            // comboboxProyecto
            // 
            this.comboboxProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxProyecto.FormattingEnabled = true;
            this.comboboxProyecto.Location = new System.Drawing.Point(123, 78);
            this.comboboxProyecto.Name = "comboboxProyecto";
            this.comboboxProyecto.Size = new System.Drawing.Size(162, 21);
            this.comboboxProyecto.TabIndex = 51;
            // 
            // comboboxEstado
            // 
            this.comboboxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxEstado.FormattingEnabled = true;
            this.comboboxEstado.Location = new System.Drawing.Point(585, 84);
            this.comboboxEstado.Name = "comboboxEstado";
            this.comboboxEstado.Size = new System.Drawing.Size(169, 21);
            this.comboboxEstado.TabIndex = 52;
            // 
            // lEdicion
            // 
            this.lEdicion.AutoSize = true;
            this.lEdicion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEdicion.Location = new System.Drawing.Point(27, 11);
            this.lEdicion.Name = "lEdicion";
            this.lEdicion.Size = new System.Drawing.Size(101, 14);
            this.lEdicion.TabIndex = 53;
            this.lEdicion.Text = "[MODO LECTURA]";
            // 
            // btnEliminarProyecto
            // 
            this.btnEliminarProyecto.BackColor = System.Drawing.Color.White;
            this.btnEliminarProyecto.BackgroundImage = global::capapresentacion.Properties.Resources.DeleteButton;
            this.btnEliminarProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarProyecto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProyecto.Location = new System.Drawing.Point(722, 118);
            this.btnEliminarProyecto.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarProyecto.Name = "btnEliminarProyecto";
            this.btnEliminarProyecto.Size = new System.Drawing.Size(32, 28);
            this.btnEliminarProyecto.TabIndex = 54;
            this.btnEliminarProyecto.UseVisualStyleBackColor = false;
            this.btnEliminarProyecto.Click += new System.EventHandler(this.btnEliminarProyecto_Click);
            // 
            // ltec
            // 
            this.ltec.AutoSize = true;
            this.ltec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltec.Location = new System.Drawing.Point(609, 22);
            this.ltec.Name = "ltec";
            this.ltec.Size = new System.Drawing.Size(57, 13);
            this.ltec.TabIndex = 57;
            this.ltec.Text = "Tecnico:";
            // 
            // lTecnico
            // 
            this.lTecnico.AutoSize = true;
            this.lTecnico.Location = new System.Drawing.Point(672, 22);
            this.lTecnico.Name = "lTecnico";
            this.lTecnico.Size = new System.Drawing.Size(0, 13);
            this.lTecnico.TabIndex = 58;
            // 
            // FrmDetalleTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(766, 498);
            this.Controls.Add(this.lTecnico);
            this.Controls.Add(this.ltec);
            this.Controls.Add(this.btnEliminarProyecto);
            this.Controls.Add(this.lEdicion);
            this.Controls.Add(this.comboboxEstado);
            this.Controls.Add(this.comboboxProyecto);
            this.Controls.Add(this.txtDescripcionTarea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtFechaTarea);
            this.Controls.Add(this.txtTituloTarea);
            this.Controls.Add(this.txtIdTarea);
            this.Controls.Add(this.txtObservacionesTarea);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloProyecto);
            this.Controls.Add(this.lbl_idproyecto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDetalleTarea";
            this.Text = "Tarea";
            this.Load += new System.EventHandler(this.FrmDetalleTarea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DateTimePicker dtFechaTarea;
        private System.Windows.Forms.TextBox txtTituloTarea;
        private System.Windows.Forms.TextBox txtIdTarea;
        private System.Windows.Forms.RichTextBox txtObservacionesTarea;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloProyecto;
        private System.Windows.Forms.Label lbl_idproyecto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtDescripcionTarea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboboxProyecto;
        private System.Windows.Forms.ComboBox comboboxEstado;
        private System.Windows.Forms.Label lEdicion;
        private System.Windows.Forms.Button btnEliminarProyecto;
        private System.Windows.Forms.Label ltec;
        private System.Windows.Forms.Label lTecnico;
    }
}