using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capadatos;
using System.Data;

namespace capanegocio
{
    public class NTiempo
    {

        public static DataTable mostrartiempos()
        {
            DTiempo objeto = new DTiempo();
            return objeto.mostrartiempos(objeto);
        }

        public static DataTable buscartiempo(String textobuscar)
        {
            DTiempo objeto = new DTiempo();
            objeto.Textobuscar = textobuscar;
            return objeto.buscartiempo(objeto);
        }

        //TODO cambiar el id_Tarea para que reciba un string desde la entrada de datos
        public static string insertartiempo(string tarea, DateTime fecha_inicio, DateTime fecha_fin,string observaciones)
        {
            DTiempo objeto = new DTiempo();
            objeto.Tarea = tarea;
            objeto.Fecha_inicio = fecha_inicio;
            objeto.Fecha_fin = fecha_fin;
            objeto.Observaciones = observaciones;

            return objeto.insertartiempo(objeto);
        }

        public static string editartiempo(int id, string tarea, DateTime fecha_inicio, DateTime fecha_fin, string observaciones)
        {
            DTiempo objeto = new DTiempo();
            objeto.Id = id;
            objeto.Tarea = tarea;
            objeto.Fecha_inicio = fecha_inicio;
            objeto.Fecha_fin = fecha_fin;
            objeto.Observaciones = observaciones;

            return objeto.editartiempo(objeto);
        }

        public static string eliminartiempo(int id)
        {
            DTiempo objeto = new DTiempo();
            objeto.Id = id;

            return objeto.eliminartiempo(objeto);
        }

        public static string[] mostrarTareaCombobox()
        {
            DTiempo objeto = new DTiempo();

            return objeto.mostrarTareaCombobox(objeto);
        }

        //public static string buscarid(string tarea, DateTime fecha_inicio, DateTime fecha_fin, string observaciones)
        //{
        //    DTiempoid objeto = new DTiempoid();
        //    //objeto.Id = id;

        //    //return objeto.getid(objeto);

           
        //    objeto.Tarea = tarea;
        //    objeto.Fecha_inicio = fecha_inicio;
        //    objeto.Fecha_fin = fecha_fin;
        //    objeto.Observaciones = observaciones;

        //    return objeto.getid(objeto);

        //}

    }
}
