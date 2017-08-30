using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SATeC
{
    public static class DataBaseSQL
    {
        public static string Error { get; set; }
        private static SqlConnection Connection = null;

        public static string getConnectionString()
        {
            string sDBMS = INI.Read("Database", "DBMS");
            string sDataSource = INI.Read("Database", "DataSource" + sDBMS);
            string sDataBase = INI.Read("Database", "Database" + sDBMS);
            string sUserID = INI.Read("Database", "UserID" + sDBMS);
            string sPassword = INI.Read("Database", "Password" + sDBMS);
            string sConeccionString = string.Empty;

            sConeccionString = "Data Source=" + sDataSource + ";Initial Catalog=" + sDataBase + ";User ID=" + sUserID + ";Password=" + sPassword + ";";

            return sConeccionString;
        }

        //VHJC Funcion que abre una conexion a la base de datos
        private static void abrirConexion()
        {
            try
            {
                Connection = new SqlConnection(getConnectionString());

                if (Connection.State == ConnectionState.Closed)
                    Connection.Open();
            }
            catch (SqlException dbEx)
            {
                string sMensaje = dbEx.Message;
                throw new Exception(sMensaje);
            }
        }
        private static void cerrarConexion()
        {
            if (Connection.State == ConnectionState.Open)
                Connection.Close();
        }
        private static int ExecuteNonQueryGetIdentityWithTransaction(SqlConnection conn, SqlTransaction tran, string queryInsert, string querySelect)
        {

            SqlCommand cmd = new SqlCommand(queryInsert, conn, tran);

            cmd.ExecuteNonQuery();

            cmd = new SqlCommand(querySelect, conn, tran);

            int idPoliza = (int)cmd.ExecuteScalar();

            return idPoliza;
        }
        public static bool ExecuteBulkCopyWithTransaction(SqlConnection conn, SqlTransaction tran, string DestinationTableName, DataTable table)
        {
            bool bReturn = true;

            try
            {
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn, SqlBulkCopyOptions.Default, tran))
                {
                    bulkCopy.DestinationTableName = DestinationTableName;
                    bulkCopy.BulkCopyTimeout = 300000;

                    bulkCopy.WriteToServer(table);
                }
            }
            catch (Exception ex)
            {
                Error = "Error <<ExecuteBulkCopyWithTransaction>>: " + ex.ToString();
                bReturn = false;
            }

            return bReturn;
        }
        public static bool RegistrarPoliza(int idSociedad, string ejercicio, string periodo, string TipoSolicitud, string NumOrden, string NumTramite, int Usuario, DataTable dtPolizas)
        {
            using (SqlConnection conn = new System.Data.SqlClient.SqlConnection(getConnectionString()))
            {
                conn.Open();

                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    string queryInsert = string.Format("INSERT INTO SATeC_Polizas (ID_Sociedad, Ejercicio, Periodo, Fecha_Importacion, ID_Usuario_Importacion, TipoSolicitud, NumOrden, NumTramite) VALUES({0},'{1}','{2}',{3},{4},'{5}','{6}','{7}') ", 
                                                                                    idSociedad, ejercicio, periodo, "GETDATE()", Usuario,                       TipoSolicitud, NumOrden, NumTramite);
                    string querySelect = "SELECT ID_Poliza FROM SATeC_Polizas WHERE @@ROWCOUNT > 0 and ID_Poliza = SCOPE_IDENTITY()";

                    int idIdentity = ExecuteNonQueryGetIdentityWithTransaction(conn, tran, queryInsert, querySelect);

                    if (idIdentity > 0)
                    {
                        DataView viewPolizas = new DataView(dtPolizas);
                        viewPolizas.Sort = "numPoliza, secuencia";
                        DataTable dtPolizasPolizas = viewPolizas.ToTable(false, "idPoliza", "numPoliza", "fechaPoliza", "conceptoOperacion");

                        foreach (DataRow row in dtPolizasPolizas.Rows)
                        {
                            row["idPoliza"] = idIdentity;
                        }

                        bool registroPolizaPoliza = ExecuteBulkCopyWithTransaction(conn, tran, "SATeC_Polizas_Polizas", dtPolizasPolizas);

                        if (registroPolizaPoliza)
                        {
                            viewPolizas.Sort = "numPoliza, secuencia";
                            DataTable dtPolizasTransacciones = viewPolizas.ToTable(false, "idPoliza", "numPoliza", "secuencia", "numCuenta", "descCuenta", "concepto", "debe", "haber");

                            foreach (DataRow row in dtPolizasTransacciones.Rows)
                            {
                                row["idPoliza"] = idIdentity;

                                if (String.IsNullOrEmpty(row["debe"].ToString()))
                                    row["debe"] = 0.00;

                                if (String.IsNullOrEmpty(row["haber"].ToString()))
                                    row["haber"] = 0.00;
                            }

                            bool registroPolizaTransacciones = ExecuteBulkCopyWithTransaction(conn, tran, "SATeC_Polizas_Transacciones", dtPolizasTransacciones);

                            if (registroPolizaTransacciones)
                            {
                                tran.Commit();
                                return true;
                            }
                            else
                            {
                                tran.Rollback();
                                return false;
                            }
                        }
                        else
                        {
                            tran.Rollback();
                            return false;
                        }
                    }
                    else
                    {
                        tran.Rollback();
                        return false;
                    }
                } //Fin de SqlTransaction.
            }
        }
        public static bool RegistrarComprobantesNacionales(DataTable dtComprobantes)
        {
            using (SqlConnection conn = new System.Data.SqlClient.SqlConnection(getConnectionString()))
            {
                conn.Open();

                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    bool registroComprobantes = ExecuteBulkCopyWithTransaction(conn, tran, "SATeC_Polizas_Comprobantes_Nacional", dtComprobantes);

                    if (registroComprobantes)
                    {
                        tran.Commit();
                        return true;
                    }
                    else
                    {
                        tran.Rollback();
                        return false;
                    }
                }
            }
        }
        public static bool RegistrarComprobantesNacionalesOtros(DataTable dtComprobantesOtros)
        {
            using (SqlConnection conn = new System.Data.SqlClient.SqlConnection(getConnectionString()))
            {
                conn.Open();

                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    bool registroComprobantesOtros = ExecuteBulkCopyWithTransaction(conn, tran, "SATeC_Polizas_Comprobantes_Nacional_Otros", dtComprobantesOtros);

                    if (registroComprobantesOtros)
                    {
                        tran.Commit();
                        return true;
                    }
                    else
                    {
                        tran.Rollback();
                        return false;
                    }
                }
            }
        }
        public static bool RegistrarComprobantesExtranjeros(DataTable dtComprobantesExtranjeros)
        {
            using (SqlConnection conn = new System.Data.SqlClient.SqlConnection(getConnectionString()))
            {
                conn.Open();

                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    bool registroComprobantesExtranjeros = ExecuteBulkCopyWithTransaction(conn, tran, "SATeC_Polizas_Comprobantes_Extranjeros", dtComprobantesExtranjeros);

                    if (registroComprobantesExtranjeros)
                    {
                        tran.Commit();
                        return true;
                    }
                    else
                    {
                        tran.Rollback();
                        return false;
                    }
                }
            }
        }
        public static bool RegistrarMetodosPago(DataTable dtMetodosPago)
        {
            using (SqlConnection conn = new System.Data.SqlClient.SqlConnection(getConnectionString()))
            {
                conn.Open();

                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    bool registroMetodosPago = ExecuteBulkCopyWithTransaction(conn, tran, "SATeC_Polizas_OtroMetodoPago", dtMetodosPago);

                    if (registroMetodosPago)
                    {
                        tran.Commit();
                        return true;
                    }
                    else
                    {
                        tran.Rollback();
                        return false;
                    }
                }
            }
        }
        public static bool RegistrarTransferencias(DataTable dtTransferencias)
        {
            using (SqlConnection conn = new System.Data.SqlClient.SqlConnection(getConnectionString()))
            {
                conn.Open();

                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    bool registroTransferencias = ExecuteBulkCopyWithTransaction(conn, tran, "SATeC_Polizas_Transferencias", dtTransferencias);

                    if (registroTransferencias)
                    {
                        tran.Commit();
                        return true;
                    }
                    else
                    {
                        tran.Rollback();
                        return false;
                    }
                }
            }
        }

        public static void ExecuteNonQuery(string SQL)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(getConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(SQL, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        con.Open();

                        cmd.ExecuteNonQuery();
                    }

                    if (con.State != ConnectionState.Closed)
                        con.Close();
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

    }
        
}