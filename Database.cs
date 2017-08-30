using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SATeC {

    public enum DatabaseManagementSystem {
        SQLServer = 1,
        Access
    };

    public static class Database {
		public static string Error { get; set; }

		private static DatabaseManagementSystem DBMS { get; set; }
        private static OleDbConnection DBConnection = null;

        //VHJC Funcion que genera la cadena de conexion para poder conectarse a la base de datos indicada en el archivo .INI
        public static string getConnectionString() {
            string sDBMS = INI.Read("Database", "DBMS");
            string sDataSource = INI.Read("Database", "DataSource" + sDBMS);
            string sDataBase = INI.Read("Database", "Database" + sDBMS);
            string sUserID = INI.Read("Database", "UserID" + sDBMS);
            string sPassword = INI.Read("Database", "Password" + sDBMS);
            string sConeccionString = string.Empty;

			DatabaseManagementSystem DBMSSeleccionado;
			Enum.TryParse(sDBMS, out DBMSSeleccionado);

			DBMS = DBMSSeleccionado;

            switch(DBMS) {
                case DatabaseManagementSystem.SQLServer:
                    sConeccionString = "Provider=SQLOLEDB;Data Source=" + sDataSource + ";Initial Catalog=" + sDataBase + ";User ID=" + sUserID + ";Password=" + sPassword + ";";
                    break;
                case DatabaseManagementSystem.Access:
                    sConeccionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + sDataSource + ";";
                    break;
            }

            Error = sConeccionString;
            return sConeccionString;
        }

        //VHJC Funcion que abre una conexion a la base de datos
        private static void abrirConexion() {
            try {
                DBConnection = new OleDbConnection(getConnectionString());
                if(DBConnection.State == ConnectionState.Closed)
                    DBConnection.Open();
            } catch(OleDbException dbEx) {
                string sMensaje = dbEx.Message;
                //if(dbEx.Number == 2) {
                //    sMensaje = "No se encuentra o no se puede conectar con el servidor de base de datos. Favor de notificar a su area de sistemas.";
                //}
                throw new Exception(sMensaje);
            }
        }

        //VHJC Funcion que cierra una conexion a la base de datos
        private static void cerrarConexion() {
            if(DBConnection.State != ConnectionState.Closed)
                DBConnection.Close();
        }

        //VHJC
        //Funcion con la que se puede obtener n registros de la base de datos
        //Se regresa un objeto SqlDataReader para poder leer los registros
        public static OleDbDataReader obtenRegistros(string SQL, CommandType commandType = CommandType.Text, params string[] SQLParameters) {
            OleDbCommand DBCommand = null;
            OleDbDataReader DBReader = null;

            try
            {
                abrirConexion();

                DBCommand = new OleDbCommand(SQL, DBConnection);

                //VHJC Si el SQL es un stored procedure
                if (commandType == CommandType.StoredProcedure)
                {
                    DBCommand.CommandType = CommandType.StoredProcedure;
                    foreach (string SQLParameter in SQLParameters)
                    {
                        DBCommand.Parameters.AddWithValue("", SQLParameter);
                    }
                }

                DBCommand.CommandTimeout = 3600;
                DBReader = DBCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return DBReader;
            }
            catch (OleDbException dbEx)
            {
                Error = "Error <<obtenRegistros>>: " + dbEx.ToString();
                throw new Exception(Error);
            }
            catch (Exception e)
            {
                Error = "Error <<obtenRegistros>>: " + e.ToString();
                throw new Exception(e.Message);
            }            
        }

		//VHJC
		//Funcion que obtiene solo un dato de la base de datos
		//Se regresa un string para que se pueda convertir a cualquier tipo de datos
		public static string obtenerDato(string SQL) {
			OleDbCommand DBCommand = null;
			string Dato = string.Empty;
			try {
				abrirConexion();

				DBCommand = new OleDbCommand(SQL, DBConnection);
                DBCommand.CommandTimeout = 3600;
				Dato = DBCommand.ExecuteScalar().ToString();
				return Dato;
			} catch(OleDbException dbEx) {
				Error = "Error <<obtenRegistros>>: " + dbEx.ToString();
				throw new Exception(Error);
			} catch(Exception e) {
				Error = "Error <<obtenRegistros>>: " + e.ToString();
				throw new Exception(e.Message);
			} finally {
				cerrarConexion();
			}
		}

        public static string obtenerDato(string StoredProcedure, CommandType commandType = CommandType.StoredProcedure, params string[] SQLParameters)
        {
            OleDbCommand DBCommand = null;
            string Dato = string.Empty;
            try
            {
                abrirConexion();

                DBCommand = new OleDbCommand(StoredProcedure, DBConnection);
                DBCommand.CommandType = commandType;

                foreach (string SQLParameter in SQLParameters)
                {
                    DBCommand.Parameters.AddWithValue("", SQLParameter);
                }

                DBCommand.CommandTimeout = 3600;
                Dato = DBCommand.ExecuteScalar().ToString();
                return Dato;
            }
            catch (OleDbException dbEx)
            {
                Error = "Error <<obtenerDato>>: " + dbEx.ToString();
                throw new Exception(Error);
            }
            catch (Exception e)
            {
                Error = "Error <<obtenerDato>>: " + e.ToString();
                throw new Exception(e.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }


        //VHJC
        //Funcion con la que se ejecuta un Query del tipo INSERT, UPDATE o DELETE
        //regresa true si no hubo ningun error, false si hubo algun error
		public static bool ejecutaQuery(string sSQL, bool bUseTransaction) {
            bool bReturn = true;
            abrirConexion();
            OleDbCommand DBCommand = new OleDbCommand(sSQL, DBConnection);
            OleDbTransaction DBTransaction = null;
            try {
                if(bUseTransaction) {
                    DBTransaction = DBConnection.BeginTransaction();
                    DBCommand.Transaction = DBTransaction;
                }

                DBCommand.CommandText = sSQL;
                DBCommand.CommandTimeout = 3600;
                DBCommand.ExecuteNonQuery();

                if(bUseTransaction)
                    DBTransaction.Commit();
            } catch(Exception e) {
                LogErrores.WriteLog(string.Format("Error en el metodo ejecutaQuery({0})", sSQL), e);
                Error = "Error <<ejecutaQuery>>: " + e.ToString();
                bReturn = false;
                if(bUseTransaction)
                    DBTransaction.Rollback();
            } finally {
                cerrarConexion();
            }

            return bReturn;
        }


		//VHJC
		//Funcion con la que se ejecuta un Query del tipo STORED PROCEDURE
		//regresa true si no hubo ningun error, false si hubo algun error
		public static bool ejecutaQuery(string StoredProcedure, CommandType commandType = CommandType.StoredProcedure, params string[] SQLParameters) {
			bool bReturn = true;

			try {
				abrirConexion();
				OleDbCommand DBCommand = new OleDbCommand(StoredProcedure, DBConnection);
				DBCommand.CommandType = commandType;
				foreach(string SQLParameter in SQLParameters) {
					DBCommand.Parameters.AddWithValue("", SQLParameter);
				}

                DBCommand.CommandTimeout = 3600;
				DBCommand.ExecuteNonQuery();
			} catch(Exception e) {
				Error = "Error <<ejecutaQuery>>: " + e.ToString();
				bReturn = false;
			} finally {
				cerrarConexion();
			}

			return bReturn;
		}

        public static DataTable ExecuteDataTable(string SQL)
        {
            OleDbCommand DBCommand = null;

            try
            {
                abrirConexion();

                DBCommand = new OleDbCommand(SQL, DBConnection);
                DBCommand.CommandTimeout = 0;

                DataTable dtDatos = new DataTable();

                using (OleDbDataAdapter a = new OleDbDataAdapter(DBCommand))
                {
                    a.Fill(dtDatos);
                }

                return dtDatos;
            }
            catch (OleDbException dbEx)
            {
                Error = "Error <<ExecuteDataTable>>: " + dbEx.ToString();
                throw new Exception(Error);
            }
            catch (Exception e)
            {
                Error = "Error <<ExecuteDataTable>>: " + e.ToString();
                throw new Exception(e.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public static DataTable ExecuteDataTable(string nameStoredProcedure, params string[] SQLParameters)
        {
            OleDbCommand DBCommand = null;

            try
            {
                abrirConexion();

                DBCommand = new OleDbCommand(nameStoredProcedure, DBConnection);
                DBCommand.CommandType = CommandType.StoredProcedure;

                foreach (string SQLParameter in SQLParameters)
                {
                    DBCommand.Parameters.AddWithValue("", SQLParameter);
                }

                DBCommand.CommandTimeout = 3600;

                DataTable dtDatos = new DataTable();

                using (OleDbDataAdapter a = new OleDbDataAdapter(DBCommand))
                {
                    a.Fill(dtDatos);
                }

                return dtDatos;
            }
            catch (OleDbException dbEx)
            {
                Error = "Error <<ExecuteDataTable>>: " + dbEx.ToString();
                throw new Exception(Error);
            }
            catch (Exception e)
            {
                Error = "Error <<ExecuteDataTable>>: " + e.ToString();
                throw new Exception(e.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public static DataSet ExecuteDataSet(string nameStoredProcedure, params string[] SQLParameters)
        {
            OleDbCommand DBCommand = null;

            try
            {
                abrirConexion();

                DBCommand = new OleDbCommand(nameStoredProcedure, DBConnection);
                DBCommand.CommandType = CommandType.StoredProcedure;

                foreach (string SQLParameter in SQLParameters)
                {
                    DBCommand.Parameters.AddWithValue("", SQLParameter);
                }

                DBCommand.CommandTimeout = 3600;

                DataSet dsDatos = new DataSet();

                using (OleDbDataAdapter a = new OleDbDataAdapter(DBCommand))
                {
                    a.Fill(dsDatos);
                }

                return dsDatos;
            }
            catch (OleDbException dbEx)
            {
                Error = "Error <<ExecuteDataSet>>: " + dbEx.ToString();
                throw new Exception(Error);
            }
            catch (Exception e)
            {
                Error = "Error <<ExecuteDataSet>>: " + e.ToString();
                throw new Exception(e.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }
    }
}
