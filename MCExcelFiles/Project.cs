using System;
using System.IO;
using System.Xml;
using System.Configuration;
namespace MCExcelFiles
{
    class Project
    {
        const string BASE_PREFIX = "XXX";

        public string CopyError { get; set; }
        public string BasePath { get; set; }
        
        public Boolean renameAndCopyFiles(string nFile, string nTarget, string nPrefix)
        {
            string sourceFile;
            string destFile;
            string newFile;

            try
            {
                newFile = nFile.Replace(BASE_PREFIX, nPrefix);
                sourceFile = Path.Combine(BasePath, nFile);
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
