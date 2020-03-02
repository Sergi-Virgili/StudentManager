using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Data
{
    public class FactoryProvider
    {
        public static IAbstractFactory getFactory(string choice)
        {
            if (choice == "File") { return new FileFactory(); }
            return null;
        }
    }
}
