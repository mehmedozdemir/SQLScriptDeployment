using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace SQLScriptDeployment
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }
        public Server SeciliServer { get; set; }

        private void InitScreen()
        {
            txtServerName.Text = "";
            txtServerAdresi.Text = "";
            txtKullaniciAdi.Text = "";
            txtDatabase.Text = "";
            txtSifre.Text = "";
            txtServerName.Select();
            SeciliServer = null;
        }
        private void SetScreen()
        {
            if (SeciliServer != null)
            {
                txtServerName.Text = SeciliServer.ServerName;
                txtServerAdresi.Text = SeciliServer.ServerAddress;
                txtDatabase.Text = SeciliServer.DatabaseName;
                txtKullaniciAdi.Text = SeciliServer.UserID;
                txtSifre.Text = SeciliServer.Password;
            }
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            if (SeciliServer != null)
            {
                SetScreen();
            }
            else
            {
                InitScreen();
            }
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            InitScreen();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Server server = GetScreen();
                ProgramOperation.ServerOperation.SaveServer(server);
                InitScreen();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydedilirken hata meydana geldi.\n" + ex.Message);
            }
        }

        private Server GetScreen()
        {
            Server server = SeciliServer;
            if (server == null)
            {
                server = new Server();
                server.ServerID = ProgramOperation.ServerOperation.GetMaxServerID();
            }
            server.ServerName = txtServerName.Text.Trim();
            server.ServerAddress = txtServerAdresi.Text.Trim();
            server.DatabaseName = txtDatabase.Text.Trim();
            server.UserID = txtKullaniciAdi.Text.Trim();
            server.Password = txtSifre.Text.Trim();
            return server;
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                Server s = GetScreen();
                string connectionString = ProgramOperation.DeploymentOperation.CreateConnectionString(s);
                bool result = DBOperation.ConnectionTest(connectionString);
                if (result)
                {
                    MessageBox.Show("Başarılı");
                }
                else
                {
                    MessageBox.Show("Bağlantı sağlanamadı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Test işlemi sırasında hata meydana geldi:\n" + ex.Message);
            }
        }


    }
}
