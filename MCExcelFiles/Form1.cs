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
        const string PREFIJO_BASE_ARCHIVOS = "XXX";

        public FrmMain()
        {
            InitializeComponent();

            Project project = new Project();
            string basePath = project.BasePath;
            txtBasePath.Enabled = false;

            if(basePath != null)
            {
                txtBasePath.Text = basePath;
                loadFiles(basePath);
            }
            
        }

        private void loadFiles(string sPath)
        {
            lstBaseFiles.Items.Clear();
            string[] files = Directory.GetFiles(sPath);

            foreach (string file in files)
            {
                lstBaseFiles.Items.Add(Path.GetFileName(file));
            }
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                loadFiles(fbd.SelectedPath);

                Project project = new Project();
                project.BasePath = fbd.SelectedPath;
            }

        }

        private void btnSaveTargetPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                txtTargetPath.Text = fbd.SelectedPath;
            }
        }

        private void btnCopyFiles_Click(object sender, EventArgs e)
        {
            string basePath = txtBasePath.Text;
            string[] files = Directory.GetFiles(basePath);
            string targetPath = txtTargetPath.Text;
            string sourceFile;
            string destFile;
            string newFile;

            if (!System.IO.Directory.Exists(targetPath))
            {
                if(MessageBox.Show("La carpeta destino no existe, desea crearla?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                else
                {
                    return;
                }
            }
            foreach (string file in files)
            {
                newFile = Path.GetFileName(file).Replace(PREFIJO_BASE_ARCHIVOS, txtProjectPrefix.Text);
                sourceFile = System.IO.Path.Combine(basePath, file);
                destFile = System.IO.Path.Combine(targetPath, newFile);
                System.IO.File.Copy(sourceFile, destFile, true);
            }

            MessageBox.Show("Listo care gaver");
        }
    }
}
