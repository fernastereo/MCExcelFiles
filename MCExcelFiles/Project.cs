using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MCExcelFiles
{
    class Project
    {
        const string APP_CONFIG_KEY = "basePath";
        private string _basePath;

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

    }
}
