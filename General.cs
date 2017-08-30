using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Globalization;
using System.Windows.Forms;

namespace SATeC {

	public enum Periodo {
		enero = 1,
		febrero,
		marzo,
		abril,
		mayo,
		junio,
		julio,
		agosto,
		septiembre,
		octubre,
		noviembre,
		diciembre
	};

	public enum TipoConsultaBalanzaImportada {
		ConCodigoAgrupadorSAT = 1,
		ConFormatoXML,
		ConCatalogoDeCuentasSociedad
	};

	public enum TipoPoliza {
		Ingresos = 1,
		Egresos,
		Diario
	};

	public enum TipoConsultaPolizasImportadas {
		Importadas = 1,
		ImportarDatosComplementarios,
		ConvertidasXML
	};

	public enum TipoFuncionalidadPolizas {
		ImportarDatosComplementarios = 1,
		ValidarPolizas
	};

	public static class General {

		public static bool EsDemo { get; set; }
		public static string FechaDemo { get; set; }

        public static Usuario UsuarioActual { get; set; }

        public static int ID_SociedadSeleccionada { get; set; }
        public static string Numero_SociedadSeleccionada { get; set; }
        public static string Nombre_SociedadSeleccionada { get; set; }
		public static string RFC_SociedadSeleccionada { get; set; }

		//VHJC Funcion que verifica si la version es Demo
		public static void verificaSiEsDemo() {
			string DemoFechaDemo = INI.Read("SATeC", "SATeC");

			string[] Datos = DemoFechaDemo.Split(',');

			EsDemo = (Datos[0] == "DEMO");
			
			if(EsDemo)
				FechaDemo = Datos[1];
		}

		//VHJC Funcion que muestra un mensaje en pantalla
		public static void muestraMensaje(String sMensaje) {
			muestraMensaje(sMensaje, MessageBoxButtons.OK);
		}

		public static void muestraMensaje(String sMensaje, MessageBoxButtons msgBotones) {
			MessageBox.Show(sMensaje, "SATeC", msgBotones, MessageBoxIcon.Information);
		}

        public static DialogResult muestraMensajePregunta(String sMensaje) {
            return MessageBox.Show(sMensaje, "SATeC", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        //VHJC Funcion que cambia el mensaje en el status bar
        public static void cambiaMensajeStatus(Form frmSender, string sMensaje) {
            StatusStrip stsMain = new StatusStrip();
            if(sMensaje == string.Empty)
                sMensaje = "Listo";

            if(frmSender.IsMdiChild) {
                stsMain = (StatusStrip)frmSender.MdiParent.Controls["stsMain"];
            } else {
                stsMain = (StatusStrip)frmSender.Controls["stsMain"];
            }
            ToolStripStatusLabel lblStatus = (ToolStripStatusLabel)stsMain.Items["lblStatus"];
            lblStatus.Text = sMensaje;

            stsMain.Refresh();
        }

        //VHJC Funcion que busca un valor dentro de un combobox y esteblece el texto del combobox
        public static void buscaEnCombo(ComboBox cmbABuscar, String valor) {
            foreach(ListItem cmbItem in cmbABuscar.Items) {
                if(cmbItem.Valor.Equals(valor)) {
                    cmbABuscar.Text = cmbItem.Texto;
                    break;
                }
            }
        }

        //VHJC Funcion que regresa el ultimo dia del mes que se pasa como parametro
        public static DateTime obtenerUltimoDiaMes(DateTime dtFecha) {
            int DiasEnMes = DateTime.DaysInMonth(dtFecha.Year, dtFecha.Month);
            DateTime dtUltimoDiaMes = new DateTime(dtFecha.Year, dtFecha.Month, DiasEnMes);
            return dtUltimoDiaMes;
        }

        //VHJC Funcion que verifica si hay una sociedad seleccionada para trabajar
        public static bool verificaSociedadSeleccionada() {
            return General.ID_SociedadSeleccionada > 0;
        }

		//VHJC Funcion que obtine la carpeta de los archivos TXT de Catalogos de Cuentas maestros y auxiliares
		public static string obtenerCarpetaArchivosTXTCatalogosDeCuentas() {
			string CarpetaArchivosTXTCatalogoCuentas = INI.Read("SATeC", "CarpetaArchivosTXTCatalogoCuentas");
			if(CarpetaArchivosTXTCatalogoCuentas == string.Empty)
				CarpetaArchivosTXTCatalogoCuentas = Application.StartupPath + "\\CatalogosDeCuentasTXT";

			return CarpetaArchivosTXTCatalogoCuentas;
		}

		//VHJC Funcion que obtiene la carpeta de los archivos XML de los Catalogos de Cuentas
		public static string obtenerCarpetaArchivosXMLCatalogos() {
			string CarpetaArchivosXMLCatalogos = INI.Read("SATeC", "CarpetaArchivosXMLCatalogos");
			if(CarpetaArchivosXMLCatalogos == string.Empty)
				CarpetaArchivosXMLCatalogos = Application.StartupPath + "\\XML\\Catalogos";

			return CarpetaArchivosXMLCatalogos;
		}

		//VHJC Funcion que obtine la carpeta de los archivos TXT de Balanza
		public static string obtenerCarpetaArchivosTXTBalanza() {
			string CarpetaArchivosTXTBalanza = INI.Read("SATeC", "CarpetaArchivosTXTBalanza");
			if(CarpetaArchivosTXTBalanza == string.Empty)
				CarpetaArchivosTXTBalanza = Application.StartupPath + "\\BalanzaTXT";

			return CarpetaArchivosTXTBalanza;
		}


		//VHJC Funcion que revisa que el dato que va hacia la base de datos no tenga caracteres especiales de SQL
		public static string revisaDatoSQL(string Dato) {
			string DatoRevisado = Dato;

			DatoRevisado = DatoRevisado.Replace("'", "''");

			return DatoRevisado;
		}

#region Encriptar/Desencriptar
        //Valor de Encriptacion
        private static int iValorEncriptacion = 25;

        //Funcion que encripta un dato
        public static string encripta(string sDato) {
            string sReturn = string.Empty;
            Encoding myEncoding = Encoding.GetEncoding(437);
            byte[] encodedBytes = myEncoding.GetBytes(sDato);

            foreach(byte bCaracter in encodedBytes) {
                char cCaracter = Convert.ToChar(bCaracter);
                int iCodigoAscii = (int)cCaracter;

                iCodigoAscii += iValorEncriptacion;

                if(iCodigoAscii > 255)
                    iCodigoAscii--;

                sReturn += iCodigoAscii.ToString("X");
            }

            return sReturn;
        }


        //Funcion que desencripta un dato
        public static string desencripta(string sDato) {
            string sReturn = string.Empty;
            string sCaracter = string.Empty;

            int iLongDato = sDato.Length;
            int iCount = 0;

            Encoding myEncoding = Encoding.GetEncoding(437);
            byte[] encodedBytes = new byte[0];
            int iCountBytes = 0;

            //Por cada dos caracteres del dato
            for(iCount = 0; iCount < iLongDato; iCount += 2) {
                sCaracter = sDato.Substring(iCount, 2);
                //obtenemos el codigo hexadecimal para pasarlo a entero y despues al caracter
                int iCodigoAscii = int.Parse(sCaracter, NumberStyles.HexNumber) - iValorEncriptacion;

                Array.Resize<byte>(ref encodedBytes, iCountBytes + 1);
                encodedBytes[iCountBytes] = Convert.ToByte(iCodigoAscii);
                iCountBytes++;
            }

            sReturn = myEncoding.GetString(encodedBytes);
            return sReturn;
        }
#endregion


		internal static void muestraMensaje(Administracion.frmUsuario_Datos frmUsuario_Datos, string p) {
			throw new NotImplementedException();
		}
	}


    public class ListItem {
        private string Value;
        private string Text;

        public ListItem(string value, string text) {
            Value = value;
            Text = text;
        }

        public string Texto {
            get { return this.Text; }
        }

        public string Valor {
            get { return this.Value; }
        }
    }

}
