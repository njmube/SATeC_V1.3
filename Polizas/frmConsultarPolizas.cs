using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace SATeC.Polizas {
	public partial class frmConsultarPolizas : Form {

		public TipoConsultaPolizasImportadas ConsultaPolizasImportadas { set; get; }

		public frmConsultarPolizas() {
			InitializeComponent();
		}

		private void frmConsultarPolizas_Load(object sender, EventArgs e) {
			this.Dock = DockStyle.Fill;

			switch(ConsultaPolizasImportadas) {
				case TipoConsultaPolizasImportadas.ImportarDatosComplementarios:
					lblModulo.Text = "Importar Datos Complementarios de Pólizas";
					dgvPolizasImportadas.Columns["FechaConversionXML"].Visible = false;
					dgvPolizasImportadas.Columns["UsuarioConversionXML"].Visible = false;
					break;
				case TipoConsultaPolizasImportadas.Importadas:
					dgvPolizasImportadas.Columns["FechaConversionXML"].Visible = false;
					dgvPolizasImportadas.Columns["UsuarioConversionXML"].Visible = false;
					break;
				case TipoConsultaPolizasImportadas.ConvertidasXML:
					lblModulo.Text = "Consultar Pólizas en formato XML";
					break;
			}

			cargarPolizasImportadas();
		}

		//VHJC Funcion que carga las polizas importadas
		private void cargarPolizasImportadas() {
			Cursor.Current = Cursors.WaitCursor;
			General.cambiaMensajeStatus(this, "Cargando Pólizas Importadas...");

			dgvPolizasImportadas.Rows.Clear();

			int TipoConsulta = (int)this.ConsultaPolizasImportadas;

			string[] Parametros = { General.ID_SociedadSeleccionada.ToString(), TipoConsulta.ToString() };
			OleDbDataReader drPolizasImportadas = Database.obtenRegistros("obtenerPolizasImportadas", CommandType.StoredProcedure, Parametros);
			while(drPolizasImportadas.Read()) {

				Periodo Periodo;
				Enum.TryParse(drPolizasImportadas["Periodo"].ToString(), out Periodo);

				DataGridViewRow dgvrPolizaImportada = new DataGridViewRow();
				DataGridViewTextBoxCell cllIDPolizaImportada = new DataGridViewTextBoxCell();
				DataGridViewTextBoxCell cllEjercicio = new DataGridViewTextBoxCell();
				DataGridViewTextBoxCell cllPeriodo = new DataGridViewTextBoxCell();
				DataGridViewTextBoxCell cllFechaImportacion = new DataGridViewTextBoxCell();
				DataGridViewTextBoxCell cllUsuarioImportacion = new DataGridViewTextBoxCell();
				DataGridViewTextBoxCell cllFechaConversion = new DataGridViewTextBoxCell();
				DataGridViewTextBoxCell cllUsuarioConversion = new DataGridViewTextBoxCell();
				DataGridViewImageCell cllBorrar = new DataGridViewImageCell();

				cllIDPolizaImportada.Value = drPolizasImportadas["ID_Poliza"].ToString();
				cllEjercicio.Value = drPolizasImportadas["Ejercicio"].ToString();
				cllPeriodo.Value = drPolizasImportadas["Periodo"].ToString() + " " + Periodo.ToString();
				cllFechaImportacion.Value = drPolizasImportadas["Fecha_Importacion"].ToString();
				cllUsuarioImportacion.Value = drPolizasImportadas["Usuario_Importacion"].ToString();
				cllFechaConversion.Value = drPolizasImportadas["Fecha_Conversion"].ToString();
				cllUsuarioConversion.Value = drPolizasImportadas["Usuario_Conversion"].ToString();

				dgvrPolizaImportada.Cells.Add(cllIDPolizaImportada);
				dgvrPolizaImportada.Cells.Add(cllEjercicio);
				dgvrPolizaImportada.Cells.Add(cllPeriodo);
				dgvrPolizaImportada.Cells.Add(cllFechaImportacion);
				dgvrPolizaImportada.Cells.Add(cllUsuarioImportacion);
				dgvrPolizaImportada.Cells.Add(cllFechaConversion);
				dgvrPolizaImportada.Cells.Add(cllUsuarioConversion);
				dgvrPolizaImportada.Cells.Add(cllBorrar);

				dgvPolizasImportadas.Rows.Add(dgvrPolizaImportada);
			}

			drPolizasImportadas.Close();
			drPolizasImportadas.Dispose();

			General.cambiaMensajeStatus(this, "");
			Cursor.Current = Cursors.Default;
		}

        private void dgvPolizasImportadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dgvPolizasImportadas.Columns["Borrar"].Index)
            {
                if (General.muestraMensajePregunta("Esta accion borrara todos los registros asociados a estas Pólizas.\nEsta seguro de borrar las Pólizas del ejercicio " + dgvPolizasImportadas.Rows[e.RowIndex].Cells["Ejercicio"].Value.ToString() + " periodo " + dgvPolizasImportadas.Rows[e.RowIndex].Cells["Periodo"].Value.ToString() + "?") == System.Windows.Forms.DialogResult.Yes)
                {
                    borrarPolizas();
                    cargarPolizasImportadas();
                }
            }
            else
                if (e.RowIndex > -1 && e.ColumnIndex == dgvPolizasImportadas.Columns["ExportarXLS"].Index)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    General.cambiaMensajeStatus(this, "Exportando Pólizas a XLSX...");

                    ExportTo(General.ID_SociedadSeleccionada.ToString(), dgvPolizasImportadas.Rows[e.RowIndex].Cells["Ejercicio"].Value.ToString(), dgvPolizasImportadas.Rows[e.RowIndex].Cells["Periodo"].Value.ToString(), "xlsx", "0");

                    General.cambiaMensajeStatus(this, "");
                    Cursor.Current = Cursors.Default;
                }
                else
                    if (e.RowIndex > -1 && e.ColumnIndex == dgvPolizasImportadas.Columns["ExportarPDF"].Index)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        General.cambiaMensajeStatus(this, "Exportando Pólizas a PDF...");

                        ExportTo(General.ID_SociedadSeleccionada.ToString(), dgvPolizasImportadas.Rows[e.RowIndex].Cells["Ejercicio"].Value.ToString(), dgvPolizasImportadas.Rows[e.RowIndex].Cells["Periodo"].Value.ToString(), "pdf", "0");

                        General.cambiaMensajeStatus(this, "");
                        Cursor.Current = Cursors.Default;
                    }
                    else
                        if (e.RowIndex > -1 && e.ColumnIndex == dgvPolizasImportadas.Columns["ReporteCuentas"].Index)
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            General.cambiaMensajeStatus(this, "Exportando Reporte Cuentas a XLSX...");

                            ExportTo(General.ID_SociedadSeleccionada.ToString(), dgvPolizasImportadas.Rows[e.RowIndex].Cells["Ejercicio"].Value.ToString(), dgvPolizasImportadas.Rows[e.RowIndex].Cells["Periodo"].Value.ToString(), "xlsx", "1");

                            General.cambiaMensajeStatus(this, "");
                            Cursor.Current = Cursors.Default;
                        }
        }

		//VHJC Funcion que borra las Pólizas asociadas a un ejercicio / periodo
		private void borrarPolizas() {
			Cursor.Current = Cursors.WaitCursor;
			General.cambiaMensajeStatus(this, "Borrando datos de las Pólizas...");

			if(!Database.ejecutaQuery("borrarPolizas", CommandType.StoredProcedure, dgvPolizasImportadas.CurrentRow.Cells["ID_Poliza"].Value.ToString())) {
				General.muestraMensaje("Ocurrio un error al borrar las Pólizas del ejercicio " + dgvPolizasImportadas.CurrentRow.Cells["Ejercicio"].Value.ToString() + " periodo " + dgvPolizasImportadas.CurrentRow.Cells["Periodo"].Value.ToString() + ":\n" + Database.Error);
			}

			General.cambiaMensajeStatus(this, "");
			Cursor.Current = Cursors.Default;
		}

		private void dgvPolizasImportadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			if(e.RowIndex > -1) {
				switch(this.ConsultaPolizasImportadas) {
					case TipoConsultaPolizasImportadas.Importadas:
					case TipoConsultaPolizasImportadas.ImportarDatosComplementarios:
						frmValidarPolizas ValidarPolizas = new frmValidarPolizas();
						ValidarPolizas.IDPoliza = dgvPolizasImportadas.CurrentRow.Cells["ID_Poliza"].Value.ToString();
						ValidarPolizas.Ejercicio = dgvPolizasImportadas.CurrentRow.Cells["Ejercicio"].Value.ToString();
						ValidarPolizas.Periodo = dgvPolizasImportadas.CurrentRow.Cells["Periodo"].Value.ToString();

						if(this.ConsultaPolizasImportadas == TipoConsultaPolizasImportadas.ImportarDatosComplementarios)
							ValidarPolizas.FuncionalidadPolizas = TipoFuncionalidadPolizas.ImportarDatosComplementarios;
						else if(this.ConsultaPolizasImportadas == TipoConsultaPolizasImportadas.Importadas)
							ValidarPolizas.FuncionalidadPolizas = TipoFuncionalidadPolizas.ValidarPolizas;

						ValidarPolizas.ShowDialog(this);
						cargarPolizasImportadas();
						break;
					case TipoConsultaPolizasImportadas.ConvertidasXML:

                        GC.Collect();

						Comun.frmMostrarArchivoXML MostrarArchivoXML = new Comun.frmMostrarArchivoXML();
						MostrarArchivoXML.TipoXML = Comun.TipoMXL.Polizas;
						MostrarArchivoXML.IDXML = dgvPolizasImportadas.CurrentRow.Cells["ID_Poliza"].Value.ToString();
						MostrarArchivoXML.Ejercicio = dgvPolizasImportadas.CurrentRow.Cells["Ejercicio"].Value.ToString();
						MostrarArchivoXML.Periodo = dgvPolizasImportadas.CurrentRow.Cells["Periodo"].Value.ToString();
						MostrarArchivoXML.ShowDialog();
						break;
				}
			}
		}

		private void cmdCerrar_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void frmConsultarPolizas_FormClosing(object sender, FormClosingEventArgs e) {
			dgvPolizasImportadas.Dispose();
			this.Dispose(true);

			GC.Collect();
		}

        private void ExportTo(string ID_Sociedad, string Ejercicio, string Periodo, string extension, string tipoPoliza)
        {
            string directoryTemplate = string.Empty;

            try
            {
                string fileName = string.Empty;

                if(tipoPoliza.Equals("0"))
                    fileName = "Poliza_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                else
                    fileName = "PolizaCuentas_" + DateTime.Now.ToString("yyyyMMddHHmmss");

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo " + extension.ToUpper() + "|*." + extension;
                saveFileDialog.Title = "Descargar archivo " + extension.ToUpper();
                saveFileDialog.FileName = fileName;

                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    directoryTemplate = INI.Read("Repositorio", "Exportaciones");

                    ReportViewer ReportViewer1 = new ReportViewer();
                    ReportViewer1.ProcessingMode = ProcessingMode.Local;
                    ReportViewer1.Reset();
                    ReportViewer1.LocalReport.Dispose();
                    ReportViewer1.LocalReport.DataSources.Clear();

                    DataTable dtPoliza = null;
                    ReportDataSource dataSource = null;

                    if (tipoPoliza.Equals("0"))
                    {
                        ReportViewer1.LocalReport.ReportPath = directoryTemplate + @"\" + "Poliza.rdlc";
                        dtPoliza = Database.ExecuteDataTable("SATeC_GenerarReportePolizas", ID_Sociedad, Ejercicio, Periodo.Substring(0, 2));
                        dataSource = new ReportDataSource("dsPolizas", dtPoliza);
                    }
                    else
                    {
                        ReportViewer1.LocalReport.ReportPath = directoryTemplate + @"\" + "PolizaCuentas.rdlc";
                        dtPoliza = Database.ExecuteDataTable("SATeC_GenerarReportePolizasCuentas", ID_Sociedad, Ejercicio, Periodo.Substring(0, 2));
                        dataSource = new ReportDataSource("SATeC_DataSetPolizasCuentas", dtPoliza);
                    }
                    
                    ReportViewer1.LocalReport.DataSources.Add(dataSource);
                    ReportViewer1.LocalReport.Refresh();

                    Warning[] warnings;
                    string[] streamids;
                    string mimeType = string.Empty;
                    string encoding = string.Empty;
                    string ext = string.Empty;
                    string format = string.Empty;

                    if (extension.Equals("xlsx"))
                        format = "EXCELOPENXML";
                    else
                        format = "PDF";

                    byte[] bytes = ReportViewer1.LocalReport.Render(format, null, out mimeType, out encoding, out ext, out streamids, out warnings);

                    using (FileStream fs = File.Create(saveFileDialog.FileName))
                    {
                        fs.Write(bytes, 0, bytes.Length);
                    }

                    General.muestraMensaje("La Poliza ha sido Exportada Exitosamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo exportar la información. Intente mas tarde.");
                LogErrores.WriteLog(string.Format("Error en el metodo ExportTo ID_Sociedad={0}, Ejercicio = {1}, Periodo = {2}, extension = {3}, tipoPoliza = {4}, directoryTemplate = {5}", ID_Sociedad, Ejercicio, Periodo, extension, tipoPoliza, directoryTemplate), ex);
                throw (ex);
            }
        }
	}
}
