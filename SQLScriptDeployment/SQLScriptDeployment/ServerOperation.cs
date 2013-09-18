using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SQLScriptDeployment
{
    class ServerOperation
    {
        private FileStream fs = null;
        private BinaryFormatter bf = null;

        public List<Server> GetServerList()
        {
            return DBOperation.DBDeploy.Server.ToList<Server>();
        }
        public void SaveServer(Server s)
        {
            if (s.EntityState != System.Data.EntityState.Modified)
            {
                DBOperation.DBDeploy.AddToServer(s);
            }
            DBOperation.DBDeploy.SaveChanges();
            DBOperation.DBDeploy.AcceptAllChanges();
        }
        public void DeleteServer(Server s)
        {
            DBOperation.DBDeploy.DeleteObject(s);
            DBOperation.DBDeploy.SaveChanges();
        }
        public Server GetServerByName(string name)
        {
            return DBOperation.DBDeploy.Server.FirstOrDefault<Server>(s => s.ServerName == name);
        }
        public Server GetServerByServerId(int serverId)
        {
            return DBOperation.DBDeploy.Server.FirstOrDefault<Server>(s => s.ServerID == serverId);
        }
        public int GetMaxServerID()
        {
            return DBOperation.DBDeploy.Server.Count() + 1;
        }
        public void ServerVerileriniTemizle()
        {
            var serverList = GetServerList();
            foreach (var item in serverList)
            {
                DeleteServer(item);
            }
        }

        public bool Export(List<Server> seciliServerList)
        {
            bool result = false;
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Title = "Database Listesini Dışa Aktar";
                saveDialog.Filter = "SSD Export Format|*.ssd|Tüm Dosyalar|(*.*)";
                saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveDialog.FileName = string.Format("SSDDatabaseList_{0}_{1}_{2}.ssd", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileName = saveDialog.FileName;
                    fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    bf = new BinaryFormatter();
                    bf.Serialize(fs, seciliServerList);
                    fs.Close();
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
                CloseFileStrem();
            }
            return result;
        }
        public bool Import()
        {
            bool result = false;
            try
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Title = "Database Listesini İçe Aktar";
                openDialog.Filter = "SSD Export Format|*.ssd|Tüm Dosyalar|(*.*)";
                openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileName = openDialog.FileName;
                    fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    bf = new BinaryFormatter();
                    List<Server> databaseList = bf.Deserialize(fs) as List<Server>;
                    if (databaseList != null)
                    {
                        SaveImportServer(databaseList);
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                throw ex;
            }
            finally
            {
                CloseFileStrem();
            }
            return result;
        }
        private void CloseFileStrem()
        {
            if (fs != null)
                fs.Close();
        }

        private void SaveImportServer(List<Server> list)
        {
            foreach (Server s in list)
            {
                Server newServer = new Server();
                newServer.ServerID = GetMaxServerID();
                newServer.ServerName = s.ServerName;
                newServer.ServerAddress = s.ServerAddress;
                newServer.DatabaseName = s.DatabaseName;
                newServer.UserID = s.UserID;
                newServer.Password = s.Password;
                DBOperation.DBDeploy.AddToServer(newServer);
                DBOperation.DBDeploy.SaveChanges();
                DBOperation.DBDeploy.AcceptAllChanges();
            }
        }
    }
}
