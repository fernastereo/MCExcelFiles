using System;
using System.Configuration;
using System.IO;

namespace MCExcelFiles
{
    class Project
    {
        const string APP_CONFIG_KEY = "basePath";
        const string BASE_PREFIX = "XXX";

        private string _basePath;

        public string CopyError { get; set; }
        public string BasePath {
            get 
            {
                _basePath = ConfigurationManager.AppSettings[APP_CONFIG_KEY];
                return _basePath;
            }
            set 
            {
                _basePath = value;
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Clear();
                config.AppSettings.Settings.Add(APP_CONFIG_KEY, _basePath);
                config.Save(ConfigurationSaveMode.Modified);
            }
        }

        public Project()
        {
            _basePath = BasePath;
        }
        
        public Boolean renameAndCopyFiles(string nFile, string nTarget, string nPrefix)
        {
            string sourceFile;
            string destFile;
            string newFile;

            try
            {
                newFile = nFile.Replace(BASE_PREFIX, nPrefix);
                sourceFile = Path.Combine(_basePath, nFile);
                destFile = Path.Combine(nTarget, newFile);
                File.Copy(sourceFile, destFile, true);
                return true;
            }
            catch (Exception ex)
            {
                CopyError = ex.Message;
                return false;
            }
        }
    }
}
