using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Windows;
using System.Windows.Forms;

namespace Datos
{
    public class DatosContrato : DatosConexionBD
    {
        public int abmContrato(string accion, Contrato objContrato)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta sin cheque")
            {
                orden = "insert into Contrato (nroContrato,monto,metodoDePago,tipoDeTrabajo,fechaDeRealizacion,idServicio) values ( "
                    + objContrato.NroContrato + ", "
                    + objContrato.Monto + ", '"
                    + objContrato.MetodoDePado + "' , '"
                    + objContrato.TipoDeTrabajo + "' ,'"
                    + objContrato.FechaDeRealizacion.ToShortDateString() + " ',"
                    + objContrato.IdServicio + ");";

            }
            if(accion == "Alta con cheque")
            {
                orden = "insert into Contrato(nroContrato,monto,metodoDePago,condicionDePago,tipoDeTrabajo,fechaDeRealizacion,plazoDePago,idServicio) values ( "
                    + objContrato.NroContrato + " , "
                    + objContrato.Monto + " , '"
                    + objContrato.MetodoDePado + "' , '"
                    + objContrato.CondicionDePago + "' , '"
                    + objContrato.TipoDeTrabajo + "' , '"
                    + objContrato.FechaDeRealizacion.ToShortDateString() + "' , "
                    + objContrato.PlazoPago + " , "
                    + objContrato.IdServicio + " ) ;";
            }
            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de guardar los datos", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoContratos(string tipo)
        {
            string orden = string.Empty;
            if (tipo == "Todos")
            {
                orden = "select * from Contrato;";
            }
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
            }
            catch (Exception e)
            {

                throw new Exception("Error al listar los contratos");
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
