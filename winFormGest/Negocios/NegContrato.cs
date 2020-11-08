using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Datos;

namespace Negocios
{
    public class NegContrato
    {
        DatosContrato objDatosContrato = new DatosContrato();
        
        public int abmContrato(string accion, Contrato objContrato)
        {
            return objDatosContrato.abmContrato(accion, objContrato);
        }

        public DataSet listadoDeContratos(string tipo)
        {
            return objDatosContrato.listadoContratos(tipo);
        }
    }
}
