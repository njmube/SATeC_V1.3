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
    public partial class frmImportarComprobantesNacionalOtros : Form
    {
        public string IDPoliza { set; get; }
        public string EjercicioPeriodo { set; get; }

        public DataTable dtPolizas = new DataTable();
        public DataTable dtTransacciones = new DataTable();

        public Dictionary<string, List<string>> Polizas { set; get; }
        public Dictionary<string, List<string>> ComprobantesNacionalesOtros { set; get; }

        public bool Guardado = true;

        public DataTable dtComprobantesOtros = CreateTableComprobantesOtros();

        public frmImportarComprobantesNacionalOtros()
        {
            InitializeComponent();
        }
        private void frmImportarComprobantesNacionalOtros_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            limpiaDatos();
            lblEjercicioPeriodoSeleccionadoO.Text = EjercicioPeriodo;
            cargarComprobantesNacionalOtrosYaGuardadas();

            Cursor = Cursors.Default;
        }

        //VHJC Funcion que limpia los datos de la forma
        private void limpiaDatos()
        {
            this.chkPrimerFilaNombresColumnasO.Checked = false;
            this.txtArchivoComprobantesO.Text = string.Empty;
            this.txtPathArchivoComprobantesO.Text = string.Empty;
            this.dgvComprobantes.Rows.Clear();
        }

        //VHJC Funcion que carga en el grid los datos de los comprobantes que ya estan guardadas para las polizas
        private void cargarComprobantesNacionalOtrosYaGuardadas()
        {
            Cursor.Current = Cursors.WaitCursor;

            //VHJC Si hay Comprobantes ya guardados...
            if (ComprobantesNacionalesOtros.Keys.Count > 0)
            {
                //VHJC Primero se agrega un renglon todo en blanco para hacer la separacion
                int RegistroEnBlanco = dgvComprobantes.Rows.Add("", "", "", "", "", "", "", "", "", true, true);

                for (int i = 0; i < 3; i++)
                {
                    dgvComprobantes.Rows[RegistroEnBlanco].Cells[i].Style.BackColor = System.Drawing.Color.FromArgb(0, 130, 153);
                    dgvComprobantes.Rows[RegistroEnBlanco].Cells[i].Style.SelectionBackColor = System.Drawing.Color.FromArgb(0, 130, 153);
                    dgvComprobantes.Rows[RegistroEnBlanco].Cells[i].Style.ForeColor = System.Drawing.Color.FromArgb(0, 130, 153);
                    dgvComprobantes.Rows[RegistroEnBlanco].Cells[i].Style.SelectionForeColor = System.Drawing.Color.FromArgb(0, 130, 153);
                }

                foreach (string LlaveComprobante in ComprobantesNacionalesOtros.Keys)
                {

                    string[] Datos = LlaveComprobante.Split('-');

                    string NumeroPolizaComprobante = Datos[0];
                    string NumeroCuentaComprobante = Datos[1];

                    List<string> DatosComprobante = ComprobantesNacionalesOtros[LlaveComprobante];

                    string CFD_CBB_SerieComprobante = DatosComprobante[0];
                    string CFD_CBB_NumFolComprobante = DatosComprobante[1];
                    string RFCComprobante = DatosComprobante[2];
                    double MontoTotalComprobante = double.Parse(DatosComprobante[3]);
                    string MonedaComprobante = DatosComprobante[4];
                    double TipodeCambioComprobante = double.Parse(DatosComprobante[5]);
                    string Clave = DatosComprobante[6];

                    dgvComprobantes.Rows.Add(NumeroPolizaComprobante, NumeroCuentaComprobante, CFD_CBB_SerieComprobante, CFD_CBB_NumFolComprobante, RFCComprobante, MontoTotalComprobante, MonedaComprobante, TipodeCambioComprobante, Clave, true, true);
                }
            }

            Cursor.Current = Cursors.Default;
        }
        private void cmdImportarArchivo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos TXT(*.txt, *.csv)|*.txt; *.csv";
            openFileDialog1.Title = "Seleccione el archivo TXT de Comprobantes de las Pólizas";

            // VHJC Muestra la ventana para seleccionar el archivo
            // Si el usuario selecciona un archivo txt y le clic en el boton OK, se regresa el nombre del archivo para despues validarlo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtArchivoComprobantesO.Text = openFileDialog1.SafeFileName;
                txtPathArchivoComprobantesO.Text = openFileDialog1.FileName;

                string Error = string.Empty;

                if (!cargaArchivoTXTComprobantes(out Error))
                {
                    General.muestraMensaje("Ocurrio un error al cargar el archivo TXT de los Comprobantes de las Pólizas.\n" + Error);
                }
            }

            Cursor.Current = Cursors.Default;
        }

        //VHJC Funcion que carga el contenido de archivo TXT al grid
        private bool cargaArchivoTXTComprobantes(out string Error)
        {
            Cursor.Current = Cursors.WaitCursor;

            bool Cargado = true;
            Error = string.Empty;

            bool FirstRow = true;
            bool PrimerFilaNombresColumnas = chkPrimerFilaNombresColumnasO.Checked;

            string Separador = string.Empty;
            //VHJC Por default el separador es ","
            char[] separator = { ',' };

            dtComprobantesOtros = CreateTableComprobantesOtros();

            try
            {
                dgvComprobantes.Rows.Clear();

                TextFieldParser txtReader = new TextFieldParser(txtPathArchivoComprobantesO.Text, Encoding.Default);
                txtReader.TextFieldType = FieldType.Delimited;
                txtReader.SetDelimiters(",");
                txtReader.HasFieldsEnclosedInQuotes = true;

                //VHJC Por cada una de las lineas del archivo TXT
                while (!txtReader.EndOfData)
                {

                    //VHJC Se verifica la primer linea para ver si el archivo viene separado por TABS o por comas...
                    if (FirstRow)
                    {
                        //VHJC Se lee la primer linea...
                        string firstRow = txtReader.PeekChars(1000);

                        //VHJC Si la primer linea viene con un tab, entonces el separador pasa a ser "Tab"
                        if (firstRow.Contains("\t"))
                            txtReader.SetDelimiters("\t");

                        FirstRow = false;
                    }

                    //VHJC Si esta marcada la opcion de "Primero fila con nombres de columnas", se salta la primer linea
                    if (PrimerFilaNombresColumnas)
                    {
                        txtReader.ReadLine();
                        PrimerFilaNombresColumnas = false;
                        continue;
                    }

                    //VHJC Variable que va a contener los datos de cada Comprobante
                    string[] DatosComprobante = txtReader.ReadFields();

                    string[] EjercicioPeriodo = lblEjercicioPeriodoSeleccionadoO.Text.Split('-');
                    string Ejercicio = EjercicioPeriodo[0].Trim();
                    string Periodo = EjercicioPeriodo[1].Trim().Substring(0, 2);

                    string ano = DatosComprobante[0].ToString();
                    string mes = DatosComprobante[1].ToString();

                    if (!(Ejercicio.Equals(ano) && Periodo.Equals(mes)))
                    {
                        General.muestraMensaje("El año y mes del Comprobante debe corresponder al periodo seleccionado. Favor de validar");
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
                    string CFD_CBB_SerieComprobante = DatosComprobante[5];
                    string CFD_CBB_NumFolComprobante = DatosComprobante[6];
                    string RFCComprobante = DatosComprobante[7];
                    double MontoTotalComprobante = double.Parse(DatosComprobante[8]);
                    string MonedaComprobante = DatosComprobante[9];
                    double TipodeCambioComprobante = double.Parse(DatosComprobante[10]);

                    string Clave = string.Empty;

                    if (DatosComprobante.Count() == 12)
                    {
                        Clave = DatosComprobante[11];
                    }

                    string LlaveComprobante = NumeroPolizaComprobante + "-" + NumeroCuentaComprobante;

                    bool ExistePoliza = verificaExistePolizaTransaccion(NumeroPolizaComprobante, NumeroCuentaComprobante);

                    //VHJC Se verifica que el CFDI no exista ya en los comprobantes ya guardados
                    bool ExisteCFDIYaGuardado = ComprobantesNacionalesOtros.ContainsKey(LlaveComprobante);

                    int RegistroAgregado = dgvComprobantes.Rows.Add(
                          NumeroPolizaComprobante
                        , NumeroCuentaComprobante
                        , CFD_CBB_SerieComprobante
                        , CFD_CBB_NumFolComprobante
                        , RFCComprobante
                        , MontoTotalComprobante
                        , MonedaComprobante
                        , TipodeCambioComprobante
                        , Clave
                        , ExistePoliza
                        , ExisteCFDIYaGuardado);

                    if (ExistePoliza && !ExisteCFDIYaGuardado)
                    {
                        DataRow row = dtComprobantesOtros.NewRow();

                        row["ID_Poliza"] = this.IDPoliza;
                        row["Numero_Poliza"] = NumeroPolizaComprobante;
                        row["Numero_Cuenta"] = NumeroCuentaComprobante;
                        row["CFD_CBB_Serie"] = CFD_CBB_SerieComprobante;
                        row["CFD_CBB_NumFol"] = CFD_CBB_NumFolComprobante;
                        row["RFC"] = RFCComprobante;
                        row["MontoTotal"] = MontoTotalComprobante;
                        row["Moneda"] = MonedaComprobante;
                        row["TipCamb"] = TipodeCambioComprobante;
                        row["Clave"] = Clave;

                        dtComprobantesOtros.Rows.Add(row);
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

                    //VHJC Si el comprobante ya esta guardado se marca en amarillo
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
                }

                txtReader.Close();
                txtReader.Dispose();

            }
            catch (Exception ex)
            {
                Cargado = false;
                Error = ex.Message;
            }

            if (ComprobantesNacionalesOtros.Keys.Count > 0)
            {
                cargarComprobantesNacionalOtrosYaGuardadas();
            }

            Guardado = false;

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
        private void cmdGuardarArchivo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string SQL = string.Empty;

            if (validaComprobantes())
            {
                if (DataBaseSQL.RegistrarComprobantesNacionalesOtros(dtComprobantesOtros))
                {
                    Guardado = true;
                    General.muestraMensaje("Los datos de los Comprobantes Nacionales Otros se han guardado con exito.");
                }
                else
                {
                    Guardado = false;
                    General.muestraMensaje("Ocurrio un error al tratar de guardar los datos de los Comprobantes Nacionales Otros.");
                    ComprobantesNacionalesOtros.Clear();
                }
            }

            GC.Collect();

            Cursor = Cursors.Default;	
        }
        private bool validaComprobantes()
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

            if (!ExistenNuevos)
            {
                General.muestraMensaje("No existe ningun Comprobante nuevo a relacionar con las Pólizas, favor de validar.");
                Valida = false;
            }

            return Valida;
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            if (!Guardado)
            {
                if (General.muestraMensajePregunta("¿Esta seguro de salir sin guardar los datos de los Comprobantes Nacional Otros de las Pólizas?") == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
                this.Close();            
        }
        private void dgvComprobantes_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewRow dgvRow = dgvComprobantes.Rows[e.RowIndex];

            if (dgvRow.Cells[0].Style.BackColor == System.Drawing.Color.FromArgb(0, 130, 153))
            {

                Font fnt = new Font(dgvComprobantes.Font.FontFamily, 14, FontStyle.Bold, GraphicsUnit.Point);

                Rectangle rct = dgvComprobantes.GetRowDisplayRectangle(dgvRow.Index, true);
                rct.Height -= 1;

                SizeF s = e.Graphics.MeasureString("Comprobantes ya guardados", fnt);
                float lefts = (rct.Width / 2) - (s.Width / 2);
                float tops = rct.Top + ((rct.Height / 2) - (s.Height / 2));

                SolidBrush brush = new SolidBrush(System.Drawing.Color.FromArgb(0, 130, 153));
                e.Graphics.FillRectangle(brush, rct);

                e.Graphics.DrawString("Comprobantes ya guardados", fnt, Brushes.White, lefts, tops);
            }
        }

        private static DataTable CreateTableComprobantesOtros()
        {
            DataTable dtComprobantesOtros = new DataTable("ComprobantesOtros");

            DataColumn colIdPoliza = new DataColumn("ID_Poliza");
            DataColumn colNumPoliza = new DataColumn("Numero_Poliza");
            DataColumn colNumCuenta = new DataColumn("Numero_Cuenta");
            DataColumn colCFD_CBB_Serie = new DataColumn("CFD_CBB_Serie");
            DataColumn colCFD_CBB_NumFol = new DataColumn("CFD_CBB_NumFol");
            DataColumn colRFC = new DataColumn("RFC");
            DataColumn colMontoTotal = new DataColumn("MontoTotal");
            DataColumn colMoneda = new DataColumn("Moneda");
            DataColumn colTipoCambio = new DataColumn("TipCamb");
            DataColumn colClave = new DataColumn("colClave");

            colIdPoliza.DataType = System.Type.GetType("System.Int32");
            colNumPoliza.DataType = System.Type.GetType("System.String");
            colNumCuenta.DataType = System.Type.GetType("System.String");
            colCFD_CBB_Serie.DataType = System.Type.GetType("System.String");
            colCFD_CBB_NumFol.DataType = System.Type.GetType("System.Int32");
            colRFC.DataType = System.Type.GetType("System.String");
            colMontoTotal.DataType = System.Type.GetType("System.Decimal");
            colMoneda.DataType = System.Type.GetType("System.String");
            colTipoCambio.DataType = System.Type.GetType("System.Decimal");
            colClave.DataType = System.Type.GetType("System.String");

            dtComprobantesOtros.Columns.Add(colIdPoliza);
            dtComprobantesOtros.Columns.Add(colNumPoliza);
            dtComprobantesOtros.Columns.Add(colNumCuenta);
            dtComprobantesOtros.Columns.Add(colCFD_CBB_Serie);
            dtComprobantesOtros.Columns.Add(colCFD_CBB_NumFol);
            dtComprobantesOtros.Columns.Add(colRFC);
            dtComprobantesOtros.Columns.Add(colMontoTotal);
            dtComprobantesOtros.Columns.Add(colMoneda);
            dtComprobantesOtros.Columns.Add(colTipoCambio);
            dtComprobantesOtros.Columns.Add(colClave);

            return dtComprobantesOtros;
        }

    }
}
