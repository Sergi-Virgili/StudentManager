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
        public Student Create(Student student)
        {

            HelperXml.CreateFile(FileName);
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

            throw new NotImplementedException("No implemented");
        }
    }
}
