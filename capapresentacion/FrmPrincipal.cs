using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

using capanegocio;
using capadatos;

namespace capapresentacion
{
    public partial class FrmPrincipal : Form
    {
        private IconButton botonActual;
        private Panel panelIzquierdo;
        private string nombreusuario;


       // private DLogin login;
        public string Nombreusuario { get => nombreusuario; set => nombreusuario = value; }
        //public DLogin Login { get => login; set => login = value; }



        public FrmPrincipal()
        {
            InitializeComponent();
            panelIzquierdo = new Panel();
            panelIzquierdo.Size = new Size(7, 60);
            panelMenu.Controls.Add(panelIzquierdo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Text = string.Empty;
            //txtnombreusuario.Text = login.Usuario;
            //Console.WriteLine(Login.Usuario+" usuario");
            //this.txtnombreusuario.Text = "dsadasdsas";
            
            //AbrirFormulario(new FrmProyectosl());



            // btnEliminarProyecto.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            // mostrarproyectos();
            //quitarBordes();
            //this.ControlBox = false;
        }


        public struct RGBColors
        {
            public static Color color1 = Color.White;
            public static Color color2 = Color.FromArgb(249, 118, 176);

        }

        public void AbrirFormulario(Form childForm)
        {
            //open only form
           // if (formularioActual != null)
            //{
            //    formularioActual.Close();
           // }
           // formularioActual = childForm;
            //End


            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFormulario.Controls.Add(childForm);
            panelFormulario.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            //lblTitleChildForm.Text = childForm.Text;
        }

        public void informacionLogin(string login,string bd)
        {
            Console.WriteLine(login);
            txtnombreusuario.Text = login;
        }

        public void cierraForm()
        {
            this.Hide();
        }
        public void ActivaBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                botonActual = (IconButton)senderBtn;
                botonActual.BackColor = Color.Chocolate;
                botonActual.ForeColor = color;
                botonActual.TextAlign = ContentAlignment.MiddleCenter;
                botonActual.IconColor = color;
                botonActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonActual.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                panelIzquierdo.BackColor = color;
                panelIzquierdo.Location = new Point(0, botonActual.Location.Y);
                panelIzquierdo.Visible = true;
                panelIzquierdo.BringToFront();
                //Current Child Form Icon
                iconoFormularioActual.IconChar = botonActual.IconChar;
                iconoFormularioActual.IconColor = color;
                textoInicio.Text = botonActual.Text;
            }
        }

        private void DisableButton()
        {
            if (botonActual != null)
            {
                botonActual.BackColor = Color.DarkOrange;
                botonActual.ForeColor = Color.Gainsboro;
                botonActual.TextAlign = ContentAlignment.MiddleLeft;
                botonActual.IconColor = Color.Gainsboro;
                botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //mostrarproyectos();
            
            //this.FormClosed += new FormClosedEventHandler(cerrarX);
        }



        internal void enviaDatos(String texto)
        {
            
        }

        /*
public void mostrarproyectos()
{
    this.dataListProyectos.DataSource = NProyecto.mostrarproyectos();
    this.ocultarcolumnas();
   this.btnEliminarProyecto.Visible = true;
   this.lblTotal.Text = "Número de proyectos: "+Convert.ToString(dataListProyectos.Rows.Count);
}

private void ocultarcolumnas()
{
   this.dataListProyectos.Columns[0].Visible = false;
   this.dataListProyectos.Columns[1].Visible = false;
   this.btnEliminarProyecto.Enabled = false;
   this.cbEliminar.Checked = false;

}

private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
{

}

private void btnEliminarProyecto_Click(object sender, EventArgs e)
{
   try
   {
           DialogResult opcion;
           opcion = MessageBox.Show("¿Desea continuar?", "Eliminar Proyecto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
           if (opcion == DialogResult.OK)
           {
           int aux = 0;
               int id;
               string rpta = "";
               foreach (DataGridViewRow row in dataListProyectos.Rows)
               {                          
                   if (Convert.ToBoolean(row.Cells[0].Value))
                   {
                   aux = 1;

                   id = Convert.ToInt32(row.Cells[1].Value);
                       rpta = NProyecto.eliminarproyecto(id);

                       if (rpta.Equals("OK"))
                       {
                           this.mensajeok("Registro eliminado");
                       }
                       else
                       {
                           this.mensajeerror("¡Ups!, Al parecer tienes tareas asignadas a este proyecto...");
                           this.mensajeerror(rpta);
                       }
               }                           
               }
           if (aux<1)
           {
               MessageBox.Show("No haz seleccionado ningún proyecto", "Eliminar Proyecto", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
           }
           this.mostrarproyectos();
       }
       else
       {
           this.btnEliminarProyecto.Enabled = false;
           this.cbEliminar.Checked = false;
       }
   }
   catch (Exception ex)
   {
       MessageBox.Show(ex.Message + ex.StackTrace);
   }
}

public void dataListProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
   if (e.ColumnIndex == dataListProyectos.Columns["Eliminar"].Index)
   {
       DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)dataListProyectos.Rows[e.RowIndex].Cells["Eliminar"];
       chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
   }
}

private void cbEliminar_CheckedChanged(object sender, EventArgs e)
{
   if (this.cbEliminar.Checked)
   {
       this.dataListProyectos.Columns[0].Visible = true;
       this.btnEliminarProyecto.Enabled = true;
   }
   else
   {
       this.dataListProyectos.Columns[0].Visible = false;
       this.btnEliminarProyecto.Enabled = false;
   }
}/*

private void btnNuevo_Click(object sender, EventArgs e)
{
   FrmDetalleProyecto frmDP = new FrmDetalleProyecto();
   frmDP.Show();
   this.Hide();
}

private void cerrarX(object sender, EventArgs e)
{
   System.Windows.Forms.Application.ExitThread();
}

private void widget_Click(object sender, EventArgs e)
{
   Form1 widget = new Form1();
   widget.Show();
   this.Hide();
}

private void cboBuscarProyecto_SelectedIndexChanged(object sender, EventArgs e)
{

}

private void quitarBordes()
{
   MaximizeBox = false;
   FormBorderStyle = FormBorderStyle.FixedDialog;
   TopMost = true;
   ShowInTaskbar = false;
   this.Text = String.Empty;
   this.ControlBox = false;


}

/*Utilizado para mover el panel atraves de la pantalla*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /*fin del drag*/


        private void Proyectos_Click(object sender, EventArgs e)
        {
            ActivaBoton(sender, RGBColors.color1);
            FrmProyecto proyecto = new FrmProyecto();
            proyecto.frmparent = this;
            AbrirFormulario(proyecto);
            
            
        }

        public void lanzarNuevoElemento(Form formulario) {
            //AbrirFormulario(new FrmDetalleProyecto());
            AbrirFormulario(formulario);
        }

        private void Tareas_Click(object sender, EventArgs e)
        {
            ActivaBoton(sender, RGBColors.color1);
            FrmTarea tareas = new FrmTarea();
            tareas.frmparent = this;
            AbrirFormulario(tareas);
            //AbrirFormulario(new FrmTarea());
        }

        private void Subtareas_Click(object sender, EventArgs e)
        {
            ActivaBoton(sender, RGBColors.color1);
            FrmTareasPersonales TareasPersonales = new FrmTareasPersonales();
            TareasPersonales.frmparent = this;
            AbrirFormulario(TareasPersonales);
            //AbrirFormulario(new FrmDetalleSubtarea());
        }

        private void Aplicaciones_Click(object sender, EventArgs e)
        {
            ActivaBoton(sender, RGBColors.color1);
            FrmAplicacion aplicacion = new FrmAplicacion();
            aplicacion.frmparent = this;
            AbrirFormulario(aplicacion);
         
        }

        private void Tiempos_Click(object sender, EventArgs e)
        {
            ActivaBoton(sender, RGBColors.color1);
            FrmTiempos tiempos = new FrmTiempos();
            tiempos.frmparent = this;
            AbrirFormulario(tiempos);

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconoFormularioActual_Click(object sender, EventArgs e)
        {

        }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void detalleProyectos_Click_1(object sender, EventArgs e)
        {
            ActivaBoton(sender, RGBColors.color1);
            AbrirFormulario(new FrmDetalleProyecto());
        }

        private void miminizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void widgetBoton_Click(object sender, EventArgs e)
        {
            Widget widget = new Widget();
            widget.Show();
            this.cierraForm();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }



    }
}
