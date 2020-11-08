using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Contrato
    {
        private int id;
        private int nroContrato;
        private DateTime fechaDeRealizacion;
        private int monto;
        private string metodoDePago;
        private string condicionDePago;
        private string tipoDeTrabajo;
        private int idServicio;
        private int plazoPago;

        public Contrato()
        {

        }
        public Contrato(int id, int nroContrato, DateTime fechaDeRealizacion, int monto, string metodoDePago,string condicionDePago, string tipoDeTrabajo, int idServicio, int plazoPago)
        {
            this.id = id;
            this.nroContrato = nroContrato;
            this.fechaDeRealizacion = fechaDeRealizacion;
            this.monto = monto;
            this.metodoDePago = metodoDePago;
            this.condicionDePago = condicionDePago;
            this.tipoDeTrabajo = tipoDeTrabajo;
            this.idServicio = idServicio;
            this.plazoPago = plazoPago;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int NroContrato
        {
            get { return nroContrato; }
            set { nroContrato = value; }
        }
        public DateTime FechaDeRealizacion
        {
            get { return fechaDeRealizacion; }
            set { fechaDeRealizacion = value; }
        }
        public int Monto
        {
            get { return monto; }
            set { monto = value; }
        }
        public string MetodoDePado
        {
            get { return metodoDePago; }
            set { metodoDePago = value; }
        }
        public string CondicionDePago
        {
            get { return condicionDePago; }
            set { condicionDePago = value; }
        }
        public string TipoDeTrabajo
        {
            get { return tipoDeTrabajo; }
            set { tipoDeTrabajo = value; }
        }
        public int IdServicio
        {
            get { return idServicio; }
            set { idServicio = value; }
        }
        public int PlazoPago
        {
            get { return plazoPago; }
            set { plazoPago = value; }
        }

    }
}
