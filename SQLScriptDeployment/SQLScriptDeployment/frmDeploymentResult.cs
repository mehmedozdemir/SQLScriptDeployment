using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQLScriptDeployment
{
    public partial class frmDeploymentResult : Form
    {
        public frmDeploymentResult()
        {
            InitializeComponent();
        }

        public List<DeploymentResult> _DeploymentResult { get; set; }

        private void frmDeploymentResult_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = _DeploymentResult;
        }
    }
}
