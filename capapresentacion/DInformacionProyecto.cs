using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capapresentacion;

namespace capadatos
{
    public static class DInformacionProyecto
    {
        public static DataGridView dataListProyectos;
        public static int index;
        public static FrmDetalleProyecto detalleProyecto;

        public static void sumaIndex()
        {
            if (!(dataListProyectos.Rows.Count <= DInformacionProyecto.index + 1))
            {
                index += 1;
            }
            else
            {
                MessageBox.Show("Ultimo registro alcanzado", "Detalle de Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void restaIndex()
        {
            if (!(0 > DInformacionProyecto.index - 1))
            {
                index -= 1;
            }
            else{
                MessageBox.Show("Primer registro alcanzado", "Detalle de Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }      
        }
    }
}
