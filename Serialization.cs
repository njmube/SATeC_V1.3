using System;
using System.Data;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SATeC
{
    public class Serialization
    {
        public Serialization() { }

        #region Metodos

        public static string SerializeObject(Object objectGraph)
        {
            try
            {
                object local = objectGraph;
                Type objType = local.GetType();

                StringBuilder sb = new StringBuilder();

                XmlWriterSettings writerSettings = new XmlWriterSettings();
                writerSettings.OmitXmlDeclaration = true;
                writerSettings.Indent = true;

                using (XmlWriter xmlWriter = XmlWriter.Create(sb, writerSettings))
                {
                    XmlSerializer xs = new XmlSerializer(objType);
                    XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                    ns.Add(String.Empty, String.Empty);
                    xs.Serialize(xmlWriter, objectGraph, ns);
                }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                Exception e = new Exception("Ocurrio un error al ejecutar el metodo SerializeObject.", ex);
                throw (e);
            }
        }
        /// <summary>
        /// Método que llena una clase a partir de un DataSet. Los alias del Stored Procedure deben de ser iguales a los nombres
        /// de las propiedades de la clase que se desea llenar.
        /// </summary>
        /// <param name="ds">Resultado de la ejecución del Stored Procedure</param>
        /// <param name="objeto">Objeto del tipo que se desea llenar</param>
        /// <param name="index">0 cuando el DS tiene sólo 1 ROW, más de 0 cuando son varios registros ej. El index de un ciclo</param>
        /// <returns></returns>
        public static object FillClassFromDataSet(DataSet ds, object objeto, int index)
        {
            try
            {
                object local = objeto;

                if (ds.Tables[0].Rows.Count > 0)
                {
                    IFormatProvider culture = new CultureInfo("es-MX", true);

                    Type objType = local.GetType();
                    PropertyInfo[] propiedades = objType.GetProperties();

                    foreach (PropertyInfo propiedad in propiedades)
                    {
                        if (ds.Tables[0].Columns.Contains(propiedad.Name))
                        {
                            Type columnType = propiedad.PropertyType;

                            if (propiedad.PropertyType.IsGenericType && propiedad.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                                columnType = propiedad.PropertyType.GetGenericArguments()[0];


                            if (!DBNull.Value.Equals(ds.Tables[0].Rows[index][propiedad.Name]))
                                propiedad.SetValue(local, Convert.ChangeType(ds.Tables[0].Rows[index][propiedad.Name], columnType), null);
                        }
                    }

                    return local;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Exception e = new Exception(string.Format("Error en FillClassFromDataSet al ejecutar la extracción del objeto del tipo: {0}\n{1}", objeto.GetType(), ex));
                throw (e);
            }
        }
        public static object FillClassFromDataTable(DataTable dt, object objeto, int index)
        {
            try
            {
                object local = objeto;

                if (dt.Rows.Count > 0)
                {
                    IFormatProvider culture = new CultureInfo("es-MX", true);

                    Type objType = local.GetType();
                    PropertyInfo[] propiedades = objType.GetProperties();

                    foreach (PropertyInfo propiedad in propiedades)
                    {
                        if (dt.Columns.Contains(propiedad.Name))
                        {
                            Type columnType = propiedad.PropertyType;

                            if (propiedad.PropertyType.IsGenericType && propiedad.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                                columnType = propiedad.PropertyType.GetGenericArguments()[0];


                            if (!DBNull.Value.Equals(dt.Rows[index][propiedad.Name]))
                                propiedad.SetValue(local, Convert.ChangeType(dt.Rows[index][propiedad.Name], columnType), null);
                        }
                    }

                    return local;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Exception e = new Exception(string.Format("Error en FillClassFromDataTable al ejecutar la extracción del objeto del tipo: {0}\n{1}", objeto.GetType(), ex));
                throw (e);
            }
        }

        #endregion Metodos
    }
}
