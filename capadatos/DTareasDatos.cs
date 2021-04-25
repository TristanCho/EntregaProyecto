using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capadatos
{
    public class DTareasDatos
    {
        private string id;
        
        private string proyecto;
        private string estado;

        private string titulo;
        private string descripcion;
        private string observaciones;
        private string fecha;

        public string Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Proyecto { get => proyecto; set => proyecto = value; }
        public string Estado { get => estado; set => estado = value; }

        public DTareasDatos(string id, string titulo, string descripcion, string observaciones, string fecha, string proyecto, string estado)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Observaciones = observaciones;
            this.Fecha = fecha;
            this.Proyecto = proyecto;
            this.Estado = estado;
        }

        public DTareasDatos()
        {
        }
    }
}
