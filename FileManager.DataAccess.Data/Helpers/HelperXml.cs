using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileManager.DataAccess.Data
{
     class HelperXml
    {
        static bool ExistsFile(string path)
        {
            if (File.Exists(path)) { return true;  }
            return false;
        }

        public static void CreateFile(string fileName)
        {
            if (!ExistsFile(fileName)) { 
            XDocument document = new XDocument(
                new XElement("students")
                );
                document.Save(fileName);
            };
        }
    }
}
