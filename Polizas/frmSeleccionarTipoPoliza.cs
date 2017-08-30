using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SATeC.Polizas
{
    public partial class frmSeleccionarTipoPoliza : Form
    {
        public string TipoPoliza { get; set; }

        public frmSeleccionarTipoPoliza()
        {
            InitializeComponent();
        }

        private void frmSeleccionarTipoPoliza_Load(object sender, EventArgs e)
        {
            CargarTipoPolizas();
        }
        private void CargarTipoPolizas()
        {
            cmbTipoPoliza.Items.Add(new ListItem("0", "Todas"));
            cmbTipoPoliza.Items.Add(new ListItem("1", "Ingresos"));
            cmbTipoPoliza.Items.Add(new ListItem("2", "Egresos"));
            cmbTipoPoliza.Items.Add(new ListItem("3", "Diario"));

            cmbTipoPoliza.SelectedIndex = 0;
        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            if (cmbTipoPoliza.SelectedItem != null)
            {
                this.TipoPoliza = ((ListItem)cmbTipoPoliza.SelectedItem).Valor;
                this.Close();
            }
            else
            {
                this.TipoPoliza = string.Empty;
                General.muestraMensaje("Debe seleccionar el Tipo de Poliza a Exportar");
            }
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.TipoPoliza = string.Empty;
        }
    }
}
