namespace SQLScriptDeployment
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbServerList = new System.Windows.Forms.CheckedListBox();
            this.databaseMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.siralaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.adaGoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eklemeSirasınaGöreSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçimiBırakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddDatabase = new System.Windows.Forms.ToolStripButton();
            this.btnDatabaseDuzenle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTumunuSec = new System.Windows.Forms.ToolStripButton();
            this.btnSecimiBirak = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTools = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImport = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtSQLScript = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnExecute = new System.Windows.Forms.ToolStripButton();
            this.btnIptal = new System.Windows.Forms.ToolStripButton();
            this.btnTemizle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cMesaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.databaseMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(792, 473);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbServerList);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 448);
            this.panel1.TabIndex = 5;
            // 
            // cbServerList
            // 
            this.cbServerList.BackColor = System.Drawing.Color.White;
            this.cbServerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbServerList.CheckOnClick = true;
            this.cbServerList.ContextMenuStrip = this.databaseMenu;
            this.cbServerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbServerList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbServerList.FormattingEnabled = true;
            this.cbServerList.Location = new System.Drawing.Point(0, 20);
            this.cbServerList.Name = "cbServerList";
            this.cbServerList.Size = new System.Drawing.Size(162, 428);
            this.cbServerList.TabIndex = 3;
            this.cbServerList.ThreeDCheckBoxes = true;
            // 
            // databaseMenu
            // 
            this.databaseMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.toolStripSeparator3,
            this.siralaMenu,
            this.toolStripSeparator5,
            this.exportToolStripMenuItem,
            this.ımportToolStripMenuItem,
            this.toolStripSeparator4,
            this.tümünüSeçToolStripMenuItem,
            this.seçimiBırakToolStripMenuItem});
            this.databaseMenu.Name = "databaseMenu";
            this.databaseMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.databaseMenu.Size = new System.Drawing.Size(130, 198);
            this.databaseMenu.Opening += new System.ComponentModel.CancelEventHandler(this.databaseMenu_Opening);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Image = global::SQLScriptDeployment.Properties.Resources._1379097857_database_add;
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.btnAddDatabase_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Image = global::SQLScriptDeployment.Properties.Resources._1379097905_database_edit;
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.btnDatabaseDuzenle_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Image = global::SQLScriptDeployment.Properties.Resources._1379098526_TRASH___EMPTY;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.btnDeleteDatabase_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(126, 6);
            this.toolStripSeparator3.Visible = false;
            // 
            // siralaMenu
            // 
            this.siralaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaGoreToolStripMenuItem,
            this.eklemeSirasınaGöreSıralaToolStripMenuItem});
            this.siralaMenu.Name = "siralaMenu";
            this.siralaMenu.Size = new System.Drawing.Size(129, 22);
            this.siralaMenu.Text = "Sırala";
            this.siralaMenu.Visible = false;
            // 
            // adaGoreToolStripMenuItem
            // 
            this.adaGoreToolStripMenuItem.Name = "adaGoreToolStripMenuItem";
            this.adaGoreToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.adaGoreToolStripMenuItem.Text = "Ada göre sırala";
            this.adaGoreToolStripMenuItem.Click += new System.EventHandler(this.adaGoreToolStripMenuItem_Click);
            // 
            // eklemeSirasınaGöreSıralaToolStripMenuItem
            // 
            this.eklemeSirasınaGöreSıralaToolStripMenuItem.Name = "eklemeSirasınaGöreSıralaToolStripMenuItem";
            this.eklemeSirasınaGöreSıralaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.eklemeSirasınaGöreSıralaToolStripMenuItem.Text = "Ekleme sırasına göre sırala";
            this.eklemeSirasınaGöreSıralaToolStripMenuItem.Click += new System.EventHandler(this.eklemeSirasınaGöreSıralaToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(126, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = global::SQLScriptDeployment.Properties.Resources._1379338434_Export;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.ToolTipText = "Seçili databaseleri export eder";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ımportToolStripMenuItem
            // 
            this.ımportToolStripMenuItem.Image = global::SQLScriptDeployment.Properties.Resources._1379338431_Import;
            this.ımportToolStripMenuItem.Name = "ımportToolStripMenuItem";
            this.ımportToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ımportToolStripMenuItem.Text = "Import";
            this.ımportToolStripMenuItem.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(126, 6);
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.Image = global::SQLScriptDeployment.Properties.Resources._1379098185_checkround_24;
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.tümünüSeçToolStripMenuItem.Text = "Hepsini Seç";
            this.tümünüSeçToolStripMenuItem.Click += new System.EventHandler(this.btnTumunuSec_Click);
            // 
            // seçimiBırakToolStripMenuItem
            // 
            this.seçimiBırakToolStripMenuItem.Image = global::SQLScriptDeployment.Properties.Resources._1379098241_cancel;
            this.seçimiBırakToolStripMenuItem.Name = "seçimiBırakToolStripMenuItem";
            this.seçimiBırakToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.seçimiBırakToolStripMenuItem.Text = "Seçimi Bırak";
            this.seçimiBırakToolStripMenuItem.Click += new System.EventHandler(this.btnSecimiBirak_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 20);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 11);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATABASE";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddDatabase,
            this.btnDatabaseDuzenle,
            this.toolStripSeparator2,
            this.btnTumunuSec,
            this.btnSecimiBirak,
            this.toolStripSeparator1,
            this.btnTools});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(162, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddDatabase
            // 
            this.btnAddDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddDatabase.Image = global::SQLScriptDeployment.Properties.Resources._1379097866_database_add;
            this.btnAddDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddDatabase.Name = "btnAddDatabase";
            this.btnAddDatabase.Size = new System.Drawing.Size(23, 22);
            this.btnAddDatabase.Text = "Database Ekle";
            this.btnAddDatabase.Click += new System.EventHandler(this.btnAddDatabase_Click);
            // 
            // btnDatabaseDuzenle
            // 
            this.btnDatabaseDuzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDatabaseDuzenle.Image = global::SQLScriptDeployment.Properties.Resources._1379097905_database_edit;
            this.btnDatabaseDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDatabaseDuzenle.Name = "btnDatabaseDuzenle";
            this.btnDatabaseDuzenle.Size = new System.Drawing.Size(23, 22);
            this.btnDatabaseDuzenle.Text = "Database Düzenle";
            this.btnDatabaseDuzenle.Click += new System.EventHandler(this.btnDatabaseDuzenle_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnTumunuSec
            // 
            this.btnTumunuSec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTumunuSec.Image = global::SQLScriptDeployment.Properties.Resources._1379098185_checkround_24;
            this.btnTumunuSec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTumunuSec.Name = "btnTumunuSec";
            this.btnTumunuSec.Size = new System.Drawing.Size(23, 22);
            this.btnTumunuSec.Text = "Hepsini Seç";
            this.btnTumunuSec.Click += new System.EventHandler(this.btnTumunuSec_Click);
            // 
            // btnSecimiBirak
            // 
            this.btnSecimiBirak.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSecimiBirak.Image = global::SQLScriptDeployment.Properties.Resources._1379098241_cancel;
            this.btnSecimiBirak.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSecimiBirak.Name = "btnSecimiBirak";
            this.btnSecimiBirak.Size = new System.Drawing.Size(23, 22);
            this.btnSecimiBirak.Text = "Seçimi Bırak";
            this.btnSecimiBirak.Click += new System.EventHandler(this.btnSecimiBirak_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnTools
            // 
            this.btnTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExport,
            this.btnImport});
            this.btnTools.Image = global::SQLScriptDeployment.Properties.Resources._1379338387_98;
            this.btnTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(29, 22);
            this.btnTools.Text = "Araçlar";
            // 
            // btnExport
            // 
            this.btnExport.Image = global::SQLScriptDeployment.Properties.Resources._1379338434_Export;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(152, 22);
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Image = global::SQLScriptDeployment.Properties.Resources._1379338431_Import;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(152, 22);
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 25);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtSQLScript);
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.gvResult);
            this.splitContainer2.Panel2.Controls.Add(this.panel4);
            this.splitContainer2.Size = new System.Drawing.Size(628, 448);
            this.splitContainer2.SplitterDistance = 224;
            this.splitContainer2.TabIndex = 6;
            // 
            // txtSQLScript
            // 
            this.txtSQLScript.AutoWordSelection = true;
            this.txtSQLScript.BackColor = System.Drawing.Color.White;
            this.txtSQLScript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSQLScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLScript.EnableAutoDragDrop = true;
            this.txtSQLScript.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSQLScript.Location = new System.Drawing.Point(0, 20);
            this.txtSQLScript.Name = "txtSQLScript";
            this.txtSQLScript.ShowSelectionMargin = true;
            this.txtSQLScript.Size = new System.Drawing.Size(628, 204);
            this.txtSQLScript.TabIndex = 3;
            this.txtSQLScript.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 20);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 11);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQL";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(628, 20);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 11);
            this.label3.TabIndex = 0;
            this.label3.Text = "SONUÇ";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExecute,
            this.btnIptal,
            this.btnTemizle,
            this.toolStripSeparator6});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(628, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnExecute
            // 
            this.btnExecute.Image = global::SQLScriptDeployment.Properties.Resources._1379097927_database_run;
            this.btnExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(66, 22);
            this.btnExecute.Text = "Execute";
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Image = global::SQLScriptDeployment.Properties.Resources._1379101997_519698_206_CircledStop;
            this.btnIptal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(49, 22);
            this.btnIptal.Text = "İptal";
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Image = global::SQLScriptDeployment.Properties.Resources._1379098526_TRASH___EMPTY;
            this.btnTemizle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(62, 22);
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // cMesaj
            // 
            this.cMesaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cMesaj.DataPropertyName = "ResultDescription";
            this.cMesaj.HeaderText = "Mesaj";
            this.cMesaj.Name = "cMesaj";
            this.cMesaj.ReadOnly = true;
            // 
            // cServer
            // 
            this.cServer.DataPropertyName = "ServerName";
            this.cServer.HeaderText = "Server Name";
            this.cServer.Name = "cServer";
            this.cServer.ReadOnly = true;
            this.cServer.Width = 94;
            // 
            // gvResult
            // 
            this.gvResult.AllowUserToAddRows = false;
            this.gvResult.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.gvResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvResult.BackgroundColor = System.Drawing.Color.White;
            this.gvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cServer,
            this.cMesaj});
            this.gvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvResult.Location = new System.Drawing.Point(0, 20);
            this.gvResult.Name = "gvResult";
            this.gvResult.ReadOnly = true;
            this.gvResult.RowHeadersVisible = false;
            this.gvResult.RowTemplate.Height = 20;
            this.gvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvResult.Size = new System.Drawing.Size(628, 200);
            this.gvResult.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 473);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMain";
            this.Text = "SSD";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.databaseMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddDatabase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnTumunuSec;
        private System.Windows.Forms.ToolStripButton btnSecimiBirak;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnExecute;
        private System.Windows.Forms.ToolStripButton btnTemizle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btnIptal;
        private System.Windows.Forms.CheckedListBox cbServerList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtSQLScript;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton btnTools;
        private System.Windows.Forms.ToolStripMenuItem btnExport;
        private System.Windows.Forms.ToolStripMenuItem btnImport;
        private System.Windows.Forms.ToolStripButton btnDatabaseDuzenle;
        private System.Windows.Forms.ContextMenuStrip databaseMenu;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ımportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçimiBırakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siralaMenu;
        private System.Windows.Forms.ToolStripMenuItem adaGoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eklemeSirasınaGöreSıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.DataGridView gvResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn cServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMesaj;
    }
}

