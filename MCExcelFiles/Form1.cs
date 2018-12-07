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
            txtTargetPath.ReadOnly = true;
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

            if (String.IsNullOrEmpty(projectPrefix) || projectPrefix.Length < 3)
            {
                MessageBox.Show("Por favor especifique un prefijo válido para el proyecto", this.Text);
                return;
            }

            if (!String.IsNullOrEmpty(targetPath))
            {
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
                pgbTask.Minimum = 0;
                int n = lstBaseFiles.Items.Count;
                pgbTask.Maximum = n;
                pgbTask.Visible = true;
                for (int i = 0; i <= n - 1; i++)
                {
                    if (!project.renameAndCopyFiles(lstBaseFiles.Items[i].ToString(), targetPath, projectPrefix))
                    {
                        MessageBox.Show(project.CopyError, this.Text);
                        return;
                    }
                    
                    pgbTask.Value = i;
                }
                pgbTask.Visible = false;
                MessageBox.Show("Los archivos fueron copiados satisfactoriamente en la carpeta destino", this.Text);
            }
            else
            {
                MessageBox.Show("Por favor especifique la carpeta destino de los archivos", this.Text);
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
    }
}
