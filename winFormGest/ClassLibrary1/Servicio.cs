using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Servicio
    {
        private int id;
        private string nombreServicio;
        private int precio;
        private string tipoDeServicio;

        public Servicio()
        {

        }
        public Servicio(int id, string nombreServicio, int precio, string tipoDeServicio)
        {
            this.id = id;
            this.nombreServicio = nombreServicio;
            this.precio = precio;
            this.tipoDeServicio = tipoDeServicio;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string NombreServicio
        {
            get { return nombreServicio; }
            set { nombreServicio = value; }
        }
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public string TipoDeServicio
        {
            get { return tipoDeServicio; }
            set { tipoDeServicio = value; }
        }
    }
}
