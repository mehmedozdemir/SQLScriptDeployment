using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SQLScriptDeployment
{
    class DBOperation
    {
        private DBOperation()
        { }

        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;

        private static dbDeployEntities2 m_entities;
        public static dbDeployEntities2 DBDeploy
        {
            get
            {
                if (m_entities == null)
                {
                    m_entities = new dbDeployEntities2();
                }
                return m_entities;
            }
        }


        public static bool ConnectionTest(string connectionString)
        {
            bool result = false;
            if (_sqlConnection == null)
                _sqlConnection = new SqlConnection();

            _sqlConnection.ConnectionString = connectionString;


            try
            {
                if (_sqlConnection.State == ConnectionState.Closed)
                {
                    _sqlConnection.Open();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                result = false;
                throw ex;
            }
            finally
            {
                _sqlConnection.Close();
            }
            return result;
        }
        public static void ExecuteSQL(string connectionString, string sql)
        {
            if (_sqlConnection == null)
                _sqlConnection = new SqlConnection();

            if (_sqlCommand == null)
                _sqlCommand = new SqlCommand();

            _sqlConnection.ConnectionString = connectionString;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = sql;
            _sqlCommand.CommandType = CommandType.Text;


            if (_sqlConnection.State == ConnectionState.Closed)
                _sqlConnection.Open();

            try
            {
                _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }
    }
}
