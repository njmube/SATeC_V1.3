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
using Microsoft.Reporting.WinForms;

namespace SATeC.Balanza {
	public partial class frmConsultarBalanzasImportadas : Form {

		public TipoConsultaBalanzaImportada TipoConsultaPolizasImportadas { get; set; }

		public frmConsultarBalanzasImportadas() {
			InitializeComponent();
		}

		private void frmConsultarBalanzasImportadasNoConvertidasXML_Load(object sender, EventArgs e) {
			this.Dock = DockStyle.Fill;

			string Consulta = string.Empty;

			switch(TipoConsultaPolizasImportadas) {
				case SATeC.TipoConsultaBalanzaImportada.ConCatalogoDeCuentasSociedad:
					lblModulo.Text = "Catálogo de Cuentas de la Sociedad";
					dgvBalanzasImportadas.Columns["FechaValidacion"].Visible = false;
					dgvBalanzasImportadas.Columns["UsuarioValidacion"].Visible = false;
					dgvBalanzasImportadas.Columns["FechaConversionXML"].Visible = false;
					dgvBalanzasImportadas.Columns["UsuarioConversionXML"].Visible = false;
					break;
				case SATeC.TipoConsultaBalanzaImportada.ConCodigoAgrupadorSAT:
					lblModulo.Text = "Código Agrupador del SAT";
					dgvBalanzasImportadas.Columns["FechaConversionXML"].Visible = false;
					dgvBalanzasImportadas.Columns["UsuarioConversionXML"].Visible = false;
					break;
				case SATeC.TipoConsultaBalanzaImportada.ConFormatoXML:
					lblModulo.Text = "Consultar Balanzas Importadas Convertidas a Formato XML";
					break;
			}

			cargarBalanzasImportadas();
		}

		//VHJC Funcion que carga las balanzas importadas que aun no se han convertido a XML
		private void cargarBalanzasImportadas() {
			Cursor.Current = Cursors.WaitCursor;
			General.cambiaMensajeStatus(this, "Cargando Balanzas Importadas...");

			dgvBalanzasImportadas.Rows.Clear();

			int TipoConsulta = (int)this.TipoConsultaPolizasImportadas;

			string[] Parametros = { General.ID_SociedadSeleccionada.ToString(), TipoConsulta.ToString() };
			OleDbDataReader drBalanzasImportadas = Database.obtenRegistros("obtenerBalanzasImportadas", CommandType.StoredProcedure, Parametros);
			while(drBalanzasImportadas.Read()) {

				Periodo Periodo;
				Enum.TryParse(drBalanzasImportadas["Periodo"].ToString(), out Periodo);

				DataGridViewRow dgvrBalanzaImportada = new DataGridViewRow();
				DataGridViewTextBoxCell cllIDBalanzaImportada = new DataGridViewTextBoxCell();
				DataGridViewTextBoxCell cllEjercicio = new DataGridViewTextBoxCell();
				DataGridViewTextBoxCell cllPeriodo = new DataGridViewTextBoxCell();
				DataGridViewTextBoxCell cllFechaImportacion = new DataGridViewTextBoxCell();
				DataGridViewTextBoxCell cllUsuarioImportacion = new DataGridViewTextBoxCell();
				DataGridViewTextBoxCell cllFechaConversion = new DataGridViewTextBoxCell();
				DataGridViewTextBoxCell cllUsuarioConversion = new DataGridViewTextBoxCell();
				DataGridViewImageCell cllBorrar = new DataGridViewImageCell();
                DataGridViewImageCell cllXLS = new DataGridViewImageCell();
                DataGridViewImageCell cllPDF = new DataGridViewImageCell();
                DataGridViewImageCell cllXLSSAT = new DataGridViewImageCell();

				cllIDBalanzaImportada.Value = drBalanzasImportadas["ID_Balanza"].ToString();
				cllEjercicio.Value = drBalanzasImportadas["Ejercicio"].ToString();
				cllPeriodo.Value = drBalanzasImportadas["Periodo"].ToString() + " " + Periodo.ToString();
				cllFechaImportacion.Value = drBalanzasImportadas["Fecha_Importacion"].ToString();
				cllUsuarioImportacion.Value = drBalanzasImportadas["Usuario_Importacion"].ToString();
				cllFechaConversion.Value = drBalanzasImportadas["Fecha_Conversion"].ToString();
				cllUsuarioConversion.Value = drBalanzasImportadas["Usuario_Conversion"].ToString();

				dgvrBalanzaImportada.Cells.Add(cllIDBalanzaImportada);
				dgvrBalanzaImportada.Cells.Add(cllEjercicio);
				dgvrBalanzaImportada.Cells.Add(cllPeriodo);
				dgvrBalanzaImportada.Cells.Add(cllFechaImportacion);
				dgvrBalanzaImportada.Cells.Add(cllUsuarioImportacion);
				dgvrBalanzaImportada.Cells.Add(cllFechaConversion);
				dgvrBalanzaImportada.Cells.Add(cllUsuarioConversion);
				dgvrBalanzaImportada.Cells.Add(cllBorrar);
                dgvrBalanzaImportada.Cells.Add(cllXLS);
                dgvrBalanzaImportada.Cells.Add(cllPDF);
                dgvrBalanzaImportada.Cells.Add(cllXLSSAT);

				dgvBalanzasImportadas.Rows.Add(dgvrBalanzaImportada);
			}

			drBalanzasImportadas.Close();
			drBalanzasImportadas.Dispose();

			General.cambiaMensajeStatus(this, "");
			Cursor.Current = Cursors.Default;
		}

		private void cmdCerrar_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void dgvBalanzasImportadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			if(e.RowIndex > -1) {
				switch(this.TipoConsultaPolizasImportadas) {
					case SATeC.TipoConsultaBalanzaImportada.ConCatalogoDeCuentasSociedad:
						frmValidarBalanzaImportadaConCatalogoDeCuentasSociedad RelacionBalanzaCatalogoDeCuentasSociedad = new frmValidarBalanzaImportadaConCatalogoDeCuentasSociedad();
						RelacionBalanzaCatalogoDeCuentasSociedad.IDBalanza = dgvBalanzasImportadas.CurrentRow.Cells["ID_Balanza"].Value.ToString();
						RelacionBalanzaCatalogoDeCuentasSociedad.Ejercicio = dgvBalanzasImportadas.CurrentRow.Cells["Ejercicio"].Value.ToString();
						RelacionBalanzaCatalogoDeCuentasSociedad.Periodo = dgvBalanzasImportadas.CurrentRow.Cells["Periodo"].Value.ToString();
						RelacionBalanzaCatalogoDeCuentasSociedad.ShowDialog();
						break;
					case SATeC.TipoConsultaBalanzaImportada.ConCodigoAgrupadorSAT:
						frmValidarBalanzaImportadaConCodigoAgrupadorSAT RelacionBalanzaCodigoAgrupadorSAT = new frmValidarBalanzaImportadaConCodigoAgrupadorSAT();
						RelacionBalanzaCodigoAgrupadorSAT.IDBalanza = dgvBalanzasImportadas.CurrentRow.Cells["ID_Balanza"].Value.ToString();
						RelacionBalanzaCodigoAgrupadorSAT.Ejercicio = dgvBalanzasImportadas.CurrentRow.Cells["Ejercicio"].Value.ToString();
						RelacionBalanzaCodigoAgrupadorSAT.Periodo = dgvBalanzasImportadas.CurrentRow.Cells["Periodo"].Value.ToString();
						RelacionBalanzaCodigoAgrupadorSAT.ShowDialog();
						break;
					case SATeC.TipoConsultaBalanzaImportada.ConFormatoXML:
						Comun.frmMostrarArchivoXML MostrarArchivoXML = new Comun.frmMostrarArchivoXML();
						MostrarArchivoXML.TipoXML = Comun.TipoMXL.Balanza;
						MostrarArchivoXML.IDXML = dgvBalanzasImportadas.CurrentRow.Cells["ID_Balanza"].Value.ToString();
						MostrarArchivoXML.Ejercicio = dgvBalanzasImportadas.CurrentRow.Cells["Ejercicio"].Value.ToString();
						MostrarArchivoXML.Periodo = dgvBalanzasImportadas.CurrentRow.Cells["Periodo"].Value.ToString();
						MostrarArchivoXML.ShowDialog();
						break;
				}
			
				cargarBalanzasImportadas();
			}
		}

		private void dgvBalanzasImportadas_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
			if(e.RowIndex > -1 && e.ColumnIndex == dgvBalanzasImportadas.Columns["Borrar"].Index) 
            {
				if(General.muestraMensajePregunta("Esta accion borrara todos los registros asociados a este Balanza.\nEsta seguro de borrar la Balanza del ejercicio " + dgvBalanzasImportadas.Rows[e.RowIndex].Cells["Ejercicio"].Value.ToString() + " periodo " + dgvBalanzasImportadas.Rows[e.RowIndex].Cells["Periodo"].Value.ToString() + "?") == System.Windows.Forms.DialogResult.Yes) 
                {
					borrarBalanza();
					cargarBalanzasImportadas();
				}
			}
            else
                if (e.RowIndex > -1 && e.ColumnIndex == dgvBalanzasImportadas.Columns["ExportarXLS"].Index)
                {
                    ExportTo(General.ID_SociedadSeleccionada.ToString(), dgvBalanzasImportadas.Rows[e.RowIndex].Cells["Ejercicio"].Value.ToString(), dgvBalanzasImportadas.Rows[e.RowIndex].Cells["Periodo"].Value.ToString(), "xls");
                }
                else
                if (e.RowIndex > -1 && e.ColumnIndex == dgvBalanzasImportadas.Columns["ExportarPDF"].Index)
                {
                    ExportTo(General.ID_SociedadSeleccionada.ToString(), dgvBalanzasImportadas.Rows[e.RowIndex].Cells["Ejercicio"].Value.ToString(), dgvBalanzasImportadas.Rows[e.RowIndex].Cells["Periodo"].Value.ToString(), "pdf");
                }
                else
                    if (e.RowIndex > -1 && e.ColumnIndex == dgvBalanzasImportadas.Columns["ExportarXLSSAT"].Index)
                    {
                        ExportBalanzaSATExcel(dgvBalanzasImportadas.Rows[e.RowIndex].Cells["ID_Balanza"].Value.ToString());
                    }
		}

		//VHJC Funcion que borra una Balanza
		private void borrarBalanza() {
			Cursor.Current = Cursors.WaitCursor;
			General.cambiaMensajeStatus(this, "Borrando Balanza...");

			if(!Database.ejecutaQuery("borrarBalanza", CommandType.StoredProcedure, dgvBalanzasImportadas.CurrentRow.Cells["ID_Balanza"].Value.ToString())){
				General.muestraMensaje("Ocurrio un error al borrar la Balanza del ejercicio " + dgvBalanzasImportadas.CurrentRow.Cells["Ejercicio"].Value.ToString() + " periodo " + dgvBalanzasImportadas.CurrentRow.Cells["Periodo"].Value.ToString() + ":\n" + Database.Error);
			}

			General.cambiaMensajeStatus(this, "");
			Cursor.Current = Cursors.Default;
		}
        private void ExportTo(string ID_Sociedad, string Ejercicio, string Periodo, string extension)
        {
            try
            {
                string fileName = "Balanza_" + DateTime.Now.ToString("yyyyMMddHHmmss");

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

                    ReportViewer1.LocalReport.ReportPath = directoryTemplate + @"\" + "Balanza.rdlc";

                    DataTable dtBalanza = Database.ExecuteDataTable("SATeC_GenerarReporteBalanza", ID_Sociedad, Ejercicio, Periodo);

                    ReportDataSource dataSource = new ReportDataSource("dsBalanza", dtBalanza);
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

                    General.muestraMensaje("La Balanza ha sido Exportada Exitosamente!");
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        private void ExportBalanzaSATExcel(string ID_Balanza)
        {
            try
            {
                string fileName = "BalanzaSAT_" + DateTime.Now.ToString("yyyyMMddHHmmss");

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo XLS|*.xls";
                saveFileDialog.Title = "Descargar archivo xls";
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

                    DataTable dtBalanza = Database.ExecuteDataTable("SATeC_GenerarBalanzaCuentasSAT", ID_Balanza);

                    ReportDataSource dataSource = new ReportDataSource("dsBalanzaSAT", dtBalanza);
                    ReportViewer1.LocalReport.DataSources.Add(dataSource);
                    ReportViewer1.LocalReport.Refresh();

                    Warning[] warnings;
                    string[] streamids;
                    string mimeType = string.Empty;
                    string encoding = string.Empty;
                    string ext = string.Empty;
                    string format = string.Empty;
                    
                    format = "EXCEL";

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
