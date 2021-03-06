using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capadatos
{
    public class DTiempo
    {
        private int _id;
        private string _tarea;
        private DateTime _fecha_inicio;
        private DateTime _fecha_fin;
        private string _observaciones;
        private string _textobuscar;

        public int Id { get => _id; set => _id = value; }
        
        public string Tarea { get => _tarea; set => _tarea = value; }
        //Posiblemente tenga que cambiar el tipo de datos a string por que desde el combobox me llegará un string
        public DateTime Fecha_inicio { get => _fecha_inicio; set => _fecha_inicio = value; }
        public DateTime Fecha_fin { get => _fecha_fin; set => _fecha_fin = value; }
        public string Observaciones { get => _observaciones; set => _observaciones = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        public DTiempo()
        {

        }
        public DTiempo(int id, string tarea, DateTime fecha_inicio, DateTime fecha_fin, string observaciones, string textobuscar)
        {
            _id = id;
            _tarea = tarea;
            _fecha_inicio = fecha_inicio;
            _fecha_fin = fecha_fin;
            _observaciones = observaciones;
            _textobuscar = textobuscar;
        }
        public DataTable mostrartiempos(DTiempo objeto)
        {
            DataTable dtresultado = new DataTable("tiempos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_tiempos";
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

        public string insertartiempo(DTiempo tiempo)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_tiempo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Definición de atributos

                ////id
                //SqlParameter ParId = new SqlParameter();
                //ParId.ParameterName = "@id";
                //ParId.SqlDbType = SqlDbType.Int;
                //ParId.Direction = ParameterDirection.Output;
                //SqlCmd.Parameters.Add(ParId);

                //tarea
                SqlParameter ParTarea = new SqlParameter();
                ParTarea.ParameterName = "@tarea";
                ParTarea.SqlDbType = SqlDbType.NVarChar;
                ParTarea.Size = 1024;
                ParTarea.Value = tiempo.Tarea;
                SqlCmd.Parameters.Add(ParTarea);


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


                rpta = SqlCmd.ExecuteNonQuery() == 3 ? "OK" : "No es posible insertar el tiempo";
              

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
                ParId.Value = tiempo.Id;
                SqlCmd.Parameters.Add(ParId);


                //tarea
                SqlParameter ParTarea = new SqlParameter();
                ParTarea.ParameterName = "@tarea";
                ParTarea.SqlDbType = SqlDbType.NVarChar;
                ParTarea.Size = 1024;
                ParTarea.Value = tiempo.Tarea;
                SqlCmd.Parameters.Add(ParTarea);


                //fecha_inicio
                SqlParameter ParFechaInicio = new SqlParameter();
                ParFechaInicio.ParameterName = "@fecha_inicio";
                ParFechaInicio.SqlDbType = SqlDbType.SmallDateTime;
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
                ParObservaciones.Size = 255;
                ParObservaciones.Value = tiempo.Observaciones;
                SqlCmd.Parameters.Add(ParObservaciones);


                rpta = SqlCmd.ExecuteNonQuery() == 3 ? "OK" : "No es posible editar el Registro de tiempo";

                
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

        public string[] mostrarTareaCombobox(DTiempo objeto)
        {
            string[] array = new string[] { };

            DataTable dtresultado = new DataTable("tiempos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_combo_tareas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado
                sqladap.Fill(dtresultado);
                array = dtresultado.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            }
            catch (Exception)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return array;
        }
    }
}
