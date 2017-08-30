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
    public partial class frmConsultarCatalogoCuentasSAT : Form {
        public frmConsultarCatalogoCuentasSAT() {
            InitializeComponent();
        }

        private bool ExpandirTodo { get; set; }

        private void frmConsultarCatalogoCuentasSAT_Load(object sender, EventArgs e) {
            this.Dock = DockStyle.Fill;
            cargarCatalogoCuentasSAT();
            tgvCatalogoCuentasSAT.Columns["IDCuentaSAT"].Visible = false;
            ExpandirTodo = true;
        }

        //VHJC Carga las cuentas del catalogo del SAT
        private void cargarCatalogoCuentasSAT() {
            Cursor.Current = Cursors.WaitCursor;
            General.cambiaMensajeStatus(this, "");

            tgvCatalogoCuentasSAT.Nodes.Clear();

            OleDbDataReader drCuentasExistentes = Database.obtenRegistros("SELECT ID_CuentaSAT, Codigo_Agrupador, Codigo_Agrupador_Entero, Codigo_Agrupador_Decimal, Nombre_Cuenta FROM SATeC_CatalogoCuentasSAT ORDER BY Codigo_Agrupador_Entero, Codigo_Agrupador_Decimal");
            AdvancedDataGridView.TreeGridNode dataGridNodePadre = new AdvancedDataGridView.TreeGridNode();
            AdvancedDataGridView.TreeGridNode dataGridNodeHijo = new AdvancedDataGridView.TreeGridNode();

			//VHJC Por cada una de las cuentas existentes del SAT
            while(drCuentasExistentes.Read()) {
                //VHJC Si el codigo agrupador decimal es "0" quiere decir que es un padre
                if(drCuentasExistentes["Codigo_Agrupador_Decimal"].ToString() == "0") {
                    dataGridNodePadre = tgvCatalogoCuentasSAT.Nodes.Add(drCuentasExistentes["Codigo_Agrupador"].ToString(), drCuentasExistentes["Nombre_Cuenta"].ToString());
                //VHJC si el codigo agrupador decimal es diferente de "0" quiere decir que es un hijo
                }else {
                    dataGridNodeHijo = dataGridNodePadre.Nodes.Add(drCuentasExistentes["Codigo_Agrupador"].ToString(), drCuentasExistentes["Nombre_Cuenta"].ToString());
                }
            }

            drCuentasExistentes.Close();
            drCuentasExistentes.Dispose();

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
                foreach (AdvancedDataGridView.TreeGridNode node in tgvCatalogoCuentasSAT.Nodes)
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
                foreach (AdvancedDataGridView.TreeGridNode node in tgvCatalogoCuentasSAT.Nodes)
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
                string fileName = "CatalogoCuentasSAT" + DateTime.Now.ToString("yyyyMMddHHmmss");

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

                    ReportViewer1.LocalReport.ReportPath = directoryTemplate + @"\" + "CatalogoSAT.rdlc";

                    DataTable dtCatalogoSAT = Database.ExecuteDataTable("SELECT ID_CuentaSAT, Codigo_Agrupador, Codigo_Agrupador_Entero, Codigo_Agrupador_Decimal, Nombre_Cuenta FROM SATeC_CatalogoCuentasSAT ORDER BY Codigo_Agrupador_Entero, Codigo_Agrupador_Decimal");

                    ReportDataSource dataSource = new ReportDataSource("dsCatalogosSAT", dtCatalogoSAT);
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

                    General.muestraMensaje("El Catalogo del SAT ha sido Exportado Exitosamente!");
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
