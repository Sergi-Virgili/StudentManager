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
    public class StudentDao
    {
        public Student Create(Student student)
        {
            Student oNewStudent = DaoStudentTXT.Create(student);

            return oNewStudent;
        }
    }
}
