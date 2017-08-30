﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;

namespace SATeC {
    //VHJC Clase para leer y escribir informacion desde/hacia un archivo INI
    public static class INI {
        private static string _path = Application.StartupPath + "\\SATeC.ini";

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
		[DllImport("kernel32")]
		private static extern int GetPrivateProfileInt(string section, string key, int defValue, string filePath);

		//Funcion para verificar que una llave exista en un archivo INI
		//Section = Seccion del archivo INI
		//Key = Llave dentro de la seccion del archivo INI
		public static bool KeyExists(string Section, string Key) {
			bool Exists = false;

			if(existeINI()) {
				int i = GetPrivateProfileInt(Section, Key, -1, _path);

				Exists = (i > -1);
			}

			return Exists;
		}


        //Funcion para escribir informacion hacia un archivo INI
        //Section = Seccion del archivo INI
        //Key = Llave dentro de la seccion del archivo INI
        //Value = Valor para la llave
        public static void Write(string Section, string Key, string Value) {
            if(existeINI()) {
                WritePrivateProfileString(Section, Key, Value, _path);
            }
        }

        //Funcion para leer informacion desde un archivo INI
        //Section = Seccion del archivo INI
        //Key = Llave dentro de la seccion del archivo INI
        //Regresa un string con el valor de la llave
        public static string Read(string Section, string Key) {
            string sReturn = string.Empty;
            if(existeINI()) {
                StringBuilder temp = new StringBuilder(255);
                int i = GetPrivateProfileString(Section, Key, "", temp, 255, _path);
                sReturn = temp.ToString();
            }
            return sReturn;
        }

        //Funcion para verificar que exista el archivo INI
        public static bool existeINI() {
            bool bReturn = false;

            if(File.Exists(_path))
                bReturn = true;
            else
                throw new Exception("No es posible encontrar el archivo de configuración, favor de reportarlo a su area de sistemas.");

            return bReturn;
        }

        //Obtiene la ruta y nombre de archivo INI
        public static string Path {
            get { return _path; }
        }
    }
}
