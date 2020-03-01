using FileManager.Common.Layer;
using System;
using System.IO;
using FileManager.DataAccess.Data.DaoInterfaces;
using System.Collections.Generic;

namespace FileManager.DataAccess.Data.DaoPersistenceTXT
{
    public class DaoStudentTXT : IStudentDAO
    {
        private static readonly String FileName = "./Students.txt";
        public Student Create(Student student)
        {

            string line = "----- TXT FILE ---- " + student.Id.ToString() + ";" + student.Name + ";" + student.AgeOfBirth.ToString();
            using (StreamWriter file = new StreamWriter(FileName, true))
            {
                file.WriteLine(line);
            }

            return student;
        }
        
        public Student Update (Student student)
        {
            throw new NotImplementedException("No implemented");
             
        }

        public Boolean Delete (Student student)
        {
            throw new NotImplementedException("No implemented");
        }

        public Student Find (int id)
        {
            throw new NotImplementedException("No implemented");
        }
        public List<Student> All()
        {

            string[] lines = File.ReadAllLines(FileName);
            foreach (var line in lines)
            {
                var values = line.Split(';');
                Console.WriteLine(values[0] + " " + values[1] + " " + values[2]);

            }

            List<Student> result = new List<Student>();
            return null;

        }
    }
}
