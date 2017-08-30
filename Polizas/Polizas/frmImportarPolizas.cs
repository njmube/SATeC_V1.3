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
	public partial class frmImportarPolizas : Form {



		private Dictionary<string, List<string>> Polizas = new Dictionary<string, List<string>>();
		private List<KeyValuePair<string, List<string>>> Transacciones = new List<KeyValuePair<string, List<string>>>();
		private double TotalDebe = 0;
		private double TotalHaber = 0;


        private DataTable dtPolizas = CreateTablePolizas();
	
		public frmImportarPolizas() {
			InitializeComponent();
		}

		private void frmImportarPolizas_Load(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;

			this.Dock = DockStyle.Fill;

			limpiaDatos();
			cargarEjerciciosPeriodos();

			Cursor = Cursors.Default;
		}

		//VHJC Funcion que limpia los datos de la forma
		private void limpiaDatos() {
			this.cmbEjercicioPeriodo.Items.Clear();
			this.chkPrimerFilaNombresColumnas.Checked = false;
			this.txtArchivoPolizas.Text = string.Empty;
			this.txtPathArchivoPolizas.Text = string.Empty;
			this.txtNoPolizas.Text = string.Empty;
			this.txtTotalDebe.Text = string.Empty;
			this.txtTotalHaber.Text = string.Empty;
			this.dgvPolizas.Rows.Clear();
		}

        //VHJC Funcion que carga los Ejercicios/Periodos existentes en la base de datos
        private void cargarEjerciciosPeriodos()
        {
            OleDbDataReader drEjerciciosPeriodos = Database.obtenRegistros("SELECT Ejercicio+' - '+Periodo+' '+Mes AS EjercicioPeriodo FROM SATeC_EjerciciosPeriodos ORDER BY Ejercicio+' - '+Periodo+' '+Mes");
            
            while (drEjerciciosPeriodos.Read())
            {
                ListItem itmEjercicioPeriodo = new ListItem(drEjerciciosPeriodos["EjercicioPeriodo"].ToString(), drEjerciciosPeriodos["EjercicioPeriodo"].ToString());
                cmbEjercicioPeriodo.Items.Add(itmEjercicioPeriodo);
            }
            
            drEjerciciosPeriodos.Close();
            drEjerciciosPeriodos.Dispose();
        }

        //VHJC Cuando se da clic en el boton "..." para seleccionar el archivo de las polizas
        private void cmdAbrirArchivo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos TXT(*.txt, *.csv)|*.txt; *.csv";
            openFileDialog1.Title = "Seleccione el archivo TXT de la Balanza";

            // VHJC Muestra la ventana para seleccionar el archivo
            // Si el usuario selecciona un archivo txt y le clic en el boton OK, se regresa el nombre del archivo para despues validarlo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtArchivoPolizas.Text = openFileDialog1.SafeFileName;
                txtPathArchivoPolizas.Text = openFileDialog1.FileName;

                string Error = string.Empty;

                General.cambiaMensajeStatus(this, "Cargando Pólizas desde el archivo TXT...");
                if (!cargaArchivoPolizasTXT(out Error))
                {
                    General.muestraMensaje("Ocurrio un error al cargar el archivo TXT de las Pólizas.\n" + Error);
                }
                General.cambiaMensajeStatus(this, "");
            }

            Cursor.Current = Cursors.Default;
        }

		//VHJC Funcion que carga el contenido de archivo TXT al grid
		private bool cargaArchivoPolizasTXT(out string Error) {
			Cursor.Current = Cursors.WaitCursor;

			bool Cargado = true;
			Error = string.Empty;

			bool FirstRow = true;
			bool PrimerFilaNombresColumnas = chkPrimerFilaNombresColumnas.Checked;

			string NumeroPolizaAnterior = string.Empty;

			int NumeroPolizas = 0;
			TotalDebe = 0;
			TotalHaber = 0;

			try {

				Polizas.Clear();
				Transacciones.Clear();

				dgvPolizas.Rows.Clear();
				dgvTransacciones.Rows.Clear();

                

                using (TextFieldParser txtReader = new TextFieldParser(txtPathArchivoPolizas.Text, Encoding.Default))
                {
                    txtReader.TextFieldType = FieldType.Delimited;
                    txtReader.SetDelimiters(",");
                    txtReader.HasFieldsEnclosedInQuotes = true;

                    while (!txtReader.EndOfData)
                    {
                        //VHJC Se verifica la primer linea para ver si el archivo viene separado por TABS o por comas...
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

                        //VHJC Variable que va a contener los datos de cada renglon del archivo TXT
                        string[] Datos = txtReader.ReadFields();

                        DataRow row = dtPolizas.NewRow();
                        
                        row["tipo"] = int.Parse(Datos[0]);
                        row["numPoliza"] = int.Parse(Datos[1]);
                        row["fechaPoliza"] = DateTime.Parse(Datos[2]);
                        row["conceptoOperacion"] = Datos[3].ToString();
                        row["numCuenta"] = int.Parse(Datos[4]);
                        row["idTransaccion"] = int.Parse(Datos[5]);
                        row["concepto"] = Datos[6].ToString();

                        if(!String.IsNullOrEmpty(Datos[7]))
                            row["debe"] = decimal.Parse(Datos[7].ToString());

                        if (!String.IsNullOrEmpty(Datos[8]))
                            row["haber"] = decimal.Parse(Datos[8].ToString());
                        
                        row["modena"] = Datos[9].ToString();

                        if (!String.IsNullOrEmpty(Datos[10]))
                            row["tipoCambio"] = decimal.Parse(Datos[10].ToString());

                        dtPolizas.Rows.Add(row);

                        //VHJC Las Polizas tienen 4 datos
                        string IDTipoPoliza = Datos[0];
                        string TipoPoliza = ((TipoPoliza)int.Parse(IDTipoPoliza)).ToString();
                        string NumeroPoliza = Datos[1];
                        string FechaPoliza = Datos[2];
                        string ConceptoPoliza = Datos[3].Replace("\"", "");

                        //VHJC La llave es el Tipo de Poliza + Numero de Poliza
                        string LlavePoliza = IDTipoPoliza + "-" + NumeroPoliza;

                        //VHJC Si la llave es nueva...
                        if (!Polizas.ContainsKey(LlavePoliza))
                        {
                            //VHJC ...Se agrega el registro de la Poliza
                            List<string> DatosPoliza = new List<string>();
                            DatosPoliza.Add(TipoPoliza);
                            DatosPoliza.Add(FechaPoliza);
                            DatosPoliza.Add(ConceptoPoliza);

                            Polizas.Add(LlavePoliza, DatosPoliza);

                            NumeroPolizas++;
                        }

                        //VHJC Las Transacciones tienen 7 datos
                        string CuentaTransaccion = Datos[4];
                        string IDTransaccion = Datos[5];
                        string ConceptoTransaccion = Datos[6];
                        double DebeTransaccion = double.Parse(Datos[7] == string.Empty ? "0" : Datos[7]);
                        double HaberTransaccion = double.Parse(Datos[8] == string.Empty ? "0" : Datos[8]);
                        string MonedaTransaccion = Datos[9];
                        double TipoCambioTransaccion = double.Parse(Datos[10] == string.Empty ? "1" : Datos[10]);

                        List<string> DatosTransaccion = new List<string>();
                        DatosTransaccion.Add(CuentaTransaccion);
                        DatosTransaccion.Add(IDTransaccion);
                        DatosTransaccion.Add(ConceptoTransaccion);
                        DatosTransaccion.Add(DebeTransaccion.ToString());
                        DatosTransaccion.Add(HaberTransaccion.ToString());
                        DatosTransaccion.Add(MonedaTransaccion);
                        DatosTransaccion.Add(TipoCambioTransaccion.ToString());

                        Transacciones.Add(new KeyValuePair<string, List<string>>(LlavePoliza, DatosTransaccion));

                        //int iTransaccion = dgvTransacciones.Rows.Add(NumeroPoliza, CuentaTransaccion, IDTransaccion, ConceptoTransaccion, DebeTransaccion, HaberTransaccion, MonedaTransaccion, TipoCambioTransaccion);
                        //dgvTransacciones.Rows[iTransaccion].Visible = false;

                        TotalDebe += DebeTransaccion;
                        TotalHaber += HaberTransaccion;
                    }
                }

                DataView viewPolizas = new DataView(dtPolizas);
                DataTable dtPolizasHeader = viewPolizas.ToTable(true, "tipo", "numPoliza", "fechaPoliza", "conceptoOperacion");


				foreach(string LlavePoliza in Polizas.Keys) {
					string[] DatosLlavePoliza = LlavePoliza.Split('-');
					string IDTipoPoliza = DatosLlavePoliza[0];
					string NumeroPoliza = DatosLlavePoliza[1];

					//VHJC ...Se agrega el registro de la Poliza
					List<string> DatosPoliza = Polizas[LlavePoliza];
					string TipoPoliza = DatosPoliza[0];
					string FechaPoliza = DatosPoliza[1];
					string ConceptoPoliza = DatosPoliza[2];

					dgvPolizas.Rows.Add(IDTipoPoliza, TipoPoliza, NumeroPoliza, FechaPoliza, ConceptoPoliza);
				}

				dgvPolizas_CellClick(dgvPolizas, new DataGridViewCellEventArgs(0, 0));

				txtNoPolizas.Text = NumeroPolizas.ToString();
				txtTotalDebe.Text = TotalDebe.ToString("#,##0.00;(#,##0.00)");
				txtTotalHaber.Text = TotalHaber.ToString("#,##0.00;(#,##0.00)");

				dgvPolizas_CellClick(dgvPolizas, new DataGridViewCellEventArgs(0, 0));

			} catch(Exception ex) {
				Cargado = false;
				Error = ex.Message;
			}

			Cursor.Current = Cursors.Default;

			return Cargado;
		}

		//VHJC Cuando se da clic en un registro de Poliza se muestran las transacciones relacionadas
		private void dgvPolizas_CellClick(object sender, DataGridViewCellEventArgs e) {
			if(e.RowIndex > -1) {
				string IDTipoPoliza = dgvPolizas.CurrentRow.Cells["IDTipoPoliza"].Value.ToString();
				string NumeroPoliza = dgvPolizas.CurrentRow.Cells["NumeroPoliza"].Value.ToString();
				string LlavePoliza = IDTipoPoliza + "-" + NumeroPoliza;

				var TransaccionesPoliza = Transacciones.Where(kvp => kvp.Key == LlavePoliza).Select(kvp => kvp.Value);

				dgvTransacciones.Rows.Clear();

				foreach(List<string> TransaccionPoliza in TransaccionesPoliza) {
					string NumeroPolizaTransaccion = NumeroPoliza;
					string CuentaTransaccion = TransaccionPoliza[0];
					string IDTransaccion = TransaccionPoliza[1];
					string ConceptoTransaccion = TransaccionPoliza[2];
					double DebeTransaccion = double.Parse(TransaccionPoliza[3]);
					double HaberTransaccion = double.Parse(TransaccionPoliza[4]);
					string MonedaTransaccion = TransaccionPoliza[5];
					double TipoCambioTransaccion = double.Parse(TransaccionPoliza[6]);

					dgvTransacciones.Rows.Add(NumeroPolizaTransaccion, CuentaTransaccion, IDTransaccion, ConceptoTransaccion, DebeTransaccion, HaberTransaccion, MonedaTransaccion, TipoCambioTransaccion);
				}
			}
		}

		//VHJC Cuando se da clic en el boton Guardar
		private void cmdGuardar_Click(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;

			string SQL = string.Empty;
			bool Salir = false;

			//VHJC Si los datos de las Polizas estan completos y correctos..
			if(validaPolizas()) {
				General.cambiaMensajeStatus(this, "Generando script para guardar los datos de las Pólizas en la base de datos...");
				//VHJC ...se guarda la informacion de las Polizas
				string[] EjercicioPeriodo = ((ListItem)cmbEjercicioPeriodo.SelectedItem).Texto.Split('-');
				string Ejercicio = EjercicioPeriodo[0].Trim();
				string Periodo = EjercicioPeriodo[1].Trim().Substring(0, 2);

				SQL = "INSERT INTO SATeC_Polizas (ID_Sociedad, Ejercicio, Periodo, Fecha_Importacion, ID_Usuario_Importacion) VALUES(";
				SQL += General.ID_SociedadSeleccionada + ", ";
				SQL += "'" + Ejercicio + "', ";
				SQL += "'" + Periodo + "', ";
				SQL += "getdate(), ";
				SQL += General.UsuarioActual.ID + ")\n";

				SQL += "DECLARE @ID_Poliza int = @@IDENTITY\n";

				Console.WriteLine("Comienza el script para las Transacciones" + DateTime.Now);

				//VHJC Se guardan todos los registros de las Polizas
				foreach(DataGridViewRow dgvrPoliza in dgvPolizas.Rows) 
                {
					string IDTipoPoliza = dgvrPoliza.Cells["IDTipoPoliza"].Value.ToString();
					string Poliza_Numero = dgvrPoliza.Cells["NumeroPoliza"].Value.ToString();
					string LlavePoliza = IDTipoPoliza + "-" + Poliza_Numero;

					SQL += "INSERT INTO SATeC_Polizas_Polizas (ID_Poliza, Tipo_Poliza, Numero_Poliza, Fecha_Poliza, Concepto) VALUES(";
					SQL += "@ID_Poliza";
					SQL += ", '" + dgvrPoliza.Cells["IDTipoPoliza"].Value + "'";
					SQL += ", '" + dgvrPoliza.Cells["NumeroPoliza"].Value + "'";
					SQL += ", '" + dgvrPoliza.Cells["FechaPoliza"].Value + "'";
					SQL += ", '" + General.revisaDatoSQL(dgvrPoliza.Cells["ConceptoPoliza"].Value.ToString()) + "'";
					SQL += ")\n";

					//VHJC Se guardan todos los registros de las Transacciones aplicables a la Poliza
					var TransaccionesPoliza = Transacciones.Where(kvp => kvp.Key == LlavePoliza).Select(kvp => kvp.Value);
					
                    foreach(List<string> TransaccionPoliza in TransaccionesPoliza) 
                    {
						SQL += "INSERT INTO SATeC_Polizas_Transacciones (ID_Poliza, Tipo_Poliza, Numero_Poliza, Cuenta, ID_Transaccion, Concepto, Debe, Haber, Moneda, TipoCambio) VALUES(";
						SQL += "@ID_Poliza";
						SQL += ", '" + IDTipoPoliza + "'";
						SQL += ", '" + Poliza_Numero + "'";
						SQL += ", '" + TransaccionPoliza[0] + "'";
						SQL += ", " + TransaccionPoliza[1] + "";
						SQL += ", '" + General.revisaDatoSQL(TransaccionPoliza[2]) + "'";
						SQL += ", " + TransaccionPoliza[3] + "";
						SQL += ", " + TransaccionPoliza[4] + "";
						SQL += ", '" + TransaccionPoliza[5] + "'";
						SQL += ", " + TransaccionPoliza[6] + "";
						SQL += ")\n";
					}
				}

				Console.WriteLine("Termina el script para las Transacciones" + DateTime.Now);

				General.cambiaMensajeStatus(this, "Guardando datos de las Pólizas en la base de datos...");

				if(Database.ejecutaQuery(SQL, true)) 
                {
					Salir = true;
					General.muestraMensaje("Los datos de las Pólizas se han guardado con exito.");
				} 
                else 
                {
					General.muestraMensaje("Ocurrio un error al tratar de guardar los datos de las Pólizas: " + Database.Error);
				}

				General.cambiaMensajeStatus(this, "");
			}

			Cursor = Cursors.Default;
			if(Salir)
				this.Close();
		}

		//VHJC Funcion que valida que los datos de las pólizas esten completos y correctos
		private bool validaPolizas() {
			bool Valida = true;

			General.cambiaMensajeStatus(this, "Validando Pólizas...");

			if(cmbEjercicioPeriodo.SelectedIndex == -1) {
				General.muestraMensaje("Debe seleccionar el Ejercicio / Periodo al que pertenecen las Pólizas.");
				cmbEjercicioPeriodo.Focus();
				cmbEjercicioPeriodo.DroppedDown = true;
				Valida = false;
			}else if(Math.Round(TotalDebe, 2) != Math.Round(TotalHaber, 2)) {
				General.muestraMensaje("El total de cargos es diferente al total de abonos, favor de validar.");
				Valida = false;
			}

			General.cambiaMensajeStatus(this, "");

			return Valida;
		}

		private void cmdCheques_Click(object sender, EventArgs e) {
			frmImportarCheques ImportarCheques = new frmImportarCheques();
			ImportarCheques.ShowDialog();
		}

		private void cmdCerrar_Click(object sender, EventArgs e) {
			if(General.muestraMensajePregunta("¿Esta seguro de salir sin guardar los datos de las Pólizas?") == DialogResult.Yes) {
				this.Close();
			}
        }

        #region Nueva Implementacion

        private static DataTable CreateTablePolizas()
        {
            DataTable dtPolizas = new DataTable();

            DataColumn colTipo = new DataColumn("tipo");
            DataColumn colNumPoliza = new DataColumn("numPoliza");
            DataColumn colFechaPoliza = new DataColumn("fechaPoliza");
            DataColumn colConceptoOperacion = new DataColumn("conceptoOperacion");
            DataColumn colNumCuenta = new DataColumn("numCuenta");
            DataColumn colIdTransaccion = new DataColumn("idTransaccion");
            DataColumn colConcepto = new DataColumn("concepto");
            DataColumn colDebe = new DataColumn("debe");
            DataColumn colHaber = new DataColumn("haber");
            DataColumn colMoneda = new DataColumn("modena");
            DataColumn colTipoCambio = new DataColumn("tipoCambio");

            colTipo.DataType = System.Type.GetType("System.Int32");
            colNumPoliza.DataType = System.Type.GetType("System.Int32");
            colFechaPoliza.DataType = System.Type.GetType("System.DateTime");
            colConceptoOperacion.DataType = System.Type.GetType("System.String");
            colNumCuenta.DataType = System.Type.GetType("System.Int32");
            colIdTransaccion.DataType = System.Type.GetType("System.Int32");
            colConcepto.DataType = System.Type.GetType("System.String");
            colDebe.DataType = System.Type.GetType("System.Decimal");
            colHaber.DataType = System.Type.GetType("System.Decimal");
            colMoneda.DataType = System.Type.GetType("System.String");
            colTipoCambio.DataType = System.Type.GetType("System.Decimal");

            dtPolizas.Columns.Add(colTipo);
            dtPolizas.Columns.Add(colNumPoliza);
            dtPolizas.Columns.Add(colFechaPoliza);
            dtPolizas.Columns.Add(colConceptoOperacion);
            dtPolizas.Columns.Add(colNumCuenta);
            dtPolizas.Columns.Add(colIdTransaccion);
            dtPolizas.Columns.Add(colConcepto);
            dtPolizas.Columns.Add(colDebe);
            dtPolizas.Columns.Add(colHaber);
            dtPolizas.Columns.Add(colMoneda);
            dtPolizas.Columns.Add(colTipoCambio);

            return dtPolizas;
        }

        #endregion Nueva Implementacion

    }
}
