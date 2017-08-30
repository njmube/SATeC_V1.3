using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using AdvancedDataGridView;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Microsoft.Reporting.WinForms;

namespace SATeC.Balanza {
	public partial class frmValidarBalanzaImportadaConCodigoAgrupadorSAT : Form {

		public string IDBalanza { get; set; }
		public string Ejercicio { get; set; }
		public string Periodo { get; set; }
		private int NumeroCuentas { get; set; }

		public frmValidarBalanzaImportadaConCodigoAgrupadorSAT() {
			InitializeComponent();
		}
		private void frmValidarBalanzaImportadaConCodigoAgrupadorSAT_Load(object sender, EventArgs e) {
			lblEjercicioPeriodoSeleccionado.Text = this.Ejercicio + " - " + this.Periodo;

			obtenerBalanza();
		}
		private void obtenerBalanza() 
        {
			Cursor.Current = Cursors.WaitCursor;
			tgvBalanza.Nodes.Clear();

            string SQL = "SATeC_GenerarBalanzaCuentasSAT";

			OleDbDataReader drBalanza = Database.obtenRegistros(SQL, CommandType.StoredProcedure, this.IDBalanza);
			AdvancedDataGridView.TreeGridNode dataGridNodePadre = new AdvancedDataGridView.TreeGridNode();

            while (drBalanza.Read())
            {
                string CodigoAgrupadorSAT = drBalanza["CodigoAgrupadorSAT"].ToString();
                string NombreCuentaSAT = drBalanza["NombreCuentaSAT"].ToString();
                decimal SaldoInicial = decimal.Parse(drBalanza["SaldoInicial"].ToString());
                decimal Cargos = decimal.Parse(drBalanza["Cargos"].ToString());
                decimal Abonos = decimal.Parse(drBalanza["Abonos"].ToString());
                decimal SaldoFinal = decimal.Parse(drBalanza["SaldoFinal"].ToString());

                dataGridNodePadre = tgvBalanza.Nodes.Add(CodigoAgrupadorSAT, NombreCuentaSAT, SaldoInicial, Cargos, Abonos, SaldoFinal, ExisteCuentaRelacionSAT);
            }

			drBalanza.Close();
			drBalanza.Dispose();

			SQL = "SELECT Cuenta, SaldoInicial, Cargos, Abonos, SaldoFinal FROM SATeC_Balanza_Detalle WHERE ID_Balanza = " + this.IDBalanza;

			drBalanza = Database.obtenRegistros(SQL);
			while(drBalanza.Read()) {
				NumeroCuentas++;

				string BalanzaCuenta = drBalanza["Cuenta"].ToString();
                decimal BalanzaSaldoInicial = decimal.Parse(drBalanza["SaldoInicial"].ToString());
                decimal BalanzaCargos = decimal.Parse(drBalanza["Cargos"].ToString());
                decimal BalanzaAbonos = decimal.Parse(drBalanza["Abonos"].ToString());
                decimal BalanzaSaldoFinal = decimal.Parse(drBalanza["SaldoFinal"].ToString());

				dgvBalanza.Rows.Add(BalanzaCuenta, BalanzaSaldoInicial, BalanzaCargos, BalanzaAbonos, BalanzaSaldoFinal);
			}

			drBalanza.Close();
			drBalanza.Dispose();

			Cursor.Current = Cursors.WaitCursor;
		}
        private void cmdValidar_Click(object sender, EventArgs e)
        {
            if (General.muestraMensajePregunta("¿Quiere convertir la Balanza a formato XML?") == System.Windows.Forms.DialogResult.Yes)
            {
                string[] EjercicioPeriodo = lblEjercicioPeriodoSeleccionado.Text.Split('-');
                string Ejercicio = EjercicioPeriodo[0].Trim();
                string Periodo = EjercicioPeriodo[1].Trim().Substring(0, 2);

                string existeCatalogoCuenta = Database.obtenerDato("DECLARE @ID_Sociedad smallint = " + General.ID_SociedadSeleccionada.ToString() + " SELECT ISNULL( ( SELECT MAX(ID_CatalogoDeCuentasImportado) FROM SATeC_CatalogosCuentasFormatoXML WHERE ID_Sociedad = @ID_Sociedad AND XML IS NOT NULL ) , 0) EXISTE");

                if (!existeCatalogoCuenta.Equals("0"))
                {
                    if (ConvertirBalanzaFormatoXML())
                    {

                    }
                }
                else
                {
                    General.muestraMensaje("La Balanza no puede ser convertida a XML por que no existe el catalogo de cuentas por asociar.");
                }
            }
        }
		private bool ConvertirBalanzaFormatoXML() {
			bool Convertido = true;

			string NombreArchivoGenerado = string.Empty;
			string Error = string.Empty;

			string XMLToDatabase;

			if(generarArchivoXMLBalanza(out XMLToDatabase, this.Ejercicio, this.Periodo)) 
            {
				if(guardarRegistroBaseDatos(XMLToDatabase, this.Ejercicio, this.Periodo, out Error)) {
					General.muestraMensaje("Se ha convertido con éxito la Balanza al formato XML requerido por el SAT.");
					this.Close();
				} else {
					General.muestraMensaje("Ocurrio un error al tratar de generar el archivo XML:\n" + Error);
					Convertido = false;
				}
			} else {
				General.muestraMensaje("Ocurrio un error al tratar de generar el archivo XML:\n" + NombreArchivoGenerado);
				Convertido = false;
			}
			return Convertido;
		}
		private bool generarArchivoXMLBalanza(out string XMLToDatabase, string Ejercicio, string Periodo) {
			bool Generado = true;
            string TipoEnvio = string.Empty;
            DateTime? FechaModBal = null;
			string Sello = string.Empty;
            string noCertificado = string.Empty;
            string Certificado = string.Empty;

            string SQL = "SELECT ID_Sociedad, TipoEnvio, FechaModBal, Sello, noCertificado, Certificado FROM SATeC_Balanzas WHERE ID_Balanza = " + this.IDBalanza;

			OleDbDataReader drBalanza = Database.obtenRegistros(SQL);

            while (drBalanza.Read())
            {
                TipoEnvio = drBalanza["TipoEnvio"].ToString();

                string fechaMod = drBalanza["FechaModBal"].ToString();

                if (!string.IsNullOrEmpty(fechaMod))
                    FechaModBal = DateTime.Parse(fechaMod);
            }

			drBalanza.Close();
			drBalanza.Dispose();

            Balanza balanza = new Balanza();
            balanza.Version = Database.obtenerDato("select valor from SATeC_Parametrizacion where clave = 'VERSIONXML' AND activo = 1");
            balanza.RFC = General.RFC_SociedadSeleccionada.Trim();
            balanza.Mes = Periodo.Substring(0, 2);
            balanza.Anio = int.Parse(Ejercicio);
            balanza.TipoEnvio = TipoEnvio;

            if (TipoEnvio.Equals("C"))
            {
                balanza.TipoEnvio = "N";
                balanza.FechaModBalSpecified = true;
                balanza.FechaModBal = FechaModBal.Value;
            }

            List<BalanzaCtas> listaCuentas = new List<BalanzaCtas>();

			foreach(DataGridViewRow dgvrCuentaBalanza in dgvBalanza.Rows) {

                BalanzaCtas detalleBalanza = new BalanzaCtas();
                detalleBalanza.NumCta = dgvrCuentaBalanza.Cells["BalanzaCuenta"].Value.ToString();
                detalleBalanza.SaldoIni = decimal.Parse(dgvrCuentaBalanza.Cells["BalanzaSaldoInicial"].Value.ToString());
                detalleBalanza.Debe = decimal.Parse(dgvrCuentaBalanza.Cells["BalanzaCargos"].Value.ToString());
                detalleBalanza.Haber = decimal.Parse(dgvrCuentaBalanza.Cells["BalanzaAbonos"].Value.ToString());
                detalleBalanza.SaldoFin = decimal.Parse(dgvrCuentaBalanza.Cells["BalanzaSaldoFinal"].Value.ToString());

                listaCuentas.Add(detalleBalanza);
			}

            balanza.Ctas = listaCuentas.ToArray();

            XmlSerializer ser = new XmlSerializer(typeof(Balanza));
            StringBuilder sb = new StringBuilder();

            using (XmlWriter writer = XmlWriter.Create(sb, new XmlWriterSettings()
            {
                Indent = true,
                OmitXmlDeclaration = false,
                Encoding = Encoding.UTF8
            }))
            {

                XmlSerializerNamespaces xmlNameSpace = new XmlSerializerNamespaces();
                xmlNameSpace.Add("BCE", "www.sat.gob.mx/esquemas/ContabilidadE/1_1/BalanzaComprobacion");
                xmlNameSpace.Add("schemaLocation", "www.sat.gob.mx/esquemas/ContabilidadE/1_1/BalanzaComprobacion http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/BalanzaComprobacion/BalanzaComprobacion_1_1.xsd");
                xmlNameSpace.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

                ser.Serialize(writer, balanza, xmlNameSpace);
            }

            sb.Replace(Encoding.Unicode.WebName, Encoding.UTF8.WebName, 0, 56);
            sb.Replace("utf-8", "UTF-8");
            sb.Replace("xmlns:schemaLocation=", "xsi:schemaLocation=");

            XMLToDatabase = sb.ToString();

            GC.Collect();

			return Generado;
		}
		private bool guardarRegistroBaseDatos(string XMLToDatabase, string Ejercicio, string Periodo, out string Error) {
			bool Guardado = true;
			Error = string.Empty;

			string SQL = "UPDATE SATeC_Balanzas SET";
			SQL += " Fecha_Conversion = getdate()";
			SQL += ", ID_Usuario_Conversion = " + General.UsuarioActual.ID;
			SQL += ", XML = '" + XMLToDatabase + "'";
			SQL += " WHERE ID_Balanza = " + this.IDBalanza;

			if(!Database.ejecutaQuery(SQL, false)) {
				Guardado = false;
				Error = Database.Error;
			}

			return Guardado;
		}

		private void cmdCancelar_Click(object sender, EventArgs e) {
			this.Close();
		}

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                string extension = "xls";
                string fileName = "BalanzaSAT_" + DateTime.Now.ToString("yyyyMMddHHmmss");

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo " + extension.ToUpper() + "|*." + extension;
                saveFileDialog.Title = "Descargar archivo " + extension.ToUpper();
                saveFileDialog.FileName = fileName;

                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string directoryTemplate = INI.Read("Repositorio", "Exportaciones");

                    ReportViewer ReportViewer1 = new ReportViewer();
                    ReportViewer1.ProcessingMode = ProcessingMode.Local;
                    ReportViewer1.Reset();
                    ReportViewer1.LocalReport.Dispose();
                    ReportViewer1.LocalReport.DataSources.Clear();

                    ReportViewer1.LocalReport.ReportPath = directoryTemplate + @"\" + "BalanzaSAT.rdlc";

                    DataTable dtBalanza = Database.ExecuteDataTable("SATeC_GenerarBalanzaCuentasSAT", this.IDBalanza);

                    ReportDataSource dataSource = new ReportDataSource("dsBalanzaSAT", dtBalanza);
                    ReportViewer1.LocalReport.DataSources.Add(dataSource);
                    ReportViewer1.LocalReport.Refresh();

                    Warning[] warnings;
                    string[] streamids;
                    string mimeType = string.Empty;
                    string encoding = string.Empty;
                    string ext = string.Empty;
                    string format = string.Empty;

                    if (extension.Equals("xls"))
                        format = "EXCEL";
                    else
                        format = "PDF";

                    byte[] bytes = ReportViewer1.LocalReport.Render(format, null, out mimeType, out encoding, out ext, out streamids, out warnings);

                    using (FileStream fs = File.Create(saveFileDialog.FileName))
                    {
                        fs.Write(bytes, 0, bytes.Length);
                    }

                    General.muestraMensaje("La Balanza SAT ha sido Exportada Exitosamente!");
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

	}
}
