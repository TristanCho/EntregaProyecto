using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using capadatos;
using capanegocio;
using WPTT_1._0;

namespace capapresentacion
{
    public partial class FrmTiempos : Form
    {
        public FrmPrincipal frmparent;
        public FrmTiempos()
        {
            InitializeComponent();
            btnEliminarTiempo.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            mostrartiempos();
            quitarBordes();
        }

        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cerrarX(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void FrmTiempos_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarX);
        }

        private void FrmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void mostrartiempos()
        {
            this.dataListTiempos.DataSource = NTiempo.mostrartiempos();
            this.ocultarcolumnas();
            this.btnEliminarTiempo.Visible = true;
            this.lblTotal.Text = "Número de registros: " + Convert.ToString(dataListTiempos.Rows.Count);
        }

        private void ocultarcolumnas()
        {
            this.dataListTiempos.Columns[0].Visible = false;
            this.dataListTiempos.Columns[1].Visible = false;
            this.btnEliminarTiempo.Enabled = false;
            this.cbEliminar.Checked = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmDetalleTiempos frmTiempos = new FrmDetalleTiempos();
            frmTiempos.desbloqueaBotones();
            FrmParent.frmparent.lanzarNuevoElemento(frmTiempos);
        }

        private void quitarBordes()
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            TopMost = true;
            ShowInTaskbar = false;
            this.Text = String.Empty;
            this.ControlBox = false;

            //quita bordes del datagrid
            this.dataListTiempos.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            this.dataListTiempos.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            this.dataListTiempos.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            this.dataListTiempos.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
        }
        /*Utilizado para mover el panel atraves de la pantalla*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /*fin del drag*/

        private void cbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbEliminar.Checked)
            {
                this.dataListTiempos.Columns[0].Visible = true;
                this.btnEliminarTiempo.Enabled = true;
            }
            else
            {
                this.dataListTiempos.Columns[0].Visible = false;
                this.btnEliminarTiempo.Enabled = false;
            }
        }

        private void dataListTiempos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListTiempos.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)dataListTiempos.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
        }       

        private void dataListTiempos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FrmDetalleTiempos detalleTiempos = new FrmDetalleTiempos();

                FrmParent.frmparent.lanzarNuevoElemento(detalleTiempos);
                detalleTiempos.setModo("LECTURA");

                detalleTiempos.visualizaDatos(
                Convert.ToString(this.dataListTiempos.CurrentRow.Cells["id"].Value),
                Convert.ToString(this.dataListTiempos.CurrentRow.Cells["tarea"].Value),
                Convert.ToString(this.dataListTiempos.CurrentRow.Cells["fecha_inicio"].Value),
                Convert.ToString(this.dataListTiempos.CurrentRow.Cells["fecha_fin"].Value),
                Convert.ToString(this.dataListTiempos.CurrentRow.Cells["observaciones"].Value)
                );

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el evento Double click ", "Error en el evento Double click ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEliminarTiempo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Desea continuar?", "Eliminar Registro de tiempo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int aux = 0;
                    int id;
                    string rpta = "";
                    foreach (DataGridViewRow row in dataListTiempos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            aux = 1;

                            id = Convert.ToInt32(row.Cells[1].Value);
                            rpta = NTiempo.eliminartiempo(id);

                            if (rpta.Equals("OK"))
                            {
                                this.mensajeok("Registro eliminado");
                            }
                            else
                            {
                                this.mensajeerror("¡Ups!, Algo ha salido mal...");
                                this.mensajeerror(rpta);
                            }
                        }
                    }
                    if (aux < 1)
                    {
                        MessageBox.Show("No haz seleccionado ningún proyecto", "Eliminar Proyecto", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    this.mostrartiempos();
                }
                else
                {
                    this.btnEliminarTiempo.Enabled = false;
                    this.cbEliminar.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
                
        private void buscarTiempo(string texto)
        {
            this.dataListTiempos.DataSource = NTiempo.buscartiempo(texto);
            this.ocultarcolumnas();
        }
        private void txtBuscarTiempo_TextChanged(object sender, EventArgs e)
        {
            this.buscarTiempo(this.txtBuscarTiempo.Text);
        }

        
    }
}
