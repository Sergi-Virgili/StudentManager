using FileManager.Common.Layer;
using FileManager.DataAccess.Data.DaoPersistenceTXT;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Data
{
    public class StudentDao : IAbstractFactoryDao
    {

        public Student Create(Student student)
        {


            return null;
        }

        public object studentDao(FileTypes fileFormat)
        {
            new StudentDaoFactory().Create();
            Console.WriteLine((int)fileFormat);
            return new Object();
        }
    }
}
