﻿using System;
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
	public partial class frmImportarComprobantes : Form {

		public string IDPoliza { set; get; }
		public string EjercicioPeriodo { set; get; }

        public DataTable dtPolizas = new DataTable();
        public DataTable dtTransacciones = new DataTable();

		public Dictionary<string, List<string>> Polizas { set; get; }
		public Dictionary<string, List<string>> Comprobantes { set; get; }

		public bool Guardado = false;

        public DataTable dtComprobantes = CreateTableComprobantes();
        
        public DataTable dtCatalogoMonedasSAT = new DataTable();
        int totalCodigosMonedasNoValidos = 0;

		public frmImportarComprobantes() {
			InitializeComponent();
		}

		private void frmImportarComprobantes_Load(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;

			limpiaDatos();
			lblEjercicioPeriodoSeleccionado.Text = EjercicioPeriodo;
			cargarComprobantesYaGuardadas();
            CargarCatalogoMonedasSAT();

			Cursor = Cursors.Default;
		}
		private void limpiaDatos() 
        {
			this.chkPrimerFilaNombresColumnas.Checked = false;
			this.txtArchivoComprobantes.Text = string.Empty;
			this.txtPathArchivoComprobantes.Text = string.Empty;
			this.dgvComprobantes.Rows.Clear();
		}
		private void cargarComprobantesYaGuardadas() 
        {
			Cursor.Current = Cursors.WaitCursor;

            if (Comprobantes.Keys.Count > 0)
            {
                int RegistroEnBlanco = dgvComprobantes.Rows.Add("", "", "", "", "", "", "", "", true, true);

                for (int i = 0; i < 3; i++)
                {
                    dgvComprobantes.Rows[RegistroEnBlanco].Cells[i].Style.BackColor = System.Drawing.Color.FromArgb(0, 130, 153);
                    dgvComprobantes.Rows[RegistroEnBlanco].Cells[i].Style.SelectionBackColor = System.Drawing.Color.FromArgb(0, 130, 153);
                    dgvComprobantes.Rows[RegistroEnBlanco].Cells[i].Style.ForeColor = System.Drawing.Color.FromArgb(0, 130, 153);
                    dgvComprobantes.Rows[RegistroEnBlanco].Cells[i].Style.SelectionForeColor = System.Drawing.Color.FromArgb(0, 130, 153);
                }

                foreach (string LlaveComprobante in Comprobantes.Keys)
                {
                    string[] Datos = LlaveComprobante.Split('-');

                    string NumeroPolizaComprobante = Datos[0];
                    string NumeroCuentaComprobante = Datos[1];

                    List<string> DatosComprobante = Comprobantes[LlaveComprobante];

                    string UUID_CFDIComprobante = DatosComprobante[0];
                    string RFCComprobante = DatosComprobante[1];
                    double MontoTotalComprobante = double.Parse(DatosComprobante[2]);
                    string MonedaComprobante = DatosComprobante[3];
                    double TipodeCambioComprobante = double.Parse(DatosComprobante[4]);
                    string Clave = DatosComprobante[5];

                    dgvComprobantes.Rows.Add(NumeroPolizaComprobante, NumeroCuentaComprobante, UUID_CFDIComprobante, RFCComprobante, MontoTotalComprobante, MonedaComprobante, TipodeCambioComprobante, Clave, true, true);
                }
            }

			Cursor.Current = Cursors.Default;
		}
		private void cmdAbrirArchivo_Click(object sender, EventArgs e) 
        {
			Cursor.Current = Cursors.WaitCursor;

			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Filter = "Archivos TXT(*.txt, *.csv)|*.txt; *.csv";
			openFileDialog1.Title = "Seleccione el archivo TXT de los Comprobantes de las Pólizas";

			if(openFileDialog1.ShowDialog() == DialogResult.OK) {
				txtArchivoComprobantes.Text = openFileDialog1.SafeFileName;
				txtPathArchivoComprobantes.Text = openFileDialog1.FileName;

				string Error = string.Empty;

				if(!cargaArchivoTXTComprobantes(out Error)) {
					General.muestraMensaje("Ocurrio un error al cargar el archivo TXT de los Comprobantes de las Pólizas.\n" + Error);
				}
			}

			Cursor.Current = Cursors.Default;
		}
		private bool cargaArchivoTXTComprobantes(out string Error) 
        {
			Cursor.Current = Cursors.WaitCursor;

			bool Cargado = true;
			Error = string.Empty;

			bool FirstRow = true;
			bool PrimerFilaNombresColumnas = chkPrimerFilaNombresColumnas.Checked;

			string Separador = string.Empty;
			char[] separator = { ',' };

            dtComprobantes = CreateTableComprobantes();
            totalCodigosMonedasNoValidos = 0;

			try 
            {
				dgvComprobantes.Rows.Clear();

				TextFieldParser txtReader = new TextFieldParser(txtPathArchivoComprobantes.Text, Encoding.Default);
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

					if(PrimerFilaNombresColumnas) 
                    {
						txtReader.ReadLine();
						PrimerFilaNombresColumnas = false;
						continue;
					}

                    bool codigoMonedaOK = true;

					string[] DatosComprobante = txtReader.ReadFields();

                    string[] EjercicioPeriodo = lblEjercicioPeriodoSeleccionado.Text.Split('-');
                    string Ejercicio = EjercicioPeriodo[0].Trim();
                    string Periodo = EjercicioPeriodo[1].Trim().Substring(0, 2);

                    string ano = DatosComprobante[0].ToString();
                    string mes = DatosComprobante[1].ToString();

                    if (!(Ejercicio.Equals(ano) && Periodo.Equals(mes)))
                    {
                        General.muestraMensaje("El año y mes del Comprobante debe corresponder al periodo seleccionado. Favor de validar");
                        break;
                    }

                    List<string> listaTipoPolizas = new List<string>() { "1", "2", "3" };

                    string idTipoPoliza = DatosComprobante[2].Trim();

                    if (!listaTipoPolizas.Contains(idTipoPoliza))
                    {
                        General.muestraMensaje("El Tipo de Poliza identficado No es Valido. Solo se permiten los codigos: [1], [2] o [3]. Favor de corregir.");
                        break;
                    }

                    string NumeroPolizaComprobante = DatosComprobante[2] + DatosComprobante[3];
                    string NumeroCuentaComprobante = DatosComprobante[4];
					string UUID_CFDIComprobante = DatosComprobante[5];
                    string RFCComprobante = DatosComprobante[6];
					double MontoTotalComprobante = double.Parse(DatosComprobante[7]);
                    string MonedaComprobante = DatosComprobante[8];

                    if (!VerificarCodigoMoneda(MonedaComprobante))
                    {
                        codigoMonedaOK = false;
                        totalCodigosMonedasNoValidos++;
                    }

                    double TipodeCambioComprobante = double.Parse(DatosComprobante[9]);

                    string Clave = string.Empty;

                    if (DatosComprobante.Count() == 11)
                    {
                        Clave = DatosComprobante[10];
                    }

					string LlaveComprobante = NumeroPolizaComprobante + "-" + NumeroCuentaComprobante;

                    bool ExistePoliza = verificaExistePolizaTransaccion(NumeroPolizaComprobante, NumeroCuentaComprobante);

					bool ExisteCFDIYaGuardado = Comprobantes.ContainsKey(LlaveComprobante);

					int RegistroAgregado = dgvComprobantes.Rows.Add(
                          NumeroPolizaComprobante
                        , NumeroCuentaComprobante
						, UUID_CFDIComprobante
                        , RFCComprobante
						, MontoTotalComprobante
                        , MonedaComprobante
                        , TipodeCambioComprobante
                        , Clave
						, ExistePoliza
						, ExisteCFDIYaGuardado);

                    if (ExistePoliza && !ExisteCFDIYaGuardado)
                    {
                        DataRow row = dtComprobantes.NewRow();

                        row["ID_Poliza"] = this.IDPoliza;
                        row["Numero_Poliza"] = NumeroPolizaComprobante;
                        row["Numero_Cuenta"] = NumeroCuentaComprobante;
                        row["UUID_CFDI"] = UUID_CFDIComprobante;
                        row["RFC"] = RFCComprobante;
                        row["MontoTotal"] = MontoTotalComprobante;
                        row["Moneda"] = MonedaComprobante;
                        row["TipCamb"] = TipodeCambioComprobante;
                        row["Clave"] = Clave;

                        dtComprobantes.Rows.Add(row);
                    }

					if(!ExistePoliza) {
						for(int i = 0; i < dgvComprobantes.Columns.Count; i++) {
							dgvComprobantes.Rows[RegistroAgregado].Cells[i].Style.BackColor = System.Drawing.Color.Red;
							dgvComprobantes.Rows[RegistroAgregado].Cells[i].Style.SelectionBackColor = System.Drawing.Color.Red;
							dgvComprobantes.Rows[RegistroAgregado].Cells[i].Style.ForeColor = System.Drawing.Color.Black;
							dgvComprobantes.Rows[RegistroAgregado].Cells[i].Style.SelectionForeColor = System.Drawing.Color.Black;
						}
					}

					if(ExisteCFDIYaGuardado) {
						for(int i = 0; i < dgvComprobantes.Columns.Count; i++) {
							dgvComprobantes.Rows[RegistroAgregado].Cells[i].Style.BackColor = System.Drawing.Color.Yellow;
							dgvComprobantes.Rows[RegistroAgregado].Cells[i].Style.SelectionBackColor = System.Drawing.Color.Yellow;
							dgvComprobantes.Rows[RegistroAgregado].Cells[i].Style.ForeColor = System.Drawing.Color.Black;
							dgvComprobantes.Rows[RegistroAgregado].Cells[i].Style.SelectionForeColor = System.Drawing.Color.Black;
						}
					}

                    if (!codigoMonedaOK)
                    {
                        dgvComprobantes.Rows[RegistroAgregado].Cells[5].Style.BackColor = System.Drawing.Color.Orange;
                        dgvComprobantes.Rows[RegistroAgregado].Cells[5].Style.ForeColor = System.Drawing.Color.White;
                    }
				}

				txtReader.Close();
				txtReader.Dispose();

			} catch(Exception ex) {
				Cargado = false;
				Error = ex.Message;
			}

			if(Comprobantes.Keys.Count > 0) {
				cargarComprobantesYaGuardadas();
			}

			Cursor.Current = Cursors.Default;

			return Cargado;
		}
        private bool verificaExistePolizaTransaccion(string Poliza, string NumeroCuenta)
        {
            bool Existe = false;

            DataRow[] drTransacciones = dtTransacciones.Select("Numero_Poliza='" + Poliza + "' AND Cuenta = '" + NumeroCuenta + "'");

            if (drTransacciones.Count() > 0)
                Existe = true;

            return Existe;
        }
		private void cmdGuardar_Click(object sender, EventArgs e) 
        {
			Cursor = Cursors.WaitCursor;
			string SQL = string.Empty;

			if(validaComprobantes())
            {
                if (DataBaseSQL.RegistrarComprobantesNacionales(dtComprobantes))
                {
                    Guardado = true;
                    General.muestraMensaje("Los datos de los Comprobantes se han guardado con exito.");
                }
                else
                {
                    Guardado = false;
                    General.muestraMensaje("Ocurrio un error al tratar de guardar los datos de los Comprobantes.");
                    Comprobantes.Clear();
                }			
			}

            GC.Collect();

            Cursor = Cursors.Default;
		}
        private bool validaComprobantes()
        {
            bool Valida = true;
            int totalNoValidas = 0;
            int totalNuevos = 0;

            foreach (DataGridViewRow dgvrComprobante in dgvComprobantes.Rows)
            {
                if (!bool.Parse(dgvrComprobante.Cells["ExistePoliza"].Value.ToString()))
                    totalNoValidas++;
                else if (!bool.Parse(dgvrComprobante.Cells["YaGuardado"].Value.ToString()))
                    totalNuevos++;
            }

            if (totalCodigosMonedasNoValidos > 0)
            {
                General.muestraMensaje("Existen codigos de monedas no validos, favor de revisar.");
                Valida = false;
            }

            if (totalNoValidas > 0)
            {
                General.muestraMensaje("Existen Polizas No Validas. Favor de Verificar");
                Valida = false;
            }
            else
                if (totalNuevos == 0)
                {
                    General.muestraMensaje("No existe ningun Comprobante nuevo a relacionar con las Pólizas, favor de validar.");
                    Valida = false;
                }

            return Valida;
        }
		private void cmdCancelar_Click(object sender, EventArgs e) 
        {
            if (General.muestraMensajePregunta("¿Esta seguro de salir del Modulo de Comprobantes Nacional?") == DialogResult.Yes)
            {
                this.Close();
            }
		}
		private void dgvComprobantes_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e) {
			DataGridViewRow dgvRow = dgvComprobantes.Rows[e.RowIndex];

			if(dgvRow.Cells[0].Style.BackColor == System.Drawing.Color.FromArgb(0, 130, 153)) {

				Font fnt = new Font(dgvComprobantes.Font.FontFamily, 14, FontStyle.Bold, GraphicsUnit.Point);

				Rectangle rct = dgvComprobantes.GetRowDisplayRectangle(dgvRow.Index, true);
				rct.Height -= 1;

				SizeF s = e.Graphics.MeasureString("Comprobantes ya guardados", fnt);
				float lefts = (rct.Width /2) - (s.Width / 2);
				float tops = rct.Top + ((rct.Height / 2) - (s.Height / 2));

				SolidBrush brush = new SolidBrush(System.Drawing.Color.FromArgb(0, 130, 153));
				e.Graphics.FillRectangle(brush, rct);

				e.Graphics.DrawString("Comprobantes ya guardados", fnt, Brushes.White, lefts, tops);
			}
        }
        private static DataTable CreateTableComprobantes()
        {
            DataTable dtComprobantes = new DataTable("Comprobantes");

            DataColumn colIdPoliza = new DataColumn("ID_Poliza");
            DataColumn colNumPoliza = new DataColumn("Numero_Poliza");
            DataColumn colNumCuenta = new DataColumn("Numero_Cuenta");
            DataColumn colUUID = new DataColumn("UUID_CFDI");
            DataColumn colRFC = new DataColumn("RFC");
            DataColumn colMontoTotal = new DataColumn("MontoTotal");
            DataColumn colMoneda = new DataColumn("Moneda");
            DataColumn colTipoCambio = new DataColumn("TipCamb");
            DataColumn colClave = new DataColumn("Clave");

            colIdPoliza.DataType = System.Type.GetType("System.Int32");
            colNumPoliza.DataType = System.Type.GetType("System.String");
            colNumCuenta.DataType = System.Type.GetType("System.String");
            colUUID.DataType = System.Type.GetType("System.String");
            colRFC.DataType = System.Type.GetType("System.String");
            colMontoTotal.DataType = System.Type.GetType("System.Decimal");
            colMoneda.DataType = System.Type.GetType("System.String");
            colTipoCambio.DataType = System.Type.GetType("System.Decimal");
            colClave.DataType = System.Type.GetType("System.String");

            dtComprobantes.Columns.Add(colIdPoliza);
            dtComprobantes.Columns.Add(colNumPoliza);
            dtComprobantes.Columns.Add(colNumCuenta);
            dtComprobantes.Columns.Add(colUUID);
            dtComprobantes.Columns.Add(colRFC);
            dtComprobantes.Columns.Add(colMontoTotal);
            dtComprobantes.Columns.Add(colMoneda);
            dtComprobantes.Columns.Add(colTipoCambio);
            dtComprobantes.Columns.Add(colClave);

            return dtComprobantes;
        }
        private void CargarCatalogoMonedasSAT()
        {
            dtCatalogoMonedasSAT = Database.ExecuteDataTable("SATeC_ObtenerCatMonedasSAT");
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