using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SQLScriptDeployment
{
    public partial class frmMain : Form
    {
        private Task executeTask = null;
        private frmServer databaseFrom = null;
        private List<DeploymentResult> deploymentResultList = null;

        public frmMain()
        {
            InitializeComponent();
        }
        private void ServerListesiDoldur()
        {
            List<Server> serverList = ProgramOperation.ServerOperation.GetServerList();
            cbServerList.Items.Clear();
            foreach (Server s in serverList)
            {
                string name = string.Format("{0} - {1}", s.ServerID, s.ServerName);
                cbServerList.Items.Add(name);
            }
        }
        private void Gonder()
        {
            List<Server> serverList = GetSelectedServerList();
            deploymentResultList = new List<DeploymentResult>();
            foreach (Server s in serverList)
            {
                Deployment dep = new Deployment();
                dep.Server = s;
                dep.SqlScript = txtSQLScript.Text;
                DeploymentResult result = ProgramOperation.DeploymentOperation.DeploymentBaslat(dep);
                deploymentResultList.Add(result);
            }

        }
        private void DeploySonucuGoster()
        {
            gvResult.DataSource = deploymentResultList;
        }
        private List<Server> GetSelectedServerList()
        {

            List<Server> resultList = new List<Server>();
            for (int i = 0; i < cbServerList.Items.Count; i++)
            {
                if (cbServerList.GetItemChecked(i))
                {
                    string name = cbServerList.GetItemText(cbServerList.Items[i]);
                    string serverId = name.Substring(0, name.IndexOf("-"));
                    Server server = ProgramOperation.ServerOperation.GetServerByServerId(int.Parse(serverId));
                    resultList.Add(server);
                }
            }
            return resultList;
        }
        private Server GetSelectedServer()
        {
            Server result = null;
            if (cbServerList.GetSelected(cbServerList.SelectedIndex))
            {
                string name = cbServerList.GetItemText(cbServerList.Items[cbServerList.SelectedIndex]);
                string serverId = name.Substring(0, name.IndexOf("-"));
                result = ProgramOperation.ServerOperation.GetServerByServerId(int.Parse(serverId));
            }
            return result;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            CheckForIllegalCrossThreadCalls = false;
            gvResult.AutoGenerateColumns = false;
            gvResult.DataSource = null;
            ServerListesiDoldur();

#if DEBUG
            txtSQLScript.Text = "SELECT GETDATE();";
#endif
        }
        private void btnTumunuSec_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbServerList.Items.Count; i++)
            {
                cbServerList.SetItemChecked(i, true);
            }
        }
        private void btnSecimiBirak_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbServerList.Items.Count; i++)
            {
                cbServerList.SetItemChecked(i, false);
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSQLScript.Text = "";
            gvResult.DataSource = null;
        }
        private void btnAddDatabase_Click(object sender, EventArgs e)
        {
            frmServer serverform = new frmServer();
            if (serverform.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ServerListesiDoldur();
            }
        }
        private void btnDeleteDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                var dr = MessageBox.Show("Seçili databaseleri silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNoCancel);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    List<Server> serverList = GetSelectedServerList();
                    foreach (var item in serverList)
                    {
                        ProgramOperation.ServerOperation.DeleteServer(item);
                    }
                    ServerListesiDoldur();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbServerList.CheckedItems.Count > 0)
                {
                    executeTask = new Task(() => Gonder());
                    var endTask = executeTask.ContinueWith((t) => DeploySonucuGoster());
                    executeTask.Start();
                }
                else
                {
                    MessageBox.Show("Dağıtımı başlatmak için server seçmeniz gerekmektedir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (executeTask != null)
            {
                executeTask.Wait();
            }
            MessageBox.Show("İşlem iptal edildi.");
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                List<Server> seciliServerList = GetSelectedServerList();
                bool result = ProgramOperation.ServerOperation.Export(seciliServerList);
                if (result)
                {
                    MessageBox.Show("Export işlemi tamamlanmıştır.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = ProgramOperation.ServerOperation.Import();
                if (result)
                {
                    ServerListesiDoldur();
                    MessageBox.Show("Import işlemi tamamlanmıştır.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Import sırasında hata meydana geldi.\n" + ex.Message);
            }

        }
        private void btnDatabaseDuzenle_Click(object sender, EventArgs e)
        {
            if (cbServerList.CheckedItems.Count > 1)
            {
                MessageBox.Show("Sadece bir tane database seçebilirsiniz.");
            }
            else if (cbServerList.SelectedItems.Count == 1)
            {
                databaseFrom = new frmServer();
                databaseFrom.SeciliServer = GetSelectedServer();
                if (databaseFrom.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ServerListesiDoldur();
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz database'i listeden seçiniz.");
            }
        }
        private void databaseMenu_Opening(object sender, CancelEventArgs e)
        {
            silToolStripMenuItem.Enabled = cbServerList.CheckedItems.Count > 0;
            düzenleToolStripMenuItem.Enabled = cbServerList.CheckedItems.Count > 0;
            exportToolStripMenuItem.Enabled = cbServerList.CheckedItems.Count > 0;
        }

        private void adaGoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eklemeSirasınaGöreSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
