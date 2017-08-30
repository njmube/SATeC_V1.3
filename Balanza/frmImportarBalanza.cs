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

namespace SATeC.Balanza {
	public partial class frmImportarBalanza : Form {

		Dictionary<string, List<string>> CuentasSociedad = new Dictionary<string, List<string>>();

        List<string> CuentasErroresImportes = new List<string>();
        List<string> CuentasNoExisten = new List<string>();
        List<string> CuentasNoRelacionadas = new List<string>();

        //// INICIO: Seccion Balanza Acumulativa Senderos.
        //int ID_Balanza = 0;
        //// FIN: Seccion Balanza Acumulativa Senderos.
		
		private bool MostrandoSoloConErrores = true;
        private int TotalBalanzas = 0;
        private decimal TotalDebe = 0.00m;
        private decimal TotalHaber = 0.00m;

        private decimal TotalSaldoInicial = 0.00m;
        private decimal TotalSaldoFinal = 0.00m;

        private bool ExpandirTodo { get; set; }
        private string TipoEnvio { get; set; }

		public frmImportarBalanza() 
        {
			InitializeComponent();
		}
		private void frmImportarBalanza_Load(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;
			this.Dock = DockStyle.Fill;
			limpiaDatos();
			cargarEjerciciosPeriodos();
			cargarCuentasSociedad();
			Cursor = Cursors.Default;
            txtNoBalanzas.Text = String.Empty;
            txtTotalDebe.Text = String.Empty;
            txtTotalHaber.Text = String.Empty;
            txtDiferencia.Text = String.Empty;
            
            ExpandirTodo = true;
            //cmdMostrar.Visible = false;
            cmdExpandir.Visible = false;
            chkCuentasNoRelacionadas.Checked = true;

            //// INICIO: Seccion Balanza Acumulativa Senderos.
            //chkEsAcumulativa.Visible = false;
            //chkCerrar.Visible = false;
            //lblBalanzas.Visible = false;
            //cmbBalanza.Visible = false;
            //lblNueva.Visible = false;
            //// FIN: Seccion Balanza Acumulativa Senderos.
		}
		private void limpiaDatos() 
        {
			this.cmbEjercicioPeriodo.Items.Clear();
			this.chkPrimerFilaNombresColumnas.Checked = false;
			this.txtArchivoBalanza.Text = string.Empty;
			this.txtPathArchivoBalanza.Text = string.Empty;
		}
		private void cargarEjerciciosPeriodos() 
        {
            cmbEjercicioPeriodo.Items.Clear();

			OleDbDataReader drEjerciciosPeriodos = Database.obtenRegistros("SELECT Ejercicio+' - '+Periodo+' '+Mes AS EjercicioPeriodo FROM SATeC_EjerciciosPeriodos ORDER BY Ejercicio+' - '+Periodo+' '+Mes");
			
            while(drEjerciciosPeriodos.Read()) {
				ListItem itmEjercicioPeriodo = new ListItem(drEjerciciosPeriodos["EjercicioPeriodo"].ToString(), drEjerciciosPeriodos["EjercicioPeriodo"].ToString());
				cmbEjercicioPeriodo.Items.Add(itmEjercicioPeriodo);
			}
			
            drEjerciciosPeriodos.Close();
			drEjerciciosPeriodos.Dispose();
		}
        private void cargarCuentasSociedad()
        {
            OleDbDataReader drCuentasSociedad = Database.obtenRegistros("obtenerCuentasSociedad_RelacionSAT", CommandType.StoredProcedure, General.ID_SociedadSeleccionada.ToString());
            
            while (drCuentasSociedad.Read())
            {

                string Cuenta = drCuentasSociedad["Cuenta"].ToString();
                int Nivel = int.Parse(drCuentasSociedad["Nivel"].ToString());

                if (Nivel > 1)
                    Cuenta = drCuentasSociedad["CuentaPadre"].ToString() + "-" + drCuentasSociedad["Cuenta"].ToString();

                List<string> CuentaRelacionSAT = new List<string>();
                CuentaRelacionSAT.Add(drCuentasSociedad["DescripcionCuenta"].ToString());
                CuentaRelacionSAT.Add(drCuentasSociedad["CodigoAgrupadorSAT"].ToString());
                CuentaRelacionSAT.Add(drCuentasSociedad["NombreCuentaSAT"].ToString());

                // Se agrega validación para evitar que se dupliquen Cuentas. MAMA 23-Marzo-2015.
                if (!CuentasSociedad.ContainsKey(Cuenta))
                    CuentasSociedad.Add(Cuenta, CuentaRelacionSAT);
            }

            drCuentasSociedad.Close();
            drCuentasSociedad.Dispose();
        }

        //// INICIO: Seccion Balanza Acumulativa Senderos.
        //private void CargarBalanzasExistentes()
        //{
        //    cmbBalanza.Items.Clear();

        //    string[] EjercicioPeriodo = ((ListItem)cmbEjercicioPeriodo.SelectedItem).Texto.Split('-');
        //    string Ejercicio = EjercicioPeriodo[0].Trim();
        //    string Periodo = EjercicioPeriodo[1].Trim().Substring(0, 2);

        //    OleDbDataReader drBalanzas = Database.obtenRegistros("SELECT ID_Balanza FROM SATeC_Balanzas WHERE ID_Sociedad = " + General.ID_SociedadSeleccionada + " AND Ejercicio = '" + Ejercicio + "' AND Periodo = '" + Periodo + "' AND Cerrada = 0 AND [XML] IS NULL ORDER BY ID_Balanza");

        //    while (drBalanzas.Read())
        //    {
        //        ListItem itmBalanza = new ListItem(drBalanzas["ID_Balanza"].ToString(), drBalanzas["ID_Balanza"].ToString());
        //        cmbBalanza.Items.Add(itmBalanza);
        //    }

        //    drBalanzas.Close();
        //    drBalanzas.Dispose();

        //    if (cmbBalanza.Items.Count > 0)
        //    {
        //        lblBalanzas.Visible = true;
        //        cmbBalanza.Visible = true;
        //        lblNueva.Visible = false;
        //    }
        //    else
        //    {
        //        lblBalanzas.Visible = false;
        //        cmbBalanza.Visible = false;
        //        lblNueva.Visible = true;
        //        ID_Balanza = 0;
        //    }
        //}
        //// FIN: Seccion Balanza Acumulativa Senderos.

		private void cmdAbrirArchivo_Click(object sender, EventArgs e) 
        {
			Cursor.Current = Cursors.WaitCursor;

			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Filter = "Archivos TXT(*.txt, *.csv)|*.txt; *.csv";
			openFileDialog1.Title = "Seleccione el archivo de la Balanza";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtArchivoBalanza.Text = openFileDialog1.SafeFileName;
                txtPathArchivoBalanza.Text = openFileDialog1.FileName;

                string Error = string.Empty;

                string[] EjercicioPeriodo = ((ListItem)cmbEjercicioPeriodo.SelectedItem).Texto.Split('-');
                string Ejercicio = EjercicioPeriodo[0].Trim();
                string Periodo = EjercicioPeriodo[1].Trim().Substring(0, 2);

                if (!CargaArchivoBalanzaTXTOLEBD(out Error))
                {
                    General.muestraMensaje("Ocurrio un error al cargar el archivo TXT de la Balanza.\n" + Error);
                }

            }

			Cursor.Current = Cursors.Default;
		}
        private bool CargaArchivoBalanzaTXTOLEBD(out string Error)
        {
            cmdMostrar.Text = "Mostrar Cuentas con Errores";
            cmdMostrar.Image = SATeC.Properties.Resources.MostrarSoloCuentasNoRelacionadas;
            cmdMostrar.Width = 280;
            MostrarTodas();
            MostrandoSoloConErrores = true;

            tgvCatalogoCuentasSociedad.Nodes.Clear();
            TotalBalanzas = 0;
            TotalDebe = 0.00m;
            TotalHaber = 0.00m;
            
            TotalSaldoInicial = 0.00m;
            TotalSaldoFinal = 0.00m;

            bool Cargado = true;
            Error = string.Empty;

            CuentasErroresImportes = new List<string>();
            CuentasNoExisten = new List<string>();
            CuentasNoRelacionadas = new List<string>();
            
            int totalNoValidos = 0;            
            int totalCuentasNoExisten = 0;
            int totalCuentasNoRelacionadas = 0;

            try
            {
                DataTable dtBalanza = GetDataFromFile(txtPathArchivoBalanza.Text, chkPrimerFilaNombresColumnas.Checked);
                DataView dvBalanza = dtBalanza.DefaultView;
                dvBalanza.Sort = "CTA ASC";
                DataTable dtBalanzaOrder = dvBalanza.ToTable();

                int CountCuenta = 0;

                tgvCatalogoCuentasSociedad.Nodes.Clear();

                AdvancedDataGridView.TreeGridNode dataGridNodePadre = new AdvancedDataGridView.TreeGridNode();
                AdvancedDataGridView.TreeGridNode dataGridNodeHijo = new AdvancedDataGridView.TreeGridNode();

                foreach (DataRow DatosBalanza in dtBalanzaOrder.Rows)
                {
                    string Cuenta = string.Empty;
                    string DescripcionCuenta = string.Empty;
                    string CodigoAgrupadorSAT = string.Empty;
                    string NombreCuentaSAT = string.Empty;
                    bool ExisteCuenta = true;
                    bool ImportesValidos = true;
                    bool CuentaNoRelacionada = true;

                    decimal SaldoInicial = 0.00m;
                    decimal CargosDelMes = 0.00m;
                    decimal AbonosDelMes = 0.00m;
                    decimal SaldoFinal = 0.00m;

                    try
                    {
                        CountCuenta++;

                        string ano = DatosBalanza[0].ToString();
                        string mes = DatosBalanza[1].ToString();

                        string[] EjercicioPeriodo = ((ListItem)cmbEjercicioPeriodo.SelectedItem).Texto.Split('-');
                        string Ejercicio = EjercicioPeriodo[0].Trim();
                        string Periodo = EjercicioPeriodo[1].Trim().Substring(0, 2);

                        if (!(Ejercicio.Equals(ano) && Periodo.Equals(mes)))
                        {
                            General.muestraMensaje("El año y mes de la balanza debe corresponder al periodo seleccionado. Favor de validar");
                            break;
                        }

                        Cuenta = DatosBalanza[2].ToString();

                        if (!CuentasSociedad.ContainsKey(Cuenta))
                        {
                            ExisteCuenta = false;
                            totalCuentasNoExisten++;

                            if (!CuentasNoExisten.Contains(Cuenta))
                                CuentasNoExisten.Add(Cuenta);

                        }
                        else
                        {
                            List<string> CuentaRelacionSAT = CuentasSociedad[Cuenta];
                            DescripcionCuenta = CuentaRelacionSAT.ElementAt(0).ToString();

                            if (CuentaRelacionSAT.ElementAt(1).ToString() == string.Empty)
                            {
                                CuentaNoRelacionada = false;
                                totalCuentasNoRelacionadas++;

                                if (!CuentasNoRelacionadas.Contains(Cuenta))
                                    CuentasNoRelacionadas.Add(Cuenta);
                            }
                            else
                            {
                                CodigoAgrupadorSAT = CuentaRelacionSAT.ElementAt(1).ToString();
                                NombreCuentaSAT = CuentaRelacionSAT.ElementAt(2).ToString();
                            }
                        }

                        SaldoInicial = 0.00m;
                        CargosDelMes = 0.00m;
                        AbonosDelMes = 0.00m;
                        SaldoFinal = 0.00m;

                        if (!String.IsNullOrEmpty(DatosBalanza[3].ToString()))
                            SaldoInicial = decimal.Parse(DatosBalanza[3].ToString());

                        if (!String.IsNullOrEmpty(DatosBalanza[4].ToString()))
                            CargosDelMes = decimal.Parse(DatosBalanza[4].ToString());

                        if (!String.IsNullOrEmpty(DatosBalanza[5].ToString()))
                            AbonosDelMes = decimal.Parse(DatosBalanza[5].ToString());

                        if (!String.IsNullOrEmpty(DatosBalanza[6].ToString()))
                            SaldoFinal = decimal.Parse(DatosBalanza[6].ToString());

                        if (ExisteCuenta)
                        {
                            decimal totalValidar = SaldoInicial + CargosDelMes - AbonosDelMes;

                            if (SaldoFinal != totalValidar)
                            {
                                ImportesValidos = false;
                                totalNoValidos++;

                                if (!CuentasErroresImportes.Contains(Cuenta))
                                    CuentasErroresImportes.Add(Cuenta);
                            }

                            if (CuentaNoRelacionada)
                            {
                                TotalBalanzas++;
                                TotalDebe += CargosDelMes;
                                TotalHaber += AbonosDelMes;

                                TotalSaldoInicial += SaldoInicial;
                                TotalSaldoFinal += SaldoFinal;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Error = ex.Message;
                        Cargado = false;
                        break;
                    }
                    finally
                    {
                        if (CountCuenta > 0)
                        {
                            dataGridNodePadre = tgvCatalogoCuentasSociedad.Nodes.Add(Cuenta, DescripcionCuenta, CodigoAgrupadorSAT, NombreCuentaSAT, SaldoInicial, CargosDelMes, AbonosDelMes, SaldoFinal, ExisteCuenta, Cuenta);

                            for (int i = 0; i < dataGridNodePadre.Cells.Count; i++)
                            {
                                if (!ExisteCuenta)
                                {
                                    dataGridNodePadre.Cells[i].Style.BackColor = Color.Gray;
                                    dataGridNodePadre.Cells[i].Style.SelectionBackColor = Color.Gray;
                                    dataGridNodePadre.Cells[i].Style.ForeColor = Color.Black;
                                    dataGridNodePadre.Cells[i].Style.SelectionForeColor = Color.Black;
                                }
                                else
                                    if (!ImportesValidos)
                                    {
                                        dataGridNodePadre.Cells[i].Style.BackColor = Color.Red;
                                        dataGridNodePadre.Cells[i].Style.SelectionBackColor = Color.Red;
                                        dataGridNodePadre.Cells[i].Style.ForeColor = Color.Black;
                                        dataGridNodePadre.Cells[i].Style.SelectionForeColor = Color.Black;
                                    }
                                    else
                                        if (!CuentaNoRelacionada)
                                        {
                                            dataGridNodePadre.Cells[i].Style.BackColor = Color.FromArgb(167, 200, 219);
                                            dataGridNodePadre.Cells[i].Style.SelectionBackColor = Color.FromArgb(167, 200, 219);
                                            dataGridNodePadre.Cells[i].Style.ForeColor = Color.Black;
                                            dataGridNodePadre.Cells[i].Style.SelectionForeColor = Color.Black;
                                        }
                            }
                        }
                    }
                } // Llave del ForEach.

            }
            catch (Exception ex)
            {
                int tot = TotalBalanzas;
                Cargado = false;
                Error = ex.ToString();
            }

            txtNoBalanzas.Text = TotalBalanzas.ToString();
            txtTotalDebe.Text = TotalDebe.ToString("#,##0.00;(#,##0.00)");
            txtTotalHaber.Text = TotalHaber.ToString("#,##0.00;(#,##0.00)");
            
            txtTotalSaldoInicial.Text = TotalSaldoInicial.ToString("#,##0.00;(#,##0.00)");
            txtTotalSaldoFinal.Text = TotalSaldoFinal.ToString("#,##0.00;(#,##0.00)");

            decimal diferencia = TotalDebe - TotalHaber;

            txtDiferencia.Text = diferencia.ToString("#,##0.00;(#,##0.00)");

            if (totalCuentasNoExisten > 0)
            {
                General.muestraMensaje("Existen Cuentas No Registradas en el Catalogo de Cuentas.");
            }

            if (totalNoValidos > 0)
            {
                General.muestraMensaje("Existen Cuentas Con Diferencias en los Importes.");
            }

            if (totalCuentasNoRelacionadas > 0)
            {
                General.muestraMensaje("Existen Cuentas No Relacionadas Con el SAT.");
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
                sb.AppendLine("Col1=Ano Text");
                sb.AppendLine("Col2=Mes Text");
                sb.AppendLine("Col3=CTA Text");
                sb.AppendLine("Col4=INICIAL Currency");
                sb.AppendLine("Col5=DEBE Currency");
                sb.AppendLine("Col6=HABER Currency");
                sb.AppendLine("Col7=FINAL Currency");

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
                    connectionString+= "HDR=FALSE;";
                
                connectionString+= "FMT=CSVDelimited\"";

                string query = "SELECT * FROM [" + file + "] WHERE Ano IS NOT NULL";

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
		private void cmdGuardar_Click(object sender, EventArgs e) 
        {
            //// VERSION DEMO RESTRINGIDA.
            //int total = int.Parse(Database.obtenerDato("SELECT COUNT(ID_Balanza) Total FROM SATeC_Balanzas"));
            //int totalBalanzas = int.Parse(Properties.Resources.TotalBalanzas);

            //if (total > totalBalanzas)
            //{
            //    General.muestraMensaje("La version Demo solo permite guardar hasta " + Properties.Resources.TotalBalanzas + " Balanzas. Solicite la version completa.");
            //}
            //else
            //{
            //    if (ID_Balanza == 0)
            //    {
            //        GuardarBalanzaInicial();
            //    }
            //    else
            //    {
            //        GuardarBalanzaAcumulativa();
            //    }
            //}

            //// INICIO: Seccion Balanza Acumulativa Senderos.
            //if (ID_Balanza == 0)
            //{
            //    GuardarBalanzaInicial();
            //}
            //else
            //{
            //    GuardarBalanzaAcumulativa();
            //}
            //// FIN: Seccion Balanza Acumulativa Senderos.

            GuardarBalanzaInicial();
		}
        private void GuardarBalanzaInicial()
        {
            cmdMostrar.Text = "Mostrar Cuentas con Errores";
            cmdMostrar.Image = SATeC.Properties.Resources.MostrarSoloCuentasNoRelacionadas;
            cmdMostrar.Width = 280;
            MostrarTodas();
            MostrandoSoloConErrores = true;

            Cursor = Cursors.WaitCursor;
            bool Salir = false;
            string SQL = string.Empty;

            if (validaBalanza())
            {
                string[] EjercicioPeriodo = ((ListItem)cmbEjercicioPeriodo.SelectedItem).Texto.Split('-');
                string Ejercicio = EjercicioPeriodo[0].Trim();
                string Periodo = EjercicioPeriodo[1].Trim().Substring(0, 2);

                SQL = "INSERT INTO SATeC_Balanzas (ID_Sociedad, Ejercicio, Periodo, Fecha_Importacion, ID_Usuario_Importacion, TipoEnvio, FechaModBal) VALUES(";
                SQL += General.ID_SociedadSeleccionada + ", ";
                SQL += "'" + Ejercicio + "', ";
                SQL += "'" + Periodo + "', ";
                SQL += "getdate(), ";
                SQL += General.UsuarioActual.ID;
                SQL += ", '" + TipoEnvio + "' ";

                if (TipoEnvio.Equals("C"))
                    SQL += ", GETDATE()";
                else
                    SQL += ", NULL";

                SQL += ")\n";

                SQL += "DECLARE @ID_Balanza int = @@IDENTITY\n";

                List<string> listaCuentasNoRelacionadas = new List<string>();

                foreach (AdvancedDataGridView.TreeGridNode cuenta in tgvCatalogoCuentasSociedad.Nodes)
                {
                    listaCuentasNoRelacionadas = CuentasNoRelacionadas.FindAll(item => item.Equals(cuenta.Cells["CuentaAll"].Value));

                    if (listaCuentasNoRelacionadas.Count == 0)
                    {
                        SQL += "INSERT INTO SATeC_Balanza_Detalle (ID_Balanza, Cuenta, SaldoInicial, Cargos, Abonos, SaldoFinal) VALUES(";
                        SQL += "@ID_Balanza";
                        SQL += ", '" + cuenta.Cells["CuentaAll"].Value + "'";
                        SQL += ", " + cuenta.Cells["SaldoInicial"].Value + "";
                        SQL += ", " + cuenta.Cells["Cargos"].Value + "";
                        SQL += ", " + cuenta.Cells["Abonos"].Value + "";
                        SQL += ", " + cuenta.Cells["SaldoFinal"].Value + "";
                        SQL += ")\n";
                    }

                    foreach (AdvancedDataGridView.TreeGridNode subCuenta in cuenta.Nodes)
                    {
                        listaCuentasNoRelacionadas = CuentasNoRelacionadas.FindAll(item => item.Equals(subCuenta.Cells[9].Value));

                        if (listaCuentasNoRelacionadas.Count == 0)
                        {
                            SQL += "INSERT INTO SATeC_Balanza_Detalle (ID_Balanza, Cuenta, SaldoInicial, Cargos, Abonos, SaldoFinal) VALUES(";
                            SQL += "@ID_Balanza";
                            SQL += ", '" + subCuenta.Cells[9].Value + "'";
                            SQL += ", " + subCuenta.Cells[4].Value + "";
                            SQL += ", " + subCuenta.Cells[5].Value + "";
                            SQL += ", " + subCuenta.Cells[6].Value + "";
                            SQL += ", " + subCuenta.Cells[7].Value + "";
                            SQL += ")\n";
                        }
                    }
                }

                if (Database.ejecutaQuery(SQL, true))
                {
                    General.muestraMensaje("Los datos de la Balanza se han guardado con exito.");
                    Salir = true;
                }
                else
                {
                    General.muestraMensaje("Ocurrio un error al tratar de guardar los datos de la Balanza: " + Database.Error);
                    Salir = true;
                }
            }

            Cursor = Cursors.Default;

            if (Salir)
                this.Close();
        }

        //// INICIO: Seccion Balanza Acumulativa Senderos.
        //private void GuardarBalanzaInicial()
        //{
        //    cmdMostrar.Text = "Mostrar Cuentas con Errores";
        //    cmdMostrar.Image = SATeC.Properties.Resources.MostrarSoloCuentasNoRelacionadas;
        //    cmdMostrar.Width = 280;
        //    MostrarTodas();
        //    MostrandoSoloConErrores = true;

        //    Cursor = Cursors.WaitCursor;
        //    bool Salir = false;
        //    string SQL = string.Empty;

        //    if (validaBalanza())
        //    {
        //        //VHJC ...se guarda la informacion de la Balanza
        //        string[] EjercicioPeriodo = ((ListItem)cmbEjercicioPeriodo.SelectedItem).Texto.Split('-');
        //        string Ejercicio = EjercicioPeriodo[0].Trim();
        //        string Periodo = EjercicioPeriodo[1].Trim().Substring(0, 2);

        //        SQL = "INSERT INTO SATeC_Balanzas (ID_Sociedad, Ejercicio, Periodo, Fecha_Importacion, ID_Usuario_Importacion, TipoEnvio, FechaModBal, Cerrada) VALUES(";
        //        SQL += General.ID_SociedadSeleccionada + ", ";
        //        SQL += "'" + Ejercicio + "', ";
        //        SQL += "'" + Periodo + "', ";
        //        SQL += "getdate(), ";
        //        SQL += General.UsuarioActual.ID;
        //        SQL += ", '" + TipoEnvio + "' ";

        //        if (TipoEnvio.Equals("C"))
        //            SQL += ", GETDATE()";
        //        else
        //            SQL += ", NULL";

        //        if (chkEsAcumulativa.Checked)
        //            SQL += ", 0";
        //        else
        //            SQL += ", 1";

        //        SQL += ")\n";

        //        SQL += "DECLARE @ID_Balanza int = @@IDENTITY\n";

        //        List<string> listaCuentasNoRelacionadas = new List<string>();

        //        foreach (AdvancedDataGridView.TreeGridNode cuenta in tgvCatalogoCuentasSociedad.Nodes)
        //        {
        //            listaCuentasNoRelacionadas = CuentasNoRelacionadas.FindAll(item => item.Equals(cuenta.Cells["CuentaAll"].Value));

        //            if (listaCuentasNoRelacionadas.Count == 0)
        //            {
        //                SQL += "INSERT INTO SATeC_Balanza_Detalle (ID_Balanza, Cuenta, SaldoInicial, Cargos, Abonos, SaldoFinal) VALUES(";
        //                SQL += "@ID_Balanza";
        //                SQL += ", '" + cuenta.Cells["CuentaAll"].Value + "'";
        //                SQL += ", " + cuenta.Cells["SaldoInicial"].Value + "";
        //                SQL += ", " + cuenta.Cells["Cargos"].Value + "";
        //                SQL += ", " + cuenta.Cells["Abonos"].Value + "";
        //                SQL += ", " + cuenta.Cells["SaldoFinal"].Value + "";
        //                SQL += ")\n";
        //            }

        //            foreach (AdvancedDataGridView.TreeGridNode subCuenta in cuenta.Nodes)
        //            {
        //                listaCuentasNoRelacionadas = CuentasNoRelacionadas.FindAll(item => item.Equals(subCuenta.Cells[9].Value));

        //                if (listaCuentasNoRelacionadas.Count == 0)
        //                {
        //                    SQL += "INSERT INTO SATeC_Balanza_Detalle (ID_Balanza, Cuenta, SaldoInicial, Cargos, Abonos, SaldoFinal) VALUES(";
        //                    SQL += "@ID_Balanza";
        //                    SQL += ", '" + subCuenta.Cells[9].Value + "'";
        //                    SQL += ", " + subCuenta.Cells[4].Value + "";
        //                    SQL += ", " + subCuenta.Cells[5].Value + "";
        //                    SQL += ", " + subCuenta.Cells[6].Value + "";
        //                    SQL += ", " + subCuenta.Cells[7].Value + "";
        //                    SQL += ")\n";
        //                }
        //            }
        //        }

        //        if (Database.ejecutaQuery(SQL, true))
        //        {
        //            General.muestraMensaje("Los datos de la Balanza se han guardado con exito.");
        //            Salir = true;
        //        }
        //        else
        //        {
        //            General.muestraMensaje("Ocurrio un error al tratar de guardar los datos de la Balanza: " + Database.Error);
        //            Salir = true;
        //        }
        //    }

        //    Cursor = Cursors.Default;

        //    if (Salir)
        //        this.Close();
        //}
        //private void GuardarBalanzaAcumulativa()
        //{
        //    cmdMostrar.Text = "Mostrar Cuentas con Errores";
        //    cmdMostrar.Image = SATeC.Properties.Resources.MostrarSoloCuentasNoRelacionadas;
        //    cmdMostrar.Width = 280;
        //    MostrarTodas();
        //    MostrandoSoloConErrores = true;

        //    Cursor = Cursors.WaitCursor;
        //    bool Salir = false;
        //    string SQL = string.Empty;

        //    if (validaBalanza())
        //    {
        //        string[] EjercicioPeriodo = ((ListItem)cmbEjercicioPeriodo.SelectedItem).Texto.Split('-');
        //        string Ejercicio = EjercicioPeriodo[0].Trim();
        //        string Periodo = EjercicioPeriodo[1].Trim().Substring(0, 2);

        //        string cerrada = "0";

        //        if (chkEsAcumulativa.Checked && chkCerrar.Checked)
        //        {
        //            cerrada = "1";
        //        }

        //        SQL += "DECLARE @ID_Balanza int = " + ID_Balanza.ToString() + " \n";
        //        SQL += "UPDATE SATeC_Balanzas SET Cerrada = " + cerrada + " WHERE ID_Balanza = @ID_Balanza AND ID_Sociedad = " + General.ID_SociedadSeleccionada + " AND Ejercicio = '" + Ejercicio + "' AND Periodo = '" + Periodo + "'";

        //        List<string> listaCuentasNoRelacionadas = new List<string>();

        //        foreach (AdvancedDataGridView.TreeGridNode cuenta in tgvCatalogoCuentasSociedad.Nodes)
        //        {
        //            listaCuentasNoRelacionadas = CuentasNoRelacionadas.FindAll(item => item.Equals(cuenta.Cells["CuentaAll"].Value));

        //            if (listaCuentasNoRelacionadas.Count == 0)
        //            {
        //                SQL += " IF(EXISTS (SELECT 1 FROM SATeC_Balanza_Detalle WHERE ID_Balanza = @ID_Balanza AND Cuenta = '" + cuenta.Cells["CuentaAll"].Value + "' ) ) \n";
        //                SQL += " UPDATE SATeC_Balanza_Detalle SET SaldoInicial = SaldoInicial + " + cuenta.Cells["SaldoInicial"].Value + ", Cargos = Cargos + " + cuenta.Cells["Cargos"].Value + ", Abonos = Abonos + " + cuenta.Cells["Abonos"].Value + ", SaldoFinal = SaldoFinal + " + cuenta.Cells["SaldoFinal"].Value + " WHERE ID_Balanza = @ID_Balanza AND Cuenta = '" + cuenta.Cells["CuentaAll"].Value + "' \n";
        //                SQL += " ELSE \n";
        //                SQL += " INSERT INTO SATeC_Balanza_Detalle (ID_Balanza, Cuenta, SaldoInicial, Cargos, Abonos, SaldoFinal) VALUES(";
        //                SQL += "@ID_Balanza";
        //                SQL += ", '" + cuenta.Cells["CuentaAll"].Value + "'";
        //                SQL += ", " + cuenta.Cells["SaldoInicial"].Value + "";
        //                SQL += ", " + cuenta.Cells["Cargos"].Value + "";
        //                SQL += ", " + cuenta.Cells["Abonos"].Value + "";
        //                SQL += ", " + cuenta.Cells["SaldoFinal"].Value + "";
        //                SQL += ")\n";
        //            }

        //            foreach (AdvancedDataGridView.TreeGridNode subCuenta in cuenta.Nodes)
        //            {
        //                listaCuentasNoRelacionadas = CuentasNoRelacionadas.FindAll(item => item.Equals(subCuenta.Cells[9].Value));

        //                if (listaCuentasNoRelacionadas.Count == 0)
        //                {
        //                    SQL += " IF(EXISTS (SELECT 1 FROM SATeC_Balanza_Detalle WHERE ID_Balanza = @ID_Balanza AND Cuenta = '" + cuenta.Cells["CuentaAll"].Value + "' ) ) \n";
        //                    SQL += " UPDATE SATeC_Balanza_Detalle SET SaldoInicial = SaldoInicial + " + subCuenta.Cells[4].Value + ", Cargos = Cargos + " + subCuenta.Cells[5].Value + ", Abonos = Abonos + " + subCuenta.Cells[6].Value + ", SaldoFinal = SaldoFinal + " + subCuenta.Cells[7].Value + " WHERE ID_Balanza = @ID_Balanza AND Cuenta = '" + subCuenta.Cells[9].Value + "' \n";
        //                    SQL += " ELSE \n";
        //                    SQL += " INSERT INTO SATeC_Balanza_Detalle (ID_Balanza, Cuenta, SaldoInicial, Cargos, Abonos, SaldoFinal) VALUES(";
        //                    SQL += "@ID_Balanza";
        //                    SQL += ", '" + subCuenta.Cells[9].Value + "'";
        //                    SQL += ", " + subCuenta.Cells[4].Value + "";
        //                    SQL += ", " + subCuenta.Cells[5].Value + "";
        //                    SQL += ", " + subCuenta.Cells[6].Value + "";
        //                    SQL += ", " + subCuenta.Cells[7].Value + "";
        //                    SQL += ")\n";
        //                }
        //            }
        //        }

        //        if (Database.ejecutaQuery(SQL, true))
        //        {
        //            General.muestraMensaje("Los datos de la Balanza se han guardado con exito.");
        //            Salir = true;
        //        }
        //        else
        //        {
        //            General.muestraMensaje("Ocurrio un error al tratar de guardar los datos de la Balanza: " + Database.Error);
        //            Salir = true;
        //        }
        //    }

        //    Cursor = Cursors.Default;

        //    if (Salir)
        //        this.Close();
        //}
        //// FIN: Seccion Balanza Acumulativa Senderos.


		private bool validaBalanza() {
			bool Valida = true;

			if(cmbEjercicioPeriodo.Text == string.Empty) {
				General.muestraMensaje("Debe seleccionar el Ejercicio / Periodo al que aplica la Balanza, favor de revisar.");
				cmbEjercicioPeriodo.Focus();
				cmbEjercicioPeriodo.DroppedDown = true;
				Valida = false;
			}          
            else if (txtArchivoBalanza.Text == string.Empty)
            {
                General.muestraMensaje("Debe seleccionar el archivo de la Balanza.");
                cmdAbrirArchivo.Focus();
                Valida = false;
            }
            else if (tgvCatalogoCuentasSociedad.Nodes.Count == 0)
            {
                General.muestraMensaje("El archivo de la Balanza no es correcto, favor de revisar.");
                txtArchivoBalanza.Focus();
                Valida = false;
            }
            else if (!validaCuentasBalanza())
            {
                General.muestraMensaje("Existen cuentas en la Balanza que no existen en el Catálogo de Cuentas\n de la Sociedad y/o no tienen relación con el Código Agrupador del SAT.");
                Valida = false;
            }
            else if (CuentasErroresImportes.Count > 0)
            {
                General.muestraMensaje("Existen Cuentas cuyos importes no cuadran. Validar Registros Marcados en Rojo");
                Valida = false;
            }
            else if (Math.Round(TotalDebe, 2) != Math.Round(TotalHaber, 2))
            {
                General.muestraMensaje("El total de cargos es diferente al total de abonos, favor de validar.");
                Valida = false;
            }
            else if (!guardaArchivoBalanza())
            {
                Valida = false;
            }
            //// INICIO: Seccion Balanza Acumulativa Senderos.
            //else if (chkEsAcumulativa.Enabled)
            //{
            //    if (cmbBalanza.Items.Count > 0)
            //    {
            //        if (cmbBalanza.Text == string.Empty)
            //        {
            //            General.muestraMensaje("Debe seleccionar el Numero de Balanza al que desea acumular, favor de revisar.");
            //            cmbBalanza.Focus();
            //            Valida = false;
            //        }
            //    }
            //}
            //// FIN: Seccion Balanza Acumulativa Senderos.

			return Valida;
		}
		private bool validaCuentasBalanza() {
			bool ValidaCuentas = true;

			//VHJC Por cada uno de los registros de la Balanza...
            foreach (AdvancedDataGridView.TreeGridNode cuenta in tgvCatalogoCuentasSociedad.Nodes)
            {
				//VHJC ... se verifica que exista la cuenta, si no existe se manda mensaje al usuario y se sale del proceso
                if (!bool.Parse(cuenta.Cells["ExisteCuenta"].Value.ToString()))
                {
					//General.muestraMensaje("La cuenta " + dgvrRegistroBalanza.Cells["Cuenta"].Value.ToString() + " no existe en el Catálogo de Cuentas de la Sociedad, favor de validar.");
					ValidaCuentas = false;
					break;
				}

                foreach (AdvancedDataGridView.TreeGridNode subCuenta in cuenta.Nodes)
                {
                    //VHJC ... se verifica que exista la cuenta, si no existe se manda mensaje al usuario y se sale del proceso
                    if (!bool.Parse(subCuenta.Cells[8].Value.ToString()))
                    {
                        //General.muestraMensaje("La cuenta " + dgvrRegistroBalanza.Cells["Cuenta"].Value.ToString() + " no existe en el Catálogo de Cuentas de la Sociedad, favor de validar.");
                        ValidaCuentas = false;
                        break;
                    }
                }

			}

			return ValidaCuentas;
		}
		private bool guardaArchivoBalanza() {
			return true;
		}
		private void cmdMostrar_Click(object sender, EventArgs e) 
        {
            if (MostrandoSoloConErrores)
            {
                cmdMostrar.Text = "Mostrar Todas";
                cmdMostrar.Image = SATeC.Properties.Resources.MostrarTodasCuentas;
                cmdMostrar.Width = 200;
                SoloMostrarCuentasErrores();
                MostrandoSoloConErrores = false;
            }
            else
            {
                cmdMostrar.Text = "Mostrar Cuentas con Errores";
                cmdMostrar.Image = SATeC.Properties.Resources.MostrarSoloCuentasNoRelacionadas;
                cmdMostrar.Width = 280;
                MostrarTodas();
                MostrandoSoloConErrores = true;
            }            
		}
        private void ExpandirCuentasErrores()
        {
            foreach (AdvancedDataGridView.TreeGridNode node in tgvCatalogoCuentasSociedad.Nodes)
            {
                string cuenta = node.Cells["Cuenta"].Value.ToString();

                List<string> listaEncontrados = CuentasErroresImportes.FindAll(item => item.Equals(cuenta));

                if (listaEncontrados.Count > 0)
                {
                    if (!node.IsExpanded)
                        node.Expand();
                }

                List<string> listaCuentasNoExisten = CuentasNoExisten.FindAll(item => item.Equals(cuenta));

                if (listaCuentasNoExisten.Count > 0)
                {
                    if (!node.IsExpanded)
                        node.Expand();
                }
            }
        }
        private void SoloMostrarCuentasErrores()
        {
            foreach (AdvancedDataGridView.TreeGridNode node in tgvCatalogoCuentasSociedad.Nodes)
            {
                string cuenta = node.Cells["Cuenta"].Value.ToString();

                List<string> listaEncontrados = CuentasErroresImportes.FindAll(item => item.Equals(cuenta));
                List<string> listaCuentasNoExisten = CuentasNoExisten.FindAll(item => item.Equals(cuenta));
                List<string> listaCuentasNoRelacionadas = CuentasNoRelacionadas.FindAll(item => item.Equals(cuenta));

                if (listaEncontrados.Count > 0 || listaCuentasNoExisten.Count > 0)
                {
                    node.Visible = true;
                }
                else
                {
                    if(listaCuentasNoRelacionadas.Count == 0)
                        node.Visible = false;
                }
            }
        }    
        private void ProcesarNodo(AdvancedDataGridView.TreeGridNode nodo)
        {
            string CuentaAll = nodo.Cells["CuentaAll"].Value.ToString();

            if (CuentaAll.Contains("-"))
            {
                char[] separatorCuenta = { '-' };
                string[] numeroCuenta = CuentaAll.Split(separatorCuenta);

                if (!CuentasErroresImportes.Contains(numeroCuenta[0]))
                {
                    nodo.Visible = false;
                }
                else
                    if (!CuentasNoExisten.Contains(numeroCuenta[0]))
                    {
                        nodo.Visible = false;
                    }
            }
            else
            {
                if (!CuentasErroresImportes.Contains(CuentaAll))
                {
                    nodo.Visible = true;
                }
                else
                    if (!CuentasNoExisten.Contains(CuentaAll))
                    {
                        nodo.Visible = false;
                    }
            }
        }
        private void MostrarTodas()
        {
            string cuenta = String.Empty;
            List<string> listaCuentasNoRelacionadas = new List<string>();

            foreach (AdvancedDataGridView.TreeGridNode nodePadre in tgvCatalogoCuentasSociedad.Nodes)
            {
                foreach (AdvancedDataGridView.TreeGridNode nodoHijo in nodePadre.Nodes)
                {
                    cuenta = nodoHijo.Cells["Cuenta"].Value.ToString();
                    listaCuentasNoRelacionadas = CuentasNoRelacionadas.FindAll(item => item.Equals(cuenta));

                    if(listaCuentasNoRelacionadas.Count == 0)
                        nodoHijo.Visible = true;
                }

                cuenta = nodePadre.Cells["Cuenta"].Value.ToString();
                listaCuentasNoRelacionadas = CuentasNoRelacionadas.FindAll(item => item.Equals(cuenta));

                if (listaCuentasNoRelacionadas.Count == 0)
                    nodePadre.Visible = true;
            }
        }
		private void cmdCancelar_Click(object sender, EventArgs e) {
			if(General.muestraMensajePregunta("¿Esta seguro de salir sin guardar los datos de la Balanza?") == DialogResult.Yes) {
				this.Close();
			}
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
        private void cmbEjercicioPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] EjercicioPeriodo = ((ListItem)cmbEjercicioPeriodo.SelectedItem).Texto.Split('-');
            string Ejercicio = EjercicioPeriodo[0].Trim();
            string Periodo = EjercicioPeriodo[1].Trim().Substring(0, 2);

            StringBuilder sb = new StringBuilder();
            sb.Append("DECLARE @existe INT ");
            sb.Append("SET @existe = 0 ");
            sb.Append("IF(EXISTS (SELECT 1 FROM SATeC_Balanzas WHERE ID_Sociedad = " + General.ID_SociedadSeleccionada.ToString() + " AND Ejercicio = '" + Ejercicio + "' AND Periodo = '" + Periodo + "' AND TipoEnvio = 'N')) ");
            sb.Append("SET @existe = 1 ");
            sb.Append("SELECT @existe existe ");

            string resultado = Database.obtenerDato(sb.ToString());

            if (resultado.Equals("1"))
            {
                TipoEnvio = "C";
                General.muestraMensaje("El Tipo de Envio de la Balanza sera COMPLEMENTARIA.");
            }
            else
            {
                TipoEnvio = "N";
                General.muestraMensaje("El Tipo de Envio de la Balanza sera NORMAL.");
            }

            //// INICIO: Seccion Balanza Acumulativa Senderos.
            //if (!String.IsNullOrEmpty(cmbEjercicioPeriodo.Text))
            //{
            //    chkEsAcumulativa.Visible = true;
            //}
            //else
            //{
            //    chkEsAcumulativa.Visible = false;
            //}
            //// FIN: Seccion Balanza Acumulativa Senderos.

        }
        private void chkCuentasNoRelacionadas_CheckedChanged(object sender, EventArgs e)
        {
            List<string> listaCuentasNoRelacionadas = new List<string>();

            foreach (AdvancedDataGridView.TreeGridNode nodePadre in tgvCatalogoCuentasSociedad.Nodes)
            {
                foreach (AdvancedDataGridView.TreeGridNode nodoHijo in nodePadre.Nodes)
                {
                    listaCuentasNoRelacionadas = CuentasNoRelacionadas.FindAll(item => item.Equals(nodoHijo.Cells[0].Value.ToString()));

                    if (listaCuentasNoRelacionadas.Count > 0)
                    {
                        nodoHijo.Visible = chkCuentasNoRelacionadas.Checked;
                    }
                }

                listaCuentasNoRelacionadas = CuentasNoRelacionadas.FindAll(item => item.Equals(nodePadre.Cells[0].Value.ToString()));

                if (listaCuentasNoRelacionadas.Count > 0)
                {
                    nodePadre.Visible = chkCuentasNoRelacionadas.Checked;
                }
            }
        }

        //// INICIO: Seccion Balanza Acumulativa Senderos.
        //private void chkEsAcumulativa_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (cmbEjercicioPeriodo.Text == string.Empty)
        //    {
        //        General.muestraMensaje("Debe seleccionar el Ejercicio / Periodo al que aplica la Balanza, favor de revisar.");
        //        cmbEjercicioPeriodo.Focus();
        //    }
        //    else
        //    {
        //        if (chkEsAcumulativa.Checked)
        //        {
        //            chkCerrar.Visible = true;
        //            lblBalanzas.Visible = true;
        //            cmbBalanza.Visible = true;
        //            CargarBalanzasExistentes();
        //        }
        //        else
        //        {
        //            chkCerrar.Visible = false;
        //            lblBalanzas.Visible = false;
        //            cmbBalanza.Visible = false;
        //            lblNueva.Visible = false;
        //        }
        //    }
        //}
        //private void cmbBalanza_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string idBalanza = ((ListItem)cmbBalanza.SelectedItem).Texto;
        //    ID_Balanza = int.Parse(idBalanza);
        //}
        //// FIN: Seccion Balanza Acumulativa Senderos.

	}
}
