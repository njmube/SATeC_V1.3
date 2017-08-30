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
using System.Text.RegularExpressions;

namespace SATeC.Polizas
{
    public partial class frmImportarPolizas : Form
    {
        Dictionary<string, List<string>> CuentasSociedad = new Dictionary<string, List<string>>();

        private decimal TotalDebe = 0;
        private decimal TotalHaber = 0;
        private int totalNoValidas = 0;
        private int totalPolizasImportadas = 0;

        private DataTable dtPolizas = new DataTable();
        private DataTable dtCatalogoCuentas;

        private DataTable dtPolizaOrder;

        #region CodigoSinModificacion

        public frmImportarPolizas()
        {
            InitializeComponent();
        }
        private void frmImportarPolizas_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            this.Dock = DockStyle.Fill;

            limpiaDatos();
            cargarEjerciciosPeriodos();
            cargarCuentasSociedad();
            CargarTiposSolicitud();

            Cursor = Cursors.Default;
        }
        //VHJC Funcion que limpia los datos de la forma
        private void limpiaDatos()
        {
            this.cmbEjercicioPeriodo.Items.Clear();
            cmbTipoSolicitud.Items.Clear();
            txtNumeroOrden.Text = string.Empty;
            txtNumeroTramite.Text = string.Empty;
            this.chkPrimerFilaNombresColumnas.Checked = false;
            this.txtArchivoPolizas.Text = string.Empty;
            this.txtPathArchivoPolizas.Text = string.Empty;
            this.txtNoPolizas.Text = string.Empty;
            this.txtTotalDebe.Text = string.Empty;
            this.txtTotalHaber.Text = string.Empty;
            this.dgvPolizas.Rows.Clear();
            txtDiferencia.Text = String.Empty;
            txtTotalNoValidas.Text = String.Empty;

            lblNumeroOrden.Visible = false;
            txtNumeroOrden.Visible = false;
            lblNumeroTramite.Visible = false;
            txtNumeroTramite.Visible = false;
        }
        //VHJC Funcion que carga los Ejercicios/Periodos existentes en la base de datos
        private void cargarEjerciciosPeriodos()
        {
            OleDbDataReader drEjerciciosPeriodos = Database.obtenRegistros("SELECT Ejercicio+' - '+Periodo+' '+Mes AS EjercicioPeriodo FROM SATeC_EjerciciosPeriodos ORDER BY Ejercicio+' - '+Periodo+' '+Mes");

            while (drEjerciciosPeriodos.Read())
            {
                ListItem itmEjercicioPeriodo = new ListItem(drEjerciciosPeriodos["EjercicioPeriodo"].ToString(), drEjerciciosPeriodos["EjercicioPeriodo"].ToString());
                cmbEjercicioPeriodo.Items.Add(itmEjercicioPeriodo);
            }

            drEjerciciosPeriodos.Close();
            drEjerciciosPeriodos.Dispose();
        }

        private void CargarTiposSolicitud()
        {
            OleDbDataReader drTiposSolicitud = Database.obtenRegistros("SELECT idTipoSolicitud, clave, descripcion, fechaAlta, activo FROM SATeC_Polizas_CatTipoSolicitud WHERE activo = 1");

            while (drTiposSolicitud.Read())
            {
                ListItem itmTipoSolicitud = new ListItem(drTiposSolicitud["clave"].ToString(), drTiposSolicitud["descripcion"].ToString());
                cmbTipoSolicitud.Items.Add(itmTipoSolicitud);
            }

            drTiposSolicitud.Close();
            drTiposSolicitud.Dispose();
        }

        private void cargarCuentasSociedad()
        {
            dtCatalogoCuentas = Database.ExecuteDataTable("obtenerCuentasSociedad_RelacionSAT", General.ID_SociedadSeleccionada.ToString());
        }

        //VHJC Cuando se da clic en el boton "..." para seleccionar el archivo de las polizas
        private void cmdAbrirArchivo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos TXT(*.txt, *.csv)|*.txt; *.csv";
            openFileDialog1.Title = "Seleccione el archivo TXT de la Balanza";

            // VHJC Muestra la ventana para seleccionar el archivo
            // Si el usuario selecciona un archivo txt y le clic en el boton OK, se regresa el nombre del archivo para despues validarlo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtArchivoPolizas.Text = openFileDialog1.SafeFileName;
                txtPathArchivoPolizas.Text = openFileDialog1.FileName;

                string Error = string.Empty;

                string[] EjercicioPeriodo = ((ListItem)cmbEjercicioPeriodo.SelectedItem).Texto.Split('-');
                string Ejercicio = EjercicioPeriodo[0].Trim();
                string Periodo = EjercicioPeriodo[1].Trim().Substring(0, 2);

                string existeCatalogoCuenta = Database.obtenerDato("DECLARE @Ejercicio VARCHAR(4) = '" + Ejercicio + "' DECLARE @Periodo VARCHAR(2) = '" + Periodo + "' DECLARE @ID_Sociedad smallint = " + General.ID_SociedadSeleccionada.ToString() + " SELECT ISNULL( (SELECT MAX(ID_CatalogoDeCuentasImportado) FROM SATeC_CatalogosCuentasFormatoXML WHERE ID_Sociedad = @ID_Sociedad AND XML IS NOT NULL ), 0) EXISTE");

                if (!existeCatalogoCuenta.Equals("0"))
                {
                    string existeBalanza = Database.obtenerDato("DECLARE @Ejercicio VARCHAR(4) = '" + Ejercicio + "' DECLARE @Periodo VARCHAR(2) = '" + Periodo + "' DECLARE @ID_Sociedad smallint = " + General.ID_SociedadSeleccionada.ToString() + " SELECT ISNULL( ( SELECT MAX(ID_Balanza) FROM SATeC_Balanzas WHERE ID_Sociedad = @ID_Sociedad  AND Ejercicio = @Ejercicio AND Periodo = @Periodo AND XML IS NOT NULL ), 0 ) EXISTE");

                    if (!existeBalanza.Equals("0"))
                    {
                        if (!CargaArchivoPolizaTXTOLEBD(out Error))
                        {
                            General.muestraMensaje("Ocurrio un error al cargar el archivo de las Pólizas. \n" + Error);
                        }
                    }
                    else
                    {
                        General.muestraMensaje("La Poliza no puede ser importada por que no existe la balanza por asociar.");
                    }
                }
                else
                {
                    General.muestraMensaje("La Poliza no puede ser importada por que no existe el catalogo de cuentas por asociar.");
                }
            }

            Cursor.Current = Cursors.Default;
        }
        //VHJC Funcion que valida que los datos de las pólizas esten completos y correctos
        private bool validaPolizas()
        {
            bool Valida = true;            

            if (cmbEjercicioPeriodo.SelectedIndex == -1)
            {
                General.muestraMensaje("Debe seleccionar el Ejercicio / Periodo al que pertenecen las Pólizas.");
                cmbEjercicioPeriodo.Focus();
                cmbEjercicioPeriodo.DroppedDown = true;
                Valida = false;
            }
            else if (cmbTipoSolicitud.SelectedIndex == -1)
            {
                General.muestraMensaje("Debe seleccionar el tipo de solicitud al que pertenecen las Pólizas.");
                cmbTipoSolicitud.Focus();
                cmbTipoSolicitud.DroppedDown = true;
                Valida = false;
            }
            else if (cmbTipoSolicitud.SelectedIndex != -1 && (((ListItem)cmbTipoSolicitud.SelectedItem).Valor.Equals("AF") || ((ListItem)cmbTipoSolicitud.SelectedItem).Valor.Equals("FC")) && string.IsNullOrEmpty(txtNumeroOrden.Text))
            {
                General.muestraMensaje("Debe proporcionar el numero de orden al que pertenecen las Pólizas.");
                txtNumeroOrden.Focus();
                Valida = false;
            }
            else if (cmbTipoSolicitud.SelectedIndex != -1 && (((ListItem)cmbTipoSolicitud.SelectedItem).Valor.Equals("DE") || ((ListItem)cmbTipoSolicitud.SelectedItem).Valor.Equals("DO")) && string.IsNullOrEmpty(txtNumeroTramite.Text))
            {
                General.muestraMensaje("Debe proporcionar el numero de tramite al que pertenecen las Pólizas.");
                txtNumeroOrden.Focus();
                Valida = false;
            }
            else if (dgvPolizas.Rows.Count == 0)
            {
                General.muestraMensaje("Debe de realizar la carga del archivo de Pólizas a procesar.");
                cmdAbrirArchivo.Focus();
                Valida = false;
            }
            else if (Math.Round(TotalDebe, 2) != Math.Round(TotalHaber, 2))
            {
                General.muestraMensaje("El total de cargos es diferente al total de abonos, favor de validar.");
                Valida = false;
            }
            else
                if (totalNoValidas > 0)
                {
                    General.muestraMensaje("No se encontraron algunos Numeros de Cuenta, favor de validar.");
                    Valida = false;
                }

            return Valida;
        }
        private void cmdCheques_Click(object sender, EventArgs e)
        {
            frmImportarCheques ImportarCheques = new frmImportarCheques();
            ImportarCheques.ShowDialog();
        }
        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            if (General.muestraMensajePregunta("¿Esta seguro de salir sin guardar los datos de las Pólizas?") == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #endregion CodigoSinModificacion

        private bool CargaArchivoPolizaTXTOLEBD(out string Error)
        {
            Cursor.Current = Cursors.WaitCursor;
            bool Cargado = true;
            Error = string.Empty;
            string Ejercicio = string.Empty;
            string Periodo = string.Empty;

            TotalDebe = 0;
            TotalHaber = 0;
            totalNoValidas = 0;
            totalPolizasImportadas = 0;

            try
            {
                DataTable dtPoliza = GetDataFromFile(txtPathArchivoPolizas.Text);

                if (dtPoliza.Columns[2].ColumnName.ToLower() != "tipoPoliza")
                {
                    dtPoliza.Columns[2].ColumnName = "tipoPoliza";
                }

                if (dtPoliza.Columns[3].ColumnName.ToLower() != "numeroPoliza")
                {
                    dtPoliza.Columns[3].ColumnName = "numeroPoliza";
                }

                if (dtPoliza.Columns[5].ColumnName.ToLower() != "fechaPoliza")
                {
                    dtPoliza.Columns[5].ColumnName = "fechaPoliza";
                }

                if (dtPoliza.Columns[7].ColumnName.ToLower() != "numCuenta")
                {
                    dtPoliza.Columns[7].ColumnName = "numCuenta";
                }

                if (dtPoliza.Columns[8].ColumnName.ToLower() != "descCuenta")
                {
                    dtPoliza.Columns[8].ColumnName = "descCuenta";
                }

                if (dtPoliza.Columns[9].ColumnName.ToLower() != "concepto")
                {
                    dtPoliza.Columns[9].ColumnName = "concepto";
                }

                if (dtPoliza.Columns[10].ColumnName.ToLower() != "debe")
                {
                    dtPoliza.Columns[10].ColumnName = "debe";
                }

                if (dtPoliza.Columns[11].ColumnName.ToLower() != "haber")
                {
                    dtPoliza.Columns[11].ColumnName = "haber";
                }

                if (dtPoliza.Rows.Count == 0)
                {
                    Error = " No se pudo cargar la información desde el archivo seleccionar. Favor de validar";
                    return false;
                }

                string[] EjercicioPeriodo = ((ListItem)cmbEjercicioPeriodo.SelectedItem).Texto.Split('-');
                Ejercicio = EjercicioPeriodo[0].Trim();
                Periodo = EjercicioPeriodo[1].Trim().Substring(0, 2);

                DataRow[] drEjercicioPeriodoNoValidos = dtPoliza.Select("Ano <> " + Ejercicio + " OR Mes <> '" + Periodo + "'");

                if (drEjercicioPeriodoNoValidos.Count() > 0)
                {
                    Error = " Ejercicio/Periodo No valido.";
                    General.muestraMensaje("El año y mes de la Poliza debe corresponder al periodo seleccionado. Favor de validar");
                    return false;
                }

                DataRow[] drIdTipoPolizaVacias = dtPoliza.Select("tipoPoliza is null");

                if (drIdTipoPolizaVacias.Count() > 0)
                {
                    Error = " Id Tipo de Poliza No puede estar vacia.";
                    General.muestraMensaje("El Tipo de Poliza identficado No puede estar vacia. Solo se permiten los codigos: [1], [2] o [3]. Favor de corregir.");
                    return false;
                }

                DataRow[] drIdTipoPolizaNoValidas = dtPoliza.Select("tipoPoliza NOT IN (1, 2, 3)");

                if (drIdTipoPolizaNoValidas.Count() > 0)
                {
                    Error = " Id Tipo de Poliza No es Valida.";
                    General.muestraMensaje("El Id Tipo de Poliza identficado No es valida. Solo se permiten los codigos: [1], [2] o [3]. Favor de corregir.");
                    return false;
                }
                
                dtPoliza.Columns.Add("numPoliza", typeof(string));
                dtPoliza.Columns.Add("idPoliza", typeof(string));
                DataColumn colCuentaValida = new System.Data.DataColumn("CuentaValida", typeof(System.Boolean));
                colCuentaValida.DefaultValue = true;
                dtPoliza.Columns.Add(colCuentaValida);
                DataColumn colPolizaValida = new System.Data.DataColumn("PolizaValida", typeof(System.Boolean));
                colPolizaValida.DefaultValue = true;
                dtPoliza.Columns.Add(colPolizaValida);
                DataColumn colTotalesValidos = new System.Data.DataColumn("TotalesValidos", typeof(System.Boolean));
                colTotalesValidos.DefaultValue = true;
                dtPoliza.Columns.Add(colTotalesValidos);

                foreach (DataRow rw in dtPoliza.Rows)
                {
                    rw["numPoliza"] = rw["tipoPoliza"].ToString() + rw["numeroPoliza"].ToString();
                }

                DataView dvPoliza = dtPoliza.DefaultView;
                dvPoliza.Sort = "numeroPoliza ASC";
                dtPolizaOrder = dvPoliza.ToTable();

                bool PrimerFilaNombresColumnas = (chkPrimerFilaNombresColumnas.Checked);
                                
                MarcarCuentasNoValidas(dtPolizaOrder);
                
                DataView viewPolizasUnicas = new DataView(dtPolizaOrder);
                DataTable dtPolizasUnicas = viewPolizasUnicas.ToTable(true, "numPoliza");

                foreach (DataRow DatosPoliza in dtPolizasUnicas.Rows)
                {
                    ObtenerPolizasNoValidasAndTotalesNoValidos(dtPolizaOrder, DatosPoliza[0].ToString());
                }

                DataView viewPolizas = new DataView(dtPolizaOrder);
                DataTable dtPolizasVista = viewPolizas.ToTable(true, "numPoliza", "fechaPoliza", "PolizaValida");

                foreach (DataRow row in dtPolizasVista.Rows)
                {
                    string NumeroPoliza = row["numPoliza"].ToString();
                    string Fecha = row["fechaPoliza"].ToString();
                    bool valida = bool.Parse(row["PolizaValida"].ToString());

                    int rowNum = dgvPolizas.Rows.Add(NumeroPoliza, Fecha);

                    if (!valida)
                    {
                        for (int i = 0; i < dgvPolizas.Rows[rowNum].Cells.Count; i++)
                        {
                            dgvPolizas.Rows[rowNum].Cells[i].Style.BackColor = Color.Red;
                            dgvPolizas.Rows[rowNum].Cells[i].Style.SelectionBackColor = Color.Red;
                            dgvPolizas.Rows[rowNum].Cells[i].Style.ForeColor = Color.Black;
                            dgvPolizas.Rows[rowNum].Cells[i].Style.SelectionForeColor = Color.Black;
                        }
                    }
                }

                txtNoPolizas.Text = dtPolizasVista.Rows.Count.ToString();
                totalPolizasImportadas = dtPolizasVista.Rows.Count;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }

            object resultadoDebe = dtPolizaOrder.Compute("Sum(debe)", "");
            object resultadoHaber = dtPolizaOrder.Compute("Sum(haber)", "");
            object resultadoNoValidas = dtPolizaOrder.Compute("Count(CuentaValida)", "CuentaValida = 0");

            TotalDebe = decimal.Parse(resultadoDebe.ToString());
            TotalHaber = decimal.Parse(resultadoHaber.ToString());
            txtTotalDebe.Text = TotalDebe.ToString("#,##0.00;(#,##0.00)");
            txtTotalHaber.Text = TotalHaber.ToString("#,##0.00;(#,##0.00)");

            decimal diferencia = TotalDebe - TotalHaber;
            txtDiferencia.Text = diferencia.ToString("#,##0.00;(#,##0.00)");

            totalNoValidas = int.Parse(resultadoNoValidas.ToString());
            txtTotalNoValidas.Text = totalNoValidas.ToString();

            decimal totalCargos = decimal.Parse(Database.obtenerDato("SELECT SUM(BD.Cargos) TotalCargos FROM SATeC_Balanzas B INNER JOIN SATeC_Balanza_Detalle BD ON BD.ID_Balanza = B.ID_Balanza WHERE ID_Sociedad = " + General.ID_SociedadSeleccionada.ToString() + " AND B.Ejercicio = '" + Ejercicio + "' AND B.Periodo = '" + Periodo + "' AND B.ID_Balanza = (SELECT MAX(ID_Balanza) FROM SATeC_Balanzas where ID_Sociedad = " + General.ID_SociedadSeleccionada.ToString() + " AND Ejercicio = '" + Ejercicio + "' AND Periodo = '" + Periodo + "' )").ToString());
            decimal totalAbonos = decimal.Parse(Database.obtenerDato("SELECT SUM(BD.Abonos) TotalAbonos FROM SATeC_Balanzas B INNER JOIN SATeC_Balanza_Detalle BD ON BD.ID_Balanza = B.ID_Balanza WHERE ID_Sociedad = " + General.ID_SociedadSeleccionada.ToString() + " AND B.Ejercicio = '" + Ejercicio + "' AND B.Periodo = '" + Periodo + "' AND B.ID_Balanza = (SELECT MAX(ID_Balanza) FROM SATeC_Balanzas where ID_Sociedad = " + General.ID_SociedadSeleccionada.ToString() + " AND Ejercicio = '" + Ejercicio + "' AND Periodo = '" + Periodo + "' )").ToString());
            decimal diferenciaBalanza = totalCargos - totalAbonos;

            if ((TotalDebe != totalCargos) || (TotalHaber != totalAbonos))
            {
                General.muestraMensaje("Existen diferencias entre los importes de Balanza y la Poliza cargada. \n\n [TotalDebe= " + TotalDebe.ToString() + " VS TotalCargos=" + totalCargos.ToString() + "] \n [TotalHaber=" + TotalHaber.ToString() + " VS TotalAbono=" + totalAbonos.ToString() + "] \n [Diferencia Poliza: " + diferencia + " VS Diferencia Balanza: " + diferenciaBalanza + "] Favor de validar...");
            }

            dgvPolizas_CellClick(dgvPolizas, new DataGridViewCellEventArgs(0, 0));

            Cursor.Current = Cursors.Default;

            return Cargado;
        }
        private void MarcarCuentasNoValidas(DataTable dtPolizaOrder)
        {
            try
            {
                foreach (DataRow DatosPoliza in dtPolizaOrder.Rows)
                {
                    string numeroCuenta = DatosPoliza[7].ToString();

                    string cuenta = string.Empty;
                    string subCuenta = string.Empty;
                    string[] numerosCuenta;

                    char[] separator = { '-' };

                    if (DatosPoliza[7].ToString().Contains('-'))
                    {
                        numerosCuenta = DatosPoliza[7].ToString().Split(separator);
                        cuenta = numerosCuenta[0];
                        subCuenta = numerosCuenta[1];
                    }
                    else
                    {
                        cuenta = DatosPoliza[7].ToString();
                        subCuenta = String.Empty;
                    }

                    if (!ExisteNumeroCuenta(cuenta))
                        DatosPoliza["CuentaValida"] = false;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        private void ObtenerPolizasNoValidasAndTotalesNoValidos(DataTable dtPolizaOrder, string numPoliza)
        {
            try
            {
                DataRow[] drPolizas = dtPolizaOrder.Select("numPoliza = '" + numPoliza + "'");

                DataRow[] drTotalPolizasNoValidas = dtPolizaOrder.Select("numPoliza = '" + numPoliza + "' AND CuentaValida = 0");

                if (drTotalPolizasNoValidas.Count() > 0)
                {
                    foreach (DataRow r in drPolizas.ToList())
                    {
                        r["PolizaValida"] = false;
                    }
                }

                decimal totalDebe = 0.00m;
                decimal totalHaber = 0.00m;

                object resultadoDebe = dtPolizaOrder.Compute("Sum(debe)", "numPoliza = '" + numPoliza + "'");
                object resultadoHaber = dtPolizaOrder.Compute("Sum(haber)", "numPoliza = '" + numPoliza + "'");

                if (resultadoDebe != DBNull.Value)
                    totalDebe = decimal.Parse(resultadoDebe.ToString());

                if (resultadoHaber != DBNull.Value)
                    totalHaber = decimal.Parse(resultadoHaber.ToString());
                
                decimal diferencia = totalDebe - totalHaber;

                if (diferencia > 0)
                {
                    foreach (DataRow r in drPolizas.ToList())
                    {
                        r["TotalesValidos"] = false;
                        r["PolizaValida"] = false;
                    }
                }

            }
            catch (Exception ex)
            {
                General.muestraMensaje("numPoliza=" + numPoliza);
                General.muestraMensaje(ex.Message);
            }
        }
        private DataTable GetDataFromFile(string fileFull)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataTable dtData = new DataTable();

            try
            {
                string full = Path.GetFullPath(fileFull);
                string file = Path.GetFileName(full);

                //file = RemoveAccentsWithRegEx(file);

                string dir = Path.GetDirectoryName(full);

                string archivoIni = "schema.ini";

                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("[{0}]", file);
                sb.AppendLine("");
                sb.AppendLine("ColNameHeader=True");
                sb.AppendLine("Format=CSVDelimited");
                sb.AppendLine("Col1=Ano Short");
                sb.AppendLine("Col2=Mes Text");
                sb.AppendLine("Col3=tipoPoliza Short");
                sb.AppendLine("Col4=numeroPoliza Text");
                sb.AppendLine("Col5=secuencia Text");
                sb.AppendLine("Col6=fechaPoliza DateTime");
                sb.AppendLine("Col7=conceptoOperacion Text");
                sb.AppendLine("Col8=numCuenta Text");
                sb.AppendLine("Col9=descCuenta Text");
                sb.AppendLine("Col10=concepto Text");
                sb.AppendLine("Col11=debe Currency");
                sb.AppendLine("Col12=haber Currency");
                sb.AppendLine("CharacterSet=ANSI");

                using (StreamWriter writer = new StreamWriter(dir + @"\" + archivoIni))
                {
                    writer.Write(sb.ToString());
                }

                string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
                              + "Data Source=\"" + dir + "\\\";"
                              + "Extended Properties=\"text;HDR=YES;FMT=CSVDelimited;IMEX=1;\"";

                string query = "SELECT * FROM [" + file + "] WHERE Ano IS NOT NULL";

                adapter = new OleDbDataAdapter(query, connectionString);
                var dsInformation = new DataSet();
                adapter.Fill(dsInformation);
                dtData = dsInformation.Tables[0];

                foreach (DataRow row in dtData.Rows)
                {
                    if (String.IsNullOrEmpty(row["debe"].ToString()))
                        row["debe"] = 0.00;

                    if (String.IsNullOrEmpty(row["haber"].ToString()))
                        row["haber"] = 0.00;
                }

                return dtData;
            }
            catch (Exception ex)
            {
                Exception e = new Exception("Ocurrio un error al intentar leer los datos del archivo/archivo con formato incorrecto.", ex);
                throw (e);
            }
            finally
            {
                adapter.Dispose();
            }
        }
        private void dgvPolizas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string NumeroPoliza = dgvPolizas.CurrentRow.Cells["NumeroPoliza"].Value.ToString();

                dgvTransacciones.Rows.Clear();

                DataRow[] drTransacciones = dtPolizaOrder.Select("numPoliza='" + NumeroPoliza + "' ");

                foreach (DataRow row in drTransacciones)
                {
                    string NumeroPolizaTransaccion = row["numPoliza"].ToString();
                    string CuentaTransaccion = row["numCuenta"].ToString();
                    string DescCuenta = row["descCuenta"].ToString();
                    string ConceptoTransaccion = row["concepto"].ToString();

                    decimal DebeTransaccion = 0.00m;
                    decimal HaberTransaccion = 0.00m;

                    if (!String.IsNullOrEmpty(row["debe"].ToString()))
                        DebeTransaccion = decimal.Parse(row["debe"].ToString());

                    if (!String.IsNullOrEmpty(row["haber"].ToString()))
                        HaberTransaccion = decimal.Parse(row["haber"].ToString());

                    bool existe = bool.Parse(row["CuentaValida"].ToString());

                    int rowId = dgvTransacciones.Rows.Add(NumeroPolizaTransaccion, CuentaTransaccion, DescCuenta, ConceptoTransaccion, DebeTransaccion, HaberTransaccion);

                    if (!existe)
                    {
                        for (int i = 0; i < dgvTransacciones.Columns.Count; i++)
                        {

                            dgvTransacciones.Rows[rowId].Cells[i].Style.BackColor = System.Drawing.Color.Red;
                            dgvTransacciones.Rows[rowId].Cells[i].Style.SelectionBackColor = System.Drawing.Color.Red;
                            dgvTransacciones.Rows[rowId].Cells[i].Style.ForeColor = System.Drawing.Color.Black;
                            dgvTransacciones.Rows[rowId].Cells[i].Style.SelectionForeColor = System.Drawing.Color.Black;

                        }
                    }
                }           
            }
        }
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            bool Salir = false;

            // VERSION DEMO RESTRINGIDA.
            //int totalPolizas = int.Parse(Properties.Resources.TotalPolizas);

            //if (totalPolizasImportadas > totalPolizas)
            //{
            //    General.muestraMensaje("La version Demo solo permite guardar hasta " + Properties.Resources.TotalPolizas + " Polizas. Solicite la version completa.");
            //    Salir = true;
            //}
            //else
            //{
            //    EjecutarPoliza();
            //    Salir = true;
            //}

            EjecutarPoliza();
            Salir = true;

            Cursor = Cursors.Default;

            if (Salir)
                this.Close();
        }
        private void EjecutarPoliza()
        {
            if (validaPolizas())
            {
                string[] EjercicioPeriodo = ((ListItem)cmbEjercicioPeriodo.SelectedItem).Texto.Split('-');
                string Ejercicio = EjercicioPeriodo[0].Trim();
                string Periodo = EjercicioPeriodo[1].Trim().Substring(0, 2);

                string TipoSolicitud = ((ListItem)cmbTipoSolicitud.SelectedItem).Valor;
                string NumOrden = string.Empty;
                string NumTramite = string.Empty;

                if (TipoSolicitud.Equals("AF") || TipoSolicitud.Equals("FC"))
                {
                    NumOrden = txtNumeroOrden.Text.Trim();
                }
                else
                    if (TipoSolicitud.Equals("DE") || TipoSolicitud.Equals("CO"))
                    {
                        NumTramite = txtNumeroTramite.Text.Trim();
                    }

                if (DataBaseSQL.RegistrarPoliza(General.ID_SociedadSeleccionada, Ejercicio, Periodo, TipoSolicitud, NumOrden, NumTramite, General.UsuarioActual.ID, dtPolizaOrder))
                {
                    General.muestraMensaje("Los datos de las Pólizas se han guardado con exito.");
                }
                else
                {
                    General.muestraMensaje("Ocurrio un error al tratar de guardar los datos de las Pólizas: " + DataBaseSQL.Error);
                }                
            }
        }

        #region Nueva Implementacion

        private static DataTable CreateTablePolizas()
        {
            DataTable dtPolizas = new DataTable("Poliza");

            DataColumn colNumPoliza = new DataColumn("numPoliza");
            DataColumn colSecuencia = new DataColumn("secuencia");
            DataColumn colFechaPoliza = new DataColumn("fechaPoliza");
            DataColumn colConceptoOperacion = new DataColumn("conceptoOperacion");
            DataColumn colNumCuenta = new DataColumn("numCuenta");
            DataColumn colDescCuenta = new DataColumn("descCuenta");
            DataColumn colConcepto = new DataColumn("concepto");
            DataColumn colDebe = new DataColumn("debe");
            DataColumn colHaber = new DataColumn("haber");
            DataColumn colIdPoliza = new DataColumn("idPoliza");
            DataColumn colValida = new DataColumn("valida");

            colNumPoliza.DataType = System.Type.GetType("System.String");
            colSecuencia.DataType = System.Type.GetType("System.String");
            colFechaPoliza.DataType = System.Type.GetType("System.DateTime");
            colConceptoOperacion.DataType = System.Type.GetType("System.String");
            colNumCuenta.DataType = System.Type.GetType("System.String");
            colDescCuenta.DataType = System.Type.GetType("System.String");
            colConcepto.DataType = System.Type.GetType("System.String");
            colDebe.DataType = System.Type.GetType("System.Decimal");
            colHaber.DataType = System.Type.GetType("System.Decimal");
            colIdPoliza.DataType = System.Type.GetType("System.String");
            colValida.DataType = System.Type.GetType("System.Boolean");

            dtPolizas.Columns.Add(colNumPoliza);
            dtPolizas.Columns.Add(colSecuencia);
            dtPolizas.Columns.Add(colFechaPoliza);
            dtPolizas.Columns.Add(colConceptoOperacion);
            dtPolizas.Columns.Add(colNumCuenta);
            dtPolizas.Columns.Add(colDescCuenta);
            dtPolizas.Columns.Add(colConcepto);
            dtPolizas.Columns.Add(colDebe);
            dtPolizas.Columns.Add(colHaber);
            dtPolizas.Columns.Add(colIdPoliza);
            dtPolizas.Columns.Add(colValida);

            return dtPolizas;
        }
        private string ObtenerPolizasXML()
        {
            try
            {
                DataSet dsData = new DataSet();
                StringBuilder sb = new StringBuilder();
                StringWriter sw = new StringWriter(sb);
                string XMLformat = string.Empty;

                dsData.Merge(dtPolizas, true, MissingSchemaAction.AddWithKey);
                dsData.Tables[0].TableName = "Poliza";

                foreach (DataColumn col in dsData.Tables[0].Columns)
                {
                    col.ColumnMapping = MappingType.Attribute;
                }

                dtPolizas.WriteXml(sw);
                XMLformat = sw.ToString();

                return XMLformat;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        private bool ExisteNumeroCuenta(string cuenta)
        {
            try
            {
                DataRow[] drCuentas;

                drCuentas = dtCatalogoCuentas.Select("CuentaPadre='" + cuenta + "' AND Cuenta='" + cuenta + "' ");

                if (drCuentas.Count() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        #endregion Nueva Implementacion

        private void cmbTipoSolicitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSolicitud = ((ListItem)cmbTipoSolicitud.SelectedItem).Valor;

            txtNumeroOrden.Text = string.Empty;
            txtNumeroTramite.Text = string.Empty;

            if (tipoSolicitud.Equals("AF") || tipoSolicitud.Equals("FC"))
            {
                lblNumeroOrden.Visible = true;
                txtNumeroOrden.Visible = true;

                lblNumeroTramite.Visible = false;
                txtNumeroTramite.Visible = false;
            }
            else
            if (tipoSolicitud.Equals("DE") || tipoSolicitud.Equals("CO"))
            {
                lblNumeroOrden.Visible = false;
                txtNumeroOrden.Visible = false;

                lblNumeroTramite.Visible = true;
                txtNumeroTramite.Visible = true;
            }
        }

        public static string RemoveAccentsWithRegEx(string inputString)
        {
            Regex replace_a_Accents = new Regex("[á|à|ä|â]", RegexOptions.Compiled);
            Regex replace_e_Accents = new Regex("[é|è|ë|ê]", RegexOptions.Compiled);
            Regex replace_i_Accents = new Regex("[í|ì|ï|î]", RegexOptions.Compiled);
            Regex replace_o_Accents = new Regex("[ó|ò|ö|ô]", RegexOptions.Compiled);
            Regex replace_u_Accents = new Regex("[ú|ù|ü|û]", RegexOptions.Compiled);

            inputString = replace_a_Accents.Replace(inputString, "a");
            inputString = replace_e_Accents.Replace(inputString, "e");
            inputString = replace_i_Accents.Replace(inputString, "i");
            inputString = replace_o_Accents.Replace(inputString, "o");
            inputString = replace_u_Accents.Replace(inputString, "u");

            return inputString;
        }
    }
}
