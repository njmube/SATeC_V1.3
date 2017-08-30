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
using Microsoft.VisualBasic.FileIO;

namespace SATeC.Polizas
{
    public partial class frmImportarOtroMetodoPago : Form
    {
        public string IDPoliza { set; get; }
        public string EjercicioPeriodo { set; get; }

        public DataTable dtPolizas = new DataTable();
        public DataTable dtTransacciones = new DataTable();

        public Dictionary<string, List<string>> Polizas { set; get; }
        public Dictionary<string, List<string>> OtrosMetodosPago { set; get; }

        public bool Guardado = false;

        public DataTable dtCatalogoMetodosPagoSAT = new DataTable();
        public DataTable dtCatalogoMonedasSAT = new DataTable();

        int totalCodigosMetodosPagoNoValidos = 0;
        int totalCodigosMonedasNoValidos = 0;

        public DataTable dtMetodosPago = CreateTableMetodosPago();

        public frmImportarOtroMetodoPago()
        {
            InitializeComponent();
        }
        private void frmImportarOtroMetodoPago_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            limpiaDatos();
            lblEjercicioPeriodoSeleccionado.Text = EjercicioPeriodo;
            CargarOtrosMetodosPagoYaGuardadas();
            CargarCatalogoMetodosPagoSAT();
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
        private void CargarOtrosMetodosPagoYaGuardadas()
        {
            Cursor.Current = Cursors.WaitCursor;

            if (OtrosMetodosPago.Keys.Count > 0)
            {
                int RegistroEnBlanco = dgvComprobantes.Rows.Add("", "", "", "", "", "", "", "", "", "", true, true);

                for (int i = 0; i < 3; i++)
                {
                    dgvComprobantes.Rows[RegistroEnBlanco].Cells[i].Style.BackColor = System.Drawing.Color.FromArgb(0, 130, 153);
                    dgvComprobantes.Rows[RegistroEnBlanco].Cells[i].Style.SelectionBackColor = System.Drawing.Color.FromArgb(0, 130, 153);
                    dgvComprobantes.Rows[RegistroEnBlanco].Cells[i].Style.ForeColor = System.Drawing.Color.FromArgb(0, 130, 153);
                    dgvComprobantes.Rows[RegistroEnBlanco].Cells[i].Style.SelectionForeColor = System.Drawing.Color.FromArgb(0, 130, 153);
                }

                foreach (string LlaveOtroMetodoPago in OtrosMetodosPago.Keys)
                {

                    string[] Datos = LlaveOtroMetodoPago.Split('-');

                    string NumeroPolizaComprobante = Datos[0];
                    string NumeroCuentaComprobante = Datos[1];

                    List<string> DatosComprobante = OtrosMetodosPago[LlaveOtroMetodoPago];

                    string MetPagoPol = DatosComprobante[0];
                    string Fecha = DatosComprobante[1];
                    string Benef = DatosComprobante[2];
                    string RFC = DatosComprobante[3];
                    double Monto = double.Parse(DatosComprobante[4]);
                    string Moneda = DatosComprobante[5];
                    double TipodeCambio = double.Parse(DatosComprobante[6]);
                    string Clave = DatosComprobante[7];

                    dgvComprobantes.Rows.Add(NumeroPolizaComprobante, NumeroCuentaComprobante, MetPagoPol, Fecha, Benef, RFC, Monto, Moneda, TipodeCambio, Clave, true, true);
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

            totalCodigosMetodosPagoNoValidos = 0;
            totalCodigosMonedasNoValidos = 0;
            dtMetodosPago = CreateTableMetodosPago();

            try
            {
                dgvComprobantes.Rows.Clear();

                TextFieldParser txtReader = new TextFieldParser(txtPathArchivoComprobantes.Text, Encoding.Default);
                txtReader.TextFieldType = FieldType.Delimited;
                txtReader.SetDelimiters(",");
                txtReader.HasFieldsEnclosedInQuotes = true;

                while (!txtReader.EndOfData)
                {
                    if (FirstRow)
                    {
                        string firstRow = txtReader.PeekChars(1000);

                        if (firstRow.Contains("\t"))
                            txtReader.SetDelimiters("\t");

                        FirstRow = false;
                    }

                    if (PrimerFilaNombresColumnas)
                    {
                        txtReader.ReadLine();
                        PrimerFilaNombresColumnas = false;
                        continue;
                    }

                    bool codigoMetodoPagoOK = true;
                    bool codigoMonedaOK = true;

                    string[] DatosComprobante = txtReader.ReadFields();

                    string[] EjercicioPeriodo = lblEjercicioPeriodoSeleccionado.Text.Split('-');
                    string Ejercicio = EjercicioPeriodo[0].Trim();
                    string Periodo = EjercicioPeriodo[1].Trim().Substring(0, 2);

                    string ano = DatosComprobante[0].ToString();
                    string mes = DatosComprobante[1].ToString();

                    if (!(Ejercicio.Equals(ano) && Periodo.Equals(mes)))
                    {
                        General.muestraMensaje("El año y mes del Otro Metodo de Pago debe corresponder al periodo seleccionado. Favor de validar");
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
                    string MetPagoPol = DatosComprobante[5];

                    if (!VerificarClaveMetodoPago(MetPagoPol))
                    {
                        codigoMetodoPagoOK = false;
                        totalCodigosMetodosPagoNoValidos++;
                    }

                    DateTime Fecha = DateTime.Parse(DatosComprobante[6]);
                    string Beneficiario = DatosComprobante[7];
                    string RFC = DatosComprobante[8];
                    double Monto = double.Parse(DatosComprobante[9]);
                    string Moneda = DatosComprobante[10];

                    if (!VerificarCodigoMoneda(Moneda))
                    {
                        codigoMonedaOK = false;
                        totalCodigosMonedasNoValidos++;
                    }

                    double TipodeCambio = double.Parse(DatosComprobante[11]);
                    string Clave = string.Empty;

                    if (DatosComprobante.Count() == 13)
                    {
                        Clave = DatosComprobante[12];
                    }

                    string LlaveComprobante = NumeroPolizaComprobante + "-" + NumeroCuentaComprobante;

                    bool ExistePoliza = verificaExistePolizaTransaccion(NumeroPolizaComprobante, NumeroCuentaComprobante);

                    bool ExisteCFDIYaGuardado = OtrosMetodosPago.ContainsKey(LlaveComprobante);

                    int RegistroAgregado = dgvComprobantes.Rows.Add(
                          NumeroPolizaComprobante
                        , NumeroCuentaComprobante
                        , MetPagoPol
                        , Fecha
                        , Beneficiario
                        , RFC
                        , Monto
                        , Moneda
                        , TipodeCambio
                        , Clave
                        , ExistePoliza
                        , ExisteCFDIYaGuardado);

                    if (ExistePoliza && !ExisteCFDIYaGuardado)
                    {
                        DataRow row = dtMetodosPago.NewRow();

                        row["ID_Poliza"] = this.IDPoliza;
                        row["Numero_Poliza"] = NumeroPolizaComprobante;
                        row["Numero_Cuenta"] = NumeroCuentaComprobante;
                        row["MetPagoPol"] = MetPagoPol;
                        row["Fecha"] = Fecha;
                        row["Benef"] = Beneficiario;
                        row["RFC"] = RFC;
                        row["Monto"] = Monto;
                        row["Moneda"] = Moneda;
                        row["TipCamb"] = TipodeCambio;
                        row["Clave"] = Clave;

                        dtMetodosPago.Rows.Add(row);
                    }

                    if (!ExistePoliza)
                    {
                        for (int i = 0; i < dgvComprobantes.Columns.Count; i++)
                        {
                            dgvComprobantes.Rows[RegistroAgregado].Cells[i].Style.BackColor = System.Drawing.Color.Red;
                            dgvComprobantes.Rows[RegistroAgregado].Cells[i].Style.SelectionBackColor = System.Drawing.Color.Red;
                            dgvComprobantes.Rows[RegistroAgregado].Cells[i].Style.ForeColor = System.Drawing.Color.Black;
                            dgvComprobantes.Rows[RegistroAgregado].Cells[i].Style.SelectionForeColor = System.Drawing.Color.Black;
                        }
                    }

                    if (ExisteCFDIYaGuardado)
                    {
                        for (int i = 0; i < dgvComprobantes.Columns.Count; i++)
                        {
                            dgvComprobantes.Rows[RegistroAgregado].Cells[i].Style.BackColor = System.Drawing.Color.Yellow;
                            dgvComprobantes.Rows[RegistroAgregado].Cells[i].Style.SelectionBackColor = System.Drawing.Color.Yellow;
                            dgvComprobantes.Rows[RegistroAgregado].Cells[i].Style.ForeColor = System.Drawing.Color.Black;
                            dgvComprobantes.Rows[RegistroAgregado].Cells[i].Style.SelectionForeColor = System.Drawing.Color.Black;
                        }
                    }

                    if (!codigoMetodoPagoOK)
                    {
                        dgvComprobantes.Rows[RegistroAgregado].Cells[2].Style.BackColor = System.Drawing.Color.Maroon;
                        dgvComprobantes.Rows[RegistroAgregado].Cells[2].Style.ForeColor = System.Drawing.Color.White;
                    }

                    if (!codigoMonedaOK)
                    {
                        dgvComprobantes.Rows[RegistroAgregado].Cells[7].Style.BackColor = System.Drawing.Color.Orange;
                        dgvComprobantes.Rows[RegistroAgregado].Cells[7].Style.ForeColor = System.Drawing.Color.White;
                    }

                }

                txtReader.Close();
                txtReader.Dispose();

            }
            catch (Exception ex)
            {
                Cargado = false;
                Error = ex.Message;
            }

            if (OtrosMetodosPago.Keys.Count > 0)
            {
                CargarOtrosMetodosPagoYaGuardadas();
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

            if (ValidaOtrosMetodosPago())
            {
                if (DataBaseSQL.RegistrarMetodosPago(dtMetodosPago))
                {
                    Guardado = true;
                    General.muestraMensaje("Los datos de los Otros Metodos de Pago se han guardado con exito.");
                }
                else
                {
                    Guardado = false;
                    General.muestraMensaje("Ocurrio un error al tratar de guardar los datos de los Otros Metodos de Pago");
                    OtrosMetodosPago.Clear();
                }
            }

            GC.Collect();

            Cursor = Cursors.Default;
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (General.muestraMensajePregunta("¿Esta seguro de salir del Modulo de Otros Metodos de Pago?") == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private bool ValidaOtrosMetodosPago()
        {
            bool Valida = true;
            bool ExistenNuevos = false;

            foreach (DataGridViewRow dgvrComprobante in dgvComprobantes.Rows)
            {
                if (!bool.Parse(dgvrComprobante.Cells["ExistePoliza"].Value.ToString()))
                {
                    General.muestraMensaje("La Póliza No." + dgvrComprobante.Cells["NumeroPoliza"].Value.ToString() + " no existe en las Pólizas ya cargadas para este Ejercicio / Periodo, favor de validar.");
                    Valida = false;
                    dgvComprobantes.CurrentCell = dgvrComprobante.Cells["NumeroPoliza"];
                    break;
                }
                else if (!bool.Parse(dgvrComprobante.Cells["YaGuardado"].Value.ToString()))
                {
                    ExistenNuevos = true;
                }
            }

            if (totalCodigosMetodosPagoNoValidos > 0)
            {
                General.muestraMensaje("Existen codigos de metodos de pago no validos, favor de revisar.");
                Valida = false;
            }

            if (totalCodigosMonedasNoValidos > 0)
            {
                General.muestraMensaje("Existen codigos de monedas no validos, favor de revisar.");
                Valida = false;
            }

            if (!ExistenNuevos)
            {
                General.muestraMensaje("No existe ningun Otro Metodo de Pago Nuevo a relacionar con las Pólizas, favor de validar.");
                Valida = false;
            }

            return Valida;
        }
        private void dgvComprobantes_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewRow dgvRow = dgvComprobantes.Rows[e.RowIndex];

            if (dgvRow.Cells[0].Style.BackColor == System.Drawing.Color.FromArgb(0, 130, 153))
            {

                Font fnt = new Font(dgvComprobantes.Font.FontFamily, 14, FontStyle.Bold, GraphicsUnit.Point);

                Rectangle rct = dgvComprobantes.GetRowDisplayRectangle(dgvRow.Index, true);
                rct.Height -= 1;

                SizeF s = e.Graphics.MeasureString("Otro Metodo de Pago ya guardados", fnt);
                float lefts = (rct.Width / 2) - (s.Width / 2);
                float tops = rct.Top + ((rct.Height / 2) - (s.Height / 2));

                SolidBrush brush = new SolidBrush(System.Drawing.Color.FromArgb(0, 130, 153));
                e.Graphics.FillRectangle(brush, rct);

                e.Graphics.DrawString("Otros Metodos de Pagos Ya Guardados", fnt, Brushes.White, lefts, tops);
            }
        }
        private void cmdAbrirArchivo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos TXT(*.txt, *.csv)|*.txt; *.csv";
            openFileDialog1.Title = "Seleccione el archivo TXT de los Otros Metodos de Pago de las Pólizas";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtArchivoComprobantes.Text = openFileDialog1.SafeFileName;
                txtPathArchivoComprobantes.Text = openFileDialog1.FileName;

                string Error = string.Empty;

                if (!cargaArchivoTXTComprobantes(out Error))
                {
                    General.muestraMensaje("Ocurrio un error al cargar el archivo TXT de los Otros Metodos de Pago de las Pólizas.\n" + Error);
                }
            }

            Cursor.Current = Cursors.Default;
        }
        private void CargarCatalogoMetodosPagoSAT()
        {
            dtCatalogoMetodosPagoSAT = Database.ExecuteDataTable("SATeC_ObtenerCatMetodosPago");
        }
        private void CargarCatalogoMonedasSAT()
        {
            dtCatalogoMonedasSAT = Database.ExecuteDataTable("SATeC_ObtenerCatMonedasSAT");
        }
        private bool VerificarClaveMetodoPago(string clave)
        {
            bool Existe = false;

            DataRow[] drMetodosPago = dtCatalogoMetodosPagoSAT.Select("clave='" + clave + "' ");

            if (drMetodosPago.Count() > 0)
                Existe = true;

            return Existe;
        }
        private bool VerificarCodigoMoneda(string codigo)
        {
            bool Existe = false;

            DataRow[] drMonedas = dtCatalogoMonedasSAT.Select("codigo='" + codigo + "' ");

            if (drMonedas.Count() > 0)
                Existe = true;

            return Existe;
        }
        private static DataTable CreateTableMetodosPago()
        {
            DataTable dtComprobantes = new DataTable("MetodosPago");

            DataColumn colIdPoliza = new DataColumn("ID_Poliza");
            DataColumn colNumPoliza = new DataColumn("Numero_Poliza");
            DataColumn colNumCuenta = new DataColumn("Numero_Cuenta");
            DataColumn colMetPagoPol = new DataColumn("MetPagoPol");
            DataColumn colFecha = new DataColumn("Fecha");
            DataColumn colBenef = new DataColumn("Benef");
            DataColumn colRFC= new DataColumn("RFC");
            DataColumn colMonto = new DataColumn("Monto");
            DataColumn colMoneda = new DataColumn("Moneda");
            DataColumn colTipoCambio = new DataColumn("TipCamb");
            DataColumn colClave = new DataColumn("Clave");

            colIdPoliza.DataType = System.Type.GetType("System.Int32");
            colNumPoliza.DataType = System.Type.GetType("System.String");
            colNumCuenta.DataType = System.Type.GetType("System.String");
            colMetPagoPol.DataType = System.Type.GetType("System.String");
            colFecha.DataType = System.Type.GetType("System.String");
            colBenef.DataType = System.Type.GetType("System.String");
            colRFC.DataType = System.Type.GetType("System.String");
            colMonto.DataType = System.Type.GetType("System.Decimal");
            colMoneda.DataType = System.Type.GetType("System.String");
            colTipoCambio.DataType = System.Type.GetType("System.Decimal");
            colClave.DataType = System.Type.GetType("System.String");

            dtComprobantes.Columns.Add(colIdPoliza);
            dtComprobantes.Columns.Add(colNumPoliza);
            dtComprobantes.Columns.Add(colNumCuenta);
            dtComprobantes.Columns.Add(colMetPagoPol);
            dtComprobantes.Columns.Add(colFecha);
            dtComprobantes.Columns.Add(colBenef);
            dtComprobantes.Columns.Add(colRFC);
            dtComprobantes.Columns.Add(colMonto);
            dtComprobantes.Columns.Add(colMoneda);
            dtComprobantes.Columns.Add(colTipoCambio);
            dtComprobantes.Columns.Add(colClave);

            return dtComprobantes;
        }
    }
}