using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using AdvancedDataGridView;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using Microsoft.Reporting.WinForms;
using System.Text.RegularExpressions;

namespace SATeC.CatalogoDeCuentas {
	public partial class frmRelacionDeCuentasConCodigoAgrupadorSAT : Form {

		private int NumeroCuentas { get; set; }
		private bool MostrarSoloNoRelacionadas = false;
		private bool MostrarTodas = true;
        public bool GuardadoBD { get; set; }
        int totalRelacionadas = 0;
        int totalNoRelacionadas = 0;
        
        List<SATeC.CatalogoDeCuentasV13.CatalogoCtas> listaCtas;

		public frmRelacionDeCuentasConCodigoAgrupadorSAT() {
			InitializeComponent();
		}

        private bool ExpandirTodo { get; set; }

		private void frmRelacionDeCuentasConCodigoAgrupadorSAT_Load(object sender, EventArgs e) {
			this.Dock = DockStyle.Fill;
			cargarCuentasSociedad();
            ValidarCatalogoCuentasXMLSociedad();
            ExpandirTodo = true;
            GuardadoBD = false;
		}

		//VHJC Funcion que carga las cuentas de la Sociedad de acuerdo a sus Catalogos de Cuentas asociados
		private void cargarCuentasSociedad() {
			Cursor.Current = Cursors.WaitCursor;
			//General.cambiaMensajeStatus(this, "Cargando Cuentas de la Sociedad " + General.Nombre_SociedadSeleccionada + "...");

			tgvCatalogoCuentasSociedad.Nodes.Clear();

			//VHJC Esta funcion usa un stored procedure (o Consulta guardada en Access) debido a su complejidad
			string SQL = "obtenerCuentasSociedad_RelacionSAT";

			OleDbDataReader drCuentasSociedad = Database.obtenRegistros(SQL, CommandType.StoredProcedure, General.ID_SociedadSeleccionada.ToString());
			AdvancedDataGridView.TreeGridNode dataGridNodePadre = new AdvancedDataGridView.TreeGridNode();
			AdvancedDataGridView.TreeGridNode dataGridNodeHijo = new AdvancedDataGridView.TreeGridNode();

			//VHJC Por cada uno de los registros de la base de datos...
			while(drCuentasSociedad.Read()) {
				NumeroCuentas++;
				string CodigoAgrupadorSATAsociado = string.Empty;
				string NombreCuentaSATAsociada = string.Empty;

				//VHJC ...si la cuenta tiene un codigo agrupador relacionado se obtiene la relacion
				if(drCuentasSociedad["CodigoAgrupadorSAT"].ToString() != string.Empty) {
					CodigoAgrupadorSATAsociado = drCuentasSociedad["CodigoAgrupadorSAT"].ToString();
					NombreCuentaSATAsociada = CodigoAgrupadorSATAsociado + " - " + drCuentasSociedad["NombreCuentaSAT"].ToString();
				}

				//VHJC Si el nivel es 1 quiere decir que es un padre
				if(drCuentasSociedad["Nivel"].ToString() == "1") {
					dataGridNodePadre = tgvCatalogoCuentasSociedad.Nodes.Add(drCuentasSociedad["Cuenta"].ToString(), drCuentasSociedad["DescripcionCuenta"].ToString(), drCuentasSociedad["Naturaleza"].ToString(), NombreCuentaSATAsociada, CodigoAgrupadorSATAsociado, drCuentasSociedad["CuentaPadre"].ToString(), null, drCuentasSociedad["Nivel"].ToString());

					//VHJC si el nivel es diferente de "1" quiere decir que es un hijo
				} else {

                    try
                    {
                        dataGridNodeHijo = dataGridNodePadre.Nodes.Add(drCuentasSociedad["Cuenta"].ToString(), drCuentasSociedad["DescripcionCuenta"].ToString(), drCuentasSociedad["Naturaleza"].ToString(), NombreCuentaSATAsociada, CodigoAgrupadorSATAsociado, drCuentasSociedad["CuentaPadre"].ToString(), drCuentasSociedad["Cuenta"].ToString(), drCuentasSociedad["Nivel"].ToString());
                    }
                    catch (Exception ex)
                    {
                        throw (ex);
                    }
				}
			}

			drCuentasSociedad.Close();
			drCuentasSociedad.Dispose();

			//General.cambiaMensajeStatus(this, "");
			Cursor.Current = Cursors.WaitCursor;
		}

        private void ValidarCatalogoCuentasXMLSociedad()
        {
            try
            {
                string XMLActualizdo = Database.obtenerDato("SATeC_ValidarCatalogoXMLActualizado", CommandType.StoredProcedure, General.ID_SociedadSeleccionada.ToString());

                if (XMLActualizdo.Equals("False"))
                {
                    General.muestraMensaje("El Catalogo de Cuentas XML generado debe ser actualizado. Favor de ejecutar la Conversión a XML nuevamente.");
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

		private void cmdCerrar_Click(object sender, EventArgs e) {
            if (GuardadoBD)
                this.Close();
            else
            {
                if (General.muestraMensajePregunta("¿Esta seguro de salir sin guardar los datos?") == DialogResult.Yes)
                {
                    this.Close();
                }
            }
		}

		//VHJC Cuando se da doble clic en alguna celda del renglon seleccionado
		private void tgvCatalogoCuentasSociedad_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			if(e.RowIndex > -1) {
				frmSeleccionarCuentaSATRelacionCuentasSociedad CatalogoCuentasSAT = new frmSeleccionarCuentaSATRelacionCuentasSociedad();
				CatalogoCuentasSAT.CuentaSociedadEsPadre = (tgvCatalogoCuentasSociedad.CurrentNode.Cells["NivelCuentaSociedad"].Value.ToString() == "1");
				CatalogoCuentasSAT.CodigoAgrupadorCuentaSATSeleccionada = tgvCatalogoCuentasSociedad.CurrentNode.Cells["CodigoAgrupador"].Value.ToString();
				CatalogoCuentasSAT.ShowDialog(this);

				//VHJC Si se selecciono una Cuenta del SAT para relacionar la Cuenta de la Sociedad
				if(CatalogoCuentasSAT.CuentaSeleccionada) {
					//VHJC Se establecen los valores de la Cuenta del SAT seleccionada para relacionar
					tgvCatalogoCuentasSociedad.CurrentNode.Cells["CuentaSATRelacionada"].Value = CatalogoCuentasSAT.CuentaSATSeleccionada;
					tgvCatalogoCuentasSociedad.CurrentNode.Cells["CodigoAgrupador"].Value = CatalogoCuentasSAT.CodigoAgrupadorCuentaSATSeleccionada;
				}
			}
		}

		//VHJC Cuando se selecciona el menu emergente para relacionar una o varias cuentas de la sociedad
		private void mnuCuentasSociedad_RelacionarCuentaSAT_Click(object sender, EventArgs e) {

			//VHJC Se muestra la pantalla para seleccionar la Cuenta del SAT para relacionar
			frmSeleccionarCuentaSATRelacionCuentasSociedad CatalogoCuentasSAT = new frmSeleccionarCuentaSATRelacionCuentasSociedad();
			CatalogoCuentasSAT.ShowDialog(this);

			//VHJC Si se selecciono una Cuenta del SAT para relacionar las Cuentas de la Sociedad
			if(CatalogoCuentasSAT.CuentaSeleccionada) {
				foreach(DataGridViewRow dgvrCuentaSociedad in tgvCatalogoCuentasSociedad.SelectedRows) {
					//VHJC Se establecen los valores de la Cuenta del SAT seleccionada para relacionar
					dgvrCuentaSociedad.Cells["CuentaSATRelacionada"].Value = CatalogoCuentasSAT.CuentaSATSeleccionada;
					dgvrCuentaSociedad.Cells["CodigoAgrupador"].Value = CatalogoCuentasSAT.CodigoAgrupadorCuentaSATSeleccionada;
				}
			}
		}

		//VHJC Cuando se selecciona el menu emergente para eliminar una relacion
		private void mnuCuentasSociedad_EliminarRelacionCuentasSAT_Click(object sender, EventArgs e) {
			//VHJC Se pregunta si se quiere eliminar las relaciones de las cuentas seleccionadas
			if(General.muestraMensajePregunta("¿Esta seguro de eliminar las relaciones de las Cuentas de la Sociedad con las Cuentas del SAT?") == System.Windows.Forms.DialogResult.Yes) {
				//VHJC Cada una de las Cuentas seleccionadas se elimina la relacion
				foreach(DataGridViewRow dgvrCuentaSociedad in tgvCatalogoCuentasSociedad.SelectedRows) {
					//VHJC Se establecen los valores de la Cuenta del SAT seleccionada para relacionar
					dgvrCuentaSociedad.Cells["CuentaSATRelacionada"].Value = string.Empty;
					dgvrCuentaSociedad.Cells["CodigoAgrupador"].Value = string.Empty;
				}
			}
		}

		//VHJC Cuando se da clic en el boton de Mostrar
		private void cmdMostrar_Click(object sender, EventArgs e) {
			//VHJC Si se estan mostrando todas las cuentas quiere decir que el boton dice "Mostrar solo no relacionadas"...
			if(MostrarTodas) {
				//VHJC Se cambia el boton a que diga "Mostrar todas"
				cmdMostrar.Text = "Mostrar todas";
				cmdMostrar.Image = SATeC.Properties.Resources.MostrarTodasCuentas;
				cmdMostrar.Width = 140;
				MostrarTodas = false;
				MostrarSoloNoRelacionadas = true;

			//VHJC Si se estan mostrando solo las no relacionadas quiere decir que el boton dice "Mostrar todas"...
			} else if(MostrarSoloNoRelacionadas) {
				//VHJC Se cambia el boton a que diga "Mostrar solo no relacionadas"
				cmdMostrar.Text = "Mostrar solo no relacionadas";
				cmdMostrar.Image = SATeC.Properties.Resources.MostrarSoloCuentasNoRelacionadas;
				cmdMostrar.Width = 230;
				MostrarTodas = true;
				MostrarSoloNoRelacionadas = false;
			}

			toggleCuentas();
		}

		//VHJC Funcion que muestra y oculta cuentas dependiendo si tiene ya una relacion o no
		private void toggleCuentas() {
			Cursor.Current = Cursors.WaitCursor;

			//VHJC Por cada una de las cuentas...
			foreach(AdvancedDataGridView.TreeGridNode tgnCuentaSociedad in tgvCatalogoCuentasSociedad.Nodes) {
				//VHJC... se muestra u oculta de acuerdo a la opcion seleccionada
				toggleCuenta(tgnCuentaSociedad);
			}

			Cursor.Current = Cursors.Default;
		}

		//VHJC Funcion que muestra u oculta una cuenta
		private void toggleCuenta(AdvancedDataGridView.TreeGridNode tgnCuenta) {

			if(tgnCuenta.Index > -1) {
                //VHJC Si se tienen que mostrar solo las no relacionadas
                if (MostrarSoloNoRelacionadas)
                {
                    if (tgnCuenta.Cells[3].Value.ToString() != string.Empty)
                    {
                        tgnCuenta.Visible = false;
                    }
                    //VHJC Si se tienen que mostrar todas
                }
                else if (MostrarTodas)
                {
                    tgnCuenta.Visible = true;
                }

				//VHJC Se hace lo mismo para cada uno de los hijos que tenga la Cuenta
				foreach(AdvancedDataGridView.TreeGridNode trnCuentaAuxiliar in tgnCuenta.Nodes) {
					toggleCuenta(trnCuentaAuxiliar);
				}
			}
		}

		//VHJC Cuando se da clic en el boton guardar...
		private void cmdGuardar_Click(object sender, EventArgs e) {
			Cursor.Current = Cursors.WaitCursor;

			string Error = string.Empty;

			if(guardarCuentasRelacionadas(out Error)) {
				//VHJC ...si se guardaron los datos...
                GuardadoBD = true;
				General.muestraMensaje("Las relaciones de las Cuentas de la Sociedad con las Cuentas del SAT se han guardado con exito.");
			} else {
				//VHJC ...si no se guardaron los datos...
                GuardadoBD = true;

                if (Error.Contains("Debe registrar al menos 1 elemento para poder guardar"))
                    General.muestraMensaje(Error);
                else
                    General.muestraMensaje("Ocurrio un error al tratar de guardar las relaciones de las Cuentas de la Sociedad con las Cuentas del SAT:\n" + Error);
			}

            foreach (AdvancedDataGridView.TreeGridNode node in tgvCatalogoCuentasSociedad.Nodes)
            {
                if (node.IsExpanded)
                    node.Collapse();
            }

			Cursor.Current = Cursors.Default;
		}
		private bool guardarCuentasRelacionadas(out string Error) 
        {
			bool Guardado = true;
			Error = string.Empty;

            ContarCuentasRelacionadasAndNoRelacionadas();

            if (totalRelacionadas > 0)
            {
                string SQL = "DELETE FROM SATeC_CuentasSociedad_CuentasSAT WHERE ID_Sociedad = " + General.ID_SociedadSeleccionada.ToString() + "  \n";

                foreach (AdvancedDataGridView.TreeGridNode tgnCuentaSociedad in tgvCatalogoCuentasSociedad.Nodes)
                {
                    SQL += obtenerInsertCuenta(tgnCuentaSociedad);
                    
                    SQL += "IF NOT EXISTS ( SELECT 1 FROM SATeC_CuentasSociedad_CuentasSAT WHERE ID_Sociedad = " + General.ID_SociedadSeleccionada + " AND CuentaPadre = '" + tgnCuentaSociedad.Cells["CuentaPadre"].Value.ToString() + "' AND CuentaAuxiliar = '') " + "  \n";
                    SQL += "IF ( (SELECT COUNT(ID_Sociedad) FROM SATeC_CuentasSociedad_CuentasSAT WHERE ID_Sociedad = " + General.ID_SociedadSeleccionada + " AND CuentaPadre = '" + tgnCuentaSociedad.Cells["CuentaPadre"].Value.ToString() + "') > 0) " + "  \n";
                    SQL += "INSERT INTO SATeC_CuentasSociedad_CuentasSAT (ID_Sociedad, CuentaPadre, CuentaAuxiliar, CodigoAgrupadorSAT) VALUES(" + General.ID_SociedadSeleccionada + ", '" + tgnCuentaSociedad.Cells["CuentaPadre"].Value.ToString() + "', '', '')" + "  \n";
                }

                SQL += " UPDATE SATeC_CatalogosCuentasFormatoXML SET Actualizado = 0 WHERE ID_Sociedad = " + General.ID_SociedadSeleccionada;
                SQL += " EXEC SATeC_ReplicarCuentasSociedades " + General.ID_SociedadSeleccionada;

                if (!Database.ejecutaQuery(SQL, true))
                {
                    Guardado = false;
                    Error = Database.Error;
                }
            }
            else
            {
                Guardado = false;
                Error = "Debe relacionar al menos 1 cuenta por guardar...";
            }

			return Guardado;
		}
        private string obtenerInsertCuenta(AdvancedDataGridView.TreeGridNode tgnCuenta)
        {
            string SQL = string.Empty;

            if (tgnCuenta.Cells["CuentaSATRelacionada"].Value.ToString() != string.Empty)
            {
                SQL += "INSERT INTO SATeC_CuentasSociedad_CuentasSAT (ID_Sociedad, CuentaPadre, CuentaAuxiliar, CodigoAgrupadorSAT) VALUES(";
                SQL += General.ID_SociedadSeleccionada + ", ";
                SQL += "'" + tgnCuenta.Cells["CuentaPadre"].Value.ToString() + "', ";
                SQL += "'" + tgnCuenta.Cells["CuentaAuxiliar"].Value + "', ";
                SQL += "'" + tgnCuenta.Cells["CodigoAgrupador"].Value.ToString() + "') \n";
            }

            foreach (AdvancedDataGridView.TreeGridNode trnCuentaAuxiliar in tgnCuenta.Nodes)
            {
                SQL += obtenerInsertCuenta(trnCuentaAuxiliar);
            }

            return SQL;
        }
        private void cmdConvertirXML_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string XMLToDatabase = string.Empty;
            string EjercicioSeleccionado = string.Empty;
            string PeriodoSeleccionado = string.Empty;
            string Error = string.Empty;

            if (General.muestraMensajePregunta("¿Quiere convertir el catálogo relacionado a formato XML?") == System.Windows.Forms.DialogResult.Yes)
            {
                frmSeleccionarEjercicioPeriodo SeleccionarEjercicioPeriodo = new frmSeleccionarEjercicioPeriodo();
                SeleccionarEjercicioPeriodo.ShowDialog(this);

                if (SeleccionarEjercicioPeriodo.EjercicioSeleccionado != string.Empty)
                {
                    EjercicioSeleccionado = SeleccionarEjercicioPeriodo.EjercicioSeleccionado;
                    PeriodoSeleccionado = SeleccionarEjercicioPeriodo.PeriodoSeleccionado;

                    if (ExisteBalanza(EjercicioSeleccionado, PeriodoSeleccionado))
                    {
                        if (!guardarCuentasRelacionadas(out Error))
                        {
                            General.muestraMensaje("Ocurrio un error al tratar de guardar las relaciones de las Cuentas de la Sociedad con las Cuentas del SAT:\n" + Error);
                            return;
                        }

                        GuardadoBD = true;

                        foreach (TreeGridNode tgnCuenta in tgvCatalogoCuentasSociedad.Nodes)
                        {
                            expandeCuenta(tgnCuenta);
                        }

                        if (generarArchivoXMLCuentasSociedad(out XMLToDatabase, EjercicioSeleccionado, PeriodoSeleccionado))
                        {
                            if (guardarRegistroBaseDatos(XMLToDatabase, EjercicioSeleccionado, PeriodoSeleccionado, out Error))
                            {
                                General.muestraMensaje("CATALOGO DE CUENTAS GENERADO EN MEDIO ELECTRONICO");
                            }
                            else
                            {
                                General.muestraMensaje("Ocurrio un error al tratar de convertir el Catálogo de Cuentas al formato XML requerido por el SAT:\n" + Error);
                            }
                        }
                        else
                        {
                            General.muestraMensaje("Ocurrio un error al tratar de convertir el Catálogo de Cuentas al formato XML requerido por el SAT:\n" + XMLToDatabase);
                        }
                    }
                    else
                        General.muestraMensaje("El catalogo no puede ser convertido a XML si no existe una Balanza asociada.");
                }
                else
                {
                    General.muestraMensaje("Debe seleccionar el Ejercicio / Periodo correspondiente para convertir el Catálogo de Cuentas al formato XML requerido por el SAT, favor de verificar.");
                }
            }

            foreach (AdvancedDataGridView.TreeGridNode node in tgvCatalogoCuentasSociedad.Nodes)
            {
                if (node.IsExpanded)
                    node.Collapse();
            }

            Cursor.Current = Cursors.Default;
        }

		//VHJC Funcion que expande todas las cuentas que tengan cuentas auxiliares
		private void expandeCuenta(TreeGridNode tgnCuenta) {
			//VHJC Si la cuenta tiene cuentas auxiliares...
			if(tgnCuenta.HasChildren) {

				//VHJC ...se expanden las cuentas auxiliares...
				tgnCuenta.Expand();

				//VHJC ...y se verifica si cada cuenta auxiliar tiene otras cuentas auxiliares
				foreach(TreeGridNode tgnCuentaAuxiliar in tgnCuenta.Nodes) {
					expandeCuenta(tgnCuentaAuxiliar);
				}
			}
		}
		private bool ValidaCuentaRelacionadaSAT(TreeGridNode tgnCuenta) {
			bool Valida = true;

			if(tgnCuenta.Cells["CuentaSATRelacionada"].Value.ToString() == string.Empty) {
				General.muestraMensaje("La Cuenta '" + tgnCuenta.Cells["DescripcionCuentaSociedad"].Value.ToString() + "' no tiene una Cuenta del SAT relacionada, favor de verificar.");
				tgvCatalogoCuentasSociedad.CurrentCell = tgnCuenta.Cells["CuentaSATRelacionada"];
				return false;
			}

			foreach(TreeGridNode tgnCuentaAuxiliar in tgnCuenta.Nodes) {
				if(!ValidaCuentaRelacionadaSAT(tgnCuentaAuxiliar)) {
					Valida = false;
					break;
				}
			}

			return Valida;
		}
		private bool generarArchivoXMLCuentasSociedad(out string XMLToDatabase, string Ejercicio, string Periodo) {
			bool Generado = true;

            SATeC.CatalogoDeCuentasV13.Catalogo catalogo = new SATeC.CatalogoDeCuentasV13.Catalogo();

            catalogo.Version = Database.obtenerDato("select valor from SATeC_Parametrizacion where clave = 'VERSIONXML' AND activo = 1");
            catalogo.RFC = General.RFC_SociedadSeleccionada.Trim();
            catalogo.Mes = Tools.GetCode<SATeC.CatalogoDeCuentasV13.CatalogoMes>(Periodo);
            catalogo.Anio = int.Parse(Ejercicio);

            listaCtas = new List<SATeC.CatalogoDeCuentasV13.CatalogoCtas>();

            foreach (TreeGridNode tgnCuenta in tgvCatalogoCuentasSociedad.Nodes)
            {
                obtenerXMLCuenta(tgnCuenta);
            }

            catalogo.Ctas = listaCtas.ToArray();
            
            XmlSerializer ser = new XmlSerializer(typeof(SATeC.CatalogoDeCuentasV13.Catalogo));
            StringBuilder sb = new StringBuilder();

            using (XmlWriter writer = XmlWriter.Create(sb, new XmlWriterSettings()
            {
                Indent = true,
                OmitXmlDeclaration = false,
                Encoding = Encoding.UTF8 
            }))
            {

                XmlSerializerNamespaces xmlNameSpace = new XmlSerializerNamespaces();
                xmlNameSpace.Add("catalogocuentas", "www.sat.gob.mx/esquemas/ContabilidadE/1_3/CatalogoCuentas");
                xmlNameSpace.Add("schemaLocation", "http://www.sat.gob.mx/esquemas/ContabilidadE/1_3/CatalogoCuentas http://www.sat.gob.mx/esquemas/ContabilidadE/1_3/CatalogoCuentas/CatalogoCuentas_1_3.xsd");
                xmlNameSpace.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

                ser.Serialize(writer, catalogo, xmlNameSpace);
            }

            sb.Replace(Encoding.Unicode.WebName, Encoding.UTF8.WebName, 0, 56);
            sb.Replace("utf-8", "UTF-8");
            sb.Replace("xmlns:schemaLocation=", "xsi:schemaLocation=");
            sb.Replace("'", "&apos;");

            XMLToDatabase = sb.ToString();

            GC.Collect();

			return Generado;
		}
        private void obtenerXMLCuenta(TreeGridNode tgnCuenta)
        {
            SATeC.CatalogoDeCuentasV13.CatalogoCtas item = new SATeC.CatalogoDeCuentasV13.CatalogoCtas();

            item.CodAgrup = Tools.GetCode<SATeC.CatalogoDeCuentasV13.c_CodAgrup>(tgnCuenta.Cells["CodigoAgrupador"].Value.ToString());
            item.NumCta = tgnCuenta.Cells["CuentaSociedad"].Value.ToString();
            item.Desc = RemoveInvalidXmlChars(tgnCuenta.Cells["DescripcionCuentaSociedad"].Value.ToString());

            // INICIO: 2- el acatalogo convertido a XML repite la cuenta de mayor en Sub Cuenta,   cuando sub cuenta esta en blanco y CUANDO LA CUENTA SEA A NIVEL 1, NO DEBE TRAER SUBCUENTA
            string SubCtaDe = String.Empty;

            if (tgnCuenta.Cells["CuentaSociedad"].Value.ToString() == tgnCuenta.Cells["CuentaPadre"].Value.ToString())
                SubCtaDe = tgnCuenta.Cells["CuentaSociedad"].Value.ToString();
            else
                SubCtaDe = tgnCuenta.Cells["CuentaPadre"].Value.ToString();

            if (item.NumCta != SubCtaDe)
                item.SubCtaDe = SubCtaDe;
            // FIN: 2- el acatalogo convertido a XML repite la cuenta de mayor en Sub Cuenta,   cuando sub cuenta esta en blanco y CUANDO LA CUENTA SEA A NIVEL 1, NO DEBE TRAER SUBCUENTA
           
            item.Nivel = int.Parse(tgnCuenta.Cells["NivelCuentaSociedad"].Value.ToString());
            item.Natur = tgnCuenta.Cells["NaturalezaCuentaSociedad"].Value.ToString();

            if (!String.IsNullOrEmpty(tgnCuenta.Cells["CodigoAgrupador"].Value.ToString()))
            {
                listaCtas.Add(item);
            }

            foreach (TreeGridNode tgnCuentaAuxiliar in tgnCuenta.Nodes)
            {
                obtenerXMLCuenta(tgnCuentaAuxiliar);
            }
		}

        private string QuitarCaracteresEspeciales(string texto)
        {
            string textoFormateado = texto.Replace("\"", "&quot;");
            textoFormateado = textoFormateado.Replace("'", "&apos;");
            textoFormateado = textoFormateado.Replace("<", "&lt;");
            textoFormateado = textoFormateado.Replace(">", "&gt;");
            textoFormateado = textoFormateado.Replace("&", "&amp;");
            textoFormateado = textoFormateado.Trim();
            
            return textoFormateado;
        }
        static string RemoveInvalidXmlChars(string text)
        {
            var validXmlChars = text.Where(ch => XmlConvert.IsXmlChar(ch)).ToArray();
            return new string(validXmlChars);
        }
        public static string CleanInvalidXmlChars(string text)
        {
            // From xml spec valid chars:             
            // #x9 | #xA | #xD | [#x20-#xD7FF] | [#xE000-#xFFFD] | [#x10000-#x10FFFF]                 
            // any Unicode character, excluding the surrogate blocks, FFFE, and FFFF.             

            string re = @"[^x09x0Ax0Dx20-xD7FFxE000-xFFFDx10000-x10FFFF]";
            return Regex.Replace(text, re, "");
        }

		private bool guardarRegistroBaseDatos(string XMLToDatabase, string Ejercicio, string Periodo, out string Error) {
			bool Guardado = true;
			Error = string.Empty;

            string SQL = "INSERT INTO SATeC_CatalogosCuentasFormatoXML(ID_Sociedad, Ejercicio, Periodo, Fecha_Conversion, ID_Usuario_Conversion, [XML], Actualizado) VALUES(";
			SQL += General.ID_SociedadSeleccionada;
			SQL += ", '" + Ejercicio + "'";
			SQL += ", '" + Periodo + "'";
			SQL += ", getdate()";
			SQL += ", " + General.UsuarioActual.ID + "";
			SQL += ", '" + XMLToDatabase + "'";
            SQL += ", 1";
			SQL += ")";

			if(!Database.ejecutaQuery(SQL, false)) {
				Guardado = false;
				Error = Database.Error;
			}

			return Guardado;
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
        private void ContarCuentasRelacionadasAndNoRelacionadas()
        {
            totalRelacionadas = 0;
            totalNoRelacionadas = 0;

            foreach (AdvancedDataGridView.TreeGridNode node in tgvCatalogoCuentasSociedad.Nodes)
                if (!node.IsExpanded)
                    node.Expand();

            foreach (AdvancedDataGridView.TreeGridNode tgnCuentaSociedad in tgvCatalogoCuentasSociedad.Nodes)
            {
                if (String.IsNullOrEmpty(tgnCuentaSociedad.Cells[3].Value.ToString()))
                    totalNoRelacionadas++;
                else
                    totalRelacionadas++;

                foreach (AdvancedDataGridView.TreeGridNode trnCuentaAuxiliar in tgnCuentaSociedad.Nodes)
                {
                    if (String.IsNullOrEmpty(trnCuentaAuxiliar.Cells[3].Value.ToString()))
                        totalNoRelacionadas++;
                    else
                        totalRelacionadas++;
                }
            }
        }
        private bool ExisteBalanza(string Ejercicio, string Periodo)
        {
            string existeBalanza = Database.obtenerDato("DECLARE @Ejercicio VARCHAR(4) = '" + Ejercicio + "' DECLARE @Periodo VARCHAR(2) = '" + Periodo + "' DECLARE @ID_Sociedad smallint = " + General.ID_SociedadSeleccionada.ToString() + " SELECT ISNULL( (SELECT 1 from SATeC_Balanzas WHERE Ejercicio = @Ejercicio AND Periodo = @Periodo AND ID_Balanza IN ( SELECT MAX(ID_Balanza) FROM SATeC_Balanzas WHERE ID_Sociedad = @ID_Sociedad AND Ejercicio = @Ejercicio AND Periodo = @Periodo)), 0) EXISTE");

            if (existeBalanza.Equals("1"))
                return true;
            else
                return false;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                string extension = "xls";
                string fileName = "CatalogoCuentas" + DateTime.Now.ToString("yyyyMMddHHmmss");

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo " + extension.ToUpper() + "|*." + extension;
                saveFileDialog.Title = "Descargar archivo " + extension.ToUpper();
                saveFileDialog.FileName = fileName;

                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string directoryTemplate = INI.Read("Repositorio", "Exportaciones");

                    ReportViewer ReportViewer1 = new ReportViewer();
                    ReportViewer1.ProcessingMode = ProcessingMode.Local;
                    ReportViewer1.Reset();
                    ReportViewer1.LocalReport.Dispose();
                    ReportViewer1.LocalReport.DataSources.Clear();

                    ReportViewer1.LocalReport.ReportPath = directoryTemplate + @"\" + "CatalogoCuentas.rdlc";

                    DataTable dtCatalogoSociedad = Database.ExecuteDataTable("obtenerCuentasSociedad_RelacionSAT", General.ID_SociedadSeleccionada.ToString());

                    ReportDataSource dataSource = new ReportDataSource("dsCatalogoCuentas", dtCatalogoSociedad);
                    ReportViewer1.LocalReport.DataSources.Add(dataSource);
                    ReportViewer1.LocalReport.Refresh();

                    Warning[] warnings;
                    string[] streamids;
                    string mimeType = string.Empty;
                    string encoding = string.Empty;
                    string ext = string.Empty;
                    string format = string.Empty;

                    if (extension.Equals("xls"))
                        format = "EXCEL";
                    else
                        format = "PDF";

                    byte[] bytes = ReportViewer1.LocalReport.Render(format, null, out mimeType, out encoding, out ext, out streamids, out warnings);

                    using (FileStream fs = File.Create(saveFileDialog.FileName))
                    {
                        fs.Write(bytes, 0, bytes.Length);
                    }

                    General.muestraMensaje("El Catalogo de Cuentas ha sido Exportado Exitosamente!");
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
	}
}