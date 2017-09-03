using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SATeC.Administracion
{
    public partial class frmMapeoMetodosPago : Form
    {
        #region Atributos

        private DataTable dtMapeoSociedad;
        private DataTable dtCatalogoSAT;
        int totalNoValidos = 0;
        int totalExistentes = 0;

        #endregion Aributos

        #region Constructor

        public frmMapeoMetodosPago()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Eventos

        private void frmMapeoMetodosPago_Load(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
        private void lblSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos TXT(*.txt, *.csv)|*.txt; *.csv";
            openFileDialog1.Title = "Seleccione el archivo de Mapeo de Métodos de Pago";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                General.cambiaMensajeStatus(this, "Cargando Archivo de Mapeo de Métodos de Pago desde el archivo TXT...");

                txtArchivoCatalogoCuentas.Text = openFileDialog1.SafeFileName;
                txtPathArchivoCatalogoCuentas.Text = openFileDialog1.FileName;
                dgvMetodosPago.Rows.Clear();
                string Error = string.Empty;

                General.cambiaMensajeStatus(this, "Validando existencia del Mapeo de Métodos de Pago...");

                if (CargaArchivoTXT(out Error))
                {
                    General.muestraMensaje("Carga de archivo terminado.\n " + Error);
                }
                else
                {
                    General.muestraMensaje("Ocurrio un error al abrir el archivo de Mapeo de Métodos de Pago.\n" + Error);
                }

                General.cambiaMensajeStatus(this, "");
                Cursor = Cursors.Default;
            }
        }
        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmdImportar_Click(object sender, EventArgs e)
        {
            try
            {
                string error = String.Empty;

                if (ValidarImportacion(out error))
                {
                    Cursor = Cursors.WaitCursor;

                    string SQL = string.Empty;
                    bool Salir = false;

                    foreach (DataGridViewRow row in dgvMetodosPago.Rows)
                    {
                        bool existe = (bool)row.Cells["ExisteClave"].Value;

                        if (existe)
                        {
                            SQL += string.Format(" UPDATE SATeC_MapeoMetodosPago SET claveSociedad = '{0}', fechaModificacion = GETDATE() WHERE claveSAT = '{1}' \n ", row.Cells["ClaveSociedad"].Value, row.Cells["ClaveSAT"].Value);
                        }
                        else
                        {
                            SQL += " INSERT INTO SATeC_MapeoMetodosPago (claveSociedad, claveSAT, fechaAlta, activo) VALUES (";
                            SQL += "'" + row.Cells["ClaveSociedad"].Value + "'";
                            SQL += ", '" + row.Cells["ClaveSAT"].Value + "'";
                            SQL += ", GETDATE(), 1) \n";
                        }
                    }

                    if (Database.ejecutaQuery(SQL, true))
                    {
                        Salir = true;
                        General.muestraMensaje("Los datos de la carga del Mapeo de Métodos de Pago se ha registrado con exitosamente.");
                    }
                    else
                    {
                        General.muestraMensaje("Ocurrio un error al tratar de guardar los datos de la carga del Mapeo de Métodos de Pago: " + Database.Error);
                    }

                    Cursor = Cursors.Default;

                    if (Salir)
                        this.Close();
                }
                else
                {
                    General.muestraMensaje(error);
                }
            }
            catch (Exception ex)
            {
                StringBuilder sbLogErrores = new StringBuilder();
                sbLogErrores.AppendLine(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + " | Error en el proceso de carga del archivo de Mapeo de Métodos de Pago. | Exception: " + ex.Message);

                if (sbLogErrores.Length > 0)
                {
                    string StartupPath = INI.Read("Repositorio", "Ruta");

                    using (StreamWriter writer = new StreamWriter(StartupPath + "\\LogErrores_" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt", true))
                    {
                        writer.WriteLine(sbLogErrores.ToString());
                        writer.Close();
                    }
                }

                General.muestraMensaje("Existen registros duplicados en el archivo de mapeo. Verifique");
            }
        }

        #endregion Eventos

        #region Metodos

        private void LimpiarDatos()
        {
            this.chkPrimerFilaNombresColumnas.Checked = false;
            this.txtArchivoCatalogoCuentas.Text = string.Empty;
            this.txtPathArchivoCatalogoCuentas.Text = string.Empty;
            this.dgvMetodosPago.Rows.Clear();
        }
        private bool CargaArchivoTXT(out string Error)
        {
            Cursor.Current = Cursors.WaitCursor;

            bool Cargado = true;
            Error = string.Empty;
            totalNoValidos = 0;

            General.cambiaMensajeStatus(this, "Cargando datos del archivo de Mapeo de Métodos de Pago...");

            try
            {
                DataTable dtMapeoMetodosPago = GetDataFromFile(txtPathArchivoCatalogoCuentas.Text, chkPrimerFilaNombresColumnas.Checked);
                DataView dvMetodosPago = dtMapeoMetodosPago.DefaultView;
                dvMetodosPago.Sort = "ClaveSociedad ASC, ClaveSAT ASC";
                DataTable dtMapeoCuentasOrder = dvMetodosPago.ToTable(true, "ClaveSociedad", "ClaveSAT");

                int CountCuenta = 0;
                dgvMetodosPago.Rows.Clear();

                dtCatalogoSAT = Database.ExecuteDataTable("select clave, concepto from SATEC_MetodosPagoSAT where activo = 1 order by clave");
                dtMapeoSociedad = Database.ExecuteDataTable("select claveSociedad, claveSAT from SATeC_MapeoMetodosPago where activo = 1 order by claveSAT");

                int RegistroAgregado = 0;

                foreach (DataRow datos in dtMapeoCuentasOrder.Rows)
                {
                    string ClaveSociedad = String.Empty;
                    string ClaveSAT = String.Empty;
                    string concepto = string.Empty;
                    bool ExisteCodigoSAT = true;
                    bool ExisteClave = false;
                    string Fallo = String.Empty;

                    try
                    {
                        CountCuenta++;

                        ClaveSociedad = datos[0].ToString();
                        ClaveSAT = datos[1].ToString();

                        ExisteCodigoSAT = ValidaClaveSAT(ClaveSAT, ref concepto);

                        if (!ExisteCodigoSAT)
                        {
                            totalNoValidos++;
                            concepto = string.Empty;
                            Fallo = "No se encontro la Clave en el Catalogo de Métodos de Pago del SAT";
                        }

                        ExisteClave = ValidaExisteMetodoPago(ClaveSAT);

                        if (ExisteClave)
                        {
                            totalExistentes++;
                            Fallo = "Clave SAT registrada, se actualizara clave de la sociedad";
                        }

                        RegistroAgregado = dgvMetodosPago.Rows.Add(ClaveSociedad, ClaveSAT, concepto, ExisteClave, Fallo);
                    }
                    catch (Exception ex)
                    {
                        Error = ex.Message;
                        Cargado = false;
                        break;
                    }
                    finally
                    {
                        if (!ExisteCodigoSAT)
                        {
                            for (int i = 0; i < dgvMetodosPago.Columns.Count; i++)
                            {
                                dgvMetodosPago.Rows[RegistroAgregado].Cells[i].Style.BackColor = Color.Red;
                                dgvMetodosPago.Rows[RegistroAgregado].Cells[i].Style.SelectionBackColor = Color.Red;
                                dgvMetodosPago.Rows[RegistroAgregado].Cells[i].Style.ForeColor = Color.Black;
                                dgvMetodosPago.Rows[RegistroAgregado].Cells[i].Style.SelectionForeColor = Color.Black;
                            }
                        }

                        if (ExisteClave)
                        {
                            for (int i = 0; i < dgvMetodosPago.Columns.Count; i++)
                            {
                                dgvMetodosPago.Rows[RegistroAgregado].Cells[i].Style.BackColor = Color.Yellow;
                                dgvMetodosPago.Rows[RegistroAgregado].Cells[i].Style.SelectionBackColor = Color.Yellow;
                                dgvMetodosPago.Rows[RegistroAgregado].Cells[i].Style.ForeColor = Color.Black;
                                dgvMetodosPago.Rows[RegistroAgregado].Cells[i].Style.SelectionForeColor = Color.Black;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Cargado = false;
                Error = ex.ToString();
            }

            if (totalNoValidos > 0)
            {
                General.muestraMensaje("Existen Claves del SAT No Válidas. Favor de verificar");
            }

            return Cargado;
        }
        private DataTable GetDataFromFile(string fileFull, bool existHeader)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataTable dtData = new DataTable();

            try
            {
                string full = Path.GetFullPath(fileFull);
                string file = Path.GetFileName(full);
                string dir = Path.GetDirectoryName(full);

                string archivoIni = "schema.ini";

                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("[{0}]", file);
                sb.AppendLine("");

                if (existHeader)
                    sb.AppendLine("ColNameHeader=True");
                else
                    sb.AppendLine("ColNameHeader=False");

                sb.AppendLine("Format=CSVDelimited");
                sb.AppendLine("Col1=ClaveSociedad Text");
                sb.AppendLine("Col2=ClaveSAT Text");

                using (StreamWriter writer = new StreamWriter(dir + @"\" + archivoIni))
                {
                    writer.Write(sb.ToString());
                }

                string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
                              + "Data Source=\"" + dir + "\\\";"
                              + "Extended Properties=\"text;";

                if (existHeader)
                    connectionString += "HDR=YES;";
                else
                    connectionString += "HDR=NO;";

                connectionString += "FMT=CSVDelimited\"";

                string query = "SELECT * FROM [" + file + "] WHERE ClaveSociedad IS NOT NULL";

                adapter = new OleDbDataAdapter(query, connectionString);
                var dsInformation = new DataSet();
                adapter.Fill(dsInformation);
                dtData = dsInformation.Tables[0];
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
        private bool ValidaClaveSAT(string ClaveSAT, ref string descripcion)
        {
            try
            {
                descripcion = string.Empty;

                DataRow[] drMetodosPagoSAT;

                drMetodosPagoSAT = dtCatalogoSAT.Select("clave = '" + ClaveSAT + "' ");

                if (drMetodosPagoSAT.Count() > 0)
                {
                    descripcion = drMetodosPagoSAT[0]["concepto"].ToString();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        private bool ValidaExisteMetodoPago(string claveSAT)
        {
            try
            {
                DataRow[] drRelacion;

                if (dtMapeoSociedad.Rows.Count > 0)
                {
                    drRelacion = dtMapeoSociedad.Select("claveSAT = '" + claveSAT + "' ");

                    if (drRelacion.Count() > 0)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        private bool ValidarImportacion(out string detalle)
        {
            detalle = String.Empty;
            int total = 0;
            bool valido = true;

            if (String.IsNullOrEmpty(txtPathArchivoCatalogoCuentas.Text))
            {
                total++;
                detalle += " Debe Proporcionar el archivo a cargar. \n";
            }
            else
            if (totalNoValidos > 0)
            {
                total++;
                detalle += "Existen Métodos de Pago No Validos. Favor de verificar. \n";
            }

            if (total > 0)
                valido = false;

            return valido;
        }

        #endregion Metodos

    }
}