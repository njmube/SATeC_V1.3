using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace SATeC.Polizas {
	public partial class frmImportarCheques : Form {

		public string IDPoliza { set; get; }
		public string EjercicioPeriodo { set; get; }

        public DataTable dtPolizas = new DataTable();
        public DataTable dtTransacciones = new DataTable();

		public List<KeyValuePair<string, List<string>>> Transacciones = new List<KeyValuePair<string, List<string>>>();
		public Dictionary<string, List<string>> Cheques { set; get; }

		public bool Guardado = false;

        private int totalNoValidos = 0;

        bool Salir = false;

        public DataTable dtCatalogoBancosSAT = new DataTable();
        public DataTable dtCatalogoMonedasSAT = new DataTable();

        int totalCodigosBancosNoValidos = 0;
        int totalCodigosMonedasNoValidos = 0;


		public frmImportarCheques() {
			InitializeComponent();
		}

		private void frmImportarCheques_Load(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;

			limpiaDatos();
			lblEjercicioPeriodoSeleccionado.Text = EjercicioPeriodo;
			cargarChequesYaGuardados();
            CargarCatalogoBancosSAT();
            CargarCatalogoMonedasSAT();

			Cursor = Cursors.Default;
		}

		//VHJC Funcion que limpia los datos de la forma
		private void limpiaDatos() {
			this.chkPrimerFilaNombresColumnas.Checked = false;
			this.txtArchivoCheques.Text = string.Empty;
			this.txtPathArchivoCheques.Text = string.Empty;
			this.dgvCheques.Rows.Clear();
		}

		//VHJC Funcion que carga en el grid los datos de los cheques que ya estan guardados para las polizas
		private void cargarChequesYaGuardados() {
			Cursor.Current = Cursors.WaitCursor;

			//VHJC Si hay Cheques ya guardados...
			if(Cheques.Keys.Count > 0) {
				//VHJC Primero se agrega un renglon todo en blanco para hacer la separacion
				int RegistroEnBlanco = dgvCheques.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "", "", true, true);

				for(int i = 0; i < 3; i++) {
					dgvCheques.Rows[RegistroEnBlanco].Cells[i].Style.BackColor = System.Drawing.Color.FromArgb(0, 130, 153);
					dgvCheques.Rows[RegistroEnBlanco].Cells[i].Style.SelectionBackColor = System.Drawing.Color.FromArgb(0, 130, 153);
					dgvCheques.Rows[RegistroEnBlanco].Cells[i].Style.ForeColor = System.Drawing.Color.FromArgb(0, 130, 153);
					dgvCheques.Rows[RegistroEnBlanco].Cells[i].Style.SelectionForeColor = System.Drawing.Color.FromArgb(0, 130, 153);
				}

				//VHJC Se agregan todos los Cheques ya guardados
				foreach(string NumeroPoliza_Cuenta in Cheques.Keys) {
					List<string> DatosCheque = Cheques[NumeroPoliza_Cuenta];

					string[] Poliza_Cuenta = NumeroPoliza_Cuenta.Split('-');
					string NumeroPolizaCheque = Poliza_Cuenta[0];
					string NumeroCuentaCheque = Poliza_Cuenta[1];

					string NumeroCheque = DatosCheque[0];
					string BancoEmisorNacionalCheque = DatosCheque[1];
                    string BancoEmisorExtranjeroCheque = DatosCheque[2];
					string CuentaOrigenCheque = DatosCheque[3];
					string FechaCheque = DatosCheque[4];
                    string BeneficiarioCheque = DatosCheque[5];
                    string RFCCheque = DatosCheque[6];
					string MontoCheque = DatosCheque[7];
                    string MonedaCheque = DatosCheque[8];
                    string TipodeCambioCheque = DatosCheque[9];
                    string Clave = DatosCheque[10];

                    dgvCheques.Rows.Add(NumeroPolizaCheque, NumeroCuentaCheque, NumeroCheque, BancoEmisorNacionalCheque, BancoEmisorExtranjeroCheque, CuentaOrigenCheque, FechaCheque, BeneficiarioCheque, RFCCheque, MontoCheque, MonedaCheque, TipodeCambioCheque, Clave, true, true);
				}
			}

			Cursor.Current = Cursors.Default;
		}

		//VHJC Cuando se da clic en el boton "..." para seleccionar el archivo de los cheques de las polizas
		private void cmdAbrirArchivo_Click(object sender, EventArgs e) {
			Cursor.Current = Cursors.WaitCursor;

			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Filter = "Archivos TXT(*.txt, *.csv)|*.txt; *.csv";
			openFileDialog1.Title = "Seleccione el archivo TXT de los Cheques de las Pólizas";

			// VHJC Muestra la ventana para seleccionar el archivo
			// Si el usuario selecciona un archivo txt y le clic en el boton OK, se regresa el nombre del archivo para despues validarlo
			if(openFileDialog1.ShowDialog() == DialogResult.OK) {
				txtArchivoCheques.Text = openFileDialog1.SafeFileName;
				txtPathArchivoCheques.Text = openFileDialog1.FileName;

				string Error = string.Empty;

				if(!cargaArchivoChequesTXT(out Error)) {
					General.muestraMensaje("Ocurrio un error al cargar el archivo TXT de los Cheques de las Pólizas.\n" + Error);
				}
			}

			Cursor.Current = Cursors.Default;
		}

		//VHJC Funcion que carga el contenido de archivo TXT al grid
		private bool cargaArchivoChequesTXT(out string Error) {
			Cursor.Current = Cursors.WaitCursor;

			bool Cargado = true;
			Error = string.Empty;

			bool FirstRow = true;
			bool PrimerFilaNombresColumnas = chkPrimerFilaNombresColumnas.Checked;

			string Separador = string.Empty;
			char[] separator = { ',' };

            totalCodigosBancosNoValidos = 0;
            totalCodigosMonedasNoValidos = 0;

			try {
				dgvCheques.Rows.Clear();

				TextFieldParser txtReader = new TextFieldParser(txtPathArchivoCheques.Text, Encoding.Default);
				txtReader.TextFieldType = FieldType.Delimited;
				txtReader.SetDelimiters(",");
				txtReader.HasFieldsEnclosedInQuotes = true;

				//VHJC Por cada una de las lineas del archivo TXT
				while(!txtReader.EndOfData) {

					//VHJC Se verifica la primer linea para ver si el archivo viene separado por TABS o por comas...
					if(FirstRow) {
						//VHJC Se lee la primer linea...
						string firstRow = txtReader.PeekChars(1000);

						//VHJC Si la primer linea viene con un tab, entonces el separador pasa a ser "Tab"
						if(firstRow.Contains("\t"))
							txtReader.SetDelimiters("\t");

						FirstRow = false;
					}

					//VHJC Si esta marcada la opcion de "Primero fila con nombres de columnas", se salta la primer linea
					if(PrimerFilaNombresColumnas) {
						txtReader.ReadLine();
						PrimerFilaNombresColumnas = false;
						continue;
					}

                    bool codigoBancoOK = true;
                    bool codigoMonedaOK = true;

					string[] DatosCheque = txtReader.ReadFields();

                    string[] EjercicioPeriodo = lblEjercicioPeriodoSeleccionado.Text.Split('-');
                    string Ejercicio = EjercicioPeriodo[0].Trim();
                    string Periodo = EjercicioPeriodo[1].Trim().Substring(0, 2);

                    string ano = DatosCheque[0].ToString();
                    string mes = DatosCheque[1].ToString();

                    if (!(Ejercicio.Equals(ano) && Periodo.Equals(mes)))
                    {
                        General.muestraMensaje("El año y mes del Cheque debe corresponder al periodo seleccionado. Favor de validar");
                        break;
                    }

                    List<string> listaTipoPolizas = new List<string>() { "1", "2", "3" };

                    string idTipoPoliza = DatosCheque[2].Trim();

                    if (!listaTipoPolizas.Contains(idTipoPoliza))
                    {
                        General.muestraMensaje("El Tipo de Poliza identficado No es Valido. Solo se permiten los codigos: [1], [2] o [3]. Favor de corregir.");
                        break;
                    }

                    string NumeroPolizaCheque = DatosCheque[2] + DatosCheque[3];
					string NumeroCuentaCheque = DatosCheque[4];
					string NumeroCheque = DatosCheque[5];
					string BancoEmisorNacional = DatosCheque[6];

                    if (!VerificarClaveBanco(BancoEmisorNacional))
                    {
                        codigoBancoOK = false;
                        totalCodigosBancosNoValidos++;
                    }

                    string BancoEmisorExtranjero = DatosCheque[7];
					string CuentaOrigen = DatosCheque[8];
					string Fecha = DatosCheque[9];
                    string Beneficiario = DatosCheque[10];
                    string RFC = DatosCheque[11];
					double Monto = double.Parse(DatosCheque[12]);
                    string Moneda = DatosCheque[13];

                    if (!VerificarCodigoMoneda(Moneda))
                    {
                        codigoMonedaOK = false;
                        totalCodigosMonedasNoValidos++;
                    }

                    double TipodeCambio = double.Parse(DatosCheque[14]);

                    string Clave = string.Empty;

                    if (DatosCheque.Count() == 16)
                    {
                        Clave = DatosCheque[15];
                    }

					//VHJC Se verifica que la Poliza y Transaccion del Cheque ya exista
                    bool ExistePoliza = verificaExistePolizaTransaccion(NumeroPolizaCheque, NumeroCuentaCheque);

					//VHJC Se verifica si el Cheque ya esta guardado
					string LlaveCheque = NumeroPolizaCheque + "-" + NumeroCuentaCheque;
					bool ExisteCheque = Cheques.ContainsKey(LlaveCheque);

                    int RegistroAgregado = dgvCheques.Rows.Add(NumeroPolizaCheque, NumeroCuentaCheque, NumeroCheque, BancoEmisorNacional, BancoEmisorExtranjero, CuentaOrigen, Fecha, Beneficiario, RFC, Monto, Moneda, TipodeCambio, Clave, ExistePoliza, ExisteCheque);

					//VHJC Si la poliza del cheque no existe en las polizas ya cargadas se marca el registro en rojo
                    if (!ExistePoliza)
                    {
						for(int i = 0; i < dgvCheques.Columns.Count; i++) {
							dgvCheques.Rows[RegistroAgregado].Cells[i].Style.BackColor = System.Drawing.Color.Red;
							dgvCheques.Rows[RegistroAgregado].Cells[i].Style.SelectionBackColor = System.Drawing.Color.Red;
							dgvCheques.Rows[RegistroAgregado].Cells[i].Style.ForeColor = System.Drawing.Color.Black;
							dgvCheques.Rows[RegistroAgregado].Cells[i].Style.SelectionForeColor = System.Drawing.Color.Black;
						}

                        totalNoValidos++;
					}

					//VHJC Si el cheque ya existe se marca el registro en amarillo
					if(ExisteCheque) {
						for(int i = 0; i < dgvCheques.Columns.Count; i++) {
							dgvCheques.Rows[RegistroAgregado].Cells[i].Style.BackColor = System.Drawing.Color.Yellow;
							dgvCheques.Rows[RegistroAgregado].Cells[i].Style.SelectionBackColor = System.Drawing.Color.Yellow;
							dgvCheques.Rows[RegistroAgregado].Cells[i].Style.ForeColor = System.Drawing.Color.Black;
							dgvCheques.Rows[RegistroAgregado].Cells[i].Style.SelectionForeColor = System.Drawing.Color.Black;
						}
					}

                    if (!codigoBancoOK)
                    {
                        dgvCheques.Rows[RegistroAgregado].Cells[3].Style.BackColor = System.Drawing.Color.Maroon;
                        dgvCheques.Rows[RegistroAgregado].Cells[3].Style.ForeColor = System.Drawing.Color.White;
                    }

                    if (!codigoMonedaOK)
                    {
                        dgvCheques.Rows[RegistroAgregado].Cells[10].Style.BackColor = System.Drawing.Color.Orange;
                        dgvCheques.Rows[RegistroAgregado].Cells[10].Style.ForeColor = System.Drawing.Color.White;
                    }

				}

				txtReader.Close();
				txtReader.Dispose();

			} catch(Exception ex) {
				Cargado = false;
				Error = ex.Message;
			}

			//VHJC Si ya hay algo guardado se agrega despues de lo que se carga del archivo
			if(Cheques.Keys.Count > 0) {
				cargarChequesYaGuardados();
			}

			Cursor.Current = Cursors.Default;

			return Cargado;
		}

		//VHJC Funcion que verifica que el chueque tenga una poliza y transaccion relacionada en las ya cargadas
		private bool verificaExistePolizaTransaccion(string Poliza, string NumeroCuentaCheque) {
			bool Existe = false;

            DataRow[] drTransacciones = dtTransacciones.Select("Numero_Poliza='" + Poliza + "' AND Cuenta = '" + NumeroCuentaCheque + "'");

            if (drTransacciones.Count() > 0)
                Existe = true;

			return Existe;
		}

		//VHJC Cuando se da clic en el boton Guardar
		private void cmdGuardar_Click(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;

			string SQL = string.Empty;

            Salir = false;

			//VHJC Si los datos de los Cheques estan completos y correctos..
			if(validaCheques()) {
				//General.cambiaMensajeStatus(this, "Generando script para guardar los datos de los Cheques en la base de datos...");
				//VHJC Se guardan los registros de los Cheques que sean nuevos, es decir los que tengan la columna "Guardado" en falso
				foreach(DataGridViewRow dgvrCheque in dgvCheques.Rows) {
					//Console.WriteLine("Transacción " + dgvrTransaccion.Index + ": " + DateTime.Now.ToString("h:mm:ss.ff"));

					if(!bool.Parse(dgvrCheque.Cells["YaGuardado"].Value.ToString())) {

						string NumeroPolizaCheque = dgvrCheque.Cells["NumeroPoliza"].Value.ToString();
						string NumeroCuentaCheque = dgvrCheque.Cells["NumeroCuenta"].Value.ToString();
						string NumeroCheque = dgvrCheque.Cells["NumeroCheque"].Value.ToString();
						string BancoEmisorNacional = dgvrCheque.Cells["BancoEmisorNacional"].Value.ToString();
                        string BancoEmisorExtranjero = dgvrCheque.Cells["BancoEmisorExtranjero"].Value.ToString();
						string CuentaOrigenCheque = dgvrCheque.Cells["CuentaOrigen"].Value.ToString();
						string FechaCheque = dgvrCheque.Cells["Fecha"].Value.ToString();
                        string BeneficiarioCheque = dgvrCheque.Cells["Beneficiario"].Value.ToString();
                        string RFCCheque = dgvrCheque.Cells["RFC"].Value.ToString();
                        string MontoCheque = dgvrCheque.Cells["Monto"].Value.ToString();
                        string Moneda = dgvrCheque.Cells["Moneda"].Value.ToString();
                        string TipodeCambio = dgvrCheque.Cells["TipodeCambio"].Value.ToString();
                        string Clave = dgvrCheque.Cells["Clave"].Value.ToString();

                        SQL += "INSERT INTO SATeC_Polizas_Cheques (ID_Poliza, Numero_Poliza, Numero_Cuenta, Num, BanEmisNal, BanEmisExt, CtaOri, Fecha, Benef, RFC, Monto, Moneda, TipCamb, Clave) VALUES(";
						SQL += this.IDPoliza;
						SQL += ", '" + NumeroPolizaCheque + "'";
						SQL += ", '" + NumeroCuentaCheque + "'";
						SQL += ", '" + NumeroCheque + "'";
                        SQL += ", '" + BancoEmisorNacional + "'";
                        SQL += ", '" + BancoEmisorExtranjero + "'";
						SQL += ", '" + CuentaOrigenCheque + "'";
						SQL += ", CONVERT(DATETIME, '" + FechaCheque + "', 103)";
                        SQL += ", '" + General.revisaDatoSQL(BeneficiarioCheque) + "'";
                        SQL += ", '" + RFCCheque + "'";
						SQL += ", " + MontoCheque + "";
                        SQL += ", '" + Moneda + "'";
                        SQL += ", " + TipodeCambio + "";
                        SQL += ", '" + Clave + "' ";
						SQL += ")\n";

						List<string> DatosCheque = new List<string>();
						DatosCheque.Add(NumeroCheque);
                        DatosCheque.Add(BancoEmisorNacional);
                        DatosCheque.Add(BancoEmisorExtranjero);
						DatosCheque.Add(CuentaOrigenCheque);
						DatosCheque.Add(FechaCheque);
                        DatosCheque.Add(BeneficiarioCheque);
                        DatosCheque.Add(RFCCheque);
						DatosCheque.Add(MontoCheque);
                        DatosCheque.Add(Moneda);
                        DatosCheque.Add(TipodeCambio);
                        DatosCheque.Add(Clave);

                        if(!Cheques.ContainsKey(NumeroPolizaCheque + "-" + NumeroCuentaCheque))
                            Cheques.Add(NumeroPolizaCheque + "-" + NumeroCuentaCheque, DatosCheque);
					}
				}

				//General.cambiaMensajeStatus(this, "Guardando datos de los Cheques en la base de datos...");
				if(Database.ejecutaQuery(SQL, true)) {
					Salir = true;
					this.Guardado = true;
					General.muestraMensaje("Los datos de los Cheques se han guardado con exito.");
				} else {
					this.Guardado = false;
                    Salir = false;
					General.muestraMensaje("Ocurrio un error al tratar de guardar los datos de los Cheques");
					Cheques.Clear();
				}

				//General.cambiaMensajeStatus(this, "");
			}

			Cursor = Cursors.Default;

			if(Salir)
				this.Close();
		}

		//VHJC Funcion que valida que los datos de las pólizas esten completos y correctos
		private bool validaCheques() {
			bool Valida = true;
			bool ExistenNuevos = false;

			foreach(DataGridViewRow dgvrCheque in dgvCheques.Rows) {
				if(!bool.Parse(dgvrCheque.Cells["ExistePoliza"].Value.ToString())) {
					General.muestraMensaje("La Póliza " + dgvrCheque.Cells["NumeroPoliza"].Value.ToString() + " no contiene una Transaccion #" + dgvrCheque.Cells["IDTransaccion"].Value.ToString() + " para la Cuenta " + dgvrCheque.Cells["NumeroCuenta"].Value.ToString() + " en las Pólizas ya cargadas para este Ejercicio / Periodo, favor de validar.");
					Valida = false;
					dgvCheques.CurrentCell = dgvrCheque.Cells["NumeroPoliza"];
					return Valida;
				} else if(!bool.Parse(dgvrCheque.Cells["YaGuardado"].Value.ToString())) {
					ExistenNuevos = true;
				}
			}

            if (totalCodigosBancosNoValidos > 0)
            {
                General.muestraMensaje("Existen codigos de bancos no validos, favor de revisar.");
                Valida = false;
            }

            if (totalCodigosMonedasNoValidos > 0)
            {
                General.muestraMensaje("Existen codigos de monedas no validos, favor de revisar.");
                Valida = false;
            }

			if(!ExistenNuevos) {
				General.muestraMensaje("No existe ningun Cheque nuevo a relacionar con las Pólizas, favor de validar.");
				Valida = false;
			}

			return Valida;
		}

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (General.muestraMensajePregunta("¿Esta seguro de salir del Modulo de Cheques?") == DialogResult.Yes)
            {
                this.Close();
            }
        }

		private void dgvCheques_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e) {
			DataGridViewRow dgvRow = dgvCheques.Rows[e.RowIndex];

			if(dgvRow.Cells[0].Style.BackColor == System.Drawing.Color.FromArgb(0, 130, 153)) {

				Font fnt = new Font(dgvCheques.Font.FontFamily, 14, FontStyle.Bold, GraphicsUnit.Point);

				Rectangle rct = dgvCheques.GetRowDisplayRectangle(dgvRow.Index, true);
				rct.Height -= 1;

				SizeF s = e.Graphics.MeasureString("Cheques ya guardados", fnt);
				float lefts = (rct.Width / 2) - (s.Width / 2);
				float tops = rct.Top + ((rct.Height / 2) - (s.Height / 2));

				SolidBrush brush = new SolidBrush(System.Drawing.Color.FromArgb(0, 130, 153));
				e.Graphics.FillRectangle(brush, rct);

				e.Graphics.DrawString("Cheques ya guardados", fnt, Brushes.White, lefts, tops);
			}
		}
        private void CargarCatalogoBancosSAT()
        {
            dtCatalogoBancosSAT = Database.ExecuteDataTable("SATeC_ObtenerCatBancosSAT");
        }
        private void CargarCatalogoMonedasSAT()
        {
            dtCatalogoMonedasSAT = Database.ExecuteDataTable("SATeC_ObtenerCatMonedasSAT");
        }
        private bool VerificarClaveBanco(string clave)
        {
            bool Existe = false;

            DataRow[] drBancos = dtCatalogoBancosSAT.Select("clave='" + clave + "' ");

            if (drBancos.Count() > 0)
                Existe = true;

            return Existe;
        }
        private bool VerificarCodigoMoneda(string codigo)
        {
            bool Existe = false;

            DataRow[] drMonedas = dtCatalogoMonedasSAT.Select("codigo='" + codigo + "' ");

            if (drMonedas.Count() > 0)
                Existe = true;

            return Existe;
        }

		
	}
}
