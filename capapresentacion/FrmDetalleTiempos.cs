using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capanegocio;

namespace capapresentacion
{
    public partial class FrmDetalleTiempos : Form
    {
        bool esnuevo = false;
        bool eseditar = false;
        public string idtiempo = "";
        public FrmDetalleTiempos()
        {
            InitializeComponent();
            ModoInicial();
            //habilitar(false);
            //botonesVisible(false);
        }


        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Detalle de Tiempo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Detalle de Tiempo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //sss
        private void limpiar()
        {
            this.txtIdTiempo.Text = string.Empty;
            this.txtTarea.Text = string.Empty;
            this.txtObservaciones.Text = string.Empty;
            this.dtFechaInicio.Text = string.Empty;
            this.dtFechaFin.Text = string.Empty;
            this.txtMinutos.Text = string.Empty;
        }

        private void habilitar(bool valor)
        {
            this.txtIdTiempo.ReadOnly = true;
            this.txtTarea.ReadOnly = !valor;
            this.txtObservaciones.ReadOnly = !valor;
            this.dtFechaInicio.Enabled = valor;
            this.dtFechaFin.Enabled = valor;
            this.txtMinutos.Enabled = !valor;//TODO cambiar a label y setear valor
        }

        private void ModoInicial()
        {
            //Casillas
            limpiar();
            this.txtIdTiempo.ReadOnly = true;
            this.txtTarea.ReadOnly = true;
            this.txtObservaciones.ReadOnly = true;
            this.dtFechaInicio.Enabled = false;
            this.dtFechaFin.Enabled = false;
            this.txtMinutos.ReadOnly = true;//TODO cambiar a label y setear valor

            //Botones
            btnGuardar.Visible = false;
            btnCancelar.Visible = true;
            btnEditar.Visible = false;
            btnNuevo.Visible = true;
        }

        private void ModoNuevo()
        {
            //Casillas
            limpiar();
            this.txtIdTiempo.ReadOnly = true;
            this.txtTarea.ReadOnly = false;
            this.txtObservaciones.ReadOnly = false;
            this.dtFechaInicio.Enabled = true;
            this.dtFechaFin.Enabled = true;
            this.txtMinutos.ReadOnly = true;//TODO cambiar a label y setear valor

            //Botones
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            btnEditar.Visible = false;
            btnNuevo.Visible = false;
        }


        private void ModoVisualizar()
        {
            //Casillas
            
            this.txtIdTiempo.ReadOnly = true;
            this.txtTarea.ReadOnly = true;
            this.txtObservaciones.ReadOnly = true;
            this.dtFechaInicio.Enabled = false;
            this.dtFechaFin.Enabled = false;
            this.txtMinutos.ReadOnly = true; ;//TODO cambiar a label y setear valor

            //Botones
            btnNuevo.Visible = true;
            btnEditar.Visible = true;
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            
        }

        private void ModoEditar()
        {
            //Casillas

            this.txtIdTiempo.ReadOnly = true;
            this.txtTarea.ReadOnly = true;
            this.txtObservaciones.ReadOnly = true;
            this.dtFechaInicio.Enabled = false;
            this.dtFechaFin.Enabled = false;
            this.txtMinutos.ReadOnly = true; ;//TODO cambiar a label y setear valor

            //Botones
            btnNuevo.Visible = false;
            btnEditar.Visible = false;
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;

        }

        private void ModoCancelar()
        {
            //Casillas
            limpiar();
            this.txtIdTiempo.ReadOnly = true;
            this.txtTarea.ReadOnly = false;
            this.txtObservaciones.ReadOnly = false;
            this.dtFechaInicio.Enabled = false;
            this.dtFechaFin.Enabled = false;
            this.txtMinutos.Enabled = true;//TODO cambiar a label y setear valor

            //Botones
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            btnEditar.Visible = true;
            btnNuevo.Visible = false;
        }

        private void botonesVisible(bool estado)
        {
            btnGuardar.Visible = estado;
            btnCancelar.Visible = estado;
            btnEditar.Visible = !estado;
            btnNuevo.Visible = !estado;
            //txtObservaciones.Enabled = estado;
        }

        private void botones()
        {
            if (esnuevo || this.eseditar)
            {
                habilitar(true);
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = true;
            }
            else
            {
                habilitar(false);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }


        private void FrmDetalleTiempos_Load(object sender, EventArgs e)
        {
            this.botones();
            this.FormClosed += new FormClosedEventHandler(cerrarX);
        }

        private void cerrarX(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            this.Hide();
            frmPrincipal.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esnuevo = true;
            ModoNuevo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                //MessageBox.Show("En guardar");

                string rpta = "";
                if (this.txtTarea.Text==string.Empty)
                {
                    mensajeerror("Formulario incompleto");
                    this.iconoerror.SetError(this.txtTarea, "Ingresar Tarea");
                }
                else
                {
                    if (esnuevo)
                    {
                        rpta = NTiempo.insertartiempo(
                        this.txtTarea.Text.Trim().ToUpper(),
                        Convert.ToDateTime(this.dtFechaInicio.Value),
                        Convert.ToDateTime(this.dtFechaFin.Value),
                        this.txtObservaciones.Text.Trim());
                    }
                    else
                    {
                        MessageBox.Show("Entrando en else editar");
                        rpta = NTiempo.editartiempo(Convert.ToInt32(this.txtIdTiempo.Text),
                            this.txtTarea.Text.Trim(), 
                            Convert.ToDateTime(this.dtFechaInicio.Value),
                            Convert.ToDateTime(this.dtFechaFin.Value), 
                            this.txtObservaciones.Text.Trim());
                     }

                    if (rpta.Equals("OK"))
                    {
                        if (esnuevo)
                        {
                            this.mensajeok("Se ha creado el Registro de tiempo satisfactoriamente");
                        }
                        else
                        {
                            this.mensajeok("Se ha editado el Registro de tiempo satisfactoriamente");
                        }

                    }
                    else
                    {
                        this.mensajeerror(rpta);
                    }

                    this.esnuevo = false;
                    this.eseditar = false;
                    ModoVisualizar();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdTiempo.Text.Equals(""))
            {
                this.eseditar = true;
                this.botones();
            }
            else
            {
                this.mensajeerror("selleccione el registro a modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // botones();
            //limpiar();
            ModoInicial();
            this.Hide();
        }

        private void txtIdProyecto_TextChanged(object sender, EventArgs e)
        {

        }

        public void visualizaDatos(string id, string id_tarea, string fecha_inicio, string fecha_fin, string observaciones)
        {

            this.txtIdTiempo.Text = id;
            this.txtTarea.Text = id_tarea;            
            this.dtFechaInicio.Text = fecha_inicio;
            this.dtFechaFin.Text = fecha_fin;
            this.txtObservaciones.Text = observaciones;

        }

        private void txtObservacionesProyecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtFechaProyecto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                string rpta = "";
                //if (this.txtTarea.Text == string.Empty)
                //{
                //    mensajeerror("Formulario incompleto");
                //    this.iconoerror.SetError(this.txtTarea, "Ingresar Tarea");
                //}

                rpta = NTiempo.buscarid(
                   this.txtTarea.Text.Trim().ToUpper(),
                   Convert.ToDateTime(this.dtFechaInicio.Value),
                   Convert.ToDateTime(this.dtFechaFin.Value),
                   this.txtObservaciones.Text.Trim());

                if (rpta.Equals("OK"))
                    {
                        if (esnuevo)
                        {
                            this.mensajeok("Tenemos id");
                        }
                        else
                        {
                            this.mensajeok("Fallo al encontrar id");
                        }

                    }
                    else
                    {
                        this.mensajeerror(rpta);
                    }

                    //this.esnuevo = false;
                    //this.eseditar = false;
                    //ModoVisualizar();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }
    }
}
