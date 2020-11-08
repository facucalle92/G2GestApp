using ClassLibrary1;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace winFormGest
{
    public partial class Form1 : Form
    {
        public Contrato objContrato = new Contrato();
        public NegContrato objNegContrato = new NegContrato();
        public NegServicio objNegServicio = new NegServicio();
        public Servicio objServicio = new Servicio();
        public Form1()
        {
            InitializeComponent();
            for(int i = 1; i <= 180; i++)
            {
                cmbPlazoDias.Items.Add(i);
            }
            limpiar();
            LlenarDGV();
        }

        private void limpiar()
        {
            txtCondicionPago.Text = "";
            txtContrato.Text = "";
            cmbMetodoPago.SelectedIndex = -1;
            txtPlata.Text = "";
            cmbServicios.SelectedIndex = -1;
            txtTipoTrabajo.Text = "";
            datePickerRealizacion.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private bool validation()
        {
            Boolean isValid = true;
            if(txtContrato.Text == "")
            {
                MessageBox.Show("Ingrese un N° de Contrato");
                return isValid =  false;
            }
            if(cmbServicios.SelectedItem == null )
            {
                MessageBox.Show("Ingrese un servicio adherido");
                return isValid = false;
            }
            if(txtPlata.Text == "")
            {
                MessageBox.Show("Ingrese el monto");
                return isValid = false;
            }
            if(txtTipoTrabajo.Text == "")
            {
                MessageBox.Show("Ingrese un tipo de trabajo");
                return isValid = false;
            }
            if(cmbMetodoPago.SelectedItem.ToString() == "Cheque" && (cmbPlazoDias.SelectedItem == null))
            {
                MessageBox.Show("Ingrese un plazo de fecha");
                return isValid = false;
            }
            if (cmbMetodoPago.SelectedItem.ToString() == "Cheque" && txtCondicionPago.Text == "")
            {
                MessageBox.Show("Ingrese una condición de pago");
                return isValid = false;
            }
            if (cmbMetodoPago.SelectedItem.ToString() == "Transferencia" && cmbPlazoDias.SelectedItem != null )
            {
                MessageBox.Show("Las transferencia no llevan plazo de dias");
                return isValid = false;
            }
            if (cmbMetodoPago.SelectedItem.ToString() == "Transferencia" && txtCondicionPago.Text != "")
            {
                MessageBox.Show("Las transferencia no llevan condición de pago");
                return isValid = false;
            }
            return isValid;
        }

        private void TxtBox_to_Obj()
        {
            objContrato.CondicionDePago = txtCondicionPago.Text;
            objContrato.FechaDeRealizacion = datePickerRealizacion.Value;
            objContrato.MetodoDePado = cmbMetodoPago.SelectedItem.ToString();
            objContrato.Monto = Convert.ToInt32(txtPlata.Text);
            objContrato.NroContrato = Convert.ToInt32(txtContrato.Text);
            objContrato.TipoDeTrabajo = txtTipoTrabajo.Text;
            objContrato.IdServicio = ((KeyValuePair<int, string>)cmbServicios.SelectedItem).Key;
            objContrato.PlazoPago = Convert.ToInt32(cmbPlazoDias.SelectedItem);
        }

        private void LlenarDGV()
        {
            dataGridView1.Rows.Clear();
            DataSet datosContrato = new DataSet();
            DataSet datosServicio = new DataSet();
            datosContrato = objNegContrato.listadoDeContratos("Todos");
            datosServicio = objNegServicio.listadoServicios("Todos");
            if(datosContrato.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in datosContrato.Tables[0].Rows)
                {
                    string serviceName = string.Empty;
                    foreach(DataRow it in datosServicio.Tables[0].Rows)
                    {
                        if(it[0].ToString() == dr[8].ToString())
                        {
                            serviceName = it[1].ToString();
                        }
                    }
                    dataGridView1.Rows.Add(dr[0], serviceName, dr[1], "$"+dr[2], dr[3], dr[7], dr[4], dr[5], Convert.ToDateTime(dr[6]).ToShortDateString());
                }
            }
            if(datosServicio.Tables[0].Rows.Count > 0)
            {
                Dictionary<int, string> test = new Dictionary<int, string>();

                foreach (DataRow item in datosServicio.Tables[0].Rows)
                {
                    test.Add(Convert.ToInt32(item[0]),item[1].ToString());
                }
                cmbServicios.DataSource = new BindingSource(test, null);
                cmbServicios.DisplayMember = "Value";
                cmbServicios.ValueMember = "Key";
            }
            cmbServicios.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                int result = -1;
                TxtBox_to_Obj();
                if(cmbMetodoPago.SelectedItem.ToString() != "Cheque")
                {
                    result = objNegContrato.abmContrato("Alta sin cheque", objContrato);
                }
                else
                {
                    result = objNegContrato.abmContrato("Alta con cheque", objContrato);
                }
                if(result == -1)
                {
                    MessageBox.Show("No se puedieron guardar los datos de forma correcta");
                }
                else
                {
                    MessageBox.Show("Contrato guardado con éxito!");
                    LlenarDGV();
                    limpiar();
                }
            }
        }
    }
}
