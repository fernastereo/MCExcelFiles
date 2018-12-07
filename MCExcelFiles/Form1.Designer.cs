namespace MCExcelFiles
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveBasePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBasePath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveDestinationPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstBaseFiles = new System.Windows.Forms.ListBox();
            this.ilsIcons = new System.Windows.Forms.ImageList(this.components);
            this.txtProjectPrefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCopyFiles = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveBasePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBasePath);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carpeta Base";
            // 
            // btnSaveBasePath
            // 
            this.btnSaveBasePath.ImageIndex = 0;
            this.btnSaveBasePath.ImageList = this.ilsIcons;
            this.btnSaveBasePath.Location = new System.Drawing.Point(550, 17);
            this.btnSaveBasePath.Name = "btnSaveBasePath";
            this.btnSaveBasePath.Size = new System.Drawing.Size(24, 24);
            this.btnSaveBasePath.TabIndex = 5;
            this.btnSaveBasePath.UseVisualStyleBackColor = true;
            this.btnSaveBasePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Directorio De Archivos:";
            // 
            // txtBasePath
            // 
            this.txtBasePath.Location = new System.Drawing.Point(132, 19);
            this.txtBasePath.Name = "txtBasePath";
            this.txtBasePath.Size = new System.Drawing.Size(412, 20);
            this.txtBasePath.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProjectPrefix);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnCopyFiles);
            this.groupBox2.Controls.Add(this.btnSaveDestinationPath);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(16, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 86);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carpeta Destino";
            // 
            // btnSaveDestinationPath
            // 
            this.btnSaveDestinationPath.ImageIndex = 0;
            this.btnSaveDestinationPath.ImageList = this.ilsIcons;
            this.btnSaveDestinationPath.Location = new System.Drawing.Point(550, 17);
            this.btnSaveDestinationPath.Name = "btnSaveDestinationPath";
            this.btnSaveDestinationPath.Size = new System.Drawing.Size(24, 24);
            this.btnSaveDestinationPath.TabIndex = 5;
            this.btnSaveDestinationPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveDestinationPath.UseVisualStyleBackColor = true;
            this.btnSaveDestinationPath.Click += new System.EventHandler(this.btnSaveDestinationPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Directorio De Archivos:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lstBaseFiles
            // 
            this.lstBaseFiles.FormattingEnabled = true;
            this.lstBaseFiles.Location = new System.Drawing.Point(16, 171);
            this.lstBaseFiles.Name = "lstBaseFiles";
            this.lstBaseFiles.Size = new System.Drawing.Size(262, 264);
            this.lstBaseFiles.TabIndex = 3;
            // 
            // ilsIcons
            // 
            this.ilsIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsIcons.ImageStream")));
            this.ilsIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsIcons.Images.SetKeyName(0, "icons8-save-50.png");
            this.ilsIcons.Images.SetKeyName(1, "icons8-copy-52.png");
            // 
            // txtProjectPrefix
            // 
            this.txtProjectPrefix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProjectPrefix.Location = new System.Drawing.Point(132, 51);
            this.txtProjectPrefix.MaxLength = 3;
            this.txtProjectPrefix.Name = "txtProjectPrefix";
            this.txtProjectPrefix.Size = new System.Drawing.Size(55, 20);
            this.txtProjectPrefix.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prefijo del Proyecto:";
            // 
            // btnCopyFiles
            // 
            this.btnCopyFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyFiles.ImageIndex = 1;
            this.btnCopyFiles.ImageList = this.ilsIcons;
            this.btnCopyFiles.Location = new System.Drawing.Point(204, 45);
            this.btnCopyFiles.Name = "btnCopyFiles";
            this.btnCopyFiles.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCopyFiles.Size = new System.Drawing.Size(128, 28);
            this.btnCopyFiles.TabIndex = 9;
            this.btnCopyFiles.Text = "Crear Archivos";
            this.btnCopyFiles.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.lstBaseFiles);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCExcelFiles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveBasePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBasePath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveDestinationPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lstBaseFiles;
        private System.Windows.Forms.ImageList ilsIcons;
        private System.Windows.Forms.TextBox txtProjectPrefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCopyFiles;
    }
}

