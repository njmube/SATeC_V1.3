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
	public partial class frmImportarTransferencias : Form {

		public string IDPoliza { set; get; }
		public string EjercicioPeriodo { set; get; }

        public DataTable dtPolizas = new DataTable();
        public DataTable dtTransacciones = new DataTable();

		public List<KeyValuePair<string, List<string>>> Transacciones = new List<KeyValuePair<string, List<string>>>();
		public Dictionary<string, List<string>> Transferencias { set; get; }

		public bool Guardado = true;

        public DataTable dtCatalogoBancosSAT = new DataTable();
        public DataTable dtCatalogoMonedasSAT = new DataTable();

        int totalCodigosBancosNoValidos = 0;
        int totalCodigosMonedasNoValidos = 0;

        public DataTable dtTransferencias = CreateTableTransferencias();

		public frmImportarTransferencias() {
			InitializeComponent();
		}

		private void frmImportarTransferencias_Load(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;

			limpiaDatos();
			lblEjercicioPeriodoSeleccionado.Text = EjercicioPeriodo;
			cargarTransferenciasYaGuardadas();
            CargarCatalogoBancosSAT();
            CargarCatalogoMonedasSAT();

			Cursor = Cursors.Default;
		}

		//VHJC Funcion que limpia los datos de la forma
		private void limpiaDatos() {
			this.chkPrimerFilaNombresColumnas.Checked = false;
			this.txtArchivoTransferencias.Text = string.Empty;
			this.txtPathArchivoTransferencias.Text = string.Empty;
			this.dgvTransferencias.Rows.Clear();
		}

		//VHJC Funcion que carga en el grid los datos de las transferencias que ya estan guardadas para las polizas
		private void cargarTransferenciasYaGuardadas() {
			Cursor.Current = Cursors.WaitCursor;

			//VHJC Si hay Transferencias ya guardadas...
			if(Transferencias.Keys.Count > 0) {
				//VHJC Primero se agrega un renglon todo en blanco para hacer la separacion
				int RegistroEnBlanco = dgvTransferencias.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", true, true);

				for(int i = 0; i < 3; i++) {
					dgvTransferencias.Rows[RegistroEnBlanco].Cells[i].Style.BackColor = System.Drawing.Color.FromArgb(0, 130, 153);
					dgvTransferencias.Rows[RegistroEnBlanco].Cells[i].Style.SelectionBackColor = System.Drawing.Color.FromArgb(0, 130, 153);
					dgvTransferencias.Rows[RegistroEnBlanco].Cells[i].Style.ForeColor = System.Drawing.Color.FromArgb(0, 130, 153);
					dgvTransferencias.Rows[RegistroEnBlanco].Cells[i].Style.SelectionForeColor = System.Drawing.Color.FromArgb(0, 130, 153);
				}

				//VHJC Se agregan todas las Transferencias ya guardadas
				foreach(string NumeroPoliza_Cuenta in Transferencias.Keys) {
					List<string> DatosTransferencia = Transferencias[NumeroPoliza_Cuenta];

					string[] Llave = NumeroPoliza_Cuenta.Split('-');
					string NumeroPolizaTransferencia = Llave[0];
					string CuentaContableTransferencia = Llave[1];

					string CuentaOrigenTransferencia = DatosTransferencia[0];
					string BancoOrigenNacionalTransferencia = DatosTransferencia[1];
                    string BancoOrigenExtranjeroTransferencia = DatosTransferencia[2];
                    string CuentaDestinoTransferencia = DatosTransferencia[3];
                    string BancoDestinoNacionalTransferencia = DatosTransferencia[4];
                    string BancoDestinoExtranjeroTransferencia = DatosTransferencia[5];
                    string FechaTransferencia = DatosTransferencia[6];
                    string BeneficiarioTransferencia = DatosTransferencia[7];
                    string RFCTransferencia = DatosTransferencia[8];
					double MontoTransferencia = double.Parse(DatosTransferencia[9]);
                    string MonedaTransferencia = DatosTransferencia[10];
                    double TipodeCambioTransferencia = double.Parse(DatosTransferencia[11]);
                    string Clave = DatosTransferencia[12];

					dgvTransferencias.Rows.Add(NumeroPolizaTransferencia, CuentaContableTransferencia
						, CuentaOrigenTransferencia
                        , BancoOrigenNacionalTransferencia
                        , BancoOrigenExtranjeroTransferencia
                        , CuentaDestinoTransferencia
                        , BancoDestinoNacionalTransferencia
                        , BancoDestinoExtranjeroTransferencia
                        , FechaTransferencia
                        , BeneficiarioTransferencia
                        , RFCTransferencia
						, MontoTransferencia
                        , MonedaTransferencia
                        , TipodeCambioTransferencia
                        , Clave
						, true
						, true
                        );
				}
			}

			Cursor.Current = Cursors.Default;
		}

		//VHJC Cuando se da clic en el boton "..." para seleccionar el archivo de las transferencias de las polizas
		private void cmdAbrirArchivo_Click(object sender, EventArgs e) {
			Cursor.Current = Cursors.WaitCursor;

			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Filter = "Archivos TXT(*.txt, *.csv)|*.txt; *.csv";
			openFileDialog1.Title = "Seleccione el archivo TXT de las Transferencias de las Pólizas";

			// VHJC Muestra la ventana para seleccionar el archivo
			// Si el usuario selecciona un archivo txt y le clic en el boton OK, se regresa el nombre del archivo para despues validarlo
			if(openFileDialog1.ShowDialog() == DialogResult.OK) {
				txtArchivoTransferencias.Text = openFileDialog1.SafeFileName;
				txtPathArchivoTransferencias.Text = openFileDialog1.FileName;

				string Error = string.Empty;

				if(!cargaArchivoTXTTransferencias(out Error)) {
					General.muestraMensaje("Ocurrio un error al cargar el archivo TXT de las Transferencias de las Pólizas.\n" + Error);
				}
			}

			Cursor.Current = Cursors.Default;
		}

		//VHJC Funcion que carga el contenido de archivo TXT al grid
        private bool cargaArchivoTXTTransferencias(out string Error)
        {
            Cursor.Current = Cursors.WaitCursor;

            bool Cargado = true;
            Error = string.Empty;

            bool FirstRow = true;
            bool PrimerFilaNombresColumnas = chkPrimerFilaNombresColumnas.Checked;

            string Separador = string.Empty;
            //VHJC Por default el separador es ","
            char[] separator = { ',' };

            totalCodigosBancosNoValidos = 0;
            totalCodigosMonedasNoValidos = 0;

            dtTransferencias = CreateTableTransferencias();
            string[] DatosTransferencia;

            try
            {
                dgvTransferencias.Rows.Clear();

                TextFieldParser txtReader = new TextFieldParser(txtPathArchivoTransferencias.Text, Encoding.Default);
                txtReader.TextFieldType = FieldType.Delimited;
                txtReader.SetDelimiters(",");
                txtReader.HasFieldsEnclosedInQuotes = true;

                //VHJC Por cada una de las lineas del archivo TXT
                while (!txtReader.EndOfData)
                {
                    if (FirstRow)
                    {
                        //VHJC Se lee la primer linea...
                        string firstRow = txtReader.PeekChars(1000);

                        //VHJC Si la primer linea viene con un tab, entonces el separador pasa a ser "Tab"
                        if (firstRow.Contains("\t"))
                            txtReader.SetDelimiters("\t");

                        FirstRow = false;
                    }

                    //VHJC Si esta marcada la opcion de "Primero fila con nombres de columnas", se salta la primer linea
                    if (PrimerFilaNombresColumnas)
                    {
                        txtReader.ReadLine();
                        PrimerFilaNombresColumnas = false;
                        continue;
                    }

                    bool codigoBanco1OK = true;
                    bool codigoBanco2OK = true;
                    bool codigoMonedaOK = true;

                    //VHJC Variable que va a contener los datos de cada Transferencia
                    DatosTransferencia = txtReader.ReadFields();

                    string[] EjercicioPeriodo = lblEjercicioPeriodoSeleccionado.Text.Split('-');
                    string Ejercicio = EjercicioPeriodo[0].Trim();
                    string Periodo = EjercicioPeriodo[1].Trim().Substring(0, 2);

                    string ano = DatosTransferencia[0].ToString();
                    string mes = DatosTransferencia[1].ToString();

                    if (!(Ejercicio.Equals(ano) && Periodo.Equals(mes)))
                    {
                        General.muestraMensaje("El año y mes de la Transferencias debe corresponder al periodo seleccionado. Favor de validar");
                        break;
                    }

                    List<string> listaTipoPolizas = new List<string>() { "1", "2", "3" };

                    string idTipoPoliza = DatosTransferencia[2].Trim();

                    if (!listaTipoPolizas.Contains(idTipoPoliza))
                    {
                        General.muestraMensaje("El Tipo de Poliza identficado No es Valido. Solo se permiten los codigos: [1], [2] o [3]. Favor de corregir.");
                        break;
                    }

                    //VHJC Las transferencias tienen 12 datos
                    string NumeroPolizaTransferencia = DatosTransferencia[2] + DatosTransferencia[3];
                    string CuentaPolizaTransferencia = DatosTransferencia[4];
                    string CuentaOrigenTransferencia = DatosTransferencia[5];

                    string BancoOrigenNacionalTransferencia = DatosTransferencia[6];

                    if (!VerificarClaveBanco(BancoOrigenNacionalTransferencia))
                    {
                        codigoBanco1OK = false;
                        totalCodigosBancosNoValidos++;
                    }

                    string BancoOrigenExtranjeroTransferencia = DatosTransferencia[7];

                    string CuentaDestinoTransferencia = DatosTransferencia[8];

                    string BancoDestinoNacionalTransferencia = DatosTransferencia[9];

                    if (!VerificarClaveBanco(BancoDestinoNacionalTransferencia))
                    {
                        codigoBanco2OK = false;
                        totalCodigosBancosNoValidos++;
                    }
                    
                    string BancoDestinoExtranjeroTransferencia = DatosTransferencia[10];

                    string FechaTransferencia = DatosTransferencia[11];
                    string BeneficiarioTransferencia = DatosTransferencia[12];
                    string RFCTransferencia = DatosTransferencia[13];
                    double MontoTransferencia = 0;

                    if(!string.IsNullOrEmpty(DatosTransferencia[14]))
                        MontoTransferencia = double.Parse(DatosTransferencia[14]);

                    string MonedaTransferencia = DatosTransferencia[15];

                    if (!VerificarCodigoMoneda(MonedaTransferencia))
                    {
                        codigoMonedaOK = false;
                        totalCodigosMonedasNoValidos++;
                    }

                    double TipodeCambioTransferencia = 0;
                    
                    if(!string.IsNullOrEmpty(DatosTransferencia[16]))
                        TipodeCambioTransferencia = double.Parse(DatosTransferencia[16]);

                    string Clave = string.Empty;

                    if (DatosTransferencia.Count() == 18)
                    {
                        Clave = DatosTransferencia[17];
                    }

                    bool ExistePolizaTransaccion = verificaExistePolizaTransaccion(NumeroPolizaTransferencia, CuentaPolizaTransferencia);

                    if (String.IsNullOrEmpty(CuentaOrigenTransferencia))
                        ExistePolizaTransaccion = false;
                    else
                        if (String.IsNullOrEmpty(CuentaDestinoTransferencia))
                            ExistePolizaTransaccion = false;
                        else
                            if (String.IsNullOrEmpty(BancoDestinoNacionalTransferencia))
                                ExistePolizaTransaccion = false;
                            else
                                if (String.IsNullOrEmpty(BancoOrigenExtranjeroTransferencia))
                                    ExistePolizaTransaccion = false;
                                else
                                    if (String.IsNullOrEmpty(BancoDestinoExtranjeroTransferencia))
                                        ExistePolizaTransaccion = false;

                    string LlaveTransferencia = NumeroPolizaTransferencia + "-" + CuentaPolizaTransferencia;

                    bool ExisteTransferencia = Transferencias.ContainsKey(LlaveTransferencia);

                    int RegistroAgregado = dgvTransferencias.Rows.Add(
                          NumeroPolizaTransferencia, 
                          CuentaPolizaTransferencia
                        , CuentaOrigenTransferencia
                        , BancoOrigenNacionalTransferencia
                        , BancoOrigenExtranjeroTransferencia
                        , CuentaDestinoTransferencia
                        , BancoDestinoNacionalTransferencia
                        , BancoDestinoExtranjeroTransferencia
                        , FechaTransferencia
                        , BeneficiarioTransferencia
                        , RFCTransferencia
                        , MontoTransferencia
                        , MonedaTransferencia
                        , TipodeCambioTransferencia
                        , Clave
                        , ExistePolizaTransaccion
                        , ExisteTransferencia
                        );

                    if (ExistePolizaTransaccion && !ExisteTransferencia)
                    {
                        DataRow row = dtTransferencias.NewRow();

                        row["ID_Poliza"] = this.IDPoliza;
                        row["Numero_Poliza"] = NumeroPolizaTransferencia;
                        row["Cuenta_Poliza"] = CuentaPolizaTransferencia;
                        row["CtaOri"] = CuentaOrigenTransferencia;
                        row["BancoOriNal"] = BancoOrigenNacionalTransferencia;
                        row["BancoOriExt"] = BancoOrigenExtranjeroTransferencia;
                        row["CtaDest"] = CuentaDestinoTransferencia;
                        row["BancoDestNal"] = BancoDestinoNacionalTransferencia;
                        row["BancoDestExt"] = BancoDestinoExtranjeroTransferencia;
                        row["Fecha"] = FechaTransferencia;
                        row["Benef"] = BeneficiarioTransferencia;
                        row["RFC"] = RFCTransferencia;
                        row["Monto"] = MontoTransferencia;
                        row["Moneda"] = MonedaTransferencia;
                        row["TipCamb"] = TipodeCambioTransferencia;
                        row["Clave"] = Clave;

                        dtTransferencias.Rows.Add(row);
                    }

                    //VHJC Si la poliza de la transferencia no existe en las polizas ya cargadas se marca el registro en rojo
                    if (!ExistePolizaTransaccion)
                    {
                        for (int i = 0; i < dgvTransferencias.Columns.Count; i++)
                        {
                            dgvTransferencias.Rows[RegistroAgregado].Cells[i].Style.BackColor = System.Drawing.Color.Red;
                            dgvTransferencias.Rows[RegistroAgregado].Cells[i].Style.SelectionBackColor = System.Drawing.Color.Red;
                            dgvTransferencias.Rows[RegistroAgregado].Cells[i].Style.ForeColor = System.Drawing.Color.Black;
                            dgvTransferencias.Rows[RegistroAgregado].Cells[i].Style.SelectionForeColor = System.Drawing.Color.Black;
                        }
                    }

                    if (ExisteTransferencia)
                    {
                        for (int i = 0; i < dgvTransferencias.Columns.Count; i++)
                        {
                            dgvTransferencias.Rows[RegistroAgregado].Cells[i].Style.BackColor = System.Drawing.Color.Yellow;
                            dgvTransferencias.Rows[RegistroAgregado].Cells[i].Style.SelectionBackColor = System.Drawing.Color.Yellow;
                            dgvTransferencias.Rows[RegistroAgregado].Cells[i].Style.ForeColor = System.Drawing.Color.Black;
                            dgvTransferencias.Rows[RegistroAgregado].Cells[i].Style.SelectionForeColor = System.Drawing.Color.Black;
                        }
                    }

                    if (!codigoBanco1OK)
                    {
                        dgvTransferencias.Rows[RegistroAgregado].Cells[3].Style.BackColor = System.Drawing.Color.Maroon;
                        dgvTransferencias.Rows[RegistroAgregado].Cells[3].Style.ForeColor = System.Drawing.Color.White;
                    }

                    if (!codigoBanco2OK)
                    {
                        dgvTransferencias.Rows[RegistroAgregado].Cells[6].Style.BackColor = System.Drawing.Color.Maroon;
                        dgvTransferencias.Rows[RegistroAgregado].Cells[6].Style.ForeColor = System.Drawing.Color.White;
                    }

                    if (!codigoMonedaOK)
                    {
                        dgvTransferencias.Rows[RegistroAgregado].Cells[12].Style.BackColor = System.Drawing.Color.Orange;
                        dgvTransferencias.Rows[RegistroAgregado].Cells[12].Style.ForeColor = System.Drawing.Color.White;
                    }

                }

                txtReader.Close();
                txtReader.Dispose();

            }
            catch (Exception ex)
            {
                LogErrores.WriteLog("Error en la carga del archivo de Transferencias.", ex);

                Cargado = false;
                Error = ex.Message;
            }

            if (Transferencias.Keys.Count > 0)
            {
                cargarTransferenciasYaGuardadas();
            }

            Guardado = false;

            Cursor.Current = Cursors.Default;

            return Cargado;
        }
		private bool verificaExistePolizaTransaccion(string Poliza, string NumeroCuenta) {
			bool Existe = false;

            DataRow[] drTransacciones = dtTransacciones.Select("Numero_Poliza='" + Poliza + "' AND Cuenta = '" + NumeroCuenta + "'");

            if (drTransacciones.Count() > 0)
                Existe = true;

			return Existe;
		}
		private void cmdGuardar_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            string SQL = string.Empty;

            if (validaTransferencia())
            {
                if (DataBaseSQL.RegistrarTransferencias(dtTransferencias))
                {
                    Guardado = true;
                    General.muestraMensaje("Los datos de las transferencias se han guardado con exito.");
                }
                else
                {
                    Guardado = false;
                    General.muestraMensaje("Ocurrio un error al tratar de guardar los datos de las transferencias.");
                    Transferencias.Clear();
                }
            }

            GC.Collect();

            Cursor = Cursors.Default;
		}

		//VHJC Funcion que valida que los datos de las Transferencias esten completos y correctos
		private bool validaTransferencia() {
			bool Valida = true;
			bool ExistenNuevos = false;

			foreach(DataGridViewRow dgvrTransferencia in dgvTransferencias.Rows) {
				if(!bool.Parse(dgvrTransferencia.Cells["ExistePoliza"].Value.ToString())) {
					General.muestraMensaje("La Póliza " + dgvrTransferencia.Cells["NumeroPoliza"].Value.ToString() + " no contiene una Transaccion para la Cuenta " + dgvrTransferencia.Cells["CuentaContablePoliza"].Value.ToString() + " en las Pólizas ya cargadas para este Ejercicio / Periodo, favor de validar.");
					Valida = false;
					dgvTransferencias.CurrentCell = dgvrTransferencia.Cells["NumeroPoliza"];
					return Valida;
				} else if(!bool.Parse(dgvrTransferencia.Cells["YaGuardado"].Value.ToString())) {
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
				General.muestraMensaje("No existe ninguna Transferencia nueva a relacionar con las Pólizas, favor de validar.");
				Valida = false;
			}

			return Valida;
		}

		private void cmdCancelar_Click(object sender, EventArgs e) 
        {
            if (!Guardado)
            {
                if (General.muestraMensajePregunta("¿Esta seguro de salir sin guardar los datos de las Transferencias de las Pólizas?") == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
		}

		private void dgvTransferencias_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e) {
			DataGridViewRow dgvRow = dgvTransferencias.Rows[e.RowIndex];

			if(dgvRow.Cells[0].Style.BackColor == System.Drawing.Color.FromArgb(0, 130, 153)) {

				Font fnt = new Font(dgvTransferencias.Font.FontFamily, 14, FontStyle.Bold, GraphicsUnit.Point);

				Rectangle rct = dgvTransferencias.GetRowDisplayRectangle(dgvRow.Index, true);
				rct.Height -= 1;

				SizeF s = e.Graphics.MeasureString("Transferencias ya guardadas", fnt);
				float lefts = (rct.Width / 2) - (s.Width / 2);
				float tops = rct.Top + ((rct.Height / 2) - (s.Height / 2));

				SolidBrush brush = new SolidBrush(System.Drawing.Color.FromArgb(0, 130, 153));
				e.Graphics.FillRectangle(brush, rct);

				e.Graphics.DrawString("Transferencias ya guardadas", fnt, Brushes.White, lefts, tops);
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
        private static DataTable CreateTableTransferencias()
        {
            DataTable dtTransferencias = new DataTable("Transferencias");

            DataColumn colIdPoliza = new DataColumn("ID_Poliza");
            DataColumn colNumPoliza = new DataColumn("Numero_Poliza");
            DataColumn colNumCuenta = new DataColumn("Cuenta_Poliza");
            DataColumn colCtaOri = new DataColumn("CtaOri");
            DataColumn colBancoOriNal = new DataColumn("BancoOriNal");
            DataColumn colBancoOriExt = new DataColumn("BancoOriExt");
            DataColumn colCtaDest = new DataColumn("CtaDest");
            DataColumn colBancoDestNal = new DataColumn("BancoDestNal");
            DataColumn colBancoDestExt = new DataColumn("BancoDestExt");
            DataColumn colFecha = new DataColumn("Fecha");
            DataColumn colBenef = new DataColumn("Benef");
            DataColumn colRFC = new DataColumn("RFC");
            DataColumn colMonto = new DataColumn("Monto");
            DataColumn colMoneda = new DataColumn("Moneda");
            DataColumn colTipCamb = new DataColumn("TipCamb");
            DataColumn colClave = new DataColumn("Clave");

            colIdPoliza.DataType = System.Type.GetType("System.Int32");
            colNumPoliza.DataType = System.Type.GetType("System.String");
            colNumCuenta.DataType = System.Type.GetType("System.String");
            colCtaOri.DataType = System.Type.GetType("System.String");
            colBancoOriNal.DataType = System.Type.GetType("System.String");
            colBancoOriExt.DataType = System.Type.GetType("System.String");
            colCtaDest.DataType = System.Type.GetType("System.String");
            colBancoDestNal.DataType = System.Type.GetType("System.String");
            colBancoDestExt.DataType = System.Type.GetType("System.String");
            colFecha.DataType = System.Type.GetType("System.DateTime");
            colBenef.DataType = System.Type.GetType("System.String");
            colRFC.DataType = System.Type.GetType("System.String");
            colMonto.DataType = System.Type.GetType("System.Decimal");
            colMoneda.DataType = System.Type.GetType("System.String");
            colTipCamb.DataType = System.Type.GetType("System.Decimal");
            colClave.DataType = System.Type.GetType("System.String");

            dtTransferencias.Columns.Add(colIdPoliza);
            dtTransferencias.Columns.Add(colNumPoliza);
            dtTransferencias.Columns.Add(colNumCuenta);
            dtTransferencias.Columns.Add(colCtaOri);
            dtTransferencias.Columns.Add(colBancoOriNal);
            dtTransferencias.Columns.Add(colBancoOriExt);
            dtTransferencias.Columns.Add(colCtaDest);
            dtTransferencias.Columns.Add(colBancoDestNal);
            dtTransferencias.Columns.Add(colBancoDestExt);
            dtTransferencias.Columns.Add(colFecha);
            dtTransferencias.Columns.Add(colBenef);
            dtTransferencias.Columns.Add(colRFC);
            dtTransferencias.Columns.Add(colMonto);
            dtTransferencias.Columns.Add(colMoneda);
            dtTransferencias.Columns.Add(colTipCamb);
            dtTransferencias.Columns.Add(colClave);

            return dtTransferencias;
        }


	}
}
