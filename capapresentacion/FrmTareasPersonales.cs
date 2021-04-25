using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capapresentacion
{
    public partial class FrmTareasPersonales : Form
    {
        public FrmPrincipal frmparent;
        public FrmTareasPersonales()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmparent.lanzarNuevoElemento(new FrmDetallesTareasPersonales());
        }

        private void cboBuscarTareasPersonales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
