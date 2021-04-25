
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
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(468, 120);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(204, 20);
            this.txtHoras.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Horas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "Estado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(597, 459);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(148, 459);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(468, 459);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(25, 459);
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
            this.dtFechaTarea.Location = new System.Drawing.Point(468, 41);
            this.dtFechaTarea.Name = "dtFechaTarea";
            this.dtFechaTarea.Size = new System.Drawing.Size(204, 20);
            this.dtFechaTarea.TabIndex = 38;
            this.dtFechaTarea.ValueChanged += new System.EventHandler(this.dtFechaTarea_ValueChanged);
            // 
            // txtTituloTarea
            // 
            this.txtTituloTarea.Location = new System.Drawing.Point(148, 78);
            this.txtTituloTarea.Name = "txtTituloTarea";
            this.txtTituloTarea.ReadOnly = true;
            this.txtTituloTarea.Size = new System.Drawing.Size(162, 20);
            this.txtTituloTarea.TabIndex = 36;
            // 
            // txtIdTarea
            // 
            this.txtIdTarea.Location = new System.Drawing.Point(148, 41);
            this.txtIdTarea.Name = "txtIdTarea";
            this.txtIdTarea.ReadOnly = true;
            this.txtIdTarea.Size = new System.Drawing.Size(162, 20);
            this.txtIdTarea.TabIndex = 35;
            // 
            // txtObservacionesTarea
            // 
            this.txtObservacionesTarea.Location = new System.Drawing.Point(26, 324);
            this.txtObservacionesTarea.Name = "txtObservacionesTarea";
            this.txtObservacionesTarea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtObservacionesTarea.Size = new System.Drawing.Size(651, 113);
            this.txtObservacionesTarea.TabIndex = 34;
            this.txtObservacionesTarea.Text = "";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(20, 296);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(162, 25);
            this.lblObservaciones.TabIndex = 32;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Fecha";
            // 
            // lblTituloProyecto
            // 
            this.lblTituloProyecto.AutoSize = true;
            this.lblTituloProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProyecto.Location = new System.Drawing.Point(71, 78);
            this.lblTituloProyecto.Name = "lblTituloProyecto";
            this.lblTituloProyecto.Size = new System.Drawing.Size(65, 25);
            this.lblTituloProyecto.TabIndex = 30;
            this.lblTituloProyecto.Text = "Título";
            this.lblTituloProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_idproyecto
            // 
            this.lbl_idproyecto.AutoSize = true;
            this.lbl_idproyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idproyecto.Location = new System.Drawing.Point(51, 41);
            this.lbl_idproyecto.Name = "lbl_idproyecto";
            this.lbl_idproyecto.Size = new System.Drawing.Size(85, 25);
            this.lbl_idproyecto.TabIndex = 29;
            this.lbl_idproyecto.Text = "IdTarea";
            this.lbl_idproyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "Proyecto";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescripcionTarea
            // 
            this.txtDescripcionTarea.Location = new System.Drawing.Point(25, 203);
            this.txtDescripcionTarea.Name = "txtDescripcionTarea";
            this.txtDescripcionTarea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDescripcionTarea.Size = new System.Drawing.Size(651, 72);
            this.txtDescripcionTarea.TabIndex = 50;
            this.txtDescripcionTarea.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Descripción:";
            // 
            // comboboxProyecto
            // 
            this.comboboxProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxProyecto.FormattingEnabled = true;
            this.comboboxProyecto.Location = new System.Drawing.Point(148, 117);
            this.comboboxProyecto.Name = "comboboxProyecto";
            this.comboboxProyecto.Size = new System.Drawing.Size(162, 21);
            this.comboboxProyecto.TabIndex = 51;
            this.comboboxProyecto.SelectedIndexChanged += new System.EventHandler(this.comboboxProyecto_SelectedIndexChanged);
            // 
            // comboboxEstado
            // 
            this.comboboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxEstado.FormattingEnabled = true;
            this.comboboxEstado.Location = new System.Drawing.Point(468, 84);
            this.comboboxEstado.Name = "comboboxEstado";
            this.comboboxEstado.Size = new System.Drawing.Size(204, 21);
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
            this.btnEliminarProyecto.Location = new System.Drawing.Point(640, 162);
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
            this.ltec.Location = new System.Drawing.Point(609, 12);
            this.ltec.Name = "ltec";
            this.ltec.Size = new System.Drawing.Size(57, 13);
            this.ltec.TabIndex = 57;
            this.ltec.Text = "Tecnico:";
            // 
            // lTecnico
            // 
            this.lTecnico.AutoSize = true;
            this.lTecnico.Location = new System.Drawing.Point(672, 12);
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
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label label4;
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