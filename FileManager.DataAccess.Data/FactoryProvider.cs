using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Data
{
    public class FactoryProvider
    {
        public static IAbstractFactory getFactory(PersitenseTypes PersistenceTypes)
        {

            switch (PersistenceTypes)
            {
                case PersitenseTypes.FILE:

                    return new FileFactory();
                default : return null; 
            }
          
        }
    }
}
