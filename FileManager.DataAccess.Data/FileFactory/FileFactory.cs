using FileManager.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Data
{
    public class FileFactory : IAbstractFactory
    {

        public IFile Create(FileTypes fileFormat) {
          
            
            switch (fileFormat)
            {
                case FileTypes.txt :
                    Console.WriteLine("txt");
                    return new FileTXT();
                    
                   
                case FileTypes.json:
                    Console.WriteLine("json");
                    return new FileJSON();
                  
                case FileTypes.xml:
                    return new FileXML();
                default: return null;
            }
           
        }
      
    }
}
