using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace MCExcelFiles
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            string basePath = ConfigurationManager.AppSettings["basePath"];
            txtBasePath.Text = basePath;
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add("basePath", "Some Cool Path");
            config.Save(ConfigurationSaveMode.Modified);

            MessageBox.Show("Base path updated!", "MCExcelFiles");
        }
    }
}
