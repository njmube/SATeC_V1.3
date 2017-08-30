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

namespace SATeC.CatalogoDeCuentas {
	public partial class frmConsultarCatalogosFormatoXML : Form {

		public frmConsultarCatalogosFormatoXML() {
			InitializeComponent();
		}

		private void frmVerificarCatalogosFormatoXML_Load(object sender, EventArgs e) {
			this.Dock = DockStyle.Fill;

			cargarCatalogosDeCuentasImportados();
		}

		//VHJC Funcion que carga los Catalogos de Cuentas Importados y Convertidos a XML para la sociedad
		private void cargarCatalogosDeCuentasImportados() {
			Cursor.Current = Cursors.WaitCursor;
			General.cambiaMensajeStatus(this, "Cargando Catálogos de Cuentas de la Sociedad " + General.Nombre_SociedadSeleccionada + " importados y convertidos a XML...");


			dgvCatalogosImportados.Rows.Clear();
			string[] Parametros = { General.ID_SociedadSeleccionada.ToString() };
			OleDbDataReader drCatalogosDeCuentasImportados = Database.obtenRegistros("obtenerCatalogosDeCuentasImportados", CommandType.StoredProcedure, Parametros);

			while(drCatalogosDeCuentasImportados.Read()) {
				string ID_CatalogoDeCuentasImportado = drCatalogosDeCuentasImportados["ID_CatalogoDeCuentasImportado"].ToString();
				string Ejercicio = drCatalogosDeCuentasImportados["Ejercicio"].ToString();
				string Periodo = drCatalogosDeCuentasImportados["Periodo"].ToString();
				string FechaImportacion = drCatalogosDeCuentasImportados["FechaImportacion"].ToString();
				string UsuarioImportacion = drCatalogosDeCuentasImportados["UsuarioImportacion"].ToString();
				string FechaConversion = drCatalogosDeCuentasImportados["FechaConversion"].ToString();
				string UsuarioConversion = drCatalogosDeCuentasImportados["UsuarioConversion"].ToString();
                string Actualizado = drCatalogosDeCuentasImportados["Actualizado"].ToString();

                dgvCatalogosImportados.Rows.Add(ID_CatalogoDeCuentasImportado, Ejercicio, Periodo, FechaImportacion, UsuarioImportacion, FechaConversion, UsuarioConversion, Actualizado);
			}

			drCatalogosDeCuentasImportados.Close();
			drCatalogosDeCuentasImportados.Dispose();

			General.cambiaMensajeStatus(this, "");
			Cursor.Current = Cursors.WaitCursor;
		}

		private void dgvCatalogosImportados_CellClick(object sender, DataGridViewCellEventArgs e) {
			if(e.RowIndex > -1 && e.ColumnIndex == dgvCatalogosImportados.Columns["Borrar"].Index) {
				if(General.muestraMensajePregunta("Esta accion borrara todos los registros de Cuentas y Cuentas Auxiliares asociados a este Catálogo de Cuentas.\nEsta seguro de borrar el Catálogo de Cuentas del ejercicio " + dgvCatalogosImportados.Rows[e.RowIndex].Cells["Ejercicio"].Value.ToString() + " periodo " + dgvCatalogosImportados.Rows[e.RowIndex].Cells["Periodo"].Value.ToString() + "?") == System.Windows.Forms.DialogResult.Yes) {
					borrarCatalogoDeCuentas();

					cargarCatalogosDeCuentasImportados();
				}
			}
            else
                if (e.RowIndex > -1 && e.ColumnIndex == dgvCatalogosImportados.Columns["ExportarXLS"].Index)
                {
                    ExportTo(General.ID_SociedadSeleccionada.ToString(), "xls");
                }
                else
                    if (e.RowIndex > -1 && e.ColumnIndex == dgvCatalogosImportados.Columns["ExportarPDF"].Index)
                    {
                        ExportTo(General.ID_SociedadSeleccionada.ToString(), "pdf");
                    }
		}

		//VHJC Funcion que borra un Catalogo de Cuentas
		private void borrarCatalogoDeCuentas() {
			Cursor.Current = Cursors.WaitCursor;
			General.cambiaMensajeStatus(this, "Borrando Catálogo de Cuentas...");

			if(!Database.ejecutaQuery("borrarCatalogoDeCuentas", CommandType.StoredProcedure, dgvCatalogosImportados.CurrentRow.Cells["ID_CatalogoDeCuentasImportado"].Value.ToString())) {
				General.muestraMensaje("Ocurrio un error al borrar el Catálogo de Cuentas del ejercicio " + dgvCatalogosImportados.CurrentRow.Cells["Ejercicio"].Value.ToString() + " periodo " + dgvCatalogosImportados.CurrentRow.Cells["Periodo"].Value.ToString() + ":\n" + Database.Error);
			}

			General.cambiaMensajeStatus(this, "");
			Cursor.Current = Cursors.Default;
		}

		private void dgvCatalogosImportados_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			if(e.RowIndex > -1) {
				Comun.frmMostrarArchivoXML MostrarArchivoXML = new Comun.frmMostrarArchivoXML();
				MostrarArchivoXML.TipoXML = Comun.TipoMXL.CatalogoDeCuentasSociedad;
				MostrarArchivoXML.IDXML = dgvCatalogosImportados.CurrentRow.Cells["ID_CatalogoDeCuentasImportado"].Value.ToString();
				MostrarArchivoXML.Ejercicio = dgvCatalogosImportados.CurrentRow.Cells["Ejercicio"].Value.ToString();
				MostrarArchivoXML.Periodo = dgvCatalogosImportados.CurrentRow.Cells["Periodo"].Value.ToString();

				MostrarArchivoXML.ShowDialog(this);
			}
		}
        private void ExportTo(string ID_Sociedad, string extension)
        {
            try
            {
                string fileName = "CatalogoCuentas_" + DateTime.Now.ToString("yyyyMMddHHmmss");

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

                    ReportViewer1.LocalReport.ReportPath = directoryTemplate + @"\" + "CatalogoCuentas.rdlc";

                    DataTable dtCatalogoCuentas = Database.ExecuteDataTable("obtenerCuentasSociedad_RelacionSAT", ID_Sociedad);

                    ReportDataSource dataSource = new ReportDataSource("dsCatalogoCuentas", dtCatalogoCuentas);
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

                    General.muestraMensaje("El Catalogo de Cuentas ha sido Exportado Exitosamente!");
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

		private void cmdCerrar_Click(object sender, EventArgs e) {
			this.Close();
		}

	}
}
