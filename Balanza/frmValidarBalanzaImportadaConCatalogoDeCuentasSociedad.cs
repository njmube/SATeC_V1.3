using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SATeC.Balanza {
	public partial class frmValidarBalanzaImportadaConCatalogoDeCuentasSociedad : Form {

		public string IDBalanza { get; set; }
		public string Ejercicio { get; set; }
		public string Periodo { get; set; }

		public frmValidarBalanzaImportadaConCatalogoDeCuentasSociedad() {
			InitializeComponent();
		}

		private void frmRelacionBalanzaCatalogoDeCuentasSociedad_Load(object sender, EventArgs e) {
			lblEjercicioPeriodoSeleccionado.Text = this.Ejercicio + " - " + this.Periodo;

			obtenerBalanza();
		}

		//VHJC Funcion que obtiene la Balanza seleccionada de la Sociedad
		private void obtenerBalanza() {
			Cursor.Current = Cursors.WaitCursor;

			tgvBalanza.Nodes.Clear();

			//VHJC Esta funcion usa un stored procedure (o Consulta guardada en Access) debido a su complejidad
			string SQL = "obtenerBalanza_RelacionCatalogoDeCuentas";

			OleDbDataReader drBalanza = Database.obtenRegistros(SQL, CommandType.StoredProcedure, this.IDBalanza);
			AdvancedDataGridView.TreeGridNode dataGridNodePadre = new AdvancedDataGridView.TreeGridNode();
			AdvancedDataGridView.TreeGridNode dataGridNodeHijo = new AdvancedDataGridView.TreeGridNode();

			AdvancedDataGridView.TreeGridNode dataGridNodeInsertado;

			//VHJC Por cada uno de los registros de la base de datos...
			while(drBalanza.Read()) {

				string Cuenta = drBalanza["Cuenta"].ToString();
				string DescripcionCuenta = drBalanza["DescripcionCuenta"].ToString();
				double SaldoInicial = double.Parse(drBalanza["SaldoInicial"].ToString());
				double Cargos = double.Parse(drBalanza["Cargos"].ToString());
				double Abonos = double.Parse(drBalanza["Abonos"].ToString());
				double SaldoFinal = double.Parse(drBalanza["SaldoFinal"].ToString());

				//VHJC Si el nivel es 1 quiere decir que es un padre
				if(drBalanza["Nivel"].ToString() == "1") {
					dataGridNodePadre = tgvBalanza.Nodes.Add(Cuenta, DescripcionCuenta, SaldoInicial, Cargos, Abonos, SaldoFinal);
					dataGridNodeInsertado = dataGridNodePadre;

					//VHJC si el nivel es diferente de "1" quiere decir que es un hijo
				} else {
					dataGridNodeHijo = dataGridNodePadre.Nodes.Add(Cuenta, DescripcionCuenta, SaldoInicial, Cargos, Abonos, SaldoFinal);
					dataGridNodeInsertado = dataGridNodeHijo;
				}

				//VHJC ...si la cuenta no tiene una relacion con el Catalogo de Cuentas
				if(!bool.Parse(drBalanza["ExisteEnCatalogo"].ToString())) {
					for(int i = 0; i < tgvBalanza.Columns.Count; i++) {
						dataGridNodeInsertado.Cells[i].Style.BackColor = Color.Red;
						dataGridNodeInsertado.Cells[i].Style.SelectionBackColor = Color.Red;
						dataGridNodeInsertado.Cells[i].Style.ForeColor = Color.Black;
						dataGridNodeInsertado.Cells[i].Style.SelectionForeColor = Color.Black;
					}
				}
			}

			drBalanza.Close();
			drBalanza.Dispose();

			Cursor.Current = Cursors.WaitCursor;
		}

		private void cmdValidar_Click(object sender, EventArgs e) {
			if(General.muestraMensajePregunta("¿Desea validar la Balanza con el Catálogo de Cuentas de la Sociedad?") == System.Windows.Forms.DialogResult.Yes) {
				validarBalanza();
			}
		}

		private void validarBalanza() {
			Cursor = Cursors.WaitCursor;
			bool Salir = false;

			string SQL = string.Empty;
			SQL = "UPDATE SATeC_Balanza ";
			SQL += "SET Fecha_Validacion = getdate(), ";
			SQL += "ID_Usuario_Validacion = " + General.UsuarioActual.ID;
			SQL += "WHERE ID_Balanza = " + this.IDBalanza + "\n";

			if(Database.ejecutaQuery(SQL, true)) {
				Salir = true;
				General.muestraMensaje("La Balanza se han validado con exito.");
			} else {
				General.muestraMensaje("Ocurrio un error al tratar de validar la Balanza: " + Database.Error);
			}

			Cursor = Cursors.Default;

			if(Salir)
				this.Close();
		}

		private void cmdCancelar_Click(object sender, EventArgs e) {
			this.Close();
		}


	}
}
