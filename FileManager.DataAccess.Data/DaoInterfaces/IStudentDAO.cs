using FileManager.Common.Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Data
{
    interface IStudentDAO
    {
        Student Create(Student student);
        Student Update(Student student);
        Boolean Delete(Student student);
        Student Find(int id);
        List<Student> All();
    }
}
