using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosConexionBD
    {
        public SqlConnection conexion;
        public string cadenaConexion = "Data Source=DESKTOP-JA38TVA;Initial Catalog=gest;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public DatosConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        public void AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                conexion.Open();

            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de abrir la conexion",e);
            }
        }
        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexion",e);
            }
        }
    }
}
