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

            mostrarProyectoCombobox();
            mostrarEstadoCombobox();
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
        public void visualizaDatos(string id, string proyecto, string tarea, string descripcion, string observaciones, string fecha_creacion, string estado,string tecnico)
        {

            txtIdTarea.Text = id;
            txtTituloTarea.Text = tarea;
            comboboxProyecto.Items.Add(proyecto);
            comboboxProyecto.SelectedIndex = 0;
            txtDescripcionTarea.Text = descripcion;
            txtObservacionesTarea.Text = observaciones;
            dtFechaTarea.Text = fecha_creacion;
            comboboxEstado.Items.Add(estado);
            comboboxEstado.SelectedIndex = 0;
            lTecnico.Text = tecnico;
        }

        /*
        private void habilitar(bool valor)
        {
            this.txtIdProyecto.ReadOnly = true;
            this.txtTituloProyecto.ReadOnly = !valor;
            this.txtObservacionesProyecto.ReadOnly = !valor;
            this.txtDescripcionProyecto.ReadOnly = !valor;
            this.dtFechaProyecto.Enabled = valor;

        }*/
        private void habilitar(bool valor)
        {
            this.txtIdTarea.ReadOnly = true;
            this.txtIdTarea.ReadOnly = true;
            this.txtTituloTarea.ReadOnly = !valor;

        }

        private void txtAplicacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmDetalleTarea_Load(object sender, EventArgs e)
        {

        }

        private void comboboxProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esnuevo = true;
            botonesVisible(true);
            setModo("CREACIÓN");
            botones();
            limpiar();
            mostrarProyectoCombobox();
            mostrarEstadoCombobox();
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
            this.txtHoras.Text = string.Empty;
            this.txtDescripcionTarea.Text = string.Empty;
            this.txtObservacionesTarea.Text = string.Empty;
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
            llamaVisualizaDatos();
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
            Console.WriteLine(comboboxProyecto.SelectedItem.ToString());
            Console.WriteLine(comboboxEstado.SelectedItem.ToString()); ;
            Console.WriteLine(this.lTecnico.Text); 
            //Console.WriteLine(Convert.ToInt32(this.txtIdTarea.Text));
            Console.WriteLine(this.txtTituloTarea.Text.Trim().ToUpper());
            Console.WriteLine(this.txtDescripcionTarea.Text.Trim());
            Console.WriteLine(Convert.ToDateTime(this.dtFechaTarea.Value));
            Console.WriteLine(this.txtObservacionesTarea.Text.Trim());

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
                        // rpta = NTarea.editarTarea(Convert.ToInt32(this.txtIdTarea.Text), this.txtTituloTarea.Text.Trim().ToUpper(), this.txtDescripcionTarea.Text.Trim(), this.txtObservacionesTarea.Text.Trim(), this.comboboxEstado.SelectedValue, Convert.ToDateTime(this.dtFechaTarea.Value));
                        //rpta = NProyecto.editarproyecto(
                        //    Convert.ToInt32(this.txtIdProyecto.Text),
                        //    this.txtTituloProyecto.Text.Trim().ToUpper(),
                        //    this.txtObservacionesProyecto.Text.Trim(),
                        //    this.dtFechaProyecto.Value);

                    }

                    if (rpta.Equals("OK"))
                    {
                        if (esnuevo)
                        {
                            this.mensajeok("Se ha creado el proyecto satisfactoriamente");

                        }
                        else
                        {
                            this.mensajeok("Se ha editado el proyecto satisfactoriamente");
                        }

                    }
                    else
                    {
                        this.mensajeerror(rpta);
                    }
                    botonesVisible(false);
                    botones();
                    this.limpiar();

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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            DInformacionTarea.sumaIndex();
            comboboxProyecto.Items.Clear();
            comboboxEstado.Items.Clear();
            llamaVisualizaDatos();

        }
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
        private void btnAtras_Click(object sender, EventArgs e)
        {
            DInformacionTarea.restaIndex();
            comboboxProyecto.Items.Clear();
            comboboxEstado.Items.Clear();
            llamaVisualizaDatos();

        }

        private void dtFechaTarea_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
