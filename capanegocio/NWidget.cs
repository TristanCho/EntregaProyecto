using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capadatos;

namespace capanegocio
{
    public class NWidget
    {
        public String sacaIdComboboxSeleccionado(string titulo)
        {
            DWidget dw = new DWidget();
            return dw.sacaIdComboboxSeleccionado(titulo);
        }

        public void insertaTiempoTarea(string titulo,DateTime fechaInicio)
        {
            DWidget dw = new DWidget();
            dw.insertartiempo(titulo,fechaInicio);

        }
    }
}
