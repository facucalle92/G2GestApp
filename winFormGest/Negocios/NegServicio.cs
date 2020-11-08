using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocios
{
    public class NegServicio
    {
        DatosServicio objDatosServicio = new DatosServicio();

        public DataSet listadoServicios(string tipo)
        {
            return objDatosServicio.listadoServicios(tipo);
        }
    }
}
