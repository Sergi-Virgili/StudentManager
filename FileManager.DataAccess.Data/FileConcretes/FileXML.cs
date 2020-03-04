using FileManager.Common.Layer;
using System;
using System.IO;
using FileManager.DataAccess.Data;
using System.Collections.Generic;
using System.Xml.Linq;


namespace FileManager.DataAccess.Data
{
    public class FileXML : IFile
    {
        private static readonly String FileName = "./Students.xml";

        public FileXML()
        {
            HelperXml.CreateFile(FileName);
        }
        public Student Create(Student student)
        { 
            XDocument document = XDocument.Load(FileName);
          
            XElement studentXml = new XElement("student",
                new XElement("id", student.Id),
                new XElement("name", student.Name),
                new XElement("surname", student.Surname),
                new XElement("ageOfBirth", student.AgeOfBirth)
            );
            document.Element("students").Add(studentXml);
            document.Save(FileName);

            return student;
        }

        public Student Update(Student student)
        {
            throw new NotImplementedException("No implemented");

        }

        public Boolean Delete(Student student)
        {
            throw new NotImplementedException("No implemented");
        }

        public Student Find(int id)
        {
            throw new NotImplementedException("No implemented");
        }
        public List<Student> All()         
        {
            var document = XElement.Load(FileName);
            List<Student> studentList = new List<Student>();


            foreach (XElement student in document.Elements("student"))
            {
                var id = student.Element("id").Value;
                var name = student.Element("name").Value;
                var surname = student.Element("surname").Value;
                var ageOfBirth = student.Element("ageOfBirth");
                Student studentInFile = new Student(int.Parse(id), name, surname, (int)ageOfBirth);
                studentList.Add(studentInFile);
            }
           
            return studentList;
        }
    }
}
