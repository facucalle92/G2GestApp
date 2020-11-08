using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosServicio : DatosConexionBD
    {
        public DataSet listadoServicios(string tipo)
        {
            string orden = string.Empty;
            if (tipo == "Todos")
            {
                orden = "select id, nombreServicio from Servicio;";
            }
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
            }
            catch (Exception e)
            {

                throw new Exception("Error al listar los Servicios");
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
