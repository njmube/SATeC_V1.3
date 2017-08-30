using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SATeC.CatalogoDeCuentas {
	public partial class frmSeleccionarCuentaSATRelacionCuentasSociedad : Form {

		public bool CuentaSociedadEsPadre { get; set; }
		public bool CuentaSeleccionada { get; set; }
		public string CodigoAgrupadorCuentaSATSeleccionada { get; set; }
		public string CuentaSATSeleccionada { get; set; }

		public frmSeleccionarCuentaSATRelacionCuentasSociedad() {
			InitializeComponent();
		}

		private void frmSeleccionarCuentaSATRelacionCuentasSociedad_Load(object sender, EventArgs e) {
			cargarCatalogoCuentasSAT();
		}

		//VHJC Carga las cuentas del catalogo del SAT
		private void cargarCatalogoCuentasSAT() {
			Cursor.Current = Cursors.WaitCursor;

			tgvCatalogoCuentasSAT.Nodes.Clear();

			OleDbDataReader drCuentasExistentes = Database.obtenRegistros("SELECT Codigo_Agrupador, Codigo_Agrupador_Entero, Codigo_Agrupador_Decimal, Nombre_Cuenta FROM SATeC_CatalogoCuentasSAT ORDER BY Codigo_Agrupador_Entero, Codigo_Agrupador_Decimal");
			AdvancedDataGridView.TreeGridNode dataGridNodePadre = new AdvancedDataGridView.TreeGridNode();
			AdvancedDataGridView.TreeGridNode dataGridNodeHijo = new AdvancedDataGridView.TreeGridNode();

			//VHJC Por cada una de las cuentas existentes del SAT
			while(drCuentasExistentes.Read()) {
				//VHJC Si el codigo agrupador decimal es "0" quiere decir que es un padre
				if(drCuentasExistentes["Codigo_Agrupador_Decimal"].ToString() == "0") {
					dataGridNodePadre = tgvCatalogoCuentasSAT.Nodes.Add(drCuentasExistentes["Codigo_Agrupador"].ToString(), drCuentasExistentes["Nombre_Cuenta"].ToString(), true, false);
					if(drCuentasExistentes["Codigo_Agrupador"].ToString() == CodigoAgrupadorCuentaSATSeleccionada) {
						dataGridNodePadre.Selected = true;
						tgvCatalogoCuentasSAT.CurrentCell = dataGridNodePadre.Cells[0];
					}

				//VHJC si el codigo agrupador decimal es diferente de "0" quiere decir que es un hijo
				} else {
					dataGridNodeHijo = dataGridNodePadre.Nodes.Add(drCuentasExistentes["Codigo_Agrupador"].ToString(), drCuentasExistentes["Nombre_Cuenta"].ToString(),false, true);
					if(drCuentasExistentes["Codigo_Agrupador"].ToString() == CodigoAgrupadorCuentaSATSeleccionada) {
						dataGridNodePadre.Expand();
						dataGridNodeHijo.Selected = true;
						tgvCatalogoCuentasSAT.CurrentCell = dataGridNodeHijo.Cells[0];
					}
				}
			}

			drCuentasExistentes.Close();
			drCuentasExistentes.Dispose();

			Cursor.Current = Cursors.WaitCursor;
		}

		private void cmdGuardar_Click(object sender, EventArgs e) {
			if(tgvCatalogoCuentasSAT.SelectedRows.Count > 0) {
				DataGridViewRow dgvrCuentaSeleccionada = tgvCatalogoCuentasSAT.SelectedRows[0];

                CuentaSeleccionada = true;
                CodigoAgrupadorCuentaSATSeleccionada = dgvrCuentaSeleccionada.Cells["CodigoAgrupador"].Value.ToString();
                CuentaSATSeleccionada = dgvrCuentaSeleccionada.Cells["CodigoAgrupador"].Value.ToString() + " - " + dgvrCuentaSeleccionada.Cells["NombreCuenta"].Value.ToString();

                this.Close();

                //if(bool.Parse(dgvrCuentaSeleccionada.Cells["IsChild"].Value.ToString()) || CuentaSociedadEsPadre) {
                //    CuentaSeleccionada = true;
                //    CodigoAgrupadorCuentaSATSeleccionada = dgvrCuentaSeleccionada.Cells["CodigoAgrupador"].Value.ToString();
                //    CuentaSATSeleccionada = dgvrCuentaSeleccionada.Cells["CodigoAgrupador"].Value.ToString() + " - " + dgvrCuentaSeleccionada.Cells["NombreCuenta"].Value.ToString();

                //    this.Close();
                //} else {
                //    General.muestraMensaje("No puede seleccionar una Cuenta del SAT de primer nivel, favor de verificar.");
                //    tgvCatalogoCuentasSAT.Nodes[dgvrCuentaSeleccionada.Index].Expand();
                //}
			} else {
				General.muestraMensaje("Debe seleccionar una Cuenta del SAT, favor de verificar.");
			}
		}

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            CuentaSeleccionada = false;
            CodigoAgrupadorCuentaSATSeleccionada = string.Empty;
            CuentaSATSeleccionada = string.Empty;
            this.Close();
        }
		private void tgvCatalogoCuentasSAT_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			cmdGuardar.PerformClick();
		}

	}
}
