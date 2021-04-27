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
using WPTT_1._0;

namespace capapresentacion
{
    public partial class FrmDetalleTiempos : Form
    {
        bool esnuevo = false;
        bool eseditar = false;
        public string idtiempo = "";
        public FrmPrincipal frmparent;
        public FrmDetalleTiempos()
        {
            InitializeComponent();
            habilitar(false);
            botonesVisible(false);
        }

        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Detalle de Tiempo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Detalle de Tiempo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void limpiar()
        {
            this.txtIdTiempo.Text = string.Empty;
            this.txtObservaciones.Text = string.Empty;
            this.dtFechaInicio.Text = string.Empty;
            this.dtFechaFin.Text = string.Empty;
            
        }

        private void habilitar(bool valor)
        {
            this.txtIdTiempo.ReadOnly = true;
            this.comboboxTarea.Enabled = valor;
            this.txtObservaciones.ReadOnly = !valor;
            this.dtFechaInicio.Enabled = valor;
            this.dtFechaFin.Enabled = valor;
           
        }
        private void botonesVisible(bool estado)
        {
            btnGuardar.Visible = estado;
            btnCancelar.Visible = estado;
            btnEditar.Visible = !estado;
            btnNuevo.Visible = !estado;
            txtObservaciones.Enabled = estado;            
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

        public void desbloqueaBotones()
        {
            esnuevo = true;
            txtObservaciones.Enabled = true;
            btnEliminarTiempo.Visible = false;
            botonesVisible(true);
            setModo("CREACIÓN");
            botones();
            limpiar();
        }

        internal void setBotonEliminar(bool value)
        {
            btnEliminarTiempo.Visible = value;
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

        public void setModo(String modo)
        {
            lEdicion.Text = "[MODO " + modo + "]";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esnuevo = true;
            txtObservaciones.Enabled = true;
            botonesVisible(true);
            setModo("CREACIÓN");
            botones();
            limpiar();   
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                string rpta = "";
                if (this.comboboxTarea.Text==string.Empty)
                {
                    mensajeerror("Formulario incompleto");
                    this.iconoerror.SetError(this.comboboxTarea, "Ingresar Tarea");
                }
                else
                {
                    if (esnuevo)
                    {
                        rpta = NTiempo.insertartiempo(
                        this.comboboxTarea.Text.Trim().ToUpper(),
                        Convert.ToDateTime(this.dtFechaInicio.Value),
                        Convert.ToDateTime(this.dtFechaFin.Value),
                        this.txtObservaciones.Text.Trim());
                    }
                    else
                    {
                        rpta = NTiempo.editartiempo(Convert.ToInt32(this.txtIdTiempo.Text),
                            this.comboboxTarea.Text.Trim(), 
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

                    botonesVisible(false);
                    botones();
                    this.Hide();
                    FrmTiempos tiempos = new FrmTiempos();
                    FrmParent.frmparent.lanzarNuevoElemento(tiempos);
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
                setModo("EDICIÓN");
                // txtObservacionesProyecto.Enabled = true;
                //txtDescripcionProyecto.Enabled = true;
                //this.txtDescripcionProyecto.Visible = true;
                botonesVisible(true);
            }
            else
            {
                this.mensajeerror("seleccione el registro a modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            esnuevo = false;
            this.eseditar = false;
            botones();
            botonesVisible(false);
            //limpiar();
            //this.Hide();
            setModo("LECTURA");
            this.Hide();
        }
        public void visualizaDatos(string id, string id_tarea, string fecha_inicio, string fecha_fin, string observaciones)
        {
            this.txtIdTiempo.Text = id;
            comboboxTarea.SelectedIndex = comboboxTarea.Items.IndexOf(id_tarea);
            this.dtFechaInicio.Text = fecha_inicio;
            this.dtFechaFin.Text = fecha_fin;
            this.txtObservaciones.Text = observaciones;
        }
               
        public void mostrarTareaCombobox()
        {
            comboboxTarea.Items.AddRange(NTiempo.mostrarTareaCombobox().ToArray());
            comboboxTarea.SelectedIndex = 0;
        }

        private void btnEliminarTiempo_Click(object sender, EventArgs e)
        {
            if (!lEdicion.Text.Equals(""))
            {
                try
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("¿Desea continuar?", "Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {

                        string rpta = "";

                        rpta = NTiempo.eliminartiempo(Convert.ToInt32(txtIdTiempo.Text));

                        if (rpta.Equals("OK"))
                        {
                            this.mensajeok("Registro eliminado");
                            FrmParent.frmparent.AbrirFormulario(new FrmTiempos());
                        }
                        else
                        {
                            this.mensajeerror("¡Ups!, Algo ha salido mal...");
                            this.mensajeerror(rpta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void FrmDetalleTiempos_Load_1(object sender, EventArgs e)
        {
            mostrarTareaCombobox();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            esnuevo = false;
            this.eseditar = false;
            botones();
            botonesVisible(false);
            setModo("LECTURA");
            this.Hide();
        }
    }
}
