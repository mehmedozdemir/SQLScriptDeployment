using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace SQLScriptDeployment
{
    class DeploymentOperation
    {
        public DeploymentResult DeploymentBaslat(Deployment dep)
        {
            DeploymentResult depResult = new DeploymentResult();
            if (dep != null && dep.Server != null)
            {
                depResult.ServerName = dep.Server.ServerName;
                try
                {
                    string connectionString = CreateConnectionString(dep.Server);
                    DBOperation.ExecuteSQL(connectionString, dep.SqlScript);
                    depResult.IsSucces = true;
                    depResult.ResultDescription = "Başarılı";
                }
                catch (Exception ex)
                {
                    depResult.IsSucces = false;
                    depResult.ResultDescription = ex.Message;
                }
            }
            return depResult;
        }

        public string CreateConnectionString(Server s)
        {
            string result = "";
            if (s != null)
            {
                SqlConnectionStringBuilder csBuilder = new SqlConnectionStringBuilder();
                csBuilder.DataSource = s.ServerAddress;
                csBuilder.InitialCatalog = s.DatabaseName;
                csBuilder.UserID = s.UserID;
                csBuilder.Password = s.Password;
                csBuilder.ConnectTimeout = 1;
                result = csBuilder.ToString();
            }
            return result;
        }

    }
}
