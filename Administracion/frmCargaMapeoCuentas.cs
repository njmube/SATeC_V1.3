using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Data.OleDb;

namespace SATeC.Administracion
{
    public partial class frmCargaMapeoCuentas : Form
    {
        #region Atributos

        private DataTable dtCatalogoCuentas;
        private DataTable dtCatalogoSAT;
        int totalNoValidos = 0;

        #endregion Aributos

        #region Constructor

        public frmCargaMapeoCuentas()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Eventos

        private void frmCargaMapeoCuentas_Load(object sender, EventArgs e)
        {
            LimpiarDatos();
            CargarCatalogosCuenta();
        }
        private void lblSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos TXT(*.txt, *.csv)|*.txt; *.csv";
            openFileDialog1.Title = "Seleccione el archivo de Mapeo de Cuentas";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                General.cambiaMensajeStatus(this, "Cargando Archivo de Mapeo de Cuentas desde el archivo TXT...");

                txtArchivoCatalogoCuentas.Text = openFileDialog1.SafeFileName;
                txtPathArchivoCatalogoCuentas.Text = openFileDialog1.FileName;
                dgvCatalogoCuentas.Rows.Clear();
                string Error = string.Empty;

                General.cambiaMensajeStatus(this, "Validando existencia del Catalogo de Cuentas...");

                if (CargaArchivoTXT(out Error))
                {
                    General.muestraMensaje("Carga de archivo terminado.\n " + Error);
                }
                else
                {
                    General.muestraMensaje("Ocurrio un error al abrir el archivo de Mapeo de Cuentas.\n" + Error);
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

                    OleDbDataReader drSociedades = Database.obtenRegistros("SELECT TOP 1 ID_Sociedad FROM SATeC_Sociedades WHERE ID_CatalogoCuentas = " + ((ListItem)cmbCatalogoCuentas.SelectedItem).Valor);

                    string ID_Sociedad = String.Empty;

                    while (drSociedades.Read())
                    {
                        ID_Sociedad = drSociedades["ID_Sociedad"].ToString();
                    }

                    SQL += "DELETE FROM SATeC_CuentasSociedad_CuentasSAT WHERE ID_Sociedad = " + ID_Sociedad + "  \n";

                    foreach (DataGridViewRow row in dgvCatalogoCuentas.Rows)
                    {
                        SQL += " INSERT INTO SATeC_CuentasSociedad_CuentasSAT (ID_Sociedad, CuentaPadre, CuentaAuxiliar, CodigoAgrupadorSAT) VALUES (";
                        SQL += ID_Sociedad;
                        SQL += ", '" + row.Cells["Cuenta"].Value + "'";
                        SQL += ", '" + row.Cells["Subcta"].Value + "'";
                        SQL += ", '" + row.Cells["CodigoAgrupador"].Value + "'";
                        SQL += ") \n";

                        SQL += "IF NOT EXISTS ( SELECT 1 FROM SATeC_CuentasSociedad_CuentasSAT WHERE ID_Sociedad = " + ID_Sociedad + " AND CuentaPadre = '" + row.Cells["Cuenta"].Value + "' AND CuentaAuxiliar = '') " + "  \n";
                        SQL += "IF ( (SELECT COUNT(ID_Sociedad) FROM SATeC_CuentasSociedad_CuentasSAT WHERE ID_Sociedad = " + ID_Sociedad + " AND CuentaPadre = '" + row.Cells["Cuenta"].Value + "') > 0) " + "  \n";
                        SQL += "INSERT INTO SATeC_CuentasSociedad_CuentasSAT (ID_Sociedad, CuentaPadre, CuentaAuxiliar, CodigoAgrupadorSAT) VALUES(" + ID_Sociedad + ", '" + row.Cells["Cuenta"].Value + "', '', '')" + "  \n";
                    }
                    
                    SQL += " EXEC SATeC_ReplicarCuentasSociedades " + ID_Sociedad + " \n ";

                    if (Database.ejecutaQuery(SQL, true))
                    {
                        Salir = true;
                        General.muestraMensaje("Los datos de la carga del mapeo de cuentas se ha registrado con exitosamente.");
                    }
                    else
                    {
                        General.muestraMensaje("Ocurrio un error al tratar de guardar los datos de la carga del mapeo de cuentas: " + Database.Error);
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
                sbLogErrores.AppendLine(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + " | Error en el proceso de carga del archivo de Mapeo de Cuentas. | Exception: " + ex.Message);

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
            this.dgvCatalogoCuentas.Rows.Clear();            
        }
        private void CargarCatalogosCuenta()
        {
            OleDbDataReader drCatalogosCuentas = Database.obtenRegistros("SELECT ID_CatalogoCuentas, Nombre_CatalogoCuentas FROM SATeC_CatalogosCuentas WHERE ID_CatalogoCuentas IN ( SELECT ID_CatalogoCuentas FROM SATeC_Sociedades ) ORDER BY Nombre_CatalogoCuentas");
            
            while (drCatalogosCuentas.Read())
            {
                cmbCatalogoCuentas.Items.Add(new ListItem(drCatalogosCuentas["ID_CatalogoCuentas"].ToString(), drCatalogosCuentas["Nombre_CatalogoCuentas"].ToString()));
            }
        }
        private bool CargaArchivoTXT(out string Error)
        {
            Cursor.Current = Cursors.WaitCursor;

            bool Cargado = true;
            Error = string.Empty;
            totalNoValidos = 0;

            General.cambiaMensajeStatus(this, "Cargando datos del archivo de Mapeo de Cuentas...");

            try
            {
                DataTable dtMapeoCuentas = GetDataFromFile(txtPathArchivoCatalogoCuentas.Text, chkPrimerFilaNombresColumnas.Checked);
                DataView dvCuentas = dtMapeoCuentas.DefaultView;
                dvCuentas.Sort = "Cuenta ASC, Subcta ASC";
                DataTable dtMapeoCuentasOrder = dvCuentas.ToTable(true, "Cuenta", "Subcta", "CodigoAgrupador");

                int CountCuenta = 0;                
                dgvCatalogoCuentas.Rows.Clear();

                dtCatalogoCuentas = Database.ExecuteDataTable("SELECT CC.Cuenta, CC.DescripcionCuenta, CC.Naturaleza NaturalezaCuenta, CA.CuentaAuxiliar, CA.DescripcionCuentaAuxiliar, CA.Naturaleza NaturalezaAuxiliar FROM SATeC_CatalogoCuentas_Cuentas CC LEFT OUTER JOIN SATeC_CatalogoCuentasAuxiliares_CuentasAuxiliares CA ON CA.CuentaPadre = CC.Cuenta WHERE ID_CatalogoCuentas = " + ((ListItem)cmbCatalogoCuentas.SelectedItem).Valor + " ORDER BY CC.Cuenta");
                dtCatalogoSAT = Database.ExecuteDataTable("SELECT Codigo_Agrupador, Codigo_Agrupador_Entero, Codigo_Agrupador_Decimal, Nombre_Cuenta FROM SATeC_CatalogoCuentasSAT ORDER BY Codigo_Agrupador");

                int RegistroAgregado = 0;

                foreach (DataRow datos in dtMapeoCuentasOrder.Rows)
                {
                    string Cuenta = String.Empty;
                    string Subcta = String.Empty;
                    string DescripcionCuenta = String.Empty;
                    string CodigoAgrupador = String.Empty;
                    bool ExisteCuenta = true;
                    bool ExisteCodigoAgrupadorSAT = true;
                    string Fallo = String.Empty;

                    try
                    {
                        CountCuenta++;

                        Cuenta = datos[0].ToString();
                        Subcta = datos[1].ToString();
                        CodigoAgrupador = datos[2].ToString();

                        ExisteCuenta = ExisteNumeroCuentaAndSubcuenta(Cuenta, Subcta);

                        ExisteCodigoAgrupadorSAT = ValidaCodigoAgrupadorSAT(CodigoAgrupador);

                        if (!ExisteCuenta)
                        {
                            totalNoValidos++;
                            Fallo = "No se encontro la relación Cuenta / Cuenta - Subcuenta dentro del Catalogo de Cuentas de la Sociedad";
                        }
                            
                        if (!ExisteCodigoAgrupadorSAT)
                        {
                            totalNoValidos++;
                            Fallo = "No se encontro la Cuenta en el Catalogo de Cuentas del SAT";
                        }

                        RegistroAgregado = dgvCatalogoCuentas.Rows.Add(Cuenta, Subcta, CodigoAgrupador, ExisteCuenta, Fallo);
                    }
                    catch (Exception ex)
                    {
                        Error = ex.Message;
                        Cargado = false;
                        break;
                    }
                    finally
                    {
                        if (!ExisteCuenta || !ExisteCodigoAgrupadorSAT)
                        {
                            for (int i = 0; i < dgvCatalogoCuentas.Columns.Count; i++)
                            {
                                dgvCatalogoCuentas.Rows[RegistroAgregado].Cells[i].Style.BackColor = Color.Red;
                                dgvCatalogoCuentas.Rows[RegistroAgregado].Cells[i].Style.SelectionBackColor = Color.Red;
                                dgvCatalogoCuentas.Rows[RegistroAgregado].Cells[i].Style.ForeColor = Color.Black;
                                dgvCatalogoCuentas.Rows[RegistroAgregado].Cells[i].Style.SelectionForeColor = Color.Black;
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
                General.muestraMensaje("Existen Cuentas / Cuentas - Subcuentas no validas. Favor de verificar");
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

                if(existHeader)
                    sb.AppendLine("ColNameHeader=True");
                else
                    sb.AppendLine("ColNameHeader=False");

                sb.AppendLine("Format=CSVDelimited");
                sb.AppendLine("Col1=Cuenta Text");
                sb.AppendLine("Col2=Subcta Text");
                sb.AppendLine("Col3=CodigoAgrupador Text");

                using (StreamWriter writer = new StreamWriter(dir + @"\" + archivoIni))
                {
                    writer.Write(sb.ToString());
                }

                string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
                              + "Data Source=\"" + dir + "\\\";"
                              + "Extended Properties=\"text;";
                
                if(existHeader)
                    connectionString+= "HDR=YES;";
                else
                    connectionString+= "HDR=NO;";
                
                connectionString+= "FMT=CSVDelimited\"";

                string query = "SELECT * FROM [" + file + "] WHERE Cuenta IS NOT NULL";

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
        private bool ExisteNumeroCuentaAndSubcuenta(string cuenta, string subSuenta)
        {
            try
            {
                DataRow[] drCuentas;

                if(!String.IsNullOrEmpty(subSuenta))
                    drCuentas = dtCatalogoCuentas.Select("Cuenta = '" + cuenta + "' AND CuentaAuxiliar = '" + subSuenta + "'");
                else
                    drCuentas = dtCatalogoCuentas.Select("Cuenta = '" + cuenta + "' ");

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
        private bool ValidaCodigoAgrupadorSAT(string CodigoAgrupador)
        {
            try
            {
                DataRow[] drCuentasSAT;

                drCuentasSAT = dtCatalogoSAT.Select("Codigo_Agrupador = '" + CodigoAgrupador + "' ");

                if (drCuentasSAT.Count() > 0)
                    return true;
                else
                    return false;
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

            if (String.IsNullOrEmpty(cmbCatalogoCuentas.Text))
            {
                total++;
                detalle += "Debe seleccionar el Catalogo de Cuentas. \n";
            }
            else
                if (String.IsNullOrEmpty(txtPathArchivoCatalogoCuentas.Text))
                {
                    total++;
                    detalle += " Debe Proporcionar el archivo a cargar. \n";
                }
                else
                    if (totalNoValidos > 0)
                    {
                        total++;
                        detalle += "Existen Cuentas/Subcuentas/Codigos Agrupadores No Validos. Favor de verificar. \n";
                    }

            if (total > 0)
                valido = false;

            return valido;
        }

        #endregion Metodos

    }
}
