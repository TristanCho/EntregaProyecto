using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace capadatos
{
    public class DWidget
    {
        
        private string _tarea;

        public string Tarea { get => _tarea; set => _tarea = value; }

        public DWidget()
        {

        }
        public DWidget(string tarea)
        {           
            _tarea = tarea;
        }

        public DataTable mostrartareasWidget(DWidget objeto)
        {
            DataTable dtresultado = new DataTable("widget");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_tareas_widget";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado
                sqladap.Fill(dtresultado);


            }
            catch (Exception)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

            return dtresultado;
        }

        public string sacaIdComboboxSeleccionado(String titulo)
        {
            string idTarea = "";
            DataTable dtresultado = new DataTable("tareas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_tarea_widget";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //consulta del usuario
                SqlParameter ParTitulo = new SqlParameter();
                ParTitulo.ParameterName = "@titulo";
                ParTitulo.SqlDbType = SqlDbType.VarChar;
                ParTitulo.Size = 20;
                ParTitulo.Value = titulo; //aqui va el titulo;
                SqlCmd.Parameters.Add(ParTitulo);

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);
                sqladap.Fill(dtresultado);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado

                idTarea = dtresultado.Rows.OfType<DataRow>().Select(k => k[0].ToString()).First();


            }
            catch (Exception)
            {
                dtresultado = null;
            }
            finally
            {

                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return idTarea;
        }

        //Método buscar proyecto por codigo
        public DataTable buscartiempo(DTiempo tiempo)
        {
            DataTable dtresultado = new DataTable("tiempo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_tiempos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Buscar tiempo por palabra
                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 10;
                ParTextobuscar.Value = tiempo.Textobuscar;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);
                sqladap.Fill(dtresultado);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado


            }
            catch (Exception)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

            return dtresultado;
        }

        public string insertartiempo(String titulo,DateTime fechaInicio, DateTime fechaFin)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_tiempo_gadget";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Definición de atributos
                //TODO pendiente por comprobar si es necesario pasar el id 
                //id
                /*
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.NText;
                ParId.Direction = ParameterDirection.Output;
                ParId.Value = id;
                SqlCmd.Parameters.Add(ParId);
                */

                //id_tarea
                SqlParameter ParIdTarea = new SqlParameter();
                ParIdTarea.ParameterName = "@tarea";
                ParIdTarea.SqlDbType = SqlDbType.NText;
                ParIdTarea.Size = 1024;
                ParIdTarea.Value = titulo;
                //Posiblemente tenga que cambiar el tipo de datos a string por que desde el combobox me llegará un string
                SqlCmd.Parameters.Add(ParIdTarea);

                /* La fecha de inicio la inserta la BD automaticamente
                //fecha_inicio
                */
                SqlParameter ParFechaInicio = new SqlParameter();
                ParFechaInicio.ParameterName = "@fecha_inicio";
                ParFechaInicio.SqlDbType = SqlDbType.SmallDateTime;
                //ParFecha.Size = 1024;
                ParFechaInicio.Value = fechaInicio;
                SqlCmd.Parameters.Add(ParFechaInicio);
                
                
                //fecha_fin
                SqlParameter ParFechaFin = new SqlParameter();
                ParFechaFin.ParameterName = "@fecha_fin";
                ParFechaFin.SqlDbType = SqlDbType.SmallDateTime;
                //ParFecha.Size = 1024;
                ParFechaFin.Value = fechaFin;
                SqlCmd.Parameters.Add(ParFechaFin);
                
                
                rpta = SqlCmd.ExecuteNonQuery() == 2 ? "OK" : "No es posible insertar el tiempo";

                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }
            return rpta;
        }

        //Método editar Tiempo
        public string editartiempo(DTiempo tiempo)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_tiempo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Definición de atributos

                //id
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;//TODO pendiente verificar si es necesario especificar el parámetro de salida
                SqlCmd.Parameters.Add(ParId);


                //id_tarea
                SqlParameter ParIdTarea = new SqlParameter();
                ParIdTarea.ParameterName = "@id_tarea";
                ParIdTarea.SqlDbType = SqlDbType.Int;
                ParIdTarea.Value = tiempo.Tarea;
                //TODO Posiblemente tenga que cambiar el tipo de datos a string por que desde el combobox me llegará un string
                SqlCmd.Parameters.Add(ParIdTarea);


                //fecha_inicio
                SqlParameter ParFechaInicio = new SqlParameter();
                ParFechaInicio.ParameterName = "@fecha_inicio";
                ParFechaInicio.SqlDbType = SqlDbType.SmallDateTime;
                //ParFecha.Size = 1024;
                ParFechaInicio.Value = tiempo.Fecha_inicio;
                SqlCmd.Parameters.Add(ParFechaInicio);


                //fecha_fin
                SqlParameter ParFechaFin = new SqlParameter();
                ParFechaFin.ParameterName = "@fecha_fin";
                ParFechaFin.SqlDbType = SqlDbType.SmallDateTime;
                //ParFecha.Size = 1024;
                ParFechaFin.Value = tiempo.Fecha_fin;
                SqlCmd.Parameters.Add(ParFechaFin);

                //observaciones
                SqlParameter ParObservaciones = new SqlParameter();
                ParObservaciones.ParameterName = "@observaciones";
                ParObservaciones.SqlDbType = SqlDbType.NText;
                //ParObservaciones.Size = 1024;
                ParObservaciones.Value = tiempo.Observaciones;
                SqlCmd.Parameters.Add(ParObservaciones);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No es posible insertar el Registro de tiempo";

                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }
            return rpta;
        }

        //Método eliminar Tiempo
        public string eliminartiempo(DTiempo tiempo)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_tiempo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Definición de atributos

                //id
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = tiempo.Id;
                SqlCmd.Parameters.Add(ParId);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No es posible eliminar el Registro de tiempo";

                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }
            return rpta;
        }
    }
}
