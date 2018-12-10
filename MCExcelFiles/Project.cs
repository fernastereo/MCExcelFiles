using System;
using System.Configuration;
using System.IO;
using System.Xml;

namespace MCExcelFiles
{
    class Project
    {
        const string APP_XML_FILE = "\\xPath.xml";
        const string APP_ROOT_KEY = "Config";
        const string APP_CONFIG_KEY = "basePath";
        const string BASE_PREFIX = "XXX";

        private string _basePath;

        public string CopyError { get; set; }
        public string BasePath {
            get 
            {
                XmlDocument xPath = new XmlDocument();
                xPath.Load(AppDomain.CurrentDomain.BaseDirectory + APP_XML_FILE);
                XmlNodeList xRoot = xPath.GetElementsByTagName(APP_ROOT_KEY);
                XmlNodeList xBase = ((XmlElement)xRoot[0]).GetElementsByTagName(APP_CONFIG_KEY);
                _basePath = xBase[0].InnerText;

                return _basePath;
            }
            set 
            {
                _basePath = value;

                XmlDocument xPath = new XmlDocument();
                XmlElement xRoot = xPath.CreateElement(APP_ROOT_KEY);
                xPath.AppendChild(xRoot);
                XmlElement xBase = xPath.CreateElement(APP_CONFIG_KEY);
                xBase.AppendChild(xPath.CreateTextNode(_basePath));
                xRoot.AppendChild(xBase);

                xPath.Save(AppDomain.CurrentDomain.BaseDirectory + APP_XML_FILE);
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
