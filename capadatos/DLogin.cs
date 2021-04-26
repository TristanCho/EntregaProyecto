using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capadatos
{
   public static class DLogin
    {
        public static string usuario;
        public static string conexionBD;
        public static string tecnico;
        public static string id;

        public static void sacaTecnico(String user)
        {

            DataTable dtresultado = new DataTable("tecnicos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_tecnico";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //consulta del usuario
                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@usuario";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 10;
                ParTextobuscar.Value = user;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);
                sqladap.Fill(dtresultado);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado


                tecnico = dtresultado.Rows.OfType<DataRow>().Select(k => k[0].ToString()).First();
                id = dtresultado.Rows.OfType<DataRow>().Select(k => k[1].ToString()).First();


            }
            catch (Exception)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }
        }
    }
}
