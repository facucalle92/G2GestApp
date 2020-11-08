namespace winFormGest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDatosContrato = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContrato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlata = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCondicionPago = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTipoTrabajo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.datePickerRealizacion = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbServicios = new System.Windows.Forms.ComboBox();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.lblPlazoPago = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.cmbPlazoDias = new System.Windows.Forms.ComboBox();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNroContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCondicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatosContrato
            // 
            this.lblDatosContrato.AutoSize = true;
            this.lblDatosContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosContrato.Location = new System.Drawing.Point(82, 23);
            this.lblDatosContrato.Name = "lblDatosContrato";
            this.lblDatosContrato.Size = new System.Drawing.Size(281, 25);
            this.lblDatosContrato.TabIndex = 0;
            this.lblDatosContrato.Text = "Cargar Datos de Contrato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Servicio Contratado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "N° Contrato";
            // 
            // txtContrato
            // 
            this.txtContrato.Location = new System.Drawing.Point(161, 124);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(212, 20);
            this.txtContrato.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de Realización";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Plata Asignada";
            // 
            // txtPlata
            // 
            this.txtPlata.Location = new System.Drawing.Point(161, 211);
            this.txtPlata.Name = "txtPlata";
            this.txtPlata.Size = new System.Drawing.Size(212, 20);
            this.txtPlata.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Metodo de Pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Condición de Pago";
            // 
            // txtCondicionPago
            // 
            this.txtCondicionPago.Location = new System.Drawing.Point(161, 337);
            this.txtCondicionPago.Name = "txtCondicionPago";
            this.txtCondicionPago.Size = new System.Drawing.Size(212, 20);
            this.txtCondicionPago.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tipo de Trabajo";
            // 
            // txtTipoTrabajo
            // 
            this.txtTipoTrabajo.Location = new System.Drawing.Point(161, 383);
            this.txtTipoTrabajo.Name = "txtTipoTrabajo";
            this.txtTipoTrabajo.Size = new System.Drawing.Size(212, 20);
            this.txtTipoTrabajo.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(161, 436);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 32);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // datePickerRealizacion
            // 
            this.datePickerRealizacion.Location = new System.Drawing.Point(161, 173);
            this.datePickerRealizacion.Name = "datePickerRealizacion";
            this.datePickerRealizacion.Size = new System.Drawing.Size(212, 20);
            this.datePickerRealizacion.TabIndex = 16;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(270, 436);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 32);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colServicio,
            this.colNroContrato,
            this.colPlata,
            this.colMetodo,
            this.colPlazo,
            this.colCondicion,
            this.colTipo,
            this.colFecha});
            this.dataGridView1.Location = new System.Drawing.Point(398, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(823, 387);
            this.dataGridView1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(701, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Lista de Contratos";
            // 
            // cmbServicios
            // 
            this.cmbServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicios.FormattingEnabled = true;
            this.cmbServicios.Location = new System.Drawing.Point(161, 84);
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(212, 21);
            this.cmbServicios.TabIndex = 20;
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Items.AddRange(new object[] {
            "Cheque",
            "Transferencia"});
            this.cmbMetodoPago.Location = new System.Drawing.Point(161, 254);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(212, 21);
            this.cmbMetodoPago.TabIndex = 21;
            // 
            // lblPlazoPago
            // 
            this.lblPlazoPago.AutoSize = true;
            this.lblPlazoPago.Location = new System.Drawing.Point(36, 306);
            this.lblPlazoPago.Name = "lblPlazoPago";
            this.lblPlazoPago.Size = new System.Drawing.Size(75, 13);
            this.lblPlazoPago.TabIndex = 23;
            this.lblPlazoPago.Text = "Plazo de pago";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(208, 300);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(28, 13);
            this.lblDias.TabIndex = 24;
            this.lblDias.Text = "Dias";
            // 
            // cmbPlazoDias
            // 
            this.cmbPlazoDias.FormattingEnabled = true;
            this.cmbPlazoDias.Location = new System.Drawing.Point(161, 297);
            this.cmbPlazoDias.Name = "cmbPlazoDias";
            this.cmbPlazoDias.Size = new System.Drawing.Size(41, 21);
            this.cmbPlazoDias.TabIndex = 25;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 40;
            // 
            // colServicio
            // 
            this.colServicio.HeaderText = "Servicio";
            this.colServicio.Name = "colServicio";
            this.colServicio.Width = 120;
            // 
            // colNroContrato
            // 
            this.colNroContrato.HeaderText = "N° Contrato";
            this.colNroContrato.Name = "colNroContrato";
            // 
            // colPlata
            // 
            this.colPlata.HeaderText = "Plata Asignada";
            this.colPlata.Name = "colPlata";
            this.colPlata.Width = 70;
            // 
            // colMetodo
            // 
            this.colMetodo.HeaderText = "Metodo de pago";
            this.colMetodo.Name = "colMetodo";
            // 
            // colPlazo
            // 
            this.colPlazo.HeaderText = "Plazo de pago";
            this.colPlazo.Name = "colPlazo";
            this.colPlazo.Width = 50;
            // 
            // colCondicion
            // 
            this.colCondicion.HeaderText = "Condición de pago";
            this.colCondicion.Name = "colCondicion";
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo de Trabajo";
            this.colTipo.Name = "colTipo";
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha de Realización";
            this.colFecha.Name = "colFecha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 666);
            this.Controls.Add(this.cmbPlazoDias);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblPlazoPago);
            this.Controls.Add(this.cmbMetodoPago);
            this.Controls.Add(this.cmbServicios);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.datePickerRealizacion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTipoTrabajo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCondicionPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContrato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDatosContrato);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCondicionPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipoTrabajo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker datePickerRealizacion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbServicios;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.Label lblPlazoPago;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.ComboBox cmbPlazoDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlata;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCondicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
    }
}

