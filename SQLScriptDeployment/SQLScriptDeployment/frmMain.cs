using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using System.Text;
using System.IO;

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
            progress.Visible = true;
            DoAsync(new ThreadStart(DatabaseListesiDoldur));
        }

        private void DoAsync(ThreadStart ts)
        {
            Thread t = new Thread(ts);
            t.Start();
        }

        private void DatabaseListesiDoldur()
        {
            List<Server> serverList = ProgramOperation.ServerOperation.GetServerList();
            cbServerList.Items.Clear();
            foreach (Server s in serverList)
            {
                string name = string.Format("{0} - {1}", s.ServerID, s.ServerName);
                cbServerList.Items.Add(name);
            }
            progress.Visible = false;
        }
        private void Gonder()
        {
            List<Server> serverList = GetSelectedServerList();
            SetVScrollMaxValue(serverList);
            deploymentResultList = new List<DeploymentResult>();
            string sql = GetSQLText();
            foreach (Server s in serverList)
            {
                Deployment dep = new Deployment();
                dep.Server = s;
                dep.SqlScript = sql;
                DeploymentResult result = ProgramOperation.DeploymentOperation.DeploymentBaslat(dep);
                deploymentResultList.Add(result);
            }
            DeploySonucuGoster();

        }

        private void SetVScrollMaxValue(List<Server> serverList)
        {
            vScroll.Maximum = serverList.Count;
        }

        private string GetSQLText()
        {
            string result = "";
            if (!string.IsNullOrWhiteSpace(txtSQLScript.SelectedText))
            {
                result = txtSQLScript.SelectedText;
            }
            else
            {
                result = txtSQLScript.Text;
            }
            return result;
        }
        private void DeploySonucuGoster()
        {
            progress.Visible = false;
            int basarili = deploymentResultList.Where(b => b.IsSucces == true).Count();
            int hatali = deploymentResultList.Where(b => b.IsSucces == false).Count();
            string sonuc = "";
            if (basarili > 0)
                sonuc += basarili.ToString() + " Başarılı.";
            if (hatali > 0)
                sonuc += hatali.ToString() + " Hatalı.";
            lblDurum.Text = "Tamamlandı. Sonuç : " + sonuc;
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
            Temizle();
        }

        private void Temizle()
        {
            txtSQLScript.Text = "";
            gvResult.DataSource = null;
            lblDurum.Text = "";

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
            Execute();
        }

        private void Execute()
        {
            try
            {

                if (cbServerList.CheckedItems.Count > 0 && !string.IsNullOrWhiteSpace(GetSQLText()))
                {
                    lblDurum.Text = "Çalıştırılıyor...";
                    progress.Visible = true;
                    DoAsync(new ThreadStart(Gonder));
                }
                else
                {
                    MessageBox.Show("Dağıtımı başlatmak için database seçmeniz ve sql komutu yazmanız gerekmektedir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void Export()
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Title = "Database Listesini Dışa Aktar";
                saveDialog.Filter = "SSD Export Format|*.ssd|Tüm Dosyalar|*.*";
                saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveDialog.FileName = string.Format("Database_{0}{1}{2}.ssd", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileName = saveDialog.FileName;
                    List<Server> seciliServerList = GetSelectedServerList();
                    bool result = ProgramOperation.ServerOperation.Export(seciliServerList, fileName);
                    if (result)
                    {
                        MessageBox.Show("Export işlemi tamamlanmıştır.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            Import();
        }

        private void Import()
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

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSQLScript.SelectedText);
            txtSQLScript.SelectedText = "";
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSQLScript.SelectedText);
        }

        private void yapistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = Clipboard.GetText();
            txtSQLScript.Text = txtSQLScript.Text.Insert(txtSQLScript.SelectionStart, s);
        }

        private void calistirtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Execute();
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtSciprtMenu_Opening(object sender, CancelEventArgs e)
        {
            yapistirToolStripMenuItem.Enabled = !string.IsNullOrWhiteSpace(Clipboard.GetText());

            kesToolStripMenuItem.Enabled = !string.IsNullOrWhiteSpace(txtSQLScript.Text);
            kopyalaToolStripMenuItem.Enabled = !string.IsNullOrWhiteSpace(txtSQLScript.Text);
            calistirtoolStripMenuItem1.Enabled = !string.IsNullOrWhiteSpace(txtSQLScript.Text);
            kaydetToolStripMenuItem.Enabled = !string.IsNullOrWhiteSpace(txtSQLScript.Text);
            kesToolStripMenuItem.Enabled = !string.IsNullOrWhiteSpace(txtSQLScript.SelectedText);
            kopyalaToolStripMenuItem.Enabled = !string.IsNullOrWhiteSpace(txtSQLScript.SelectedText);

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void Kaydet()
        {
            try
            {
                SaveFileDialog sd = new SaveFileDialog();
                sd.Title = "Kaydet";
                sd.Filter = "SQL|*.sql|Tüm Formatlar|*.*";
                sd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sd.FileName = string.Format("{0}_{1}.sql", "SQL", new Random().Next());
                if (sd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FileStream fs = new FileStream(sd.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(GetSQLText());
                    sw.Close();
                    fs.Close();
                    MessageBox.Show("Kaydedilmiştir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ac();
        }

        private void Ac()
        {
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Title = "Aç";
                of.Filter = "SQL|*.sql|Tüm Dosyalar|*.*";
                of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FileStream fs = new FileStream(of.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs, Encoding.Default);
                    txtSQLScript.Text = sr.ReadToEnd();
                    sr.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void vScroll_Scroll(object sender, ScrollEventArgs e)
        {
            gvResult.FirstDisplayedScrollingRowIndex = e.NewValue;
        }
    }
}
