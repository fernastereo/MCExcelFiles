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
using System.IO;

namespace MCExcelFiles
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            string basePath = ConfigurationManager.AppSettings["basePath"];
            if(basePath != null)
            {
                txtBasePath.Text = basePath;
                lstBaseFiles.Items.Clear();
                string[] files = Directory.GetFiles(basePath);

                foreach (string file in files)
                {
                    lstBaseFiles.Items.Add(Path.GetFileName(file));
                }
            }
            
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            if(fdb.ShowDialog() == DialogResult.OK)
            {
                lstBaseFiles.Items.Clear();
                string[] files = Directory.GetFiles(fdb.SelectedPath);

                foreach(string file in files)
                {
                    lstBaseFiles.Items.Add(Path.GetFileName(file));
                }

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Clear();
                config.AppSettings.Settings.Add("basePath", fdb.SelectedPath);
                config.Save(ConfigurationSaveMode.Modified);

                //MessageBox.Show("Base path updated!", "MCExcelFiles");

            }

        }

        private void btnSaveDestinationPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
               
            }
        }
    }
}
