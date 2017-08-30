using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace SATeC.CatalogoDeCuentas {
    public partial class frmConsultarCatalogoDeCuentasSociedad : Form {
        public frmConsultarCatalogoDeCuentasSociedad() {
            InitializeComponent();
        }

        private bool ExpandirTodo { get; set; }

        private void frmConsultarCatalogoDeCuentasSociedad_Load(object sender, EventArgs e) {
            this.Dock = DockStyle.Fill;
            cargarCuentasSociedad();

            ExpandirTodo = true;
        }

        //VHJC Funcion que carga las cuentas de la Sociedad de acuerdo a sus Catalogos de Cuentas asociados
        private void cargarCuentasSociedad() {
            Cursor.Current = Cursors.WaitCursor;
            General.cambiaMensajeStatus(this, "Cargando Cuentas de la Sociedad " + General.Nombre_SociedadSeleccionada + "...");

            string SQL = "SELECT 1 AS Nivel, CCC.Cuenta AS CuentaPadre, CCC.Cuenta, CCC.DescripcionCuenta, CCC.Naturaleza\n";
            SQL += "FROM ((SATeC_CatalogoCuentas_Cuentas CCC\n";
            SQL += "LEFT JOIN SATeC_CatalogosCuentas CC ON CC.ID_CatalogoCuentas = CCC.ID_CatalogoCuentas)\n";
            SQL += "LEFT JOIN SATeC_Sociedades S ON S.ID_CatalogoCuentas = CC.ID_CatalogoCuentas)\n";
            SQL += "WHERE S.ID_Sociedad = " + General.ID_SociedadSeleccionada + "\n";
            SQL += "UNION\n";
            SQL += "SELECT 2 AS Nivel, CCCA.CuentaPadre, CCCA.CuentaAuxiliar AS Cuenta, CCCA.DescripcionCuentaAuxiliar, CCCA.Naturaleza\n";
            SQL += "FROM (((SATeC_CatalogoCuentasAuxiliares_CuentasAuxiliares CCCA\n";
            SQL += "LEFT JOIN SATeC_CatalogosCuentasAuxiliares CCA ON CCA.ID_CatalogoCuentasAuxiliares = CCCA.ID_CatalogoCuentasAuxiliares)\n";
            SQL += "LEFT JOIN SATeC_CatalogosCuentas CC ON CC.ID_CatalogoCuentas = CCA.ID_CatalogoCuentas)\n";
            SQL += "LEFT JOIN SATeC_Sociedades S ON S.ID_CatalogoCuentas = CC.ID_CatalogoCuentas)\n";
            SQL += "WHERE S.ID_Sociedad = " + General.ID_SociedadSeleccionada + "\n";
            SQL += "AND CCCA.CuentaPadre <> ''\n";
            SQL += "ORDER BY CuentaPadre, Nivel, Cuenta \n";


            tgvCatalogoCuentasSociedad.Nodes.Clear();

            OleDbDataReader drCuentasSociedad = Database.obtenRegistros(SQL);
            AdvancedDataGridView.TreeGridNode dataGridNodePadre = new AdvancedDataGridView.TreeGridNode();
            AdvancedDataGridView.TreeGridNode dataGridNodeHijo = new AdvancedDataGridView.TreeGridNode();

            while(drCuentasSociedad.Read()) {
                //VHJC Si el nivel es 1 quiere decir que es un padre
                if(drCuentasSociedad["Nivel"].ToString() == "1") {
                    dataGridNodePadre = tgvCatalogoCuentasSociedad.Nodes.Add(drCuentasSociedad["Cuenta"].ToString(), drCuentasSociedad["DescripcionCuenta"].ToString(), drCuentasSociedad["Naturaleza"].ToString());
                
                //VHJC si el nivel es diferente de "0" quiere decir que es un hijo
                } else {
                    dataGridNodeHijo = dataGridNodePadre.Nodes.Add(drCuentasSociedad["Cuenta"].ToString(), drCuentasSociedad["DescripcionCuenta"].ToString(), drCuentasSociedad["Naturaleza"].ToString());
                }
            }

            drCuentasSociedad.Close();
            drCuentasSociedad.Dispose();            

            General.cambiaMensajeStatus(this, "");
            Cursor.Current = Cursors.WaitCursor;
        }

        private void cmdCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cmdExpandir_Click(object sender, EventArgs e)
        {
            if (!ExpandirTodo)
            {
                foreach (AdvancedDataGridView.TreeGridNode node in tgvCatalogoCuentasSociedad.Nodes)
                {
                    if (node.IsExpanded)
                        node.Collapse();
                }

                cmdExpandir.Text = "&Expandir Todo";
                cmdExpandir.Image = global::SATeC.Properties.Resources.Aceptar_32x32;
                ExpandirTodo = true;
            }
            else
            {
                foreach (AdvancedDataGridView.TreeGridNode node in tgvCatalogoCuentasSociedad.Nodes)
                {
                    if (!node.IsExpanded)
                        node.Expand();
                }

                cmdExpandir.Text = "&Colapsar Todo";
                cmdExpandir.Image = global::SATeC.Properties.Resources.Cancelar_32x32;
                ExpandirTodo = false;
            }

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                string extension = "xls";
                string fileName = "CatalogoCuentasSociedad" + DateTime.Now.ToString("yyyyMMddHHmmss");

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

                    ReportViewer1.LocalReport.ReportPath = directoryTemplate + @"\" + "CatalogoSociedad.rdlc";

                    DataTable dtCatalogoSociedad = Database.ExecuteDataTable("SATeC_GenerarReporteCatalogoCuentasSociedad", General.ID_SociedadSeleccionada.ToString());

                    ReportDataSource dataSource = new ReportDataSource("dsCatalogoSociedad", dtCatalogoSociedad);
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

                    General.muestraMensaje("El Catalogo de Cuentas de la Sociedad ha sido Exportado Exitosamente!");
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        
    }
}
