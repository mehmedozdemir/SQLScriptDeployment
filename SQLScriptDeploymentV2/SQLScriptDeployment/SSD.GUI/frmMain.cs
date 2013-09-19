using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SSD.BL;
using SSD.BL.ConnectionBL;
using SSD.Data.Entities;

namespace SSD.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Connection c = new Connection();
                    c.ServerName = i.ToString();
                    BL.BL.ConnectionOperatin.Save(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
