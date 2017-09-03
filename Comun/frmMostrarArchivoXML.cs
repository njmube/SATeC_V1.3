using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace SATeC.Comun
{
    public enum TipoMXL
    {
        CatalogoDeCuentasSociedad = 1,
        Balanza,
        Polizas
    };

    public partial class frmMostrarArchivoXML : Form
    {
        #region Attributos

        public TipoMXL TipoXML { get; set; }
        public string IDXML { get; set; }
        public string Ejercicio { get; set; }
        public string Periodo { get; set; }
        private string XML { get; set; }
        private string ConSello { get; set; }
        private string ArchivoXMLTemporal { get; set; }
        private string Hoy { get { return DateTime.Now.ToString("yyyyMMddHHmmss"); } }
        private string Anio { get { return DateTime.Now.Year.ToString(); } }
        private string Mes
        {
            get
            {
                CultureInfo ci = new CultureInfo("es-MX");
                return DateTime.Now.ToString("MMMM", ci).ToUpper();
            }
        }
        private string NombreRepositorio { get; set; }
        private string ArchivoXSLTProcesar { get; set; }
        private string TagNameNode { get; set; }
        private string TipoEnvio { get; set; }

        frmLoading loading = new frmLoading();

        #endregion Attributos

        #region Constructores

        public frmMostrarArchivoXML()
        {
            InitializeComponent();
        }

        #endregion Constructores

        #region Eventos

        private void frmMostrarArchivoXML_Load(object sender, EventArgs e)
        {
            loading.Show(this);
            cargarXML();
        }
        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
            this.Dispose();
        }
        private void frmMostrarArchivoXML_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ArchivoXMLTemporal == null)
            {
                File.Delete(ArchivoXMLTemporal);
            }

            //webBrowser.Dispose();

            this.Dispose(true);
            GC.Collect();
        }
        private void cmdDescargar_Click(object sender, EventArgs e)
        {
            DescargarArchivo();
        }
        private void btnSellar_Click(object sender, EventArgs e)
        {
            SellarArchivo();
        }

        #endregion Eventos

        #region Metodos

        private void cargarXML()
        {
            GC.Collect();
            string ArchivoXMLCargar = string.Empty;
            ConSello = "0";

            try
            {
                if (this.TipoXML == TipoMXL.CatalogoDeCuentasSociedad)
                {
                    lblNombreArchivoXML.Text = "Catalogos de Cuentas del Ejercicio ";
                    XML = Database.obtenerDato("SELECT XML FROM SATeC_CatalogosCuentasFormatoXML WHERE ID_CatalogoDeCuentasImportado = " + IDXML);
                    ConSello = Database.obtenerDato("SELECT ISNULL(LEN(Sello), 0) longuitud FROM SATeC_CatalogosCuentasFormatoXML WHERE ID_CatalogoDeCuentasImportado = " + IDXML);
                    NombreRepositorio = "CatalogoCuentas";
                    ArchivoXSLTProcesar = "CatalogoCuentas_1_1.xslt";
                    TagNameNode = "catalogocuentas:Catalogo";
                }
                else if (this.TipoXML == TipoMXL.Balanza)
                {
                    lblNombreArchivoXML.Text = "Balanza del Ejercicio ";
                    XML = Database.obtenerDato("SELECT XML FROM SATeC_Balanzas WHERE ID_Balanza = " + IDXML);
                    ConSello = Database.obtenerDato("SELECT ISNULL(LEN(Sello), 0) longuitud FROM SATeC_Balanzas WHERE ID_Balanza = " + IDXML);
                    NombreRepositorio = "Balanzas";
                    ArchivoXSLTProcesar = "BalanzaComprobacion_1_1.xslt";
                    TagNameNode = "BCE:Balanza";
                    TipoEnvio = Database.obtenerDato("SELECT TipoEnvio FROM SATeC_Balanzas WHERE ID_Balanza = " + IDXML);
                }
                else if (this.TipoXML == TipoMXL.Polizas)
                {
                    lblNombreArchivoXML.Text = "Pólizas del Ejercicio ";
                    XML = Database.obtenerDato("SELECT XML FROM SATeC_Polizas WHERE ID_Poliza = " + IDXML);
                    ConSello = Database.obtenerDato("SELECT ISNULL(LEN(Sello), 0) longuitud FROM SATeC_Polizas WHERE ID_Poliza = " + IDXML);
                    NombreRepositorio = "Polizas";
                    ArchivoXSLTProcesar = "PolizasPeriodo_1_1.xslt";
                    TagNameNode = "PLZ:Polizas";
                }

                if (ConSello.Equals("0"))
                    btnSellar.Visible = true;
                else
                    btnSellar.Visible = false;

                lblNombreArchivoXML.Text += this.Ejercicio + " Periodo " + this.Periodo;

                string path = Path.GetTempPath();
                string fileName = "SATeC_" + Guid.NewGuid().ToString() + ".xml";
                ArchivoXMLTemporal = Path.Combine(path, fileName);

                File.WriteAllText(ArchivoXMLTemporal, this.XML);

                GC.Collect();

                ArchivoXMLCargar = ArchivoXMLTemporal;

                txtXML.Text = this.XML;

                //webBrowser.DocumentText = this.XML;

                this.Refresh();

                GC.Collect();

                loading.Hide();
            }
            catch (Exception ex)
            {
                General.muestraMensaje("Ocurrio un error al mostrar el formato XML. Intente mas tarde.");
                LogErrores.WriteLog("Error en el proceso de conversion al formato XML.", ex);
            }
        }
        private void DescargarArchivo()
        {
            try
            {
                //VHJC ... se crea el nombre del archivo dependiendo que tipo sea
                string FileName = String.Empty;

                //VHJC Numero de la sociedad para la cual se visualiza el XML
                FileName += General.RFC_SociedadSeleccionada.Trim().ToUpper();

                //VHJC Ejercicio y periodo de los datos que se visualizan
                FileName += this.Ejercicio;

                FileName += this.Periodo.Substring(0, 2);

                //VHJC Tipo de datos que se visualizan
                if (this.TipoXML == TipoMXL.CatalogoDeCuentasSociedad)
                {
                    FileName += "CT";
                }
                else if (this.TipoXML == TipoMXL.Balanza)
                {
                    FileName += "B" + TipoEnvio;
                }
                else if (this.TipoXML == TipoMXL.Polizas)
                {
                    FileName += "PL";
                }

                //FileName += "_" + Hoy;

                string fileZip = FileName + ".zip";

                //VHJC Extension
                FileName += ".xml";

                //VHJC ... se pregunta en donde quiere guardar el archivo...
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo ZIP|*.zip";
                saveFileDialog.Title = "Descargar archivo";
                saveFileDialog.FileName = fileZip;

                if (INI.KeyExists("Repositorio", "Ruta"))
                {
                    string StartupPath = INI.Read("Repositorio", "Ruta");
                    string pathRepository = StartupPath + "\\" + General.Nombre_SociedadSeleccionada + "\\" + Anio + "\\" + Mes + "\\" + NombreRepositorio;

                    //VHJC ... si se selecciono alguna archivo...
                    if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        if (!Directory.Exists(pathRepository))
                        {
                            try
                            {
                                Directory.CreateDirectory(pathRepository);

                                File.Copy(ArchivoXMLTemporal, pathRepository + "\\" + FileName, true);
                                //File.Copy(ArchivoXMLTemporal, FileName, true);

                                using (ZipOutputStream s = new ZipOutputStream(File.Create(pathRepository + "\\" + fileZip)))
                                {
                                    s.SetLevel(9); // 0 - store only to 9 - means best compression
                                    byte[] buffer = new byte[4096];

                                    ZipEntry entry = new ZipEntry(Path.GetFileName(pathRepository + "\\" + FileName));
                                    entry.DateTime = DateTime.Now;
                                    s.PutNextEntry(entry);

                                    using (FileStream fs = File.OpenRead(pathRepository + "\\" + FileName))
                                    {
                                        int sourceBytes;
                                        do
                                        {
                                            sourceBytes = fs.Read(buffer, 0, buffer.Length);
                                            s.Write(buffer, 0, sourceBytes);
                                        } while (sourceBytes > 0);
                                    }

                                    s.Finish();
                                    s.Close();

                                }

                                File.Copy(pathRepository + "\\" + fileZip, saveFileDialog.FileName, true);

                                General.muestraMensaje("La descarga del archivo se realizo de forma exitosa");
                            }
                            catch (Exception ex)
                            {
                                General.muestraMensaje("Ocurrio un error al tratar de crear la carpeta en donde se guardaran los archivos XML del proceso de descargas: " + ex.Message + "\n Pida ayuda al administrador del sistema.");
                            }
                        }
                        else
                        {
                            File.Copy(ArchivoXMLTemporal, pathRepository + "\\" + FileName, true);

                            using (ZipOutputStream s = new ZipOutputStream(File.Create(pathRepository + "\\" + fileZip)))
                            {
                                s.SetLevel(9); // 0 - store only to 9 - means best compression
                                byte[] buffer = new byte[4096];

                                ZipEntry entry = new ZipEntry(Path.GetFileName(pathRepository + "\\" + FileName));
                                entry.DateTime = DateTime.Now;
                                s.PutNextEntry(entry);

                                using (FileStream fs = File.OpenRead(pathRepository + "\\" + FileName))
                                {
                                    int sourceBytes;
                                    do
                                    {
                                        sourceBytes = fs.Read(buffer, 0, buffer.Length);
                                        s.Write(buffer, 0, sourceBytes);
                                    } while (sourceBytes > 0);
                                }

                                s.Finish();
                                s.Close();

                            }

                            File.Copy(pathRepository + "\\" + fileZip, saveFileDialog.FileName, true);

                            General.muestraMensaje("La descarga del archivo se realizo de forma exitosa");
                        }

                    }
                }
                else
                {
                    General.muestraMensaje("El archivo INI no tiene la configuración para la ruta del repositorio de archivos XML.");
                }
            }
            catch (Exception ex)
            {
                General.muestraMensaje("Ocurrio un error al tratar de realizar la descarga del archivo: " + ex.Message + "\n Pida ayuda al administrador del sistema.");
            }
        }
        private void SellarArchivo()
        {
            try
            {
                string FileName = String.Empty;
                FileName += General.RFC_SociedadSeleccionada.Trim();
                FileName += this.Ejercicio;
                FileName += this.Periodo.Substring(0, 2);

                if (this.TipoXML == TipoMXL.CatalogoDeCuentasSociedad)
                {
                    FileName += "CT";
                }
                else if (this.TipoXML == TipoMXL.Balanza)
                {
                    FileName += "BN";
                }
                else if (this.TipoXML == TipoMXL.Polizas)
                {
                    FileName += "PL";
                }

                string fileZip = FileName + ".zip";

                FileName += ".xml";

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo ZIP|*.zip";
                saveFileDialog.Title = "Descargar archivo";
                saveFileDialog.FileName = fileZip;

                if (INI.KeyExists("Repositorio", "Ruta"))
                {
                    string StartupPath = INI.Read("Repositorio", "Ruta");
                    string pathRepository = StartupPath + "\\" + General.Nombre_SociedadSeleccionada + "\\" + Anio + "\\" + Mes + "\\" + NombreRepositorio;

                    if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        if (!Directory.Exists(pathRepository))
                        {
                            General.muestraMensaje("No se encuentra el directorio repositorio de archivos. Favor de validar la ruta configurada en el archivo INI.");
                            return;
                        }

                        if (!INI.KeyExists("Repositorio", "ArchivosSAT"))
                        {
                            General.muestraMensaje("No se encuentra la ruta de los archivos del SAT para el proceso de Sellado. Favor de validar las rutas en el archivo INI del sistema.");
                            return;
                        }

                        string pathArchivosSAT = INI.Read("Repositorio", "ArchivosSAT");
                        string directoryArchivosSociedad = pathArchivosSAT + "\\" + General.RFC_SociedadSeleccionada.Trim();

                        if (!Directory.Exists(directoryArchivosSociedad))
                        {
                            General.muestraMensaje("No se encuentra el directorio de archivos de la sociedad: " + General.RFC_SociedadSeleccionada.Trim());
                            return;
                        }

                        string fileXML = pathRepository + "\\" + FileName;
                        File.Copy(ArchivoXMLTemporal, fileXML, true);

                        string pathArchivoXSLT = pathArchivosSAT + "\\" + ArchivoXSLTProcesar;
                        string fileSociedadKEY = directoryArchivosSociedad + "\\" + General.RFC_SociedadSeleccionada.Trim() + ".key";
                        string fileSociedadPassword = directoryArchivosSociedad + "\\" + General.RFC_SociedadSeleccionada.Trim() + ".txt";
                        string fileSociedadCER = directoryArchivosSociedad + "\\" + General.RFC_SociedadSeleccionada.Trim() + ".cer";

                        SelladoSAT selladoSAT = new SelladoSAT();
                        string cadenaOriginal = selladoSAT.CrearCadenaOriginal(fileXML, pathArchivoXSLT);

                        if (!selladoSAT.getCode().Equals("S-001"))
                        {
                            if (File.Exists(fileXML))
                            {
                                File.Delete(fileXML);
                            }

                            General.muestraMensaje("Ocurrio un error al intentar generar la cadena original. " + selladoSAT.getMessage());
                            return;
                        }

                        string password = string.Empty;

                        using (StreamReader sr = new StreamReader(fileSociedadPassword))
                        {
                            password = sr.ReadToEnd();
                        }

                        selladoSAT = new SelladoSAT();
                        string sello = selladoSAT.CrearSelloDigital(fileSociedadKEY, password, cadenaOriginal);

                        if (!selladoSAT.getCode().Equals("S-0001"))
                        {
                            if (File.Exists(fileXML))
                            {
                                File.Delete(fileXML);
                            }

                            General.muestraMensaje("Ocurrio un error al intentar generar el sello digital. " + selladoSAT.getMessage());
                            return;
                        }

                        bool OKcertificate = selladoSAT.ObtenerInformacionCertificado(fileSociedadCER);
                        string noCertificado = String.Empty;
                        string certificado = String.Empty;

                        if (!OKcertificate)
                        {
                            if (File.Exists(fileXML))
                            {
                                File.Delete(fileXML);
                            }

                            General.muestraMensaje("Ocurrio un error al intentar obtener la información del No Certificado y el Certificado. " + selladoSAT.getMessage());
                            return;
                        }

                        noCertificado = selladoSAT.ObtenerNumeroCertificado();
                        certificado = selladoSAT.ObtenerCertificado();

                        string xmlSalida = selladoSAT.ActualizarArchivoXML(fileXML, certificado, noCertificado, sello, TagNameNode);

                        if (!selladoSAT.getCode().Equals("C-00005"))
                        {
                            if (File.Exists(fileXML))
                            {
                                File.Delete(fileXML);
                            }

                            General.muestraMensaje("Ocurrio un error al intentar actualizar el archivo XML con los datos finales. " + selladoSAT.getMessage());
                            return;
                        }

                        if (File.Exists(fileXML))
                        {
                            File.Delete(fileXML);
                        }

                        File.WriteAllText(fileXML, xmlSalida);

                        using (ZipOutputStream s = new ZipOutputStream(File.Create(pathRepository + "\\" + fileZip)))
                        {
                            s.SetLevel(9);
                            byte[] buffer = new byte[4096];

                            ZipEntry entry = new ZipEntry(Path.GetFileName(pathRepository + "\\" + FileName));
                            entry.DateTime = DateTime.Now;
                            s.PutNextEntry(entry);

                            using (FileStream fs = File.OpenRead(pathRepository + "\\" + FileName))
                            {
                                int sourceBytes;
                                do
                                {
                                    sourceBytes = fs.Read(buffer, 0, buffer.Length);
                                    s.Write(buffer, 0, sourceBytes);
                                } while (sourceBytes > 0);
                            }

                            s.Finish();
                            s.Close();

                        }

                        File.Copy(pathRepository + "\\" + fileZip, saveFileDialog.FileName, true);

                        btnSellar.Visible = false;

                        string SQL = String.Empty;

                        if (this.TipoXML == TipoMXL.CatalogoDeCuentasSociedad)
                        {
                            SQL += "UPDATE SATeC_CatalogosCuentasFormatoXML SET";
                            SQL += "  XML   = '" + xmlSalida + "'";
                            SQL += ", Sello = '" + sello + "'";
                            SQL += ", noCertificado = '" + noCertificado + "'";
                            SQL += ", Certificado = '" + certificado + "'";
                            SQL += " WHERE ID_CatalogoDeCuentasImportado = " + IDXML;
                        }
                        else if (this.TipoXML == TipoMXL.Balanza)
                        {
                            SQL += "UPDATE SATeC_Balanzas SET";
                            SQL += "  XML   = '" + xmlSalida + "'";
                            SQL += ", Sello = '" + sello + "'";
                            SQL += ", noCertificado = '" + noCertificado + "'";
                            SQL += ", Certificado = '" + certificado + "'";
                            SQL += " WHERE ID_Balanza = " + IDXML;
                        }
                        else if (this.TipoXML == TipoMXL.Polizas)
                        {
                            SQL += "UPDATE SATeC_Polizas SET";
                            SQL += "  XML   = '" + xmlSalida + "'";
                            SQL += ", Sello = '" + sello + "'";
                            SQL += ", noCertificado = '" + noCertificado + "'";
                            SQL += ", Certificado = '" + certificado + "'";
                            SQL += " WHERE ID_Poliza = " + IDXML;
                        }

                        if (!Database.ejecutaQuery(SQL, false))
                        {
                            if (File.Exists(fileXML))
                            {
                                File.Delete(fileXML);
                            }

                            General.muestraMensaje("Ocurrio un error al intentar actualizar la información del archivo XML.");
                            return;
                        }

                        General.muestraMensaje("El archivo XML fue sellado de forma exitosa");

                        this.Close();
                    }
                }
                else
                {
                    General.muestraMensaje("El archivo INI no tiene la configuración para la ruta del repositorio de archivos XML.");
                }
            }
            catch (Exception ex)
            {
                General.muestraMensaje("Ocurrio un error al tratar de realizar la descarga del archivo: " + ex.Message + "\n Pida ayuda al administrador del sistema.");
            }
        }

        #endregion Metodos      

        //private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        //{
        //    if (e.Url != webBrowser.Url)
        //        return;

        //    loading.Hide();

        //    General.muestraMensaje("El archivo XML fue cargado completamente");
        //}
    }
}