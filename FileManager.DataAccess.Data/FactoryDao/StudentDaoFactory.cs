using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Data
{
    public class StudentDaoFactory 
    {

        public object Create(FileTypes fileTypes) {

            object studentDao = null;
            switch (fileTypes)
            {
                case FileTypes.txt :  studentDao = new DaoStudentTXT();
                    break;
            }
            return studentDao;
        }
      
    }
}
