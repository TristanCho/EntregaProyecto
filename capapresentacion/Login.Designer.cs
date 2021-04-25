
namespace capapresentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.aceptar = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cerrar = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aceptar
            // 
            this.aceptar.BackColor = System.Drawing.Color.White;
            this.aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aceptar.Location = new System.Drawing.Point(140, 148);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(100, 23);
            this.aceptar.TabIndex = 0;
            this.aceptar.Text = "Validar";
            this.aceptar.UseVisualStyleBackColor = false;
            this.aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(140, 72);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(100, 20);
            this.usuario.TabIndex = 1;
            this.usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(137, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // cerrar
            // 
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Font = new System.Drawing.Font("Arial Black", 9F);
            this.cerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cerrar.Location = new System.Drawing.Point(359, 12);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(24, 27);
            this.cerrar.TabIndex = 25;
            this.cerrar.Text = "x";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(140, 109);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(137, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(395, 200);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.aceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
    }
}