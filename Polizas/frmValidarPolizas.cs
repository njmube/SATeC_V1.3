using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using SATeC.Modelos;
using System.Diagnostics;

namespace SATeC.Polizas {
	public partial class frmValidarPolizas : Form {

		public TipoFuncionalidadPolizas FuncionalidadPolizas { get; set; }

		public string IDPoliza { get; set; }
		public string Ejercicio { get; set; }
		public string Periodo { get; set; }
        public string TipoPolizaXML { get; set; }
        private DataTable dtPolizas = new DataTable();
        private DataTable dtTransacciones = new DataTable();
		private Dictionary<string, List<string>> Polizas_List = new Dictionary<string, List<string>>();
		private List<KeyValuePair<string, List<string>>> Transacciones = new List<KeyValuePair<string, List<string>>>();
        private System.Globalization.CultureInfo cultureinfo = new System.Globalization.CultureInfo("es-MX");

        List<PolizasDTO> listPolizas = new List<PolizasDTO>();
        List<TransaccionesDTO> listTransacciones = new List<TransaccionesDTO>();
        List<ComprobantesNacionalesDTO> listComprobantesNacionales = new List<ComprobantesNacionalesDTO>();
        List<ComprobantesNacionalesOtrosDTO> listComprobantesNacionalesOtros = new List<ComprobantesNacionalesOtrosDTO>();
        List<ComprobantesExtranjerosDTO> listComprobantesExtranjeros = new List<ComprobantesExtranjerosDTO>();
        List<ChequesDTO> listCheques = new List<ChequesDTO>();
        List<TransferenciasDTO> listTransferencias = new List<TransferenciasDTO>();
        List<OtroMetodosPagoDTO> listOtrosMetodosPago = new List<OtroMetodosPagoDTO>();

        Polizas polizaGlobal = new Polizas();

		public frmValidarPolizas() {
			InitializeComponent();
		}

        private void frmValidarPolizas_Load(object sender, EventArgs e)
        {
            lblEjercicioPeriodoSeleccionado.Text = this.Ejercicio + " - " + this.Periodo;

            if (this.FuncionalidadPolizas == TipoFuncionalidadPolizas.ImportarDatosComplementarios)
            {
                this.Text = "Importar Datos Complementarios de Pólizas";
                cmdValidar.Visible = false;
            }
            else if (this.FuncionalidadPolizas == TipoFuncionalidadPolizas.ValidarPolizas)
            {
                cmdCheques.Visible = false;
                cmdTransferencias.Visible = false;
                cmdComprobantes.Visible = false;
                cmdComprobantesNacionalOtros.Visible = false;
                cmdComprobantesExtranjeros.Visible = false;
                cmdOtrosMetodosPago.Visible = false;
                cmdValidar.Visible = true;
            }

            obtenerPolizas();

            TipoPolizaXML = String.Empty;
        }

		//VHJC Funcion que obtiene las Polizas seleccionada de la Sociedad
		private void obtenerPolizas() {
			Cursor.Current = Cursors.WaitCursor;
			General.cambiaMensajeStatus(this.Owner, "Obteniendo datos de las Pólizas desde la base de datos, espere por favor...");

			dgvPolizas.Rows.Clear();
			dgvTransacciones.Rows.Clear();

            dtPolizas = Database.ExecuteDataTable("select a.Numero_Poliza NumeroPoliza, CONVERT(VARCHAR(10), a.Fecha_Poliza, 103) FechaPoliza from ( SELECT DISTINCT Numero_Poliza, Fecha_Poliza FROM SATeC_Polizas_Polizas where ID_Poliza = " + IDPoliza + " ) a order by a.Numero_Poliza ");
            dtTransacciones = Database.ExecuteDataTable("select ID_Poliza, Numero_Poliza, Secuencia, Cuenta, Concepto, Debe, Haber from SATeC_Polizas_Transacciones where ID_Poliza = " + IDPoliza + " ORDER BY Numero_Poliza, Secuencia ");

            dgvPolizas.AutoGenerateColumns = false;
            dgvPolizas.DataSource = dtPolizas;

			//VHJC Despues se obtienen las Transacciones
            OleDbDataReader drTransacciones = Database.obtenRegistros("SELECT Numero_Poliza, Secuencia, Cuenta, DesCta, Concepto, Debe, Haber FROM SATeC_Polizas_Transacciones WHERE ID_Poliza = " + IDPoliza + " ORDER BY Numero_Poliza, Secuencia ");

			//VHJC Por cada uno de los registros de la base de datos...
			while(drTransacciones.Read()) {
				//VHJC Las Transacciones tienen 9 datos
				string NumeroPolizaTransaccion = drTransacciones["Numero_Poliza"].ToString();
				string CuentaTransaccion = drTransacciones["Cuenta"].ToString();
                string DescCuentaTransaccion = drTransacciones["DesCta"].ToString();
				string ConceptoTransaccion = drTransacciones["Concepto"].ToString();
				double DebeTransaccion = double.Parse(drTransacciones["Debe"].ToString() == string.Empty ? "0" : drTransacciones["Debe"].ToString());
				double HaberTransaccion = double.Parse(drTransacciones["Haber"].ToString() == string.Empty ? "0" : drTransacciones["Haber"].ToString());

				string LlaveTransaccion = NumeroPolizaTransaccion;

				List<string> DatosTransaccion = new List<string>();
				DatosTransaccion.Add(CuentaTransaccion);
                DatosTransaccion.Add(DescCuentaTransaccion);
				DatosTransaccion.Add(ConceptoTransaccion);
				DatosTransaccion.Add(DebeTransaccion.ToString());
				DatosTransaccion.Add(HaberTransaccion.ToString());

				Transacciones.Add(new KeyValuePair<string,List<string>>(LlaveTransaccion, DatosTransaccion));
			}

			drTransacciones.Close();
			drTransacciones.Dispose();

			dgvPolizas_CellClick(dgvPolizas, new DataGridViewCellEventArgs(0, 0));

            General.cambiaMensajeStatus(this.Owner, "");
			Cursor.Current = Cursors.WaitCursor;
		}
		private void cmdCheques_Click(object sender, EventArgs e) {          

             Dictionary<string, List<string>> Cheques = new Dictionary<string, List<string>>();

            OleDbDataReader drCheques = Database.obtenRegistros("SELECT Numero_Poliza, Numero_Cuenta, Num, BanEmisNal, BanEmisExt, CtaOri, Fecha, Benef, RFC, Monto, Moneda, TipCamb, Clave FROM SATeC_Polizas_Cheques WHERE ID_Poliza = " + IDPoliza + " ORDER BY Numero_Poliza ");

            while (drCheques.Read())
            {
                string NumeroPolizaCheque = drCheques["Numero_Poliza"].ToString();
                string NumeroCuenta = drCheques["Numero_Cuenta"].ToString();
                string NumeroCheque = drCheques["Num"].ToString();
                string BancoNacionalEmisor = drCheques["BanEmisNal"].ToString();
                string BancoExtranjeroEmisor = drCheques["BanEmisExt"].ToString();
                string CuentaBancariaOrigen = drCheques["CtaOri"].ToString();
                string FechaCheque = drCheques["Fecha"].ToString();
                string BeneficiarioCheque = drCheques["Benef"].ToString();
                string RFCCheque = drCheques["RFC"].ToString();
                string MontoCheque = drCheques["Monto"].ToString();
                string MonedaCheque = drCheques["Moneda"].ToString();
                string TipoCambioCheque = drCheques["TipCamb"].ToString();
                string Clave = drCheques["Clave"].ToString();

                string LlaveCheque = NumeroPolizaCheque + "-" + NumeroCuenta;

                List<string> DatosCheque = new List<string>();

                DatosCheque.Add(NumeroCheque);
                DatosCheque.Add(BancoNacionalEmisor);
                DatosCheque.Add(BancoExtranjeroEmisor);
                DatosCheque.Add(CuentaBancariaOrigen);
                DatosCheque.Add(FechaCheque);
                DatosCheque.Add(BeneficiarioCheque);
                DatosCheque.Add(RFCCheque);
                DatosCheque.Add(MontoCheque);
                DatosCheque.Add(MonedaCheque);
                DatosCheque.Add(TipoCambioCheque);
                DatosCheque.Add(Clave);

                if (!Cheques.ContainsKey(LlaveCheque))
                    Cheques.Add(LlaveCheque, DatosCheque);
            }

            drCheques.Close();
            drCheques.Dispose();

            frmImportarCheques ImportarCheques = new frmImportarCheques() { IDPoliza = this.IDPoliza, EjercicioPeriodo = lblEjercicioPeriodoSeleccionado.Text, Transacciones = this.Transacciones, Cheques = Cheques, dtPolizas = dtPolizas, dtTransacciones = dtTransacciones };

			ImportarCheques.ShowDialog(this);

			if(ImportarCheques.Guardado) {
				Cheques = ImportarCheques.Cheques;
			}
		}
		private void cmdTransferencias_Click(object sender, EventArgs e) {
			frmImportarTransferencias ImportarTransferencias = new frmImportarTransferencias();
            Dictionary<string, List<string>> Transferencias = new Dictionary<string, List<string>>();

			ImportarTransferencias.IDPoliza = this.IDPoliza;
			ImportarTransferencias.EjercicioPeriodo = lblEjercicioPeriodoSeleccionado.Text;
			ImportarTransferencias.Transacciones = this.Transacciones;

            OleDbDataReader drTransferencias = Database.obtenRegistros("SELECT Numero_Poliza, Cuenta_Poliza Numero_Cuenta, CtaOri, BancoOriNal, BancoOriExt, CtaDest, BancoDestNal, BancoDestExt, CONVERT(VARCHAR(10), Fecha, 103) Fecha, Benef, RFC, Monto, Moneda, TipCamb, Clave FROM SATeC_Polizas_Transferencias WHERE ID_Poliza = " + IDPoliza + " ORDER BY Numero_Poliza ");

            while (drTransferencias.Read())
            {
                string NumeroPolizaTransferencia = drTransferencias["Numero_Poliza"].ToString();
                string CuentaPolizaTransferencia = drTransferencias["Numero_Cuenta"].ToString();

                string CuentaOrigenTransferencia = drTransferencias["CtaOri"].ToString();
                string BancoOrigenNacionalTransferencia = drTransferencias["BancoOriNal"].ToString();
                string BancoOrigenExtranjeroTransferencia = drTransferencias["BancoOriExt"].ToString();
                string CuentaDestinoTransferencia = drTransferencias["CtaDest"].ToString();
                string BancoDestinoNacionalTransferencia = drTransferencias["BancoDestNal"].ToString();
                string BancoDestinoExtranjeroTransferencia = drTransferencias["BancoDestExt"].ToString();
                string FechaTransferencia = drTransferencias["Fecha"].ToString();
                string BeneficiarioTransferencia = drTransferencias["Benef"].ToString();
                string RFCTransferencia = drTransferencias["RFC"].ToString();
                string MontoTransferencia = drTransferencias["Monto"].ToString();
                string MonedaTransferencia = drTransferencias["Moneda"].ToString();
                string TipoCambioTransferencia = drTransferencias["TipCamb"].ToString();
                string Clave = drTransferencias["Clave"].ToString();

                string LlaveTransferencia = NumeroPolizaTransferencia + "-" + CuentaPolizaTransferencia;

                List<string> DatosTransferencia = new List<string>();
                DatosTransferencia.Add(CuentaOrigenTransferencia);
                DatosTransferencia.Add(BancoOrigenNacionalTransferencia);
                DatosTransferencia.Add(BancoOrigenExtranjeroTransferencia);
                DatosTransferencia.Add(CuentaDestinoTransferencia);
                DatosTransferencia.Add(BancoDestinoNacionalTransferencia);
                DatosTransferencia.Add(BancoDestinoExtranjeroTransferencia);
                DatosTransferencia.Add(FechaTransferencia);
                DatosTransferencia.Add(BeneficiarioTransferencia);
                DatosTransferencia.Add(RFCTransferencia);
                DatosTransferencia.Add(MontoTransferencia);
                DatosTransferencia.Add(MonedaTransferencia);
                DatosTransferencia.Add(TipoCambioTransferencia);
                DatosTransferencia.Add(Clave);

                if (!Transferencias.ContainsKey(LlaveTransferencia))
                    Transferencias.Add(LlaveTransferencia, DatosTransferencia);
            }

            drTransferencias.Close();
            drTransferencias.Dispose();

			ImportarTransferencias.Transferencias = Transferencias;

            ImportarTransferencias.dtPolizas = dtPolizas;
            ImportarTransferencias.dtTransacciones = dtTransacciones;

			ImportarTransferencias.ShowDialog(this);

			if(ImportarTransferencias.Guardado) {
				Transferencias = ImportarTransferencias.Transferencias;
			}
		}
		private void cmdComprobantes_Click(object sender, EventArgs e) {
			frmImportarComprobantes ImportarComprobantes = new frmImportarComprobantes();
            Dictionary<string, List<string>> Comprobantes = new Dictionary<string, List<string>>();

			ImportarComprobantes.IDPoliza = this.IDPoliza;
			ImportarComprobantes.EjercicioPeriodo = lblEjercicioPeriodoSeleccionado.Text;
            ImportarComprobantes.Polizas = this.Polizas_List;

            OleDbDataReader drComprobantes = Database.obtenRegistros(string.Format("SELECT Numero_Poliza, Numero_Cuenta, UUID_CFDI, RFC, MontoTotal, Moneda, TipCamb, Clave  FROM SATeC_Polizas_Comprobantes_Nacional WHERE ID_Poliza = {0} ORDER BY Numero_Poliza ", IDPoliza));

            while (drComprobantes.Read())
            {
                string NumeroPolizaComprobante = drComprobantes["Numero_Poliza"].ToString();
                string NumeroCuentaComprobante = drComprobantes["Numero_Cuenta"].ToString();
                string UUID_CFDIComprobante = drComprobantes["UUID_CFDI"].ToString();
                string RFCComprobante = drComprobantes["RFC"].ToString();
                string MontoTotalComprobante = drComprobantes["MontoTotal"].ToString();
                string MonedaComprobante = drComprobantes["Moneda"].ToString();
                string TipCambioComprobante = drComprobantes["TipCamb"].ToString();
                string Clave = drComprobantes["Clave"].ToString();

                string LlaveComprobante = string.Format("{0}-{1}", NumeroPolizaComprobante, NumeroCuentaComprobante);

                List<string> DatosComprobante = new List<string>();
                DatosComprobante.Add(UUID_CFDIComprobante);
                DatosComprobante.Add(RFCComprobante);
                DatosComprobante.Add(MontoTotalComprobante);
                DatosComprobante.Add(MonedaComprobante);
                DatosComprobante.Add(TipCambioComprobante);
                DatosComprobante.Add(Clave);

                if (!Comprobantes.ContainsKey(LlaveComprobante))
                    Comprobantes.Add(LlaveComprobante, DatosComprobante);
            }

            drComprobantes.Close();
            drComprobantes.Dispose();

			ImportarComprobantes.Comprobantes = Comprobantes;

            ImportarComprobantes.dtPolizas = dtPolizas;
            ImportarComprobantes.dtTransacciones = dtTransacciones;

			ImportarComprobantes.ShowDialog(this);

			if(ImportarComprobantes.Guardado) {
				Comprobantes = ImportarComprobantes.Comprobantes;
			}
		}
        private void cmdComprobantesNacionalOtros_Click(object sender, EventArgs e)
        {
            frmImportarComprobantesNacionalOtros ImportarComprobantesNacionalOtros = new frmImportarComprobantesNacionalOtros();
            Dictionary<string, List<string>> ComprobantesNacionalOtros = new Dictionary<string, List<string>>();

            ImportarComprobantesNacionalOtros.IDPoliza = this.IDPoliza;
            ImportarComprobantesNacionalOtros.EjercicioPeriodo = lblEjercicioPeriodoSeleccionado.Text;
            ImportarComprobantesNacionalOtros.Polizas = this.Polizas_List;

            OleDbDataReader drComprobantesNacionalOtros = Database.obtenRegistros("SELECT Numero_Poliza, Numero_Cuenta, CFD_CBB_Serie, CFD_CBB_NumFol, RFC, MontoTotal, Moneda, TipCamb, Clave  FROM SATeC_Polizas_Comprobantes_Nacional_Otros WHERE ID_Poliza = " + IDPoliza + " ORDER BY Numero_Poliza ");

            while (drComprobantesNacionalOtros.Read())
            {
                string NumeroPolizaComprobante = drComprobantesNacionalOtros["Numero_Poliza"].ToString();
                string NumeroCuentaComprobante = drComprobantesNacionalOtros["Numero_Cuenta"].ToString();
                string CFD_CBB_SerieComprobante = drComprobantesNacionalOtros["CFD_CBB_Serie"].ToString();
                string CFD_CBB_NumFolComprobante = drComprobantesNacionalOtros["CFD_CBB_NumFol"].ToString();
                string RFCComprobante = drComprobantesNacionalOtros["RFC"].ToString();
                string MontoTotalComprobante = drComprobantesNacionalOtros["MontoTotal"].ToString();
                string MonedaComprobante = drComprobantesNacionalOtros["Moneda"].ToString();
                string TipCambioComprobante = drComprobantesNacionalOtros["TipCamb"].ToString();
                string Clave = drComprobantesNacionalOtros["Clave"].ToString();

                string LlaveComprobante = NumeroPolizaComprobante + "-" + NumeroCuentaComprobante;

                List<string> DatosComprobante = new List<string>();
                DatosComprobante.Add(CFD_CBB_SerieComprobante);
                DatosComprobante.Add(CFD_CBB_NumFolComprobante);
                DatosComprobante.Add(RFCComprobante);
                DatosComprobante.Add(MontoTotalComprobante);
                DatosComprobante.Add(MonedaComprobante);
                DatosComprobante.Add(TipCambioComprobante);
                DatosComprobante.Add(Clave);

                if (!ComprobantesNacionalOtros.ContainsKey(LlaveComprobante))
                    ComprobantesNacionalOtros.Add(LlaveComprobante, DatosComprobante);
            }

            drComprobantesNacionalOtros.Close();
            drComprobantesNacionalOtros.Dispose();

            ImportarComprobantesNacionalOtros.ComprobantesNacionalesOtros = ComprobantesNacionalOtros;

            ImportarComprobantesNacionalOtros.dtPolizas = dtPolizas;
            ImportarComprobantesNacionalOtros.dtTransacciones = dtTransacciones;

            ImportarComprobantesNacionalOtros.ShowDialog(this);

            if (ImportarComprobantesNacionalOtros.Guardado)
            {
               ComprobantesNacionalOtros = ImportarComprobantesNacionalOtros.ComprobantesNacionalesOtros;
            }
        }
        private void cmdComprobantesExtranjeros_Click(object sender, EventArgs e)
        {
            frmImportarComprobantesExtranjeros ImportarComprobantesExtranjeros = new frmImportarComprobantesExtranjeros();
            Dictionary<string, List<string>> ComprobantesExtranjeros = new Dictionary<string, List<string>>();    

            ImportarComprobantesExtranjeros.IDPoliza = this.IDPoliza;
            ImportarComprobantesExtranjeros.EjercicioPeriodo = lblEjercicioPeriodoSeleccionado.Text;
            ImportarComprobantesExtranjeros.Polizas = this.Polizas_List;

            OleDbDataReader drComprobantesExtranjeros = Database.obtenRegistros("SELECT Numero_Poliza, Numero_Cuenta, NumFactExt, TaxID, MontoTotal, Moneda, TipCamb, Clave  FROM SATeC_Polizas_Comprobantes_Extranjeros WHERE ID_Poliza = " + IDPoliza + " ORDER BY Numero_Poliza ");

            while (drComprobantesExtranjeros.Read())
            {
                string NumeroPolizaComprobante = drComprobantesExtranjeros["Numero_Poliza"].ToString();
                string NumeroCuentaComprobante = drComprobantesExtranjeros["Numero_Cuenta"].ToString();
                string NumFactExtComprobante = drComprobantesExtranjeros["NumFactExt"].ToString();
                string TaxIDComprobante = drComprobantesExtranjeros["TaxID"].ToString();
                string MontoTotalComprobante = drComprobantesExtranjeros["MontoTotal"].ToString();
                string MonedaComprobante = drComprobantesExtranjeros["Moneda"].ToString();
                string TipCambioComprobante = drComprobantesExtranjeros["TipCamb"].ToString();
                string Clave = drComprobantesExtranjeros["Clave"].ToString();

                string LlaveComprobante = NumeroPolizaComprobante + "-" + NumeroCuentaComprobante;

                List<string> DatosComprobante = new List<string>();
                DatosComprobante.Add(NumFactExtComprobante);
                DatosComprobante.Add(TaxIDComprobante);
                DatosComprobante.Add(MontoTotalComprobante);
                DatosComprobante.Add(MonedaComprobante);
                DatosComprobante.Add(TipCambioComprobante);

                if (!ComprobantesExtranjeros.ContainsKey(LlaveComprobante))
                    ComprobantesExtranjeros.Add(LlaveComprobante, DatosComprobante);
            }

            drComprobantesExtranjeros.Close();
            drComprobantesExtranjeros.Dispose();

            ImportarComprobantesExtranjeros.ComprobantesExtranjeros = ComprobantesExtranjeros;

            ImportarComprobantesExtranjeros.dtPolizas = dtPolizas;
            ImportarComprobantesExtranjeros.dtTransacciones = dtTransacciones;

            ImportarComprobantesExtranjeros.ShowDialog(this);

            if (ImportarComprobantesExtranjeros.Guardado)
            {
                ComprobantesExtranjeros = ImportarComprobantesExtranjeros.ComprobantesExtranjeros;
            }
        }
        private void cmdOtrosMetodosPago_Click(object sender, EventArgs e)
        {
            frmImportarOtroMetodoPago ImportarOtroMetodoPago = new frmImportarOtroMetodoPago();
            Dictionary<string, List<string>> OtrosMetodosPago = new Dictionary<string, List<string>>();

            ImportarOtroMetodoPago.IDPoliza = this.IDPoliza;
            ImportarOtroMetodoPago.EjercicioPeriodo = lblEjercicioPeriodoSeleccionado.Text;
            ImportarOtroMetodoPago.Polizas = this.Polizas_List;

            OleDbDataReader drOtrosMetodosPago = Database.obtenRegistros("SELECT Numero_Poliza, Numero_Cuenta, MetPagoPol, CONVERT(VARCHAR(10), Fecha, 103) Fecha, Benef, RFC, Monto, Moneda, TipCamb, Clave  FROM SATeC_Polizas_OtroMetodoPago WHERE ID_Poliza = " + IDPoliza + " ORDER BY Numero_Poliza ");

            while (drOtrosMetodosPago.Read())
            {
                string NumeroPolizaComprobante = drOtrosMetodosPago["Numero_Poliza"].ToString();
                string NumeroCuentaComprobante = drOtrosMetodosPago["Numero_Cuenta"].ToString();
                string MetPagoPol = drOtrosMetodosPago["MetPagoPol"].ToString();
                string Fecha = drOtrosMetodosPago["Fecha"].ToString();
                string Beneficiario = drOtrosMetodosPago["Benef"].ToString();
                string RFC = drOtrosMetodosPago["RFC"].ToString();
                string Monto = drOtrosMetodosPago["Monto"].ToString();
                string Moneda = drOtrosMetodosPago["Moneda"].ToString();
                string TipCambioOtro = drOtrosMetodosPago["TipCamb"].ToString();
                string Clave = drOtrosMetodosPago["Clave"].ToString();

                string LlaveComprobante = NumeroPolizaComprobante + "-" + NumeroCuentaComprobante;

                List<string> DatosComprobante = new List<string>();
                DatosComprobante.Add(MetPagoPol);
                DatosComprobante.Add(Fecha);
                DatosComprobante.Add(Beneficiario);
                DatosComprobante.Add(RFC);
                DatosComprobante.Add(Monto);
                DatosComprobante.Add(Moneda);
                DatosComprobante.Add(TipCambioOtro);
                DatosComprobante.Add(Clave);

                if (!OtrosMetodosPago.ContainsKey(LlaveComprobante))
                    OtrosMetodosPago.Add(LlaveComprobante, DatosComprobante);
            }

            drOtrosMetodosPago.Close();
            drOtrosMetodosPago.Dispose();

            ImportarOtroMetodoPago.OtrosMetodosPago = OtrosMetodosPago;

            ImportarOtroMetodoPago.dtPolizas = dtPolizas;
            ImportarOtroMetodoPago.dtTransacciones = dtTransacciones;

            ImportarOtroMetodoPago.ShowDialog(this);

            if (ImportarOtroMetodoPago.Guardado)
            {
                OtrosMetodosPago = ImportarOtroMetodoPago.OtrosMetodosPago;
            }
        }
		private void dgvPolizas_CellClick(object sender, DataGridViewCellEventArgs e) {
			if(e.RowIndex > -1) {
				string NumeroPoliza = dgvPolizas.CurrentRow.Cells["NumeroPoliza"].Value.ToString();
				string LlavePoliza = NumeroPoliza;

				var TransaccionesPoliza = Transacciones.Where(kvp => kvp.Key == LlavePoliza).Select(kvp => kvp.Value);

				dgvTransacciones.Rows.Clear();

				foreach(List<string> TransaccionPoliza in TransaccionesPoliza) {
					string NumeroPolizaTransaccion = NumeroPoliza;
					string CuentaTransaccion = TransaccionPoliza[0];
                    string DescCuentaTransaccion = TransaccionPoliza[1];
					string ConceptoTransaccion = TransaccionPoliza[2];
					double DebeTransaccion = double.Parse(TransaccionPoliza[3]);
					double HaberTransaccion = double.Parse(TransaccionPoliza[4]);

					dgvTransacciones.Rows.Add(NumeroPolizaTransaccion, CuentaTransaccion, DescCuentaTransaccion, ConceptoTransaccion, DebeTransaccion, HaberTransaccion);
				}
			}
		}
        private void cmdValidar_Click(object sender, EventArgs e)
        {
            if (ValidaPolizasImportadas())
            {
                if (General.muestraMensajePregunta("¿Quiere convertir las Pólizas a formato XML?") == System.Windows.Forms.DialogResult.Yes)
                {
                    if (ConvertirPolizaFormatoXML())
                    {
                        this.Close();
                    }

                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
                General.muestraMensaje("");
            }
        }
		private bool ValidaPolizasImportadas() {
			bool Valida = true;

			return Valida;
		}
        private bool ConvertirPolizaFormatoXML()
        {
            Cursor.Current = Cursors.WaitCursor;
            General.cambiaMensajeStatus(this.Owner, "Convirtiendo Pólizas a formato XML, espere por favor...");

            bool Convertido = true;

            string Error = string.Empty;

            string XMLToDatabase = string.Empty;

            if (generarArchivoXMLPolizas(out XMLToDatabase, this.Ejercicio, this.Periodo))
            {
                XMLToDatabase = XMLToDatabase.Replace("'", string.Empty);
                XMLToDatabase = XMLToDatabase.Replace("&", string.Empty);
                XMLToDatabase = XMLToDatabase.Replace("%", string.Empty);
                XMLToDatabase = XMLToDatabase.Replace("[", string.Empty);
                XMLToDatabase = XMLToDatabase.Replace("]", string.Empty);
                XMLToDatabase = XMLToDatabase.Replace("¿", string.Empty);

                if (guardarRegistroBaseDatos(XMLToDatabase, this.Ejercicio, this.Periodo, out Error))
                {
                    General.muestraMensaje("Se ha convertido con éxito las Pólizas al formato XML requerido por el SAT.");
                }
                else
                {
                    General.muestraMensaje("Ocurrio un error al tratar de convertir las Pólizas al formato XML requerido por el SAT:\n" + Error);
                    Convertido = false;
                }
            }
            else
            {
                General.muestraMensaje("Ocurrio un error al tratar de convertir las Pólizas al formato XML requerido por el SAT:\n" + Error);
                Convertido = false;
            }

            Cursor.Current = Cursors.Default;

            return Convertido;
        }
        static string RemoveInvalidXmlChars(string text)
        {
            var validXmlChars = text.Where(ch => XmlConvert.IsXmlChar(ch)).ToArray();
            return new string(validXmlChars);
        }
        private bool generarArchivoXMLPolizas(out string XMLToDatabase, string Ejercicio, string Periodo)
        {
            try
            {
                GC.Collect();

                bool Generado = true;
                string TipoSolicitud = String.Empty;
                string NumOrden = String.Empty;
                string NumTramite = String.Empty;
                string Sello = String.Empty;
                string noCertificado = String.Empty;
                string Certificado = String.Empty;

                string SQL = "SELECT TipoSolicitud, NumOrden, NumTramite, Sello, noCertificado, Certificado from SATeC_Polizas WHERE ID_Poliza = " + IDPoliza;

                DataTable dtPoliza = Database.ExecuteDataTable(SQL);

                if (dtPoliza.Rows.Count > 0)
                {
                    TipoSolicitud = dtPoliza.Rows[0]["TipoSolicitud"].ToString();
                    NumOrden = dtPoliza.Rows[0]["NumOrden"].ToString();
                    NumTramite = dtPoliza.Rows[0]["NumTramite"].ToString();
                }

                dtPoliza.Dispose();

                
                polizaGlobal.Version = Database.obtenerDato("select valor from SATeC_Parametrizacion where clave = 'VERSIONXML' AND activo = 1");
                polizaGlobal.RFC = General.RFC_SociedadSeleccionada.Trim();
                polizaGlobal.Mes = Periodo.Substring(0, 2);
                polizaGlobal.Anio = int.Parse(Ejercicio);
                polizaGlobal.TipoSolicitud = TipoSolicitud;

                if (TipoSolicitud.Equals("AF") || TipoSolicitud.Equals("FC"))
                    polizaGlobal.NumOrden = NumOrden;

                if (TipoSolicitud.Equals("DE") || TipoSolicitud.Equals("CO"))
                    polizaGlobal.NumTramite = NumTramite;

                #region Se Obtienen todos los componentes.

                DataSet dsDatos = Database.ExecuteDataSet("SATEC_ObtenerUniverso", IDPoliza);

                // Polizas.
                DataTable dtPolizasPolizas = dsDatos.Tables[0];

                for (int i = 0; i < dtPolizasPolizas.Rows.Count; i++)
                {
                    PolizasDTO polizaDTO = new PolizasDTO();
                    polizaDTO = (PolizasDTO)Serialization.FillClassFromDataTable(dtPolizasPolizas, polizaDTO, i);
                    listPolizas.Add(polizaDTO);
                }

                // Transacciones.
                DataTable dtPolizasTransacciones = dsDatos.Tables[1];

                for (int i = 0; i < dtPolizasTransacciones.Rows.Count; i++)
                {
                    TransaccionesDTO transaccionDTO = new TransaccionesDTO();
                    transaccionDTO = (TransaccionesDTO)Serialization.FillClassFromDataTable(dtPolizasTransacciones, transaccionDTO, i);
                    listTransacciones.Add(transaccionDTO);
                }

                // Comprobantes Nacionales.
                DataTable dtComprobantes = dsDatos.Tables[2];

                 for (int i = 0; i < dtComprobantes.Rows.Count; i++)
                {
                    ComprobantesNacionalesDTO comprobantesNacionalesDTO = new ComprobantesNacionalesDTO();
                    comprobantesNacionalesDTO = (ComprobantesNacionalesDTO)Serialization.FillClassFromDataTable(dtComprobantes, comprobantesNacionalesDTO, i);
                    listComprobantesNacionales.Add(comprobantesNacionalesDTO);
                }

                // Comprobantes Nacionales Otros.
                DataTable dtComprobantesNacionalesOtros = dsDatos.Tables[3];

                for (int i = 0; i < dtComprobantesNacionalesOtros.Rows.Count; i++)
                {
                    ComprobantesNacionalesOtrosDTO comprobantesNacionalesOtrosDTO = new ComprobantesNacionalesOtrosDTO();
                    comprobantesNacionalesOtrosDTO = (ComprobantesNacionalesOtrosDTO)Serialization.FillClassFromDataTable(dtComprobantesNacionalesOtros, comprobantesNacionalesOtrosDTO, i);
                    listComprobantesNacionalesOtros.Add(comprobantesNacionalesOtrosDTO);
                }

                // Comprobantes Extranjeros.
                DataTable dtComprobantesExtranjeros = dsDatos.Tables[4];

                for (int i = 0; i < dtComprobantesExtranjeros.Rows.Count; i++)
                {
                    ComprobantesExtranjerosDTO comprobantesExtranjerosDTO = new ComprobantesExtranjerosDTO();
                    comprobantesExtranjerosDTO = (ComprobantesExtranjerosDTO)Serialization.FillClassFromDataTable(dtComprobantesExtranjeros, comprobantesExtranjerosDTO, i);
                    listComprobantesExtranjeros.Add(comprobantesExtranjerosDTO);
                }

                // Cheques.
                DataTable dtCheques = dsDatos.Tables[5];

                for (int i = 0; i < dtCheques.Rows.Count; i++)
                {
                    ChequesDTO chequesDTO = new ChequesDTO();
                    chequesDTO = (ChequesDTO)Serialization.FillClassFromDataTable(dtCheques, chequesDTO, i);
                    listCheques.Add(chequesDTO);
                }

                // Transferencias.
                DataTable dtTransferencias = dsDatos.Tables[6];

                for (int i = 0; i < dtTransferencias.Rows.Count; i++)
                {
                    TransferenciasDTO transferenciasDTO = new TransferenciasDTO();
                    transferenciasDTO = (TransferenciasDTO)Serialization.FillClassFromDataTable(dtTransferencias, transferenciasDTO, i);
                    listTransferencias.Add(transferenciasDTO);
                }

                // Otros Metodos de Pago.
                DataTable dtOtrosMetodosPago = dsDatos.Tables[7];

                for (int i = 0; i < dtOtrosMetodosPago.Rows.Count; i++)
                {
                    OtroMetodosPagoDTO otroMetodosPagoDTO = new OtroMetodosPagoDTO();
                    otroMetodosPagoDTO = (OtroMetodosPagoDTO)Serialization.FillClassFromDataTable(dtOtrosMetodosPago, otroMetodosPagoDTO, i);
                    listOtrosMetodosPago.Add(otroMetodosPagoDTO);
                }

                dsDatos.Dispose();
                dtPolizasPolizas.Dispose();
                dtPolizasTransacciones.Dispose();
                dtComprobantes.Dispose();
                dtComprobantesNacionalesOtros.Dispose();
                dtComprobantesExtranjeros.Dispose();
                dtCheques.Dispose();
                dtTransferencias.Dispose();
                dtOtrosMetodosPago.Dispose();

                #endregion Se Obtienen todos los componentes.

                #region Polizas

                GC.Collect();

                //Stopwatch watch = new Stopwatch();
                //watch.Start();

                polizaGlobal.Poliza = (from pp in listPolizas
                                       select new PolizasPoliza()
                                       {
                                           NumUnIdenPol = pp.Numero_Poliza,
                                           Fecha = DateTime.ParseExact(pp.Fecha_Poliza, "dd/MM/yyyy", cultureinfo),
                                           Concepto = pp.Concepto,
                                           Transaccion =
                                                           (from pt in listTransacciones
                                                            where pt.Numero_Poliza == pp.Numero_Poliza
                                                            select new PolizasPolizaTransaccion()
                                                            {   
                                                                NumCta = pt.Cuenta,
                                                                DesCta = pt.DesCta,
                                                                Concepto = pt.Concepto,
                                                                Debe = pt.Debe,
                                                                Haber = pt.Haber,

                                                                CompNal =
                                                                           (
                                                                               from cn in listComprobantesNacionales
                                                                               where cn.Numero_Poliza == pt.Numero_Poliza && cn.Numero_Cuenta == pt.Cuenta && (!string.IsNullOrEmpty(cn.Clave) ? cn.Clave == pt.Concepto : true)
                                                                               select new PolizasPolizaTransaccionCompNal()
                                                                               {
                                                                                   UUID_CFDI = cn.UUID_CFDI,
                                                                                   RFC = cn.RFC,
                                                                                   MontoTotal = cn.MontoTotal,
                                                                                   Moneda = cn.Moneda,
                                                                                   TipCamb = cn.TipCamb,
                                                                                   TipCambSpecified = true
                                                                               }
                                                                           ).ToArray(),
                                                                CompNalOtr =
                                                                                (
                                                                                    from cno in listComprobantesNacionalesOtros
                                                                                    where cno.Numero_Poliza == pt.Numero_Poliza && cno.Numero_Cuenta == pt.Cuenta && (!string.IsNullOrEmpty(cno.Clave) ? cno.Clave == pt.Concepto : true)
                                                                                    select new PolizasPolizaTransaccionCompNalOtr()
                                                                                    {
                                                                                        CFD_CBB_NumFol = cno.CFD_CBB_NumFol,
                                                                                        CFD_CBB_Serie = cno.CFD_CBB_Serie,
                                                                                        Moneda = cno.Moneda,
                                                                                        MontoTotal = cno.MontoTotal,
                                                                                        RFC = cno.RFC,
                                                                                        TipCamb = cno.TipCamb,
                                                                                        TipCambSpecified = true
                                                                                    }
                                                                                ).ToArray(),
                                                                CompExt = (
                                                                           from ce in listComprobantesExtranjeros
                                                                           where ce.Numero_Poliza == pt.Numero_Poliza && ce.Numero_Cuenta == pt.Cuenta && (!string.IsNullOrEmpty(ce.Clave) ? ce.Clave == pt.Concepto : true)
                                                                           select new PolizasPolizaTransaccionCompExt()
                                                                           {
                                                                               Moneda = ce.Moneda,
                                                                               MontoTotal = ce.MontoTotal,
                                                                               NumFactExt = ce.NumFactExt,
                                                                               TaxID = ce.TaxID,
                                                                               TipCamb = ce.TipCamb,
                                                                               TipCambSpecified = true
                                                                           }
                                                                           ).ToArray(),
                                                                Cheque =
                                                                          (
                                                                             from c in listCheques
                                                                             where c.Numero_Poliza == pt.Numero_Poliza && c.Numero_Cuenta == pt.Cuenta && (!string.IsNullOrEmpty(c.Clave) ? c.Clave == pt.Concepto : true)
                                                                             select new PolizasPolizaTransaccionCheque()
                                                                             {
                                                                                 BanEmisExt = c.BanEmisExt,
                                                                                 BanEmisNal = c.BanEmisNal,
                                                                                 Benef = c.Benef,
                                                                                 CtaOri = c.CtaOri,
                                                                                 Fecha = DateTime.ParseExact(c.Fecha, "dd/MM/yyyy", cultureinfo),
                                                                                 Moneda = c.Moneda,
                                                                                 Monto = c.Monto,
                                                                                 Num = c.Num,
                                                                                 RFC = c.RFC,
                                                                                 TipCamb = c.TipCamb,
                                                                                 TipCambSpecified = true
                                                                             }
                                                                          ).ToArray(),
                                                                Transferencia =
                                                                               (
                                                                                   from t in listTransferencias
                                                                                   where t.Numero_Poliza == pt.Numero_Poliza && t.Numero_Cuenta == pt.Cuenta && ( !string.IsNullOrEmpty(t.Clave) ? t.Clave == pt.Concepto : true )
                                                                                   select new PolizasPolizaTransaccionTransferencia()
                                                                                   {
                                                                                       BancoDestExt = t.BancoDestExt,
                                                                                       BancoDestNal = t.BancoDestNal,
                                                                                       BancoOriExt = t.BancoOriExt,
                                                                                       BancoOriNal = t.BancoOriNal,
                                                                                       Benef = t.Benef,
                                                                                       CtaDest = t.CtaDest,
                                                                                       CtaOri = t.CtaOri,
                                                                                       Fecha = DateTime.ParseExact(t.Fecha, "dd/MM/yyyy", cultureinfo),
                                                                                       Moneda = t.Moneda,
                                                                                       Monto = t.Monto,
                                                                                       RFC = t.RFC,
                                                                                       TipCamb = t.TipCamb,
                                                                                       TipCambSpecified = true
                                                                                   }
                                                                               ).ToArray(),
                                                                OtrMetodoPago =
                                                                  (
                                                                      from o in listOtrosMetodosPago
                                                                      where o.Numero_Poliza == pt.Numero_Poliza && o.Numero_Cuenta == pt.Cuenta && (!string.IsNullOrEmpty(o.Clave) ? o.Clave == pt.Concepto : true)
                                                                      select new PolizasPolizaTransaccionOtrMetodoPago()
                                                                      {
                                                                          Benef = o.Benef,
                                                                          Fecha = DateTime.ParseExact(o.Fecha, "dd/MM/yyyy", cultureinfo),
                                                                          MetPagoPol = o.MetPagoPol,
                                                                          Moneda = o.Moneda,
                                                                          Monto = o.Monto,
                                                                          RFC = o.RFC,
                                                                          TipCamb = o.TipCamb,
                                                                          TipCambSpecified = true
                                                                      }
                                                                  ).ToArray(),
                                                            }
                                                            ).ToArray()
                                       }
                                      ).ToArray();
                
                //watch.Stop();
                //MessageBox.Show(string.Format("Tiempo Total de Procesamiento: {0}", watch.Elapsed.TotalMinutes.ToString() + ":" + watch.Elapsed.TotalSeconds.ToString()));

                #endregion Polizas

                GC.Collect();

                XmlSerializer ser = new XmlSerializer(typeof(Polizas));
                StringBuilder sb = new StringBuilder();

                using (XmlWriter writer = XmlWriter.Create(sb, new XmlWriterSettings()
                {
                    Indent = true,
                    OmitXmlDeclaration = false,
                    Encoding = Encoding.UTF8
                }))
                {

                    XmlSerializerNamespaces xmlNameSpace = new XmlSerializerNamespaces();
                    xmlNameSpace.Add("PLZ", "www.sat.gob.mx/esquemas/ContabilidadE/1_1/PolizasPeriodo");
                    xmlNameSpace.Add("schemaLocation", "www.sat.gob.mx/esquemas/ContabilidadE/1_1/PolizasPeriodo http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/PolizasPeriodo/PolizasPeriodo_1_1.xsd");
                    xmlNameSpace.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

                    ser.Serialize(writer, polizaGlobal, xmlNameSpace);
                }

                sb.Replace(Encoding.Unicode.WebName, Encoding.UTF8.WebName, 0, 56);
                sb.Replace("utf-8", "UTF-8");
                sb.Replace("xmlns:schemaLocation=", "xsi:schemaLocation=");

                XMLToDatabase = sb.ToString();

                GC.Collect();

                return Generado;
            }
            catch (Exception ex)
            {
                XMLToDatabase = string.Empty;
                MessageBox.Show("No se pudo convertir al formato XML. Intente mas tarde.");
                LogErrores.WriteLog("Error en el metodo generarArchivoXMLPolizas", ex);
                return false;
            }
        }
		private bool guardarRegistroBaseDatos(string XMLToDatabase, string Ejercicio, string Periodo, out string Error) {
			bool Guardado = true;
			Error = string.Empty;

			string SQL = "UPDATE SATeC_Polizas SET";
			SQL += " Fecha_Conversion = getdate()";
			SQL += ", ID_Usuario_Conversion = " + General.UsuarioActual.ID;
			SQL += ", XML = '" + XMLToDatabase + "'";
			SQL += " WHERE ID_Poliza = " + this.IDPoliza;

            try
            {
                DataBaseSQL.ExecuteNonQuery(SQL);
                Guardado = true;
            }
            catch (Exception ex)
            {
                Guardado = false;
                Error = ex.Message;
            }

			return Guardado;
		}
		private void cmdCerrar_Click(object sender, EventArgs e) {
			if(General.muestraMensajePregunta("¿Esta seguro de salir sin guardar los datos de las Pólizas?") == DialogResult.Yes) {
                dgvPolizas.Dispose();
                dgvTransacciones.Dispose();

                this.Dispose(true);

                GC.Collect();
				this.Close();
			}
        }

       
	}

}