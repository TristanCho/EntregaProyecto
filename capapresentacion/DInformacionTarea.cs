using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capapresentacion
{
    class DInformacionTarea
    {
        public static DataGridView dataListTareas;
        public static int index;
        public static FrmDetalleTarea detalleTarea;

        internal static void restaIndex()
        {
            if (!(0 > DInformacionTarea.index - 1))
            {
                index -= 1;
            }
            else
            {
                MessageBox.Show("Primer registro alcanzado", "Detalle de Tarea", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal static void sumaIndex()
        {
            if (!(dataListTareas.Rows.Count <= DInformacionTarea.index + 1))
            {
                index += 1;
            }
            else
            {
                MessageBox.Show("Ultimo registro alcanzado", "Detalle de Tarea", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
