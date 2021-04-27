using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capadatos;
using capanegocio;
using WPTT_1._0;

namespace capapresentacion
{
    public partial class FrmDetalleTarea : Form
    {

        bool esnuevo = false;
        bool eseditar = false;
        
        public FrmDetalleTarea()
        {
            InitializeComponent();
            botonesVisible(false);
            habilitar(false);
        }

        public void mostrarProyectoCombobox()
        {
            comboboxProyecto.Items.AddRange(NTarea.mostrarProyectoCombobox().ToArray());
            comboboxProyecto.SelectedIndex = 0;
        }

        public void mostrarEstadoCombobox()
        {
            comboboxEstado.Items.AddRange(NTarea.mostrarEstadoCombobox().ToArray());
            comboboxEstado.SelectedIndex = 0;
        }


        public void setTecnico()
        {
            lTecnico.Text = DLogin.tecnico;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdTarea.Text.Equals(""))
            {
                this.eseditar = true;
                this.botones();
                setModo("EDICION");
                botonesVisible(true);

            }
            else
            {
                this.mensajeerror("selleccione el registro a modificar");
            }
        }
        private void botonesVisible(bool estado)
        {
            btnGuardar.Visible = estado;
            btnCancelar.Visible = estado;
            txtDescripcionTarea.Enabled = estado;
            txtObservacionesTarea.Enabled = estado;
            
            btnEditar.Visible = !estado;
            btnNuevo.Visible = !estado;
        }

        internal void setBotonEliminar(bool value)
        {
            btnEliminarProyecto.Visible = value;
        }

        public void visualizaDatos(string id, string proyecto, string tarea, string descripcion, string observaciones, string fecha_creacion, string estado,string tecnico)
        {
            txtIdTarea.Text = id;
            txtTituloTarea.Text = tarea;
            comboboxProyecto.SelectedIndex = comboboxProyecto.FindStringExact(proyecto);
            txtDescripcionTarea.Text = descripcion;
            txtObservacionesTarea.Text = observaciones;
            dtFechaTarea.Text = fecha_creacion;
            comboboxEstado.SelectedIndex = comboboxEstado.FindStringExact(estado);
            lTecnico.Text = tecnico;
        }

        private void habilitar(bool valor)
        {
            this.txtIdTarea.ReadOnly = true;
            this.txtDescripcionTarea.ReadOnly = !valor;
            this.txtTituloTarea.ReadOnly = !valor;
            this.comboboxEstado.Enabled = valor;
            this.comboboxProyecto.Enabled = valor;
            this.dtFechaTarea.Enabled = valor;
        }

        private void FrmDetalleTarea_Load(object sender, EventArgs e)
        {
            mostrarProyectoCombobox();
            mostrarEstadoCombobox();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            crearNuevo();
        }
        public void crearNuevo() {
            esnuevo = true;
            botonesVisible(true);
            setModo("CREACIÓN");
            botones();
            limpiar();
        }
        public void setModo(String modo)
        {
            lEdicion.Text = "[MODO " + modo + "]";
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

        private void limpiar()
        {
            this.txtIdTarea.Text = string.Empty;
            this.txtTituloTarea.Text = string.Empty;
            this.comboboxProyecto.Items.Clear();
            this.comboboxEstado.Items.Clear();
            dtFechaTarea.Text = string.Empty;
            this.txtDescripcionTarea.Text = string.Empty;
            this.txtObservacionesTarea.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lectura();
        }

        public void lectura()
        {
            esnuevo = false;
            this.eseditar = false;
            botones();
            botonesVisible(false);
            //limpiar();
            this.Hide();
            setModo("LECTURA");
            //llamaVisualizaDatos();
        }

        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Detalle de Tarea", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Detalle de Tarea", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            try
            {
                string rpta = "";

                if (this.txtTituloTarea.Text == string.Empty)
                {
                    mensajeerror("Formulario incompleto");
                    //this.iconoerror.SetError(this.txtTituloTarea, "Ingresar Título");
                }
                else
                {
                    if (esnuevo)
                    {
                        rpta = NTarea.insertartarea(
                            this.txtTituloTarea.Text.Trim().ToUpper(),
                            this.txtDescripcionTarea.Text.Trim(),  
                            this.txtObservacionesTarea.Text.Trim(),
                            Convert.ToDateTime(this.dtFechaTarea.Value),
                            this.comboboxEstado.SelectedItem.ToString() ,
                            this.lTecnico.Text,
                            this.comboboxProyecto.SelectedItem.ToString()
                            );
                    }
                    else
                    {
                        //TODO falta por acabar, salta error
                        rpta = NTarea.editarTarea(
                            Convert.ToInt32(this.txtIdTarea.Text),
                            this.txtTituloTarea.Text.Trim().ToUpper(),
                            this.txtDescripcionTarea.Text.Trim(),
                            this.txtObservacionesTarea.Text.Trim(),
                            Convert.ToDateTime(this.dtFechaTarea.Value),
                            this.comboboxEstado.SelectedItem.ToString(),
                            this.lTecnico.Text,
                            this.comboboxProyecto.SelectedItem.ToString()
                            );
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (esnuevo)
                        {
                            this.mensajeok("Se ha creado la tarea satisfactoriamente");
                        }
                        else
                        {
                            this.mensajeok("Se ha editado la tarea satisfactoriamente");
                        }
                    }
                    else
                    {
                        this.mensajeerror(rpta);
                    }
                    botonesVisible(false);
                    botones();
                    this.limpiar();
                    FrmTarea tarea = new FrmTarea();
                    FrmParent.frmparent.lanzarNuevoElemento(tarea);
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }
        

        private void btnEliminarProyecto_Click(object sender, EventArgs e)
        {
            if (!txtIdTarea.Text.Equals(""))
            {
                try
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("¿Desea continuar?", "Eliminar Proyecto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        string rpta = "";

                        rpta = NTarea.eliminarTarea(Convert.ToInt32(txtIdTarea.Text));

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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }

                /*if (aux < 1)
                {
                    MessageBox.Show("No haz seleccionado ningún proyecto", "Eliminar Proyecto", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                this.mostrarproyectos();*/
            }

        }
        /*
        public void llamaVisualizaDatos()
        {

            visualizaDatos(
                Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["id"].Value),
                Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["proyecto"].Value),
                Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["tarea"].Value),
                Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["descripcion"].Value),
                Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["observaciones"].Value),
                Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["fecha_creacion"].Value),
                Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["estado"].Value),
                Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["tecnico"].Value)
                );
        }
     */
    }
}
