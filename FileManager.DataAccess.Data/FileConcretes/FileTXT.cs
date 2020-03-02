using FileManager.Common.Layer;
using System;
using System.IO;
using FileManager.DataAccess.Data;
using System.Collections.Generic;
using System.Linq;

namespace FileManager.DataAccess.Data
{
    public class FileTXT : IFile
    {
        private static readonly String FileName = "./Students.txt";
        public Student Create(Student student)
        {

            string line = student.Id.ToString() + ";" + student.Name + ";" + student.Surname + ";" + student.AgeOfBirth.ToString();
            using (StreamWriter file = new StreamWriter(FileName, true))
            {
                file.WriteLine(line);
            }

            return student;
        }
        
        public Boolean Delete (Student student)
        {
            List<Student> studentsList = All();
            Student studentToDelete = studentsList.Find(x => x.Id == student.Id);
            if (studentsList.Remove(studentToDelete))
            {
                WriteAllLines(studentsList);
                return true;
            }
            return false;

        }

        public List<Student> All()
        {
            List<Student> result = new List<Student>();

            string[] lines = File.ReadAllLines(FileName);
            foreach (var line in lines)
            {
                var values = line.Split(';');
                Student student = new Student (int.Parse(values[0]), values[1] ,values[2], int.Parse(values[3]));
                result.Add(student);
            }

            return result;
        }
        public Student Update(Student student)
        {
            List<Student> studentsList = All();
            var studentToUpdate = studentsList.Find(x => x.Id == student.Id);
            return student;

        }
       
        private void WriteAllLines(List<Student> studentList)
        {
            File.Delete(FileName);
            foreach (Student student in studentList)
            {
                Create(student);
                
            }
            
        }
    }
}
