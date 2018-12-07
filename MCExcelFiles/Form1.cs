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

            Project project = new Project();
            string basePath = project.BasePath;

            txtBasePath.Enabled = false;

            if(basePath != null)
            {
                txtBasePath.Text = basePath;
                loadFiles(basePath);
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
            string targetPath = txtTargetPath.Text;
            string projectPrefix = txtProjectPrefix.Text;

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

            Project project = new Project();
            for(int i = 0; i <= lstBaseFiles.Items.Count - 1; i++)
            {
                if(!project.renameAndCopyFiles(lstBaseFiles.Items[i].ToString(), targetPath, projectPrefix))
                {
                    MessageBox.Show(project.CopyError, this.Text);
                    return;
                }
            }

            MessageBox.Show("Los archivos fueron copiados satisfactoriamente en la carpeta destino");
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
    }
}
