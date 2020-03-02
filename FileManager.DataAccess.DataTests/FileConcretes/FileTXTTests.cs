using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileManager.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Layer;
using System.IO;

namespace FileManager.DataAccess.Data.Tests
{
    [TestClass()]
    public class FileTXTTests
    {
        readonly string file = "./Students.txt";
        Student student = new Student(1, "Estronci", "Vias", 1334);
        Student student2 = new Student(2, "vir", "Vias", 2234);

        [TestInitialize]
        public void Setup()
        {
            File.Delete(file);
            
        }
        [TestMethod()]
        public void CreatesTest()
        {
            IFile textFile = FactoryProvider.getFactory(PersitenseTypes.FILE).Create(FileTypes.txt);
          
       
            Student newStudent = textFile.Create(student);

            Assert.AreEqual(student, newStudent);

           
        }

        [TestMethod()]
        public void DeleteTest()
        {
        
            IFile textFile = FactoryProvider.getFactory(PersitenseTypes.FILE).Create(FileTypes.txt);
          
            Student newStudent = textFile.Create(student);

            Assert.IsTrue(textFile.Delete(newStudent));
 
        }

        [TestMethod()]
        public void AllTest()
        {
            IFile textFile = FactoryProvider.getFactory(PersitenseTypes.FILE).Create(FileTypes.txt);
            Student newStudent = textFile.Create(student);
            Student newStudent2 = textFile.Create(student2);

            Assert.AreEqual(newStudent.Name, textFile.All()[0].Name);
            Assert.AreEqual(newStudent2.Name, textFile.All()[1].Name);
        }

       
       
    }
}